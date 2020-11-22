/*
 * Created by SharpDevelop.
 * User: rseman
 * Date: 10/24/2020
 * Time: 10:18 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Diagnostics;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.IO;
using System.Xml;
using System.Xml.XPath;
using System.Text;

namespace KVMWC
{
	/// <summary>
	/// Description of LOL.
	/// </summary>
	public partial class ProgramForm : Form
	{
		private static string HOST;
		private static string USERNAME;
		private static string PASSWORD;
		private static int LIST_UPDATE_TIMER = 10000; //In milliseconds
		
		public ProgramForm()
		{
			InitializeComponent(); 
			
			ConnectionVariables connVars = new ConnectionVariables();
			string[] con = connVars.GetConnectionInfo();
			
			HOST = con[0];
			USERNAME = con[1];
			PASSWORD = con[2];
			
			this.Text += " - " + HOST;
			toolStripConnectionStatus.Text = "Connected to: " + HOST;
			
			UpdateVirtualMachineList();
			//InitTimer(); //Start Automatic updates
			
		}
		
		private Timer timer1; 
		public void InitTimer()
		{
		    timer1 = new Timer();
		    timer1.Tick += new EventHandler(timer1_Tick);
		    timer1.Interval = LIST_UPDATE_TIMER;
		    timer1.Start();
		}
		private void timer1_Tick(object sender, EventArgs e)
		{
		    UpdateVirtualMachineList();
		}
		
		public void UpdateVirtualMachineList()
		{
			dataGridView1.Rows.Clear();
			List<string[]> virtualMachines = ReturnVirtualMachinesAndStatuses();
			foreach(string[] col in virtualMachines)
			{
				string[] vmDetails = ReturnCPUAndMEMForMachine(col[1]);
				dataGridView1.Rows.Add(col[1], col[2], vmDetails[0], vmDetails[2], vmDetails[1]);
			}
		}
		
		public void CreateNewVM(string[] commands)
		{
			string output = ConnectToServerAndCommitCommand(HOST, USERNAME, PASSWORD, commands);
			UpdateVirtualMachineList();
		}
		
		public string[] ReturnCPUAndMEMForMachine(string vmName)
		{
			string[] commands = {"sudo virsh dumpxml " + vmName};
			string cmdOutput = ConnectToServerAndCommitCommand(HOST, USERNAME, PASSWORD, commands);
			
			bool startReading = false;
	    	string xml = "";
	    	foreach(string line in cmdOutput.Split(new string[] { Environment.NewLine }, StringSplitOptions.None))
	    	{
	    		if(line.Contains("sudo virsh dumpxml"))
	    		{
	    			startReading = true;
	    			continue;
	    		}
	    		
	    		if(startReading)
	    		{
	    			xml += line + "\n";
	    		}
	    		
	    		if(string.IsNullOrEmpty(line))
	    			startReading = false;
	    	}
	    	
	    	richTextBoxVMLog.Text = xml;
	    	
			XmlDocument xmlDoc = new XmlDocument();
			xmlDoc.LoadXml(xml);
			XPathNavigator navigator;
			navigator = xmlDoc.CreateNavigator();

			int availableMemory = Int32.Parse(navigator.SelectSingleNode("/domain/memory").Value) / 1024;
			string[] output = new string[] {navigator.SelectSingleNode("/domain/description").Value, availableMemory.ToString() + " MB", navigator.SelectSingleNode("/domain/vcpu").Value};
			
			return output;
		}
		
		public void ReturnDetailsOfVM(string vmName)
		{
			string[] commands = {"sudo virsh dumpxml " + vmName};
			string cmdOutput = ConnectToServerAndCommitCommand(HOST, USERNAME, PASSWORD, commands);
			
			bool startReading = false;
	    	string xml = "";
	    	foreach(string line in cmdOutput.Split(new string[] { Environment.NewLine }, StringSplitOptions.None))
	    	{
	    		if(line.Contains("sudo virsh dumpxml"))
	    		{
	    			startReading = true;
	    			continue;
	    		}
	    		
	    		if(startReading)
	    		{
	    			xml += line + "\n";
	    		}
	    		
	    		if(string.IsNullOrEmpty(line))
	    			startReading = false;
	    	}
	    	
	    	richTextBoxVMLog.Text = xml;
	    	
			XmlDocument xmlDoc = new XmlDocument();
			xmlDoc.LoadXml(xml);
			XPathNavigator navigator;
			navigator = xmlDoc.CreateNavigator();

			int availableMemory = Int32.Parse(navigator.SelectSingleNode("/domain/memory").Value) / 1024;
			labelVMName.Text = navigator.SelectSingleNode("/domain/name").Value;
			labelVMDescription.Text = navigator.SelectSingleNode("/domain/description").Value;
			labelVMUUID.Text = navigator.SelectSingleNode("/domain/uuid").Value;
			labelVMCPUs.Text = navigator.SelectSingleNode("/domain/vcpu").Value;
			labelVMMemory.Text = availableMemory.ToString();

			XmlNodeList disks = xmlDoc.SelectNodes("/domain/devices/disk");
			
			foreach(TreeNode parentNode in treeView1.Nodes)
				parentNode.Nodes.Clear();
			
			foreach(XmlNode disk in disks)
			{
				//MessageBox.Show(disk.ChildNodes[1].Attributes["file"].Value + "("+ disk.Attributes["device"].Value +")");
				if(disk.Attributes["device"].Value == "disk")
				{
					var node = treeView1.Nodes[0];
					node.Nodes.Add(disk.ChildNodes[1].Attributes["file"].Value);
				}
				else if(disk.Attributes["device"].Value == "cdrom")
				{
					var node = treeView1.Nodes[1];
					node.Nodes.Add(disk.ChildNodes[1].Attributes["file"].Value);
				}
				
			}
			treeView1.ExpandAll();
			
		}
		
		static string ConnectToServerAndCommitCommand(string host, string username, string password, string[] commands)
		{
			try
			{
				Process cmd = new Process();
			    cmd.StartInfo.FileName = @"plink.exe";
			    cmd.StartInfo.UseShellExecute = false;
			    cmd.StartInfo.CreateNoWindow = true;
			    cmd.StartInfo.RedirectStandardInput = true;
			    cmd.StartInfo.RedirectStandardOutput = true;
			    cmd.StartInfo.Arguments = "-batch -l "+ username +" -pw "+ password +" "+ host;
			    cmd.Start();
			    
				
			    cmd.StandardInput.WriteLine("clear");
			    foreach(string command in commands)
			    {
			    	cmd.StandardInput.WriteLine(command);	
			    }
			    cmd.StandardInput.WriteLine("exit");
			    
			    string output = cmd.StandardOutput.ReadToEnd();
			    //cmd.Close();
			    
			    if(string.IsNullOrEmpty(output))
			    {
			    	cmd.WaitForExit(10000);
			    	throw new Exception("Unable to connect to host!");
			    }
			    else
			    {
			    	return output;
			    }
			}
			catch (Exception Ex)
			{
				MessageBox.Show(Ex.ToString());
				Application.Restart();
				return "";
			}
		}
		
		static List<string[]> ReturnVirtualMachinesAndStatuses()
		{
			string[] commands = {"sudo virsh list --all", "echo"};
			string output = ConnectToServerAndCommitCommand(HOST, USERNAME, PASSWORD, commands);
			bool startReading = false;
	    	string virtualMachines = "";
	    	foreach(string line in output.Split(new string[] { Environment.NewLine }, StringSplitOptions.None))
	    	{
	    		if(line.Contains("--------"))
	    		{
	    			startReading = true;
	    			continue;
	    		}
	    		
	    		if(startReading)
	    		{
	    			virtualMachines += line + "\n";
	    		}
	    		
	    		if(string.IsNullOrEmpty(line))
	    			startReading = false;
	    	}
	    	
	    	List<string[]> vmList = new List<string[]>();
	    	foreach(string machine in virtualMachines.Split(new string[] { "\n" }, StringSplitOptions.RemoveEmptyEntries))
			{
	    		string[] col = machine.Split(new string[] { "  " }, StringSplitOptions.RemoveEmptyEntries);
	    		vmList.Add(col);
				//dataGridView1.Rows.Add(col[1], col[2], "VM for Testing Purposes", "0%", "0%");
			}
	    	return vmList;
		}
		
		// ================================================= EVENTS ==========================================================
		// Hotkeys
		protected override bool ProcessCmdKey (ref Message msg, Keys keyData)
		{
		    bool bHandled = false;
		    // switch case is the easy way, a hash or map would be better, 
		    // but more work to get set up.
		    switch (keyData)
		    {
		        case Keys.F5:
		    		UpdateVirtualMachineList();
		            bHandled = true;
		            break;
		    }
		    return bHandled;
		}
		
		// Toolstrip Menu
		void ToolStripMenuItemRefreshVMListClick(object sender, EventArgs e)
		{
			UpdateVirtualMachineList();
		}
		void ToolStripMenuItemNewConnectionClick(object sender, EventArgs e)
		{
			Application.Restart();
		}
		void ToolStripMenuItemExitClick(object sender, EventArgs e)
		{
			Application.Exit();
		}
		
		void ProgramFormFormClosed(object sender, FormClosedEventArgs e)
		{
			Application.Exit();
		}

		void ToolStripMenuItemNewMachineClick(object sender, EventArgs e)
		{
			FormCollection fc = Application.OpenForms;
			foreach (Form currentForm in fc)
			{
				if(currentForm.Name == "NewMachineForm")
				{
					return;
				}
			}
			NewMachineForm newMachineForm = new NewMachineForm();
			newMachineForm.Show();
		}
		void ToolStripMenuItemAboutClick(object sender, EventArgs e)
		{
			AboutForm aboutForm = new AboutForm();
			aboutForm.Show();
		}
		void DataGridView1SelectionChanged(object sender, EventArgs e)
		{
			try
			{
				ReturnDetailsOfVM(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
			}
			catch
			{
				return;
			}
		}

		// Side menu buttons
		void ToolStripMenuItemNewVMClick(object sender, EventArgs e)
		{
			NewMachineForm newMachineForm = new NewMachineForm();
			newMachineForm.Show();
		}
		void ToolStripButtonDeleteVMClick(object sender, EventArgs e)
		{
			string vmName = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
			
			DialogResult dialogResult = MessageBox.Show("You are about to delete: " + vmName + "\nAre you sure?", "Delete Virtual Machine", MessageBoxButtons.YesNo);
			if(dialogResult == DialogResult.Yes)
			{
			    string[] commands = {"sudo virsh undefine " + vmName, "sudo virsh destroy " + vmName};
				string output = ConnectToServerAndCommitCommand(HOST, USERNAME, PASSWORD, commands);
				UpdateVirtualMachineList();
			}
		}
		void ToolStripButtonStartVMClick(object sender, EventArgs e)
		{
			string vmName = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
			string[] commands = {"sudo virsh start " + vmName};
			string output = ConnectToServerAndCommitCommand(HOST, USERNAME, PASSWORD, commands);
			UpdateVirtualMachineList();
		}
		void ToolStripButtonRestartVMClick(object sender, EventArgs e)
		{
			string vmName = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
			DialogResult dialogResult = MessageBox.Show("You are about to restart: " + vmName + "\nAre you sure?", "Restart Virtual Machine", MessageBoxButtons.YesNo);
			if(dialogResult == DialogResult.Yes)
			{
				string[] commands = {"sudo virsh reset " + vmName};
				string output = ConnectToServerAndCommitCommand(HOST, USERNAME, PASSWORD, commands);
				UpdateVirtualMachineList();
			}
		}
		void ToolStripSplitButtonShutdownVMButtonClick(object sender, EventArgs e)
		{
			string vmName = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
			DialogResult dialogResult = MessageBox.Show("You are about to shutdown: " + vmName + "\nAre you sure?", "Shutdown Virtual Machine", MessageBoxButtons.YesNo);
			if(dialogResult == DialogResult.Yes)
			{
				string acpiShutdown = "sudo virsh shutdown " + vmName + " --mode acpi";
				string[] commands = {acpiShutdown};
				string output = ConnectToServerAndCommitCommand(HOST, USERNAME, PASSWORD, commands);
				UpdateVirtualMachineList();
			}
		}
		void ToolStripMenuItemForceShutdownClick(object sender, EventArgs e)
		{
			string vmName = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
			DialogResult dialogResult = MessageBox.Show("You are about to Brutally shutdown: " + vmName + "\nAre you sure?", "Force Shutdown Virtual Machine", MessageBoxButtons.YesNo);
			if(dialogResult == DialogResult.Yes)
			{
				string[] commands = {"sudo virsh destroy " + vmName};
				string output = ConnectToServerAndCommitCommand(HOST, USERNAME, PASSWORD, commands);
				UpdateVirtualMachineList();
			}
		}
		void ExportListToolStripMenuItemClick(object sender, EventArgs e)
		{
			if (dataGridView1.Rows.Count > 0)  
	    	{  
		        SaveFileDialog sfd = new SaveFileDialog();  
		        sfd.Filter = "CSV (*.csv)|*.csv";  
		        sfd.FileName = "VM_Export.csv";  
		        bool fileError = false;  
		        if (sfd.ShowDialog() == DialogResult.OK)  
		        {  
		            if (File.Exists(sfd.FileName))  
		            {  
		                try  
		                {  
		                    File.Delete(sfd.FileName);  
		                }  
		                catch (IOException ex)  
		                {  
		                    fileError = true;  
		                    MessageBox.Show("Unable to save data to disk!" + ex.Message);  
		                }  
		            }  
		            if (!fileError)  
		            {  
		                try  
		                {  
		                    int columnCount = dataGridView1.Columns.Count;  
		                    string columnNames = "";  
		                    string[] outputCsv = new string[dataGridView1.Rows.Count + 1];  
		                    for (int i = 0; i < columnCount; i++)  
		                    {  
		                        columnNames += dataGridView1.Columns[i].HeaderText.ToString() + ",";  
		                    }  
		                    outputCsv[0] += columnNames;  
		                              
		                    for (int i = 1; (i - 1) < dataGridView1.Rows.Count; i++)  
		                    {  
		                        for (int j = 0; j < columnCount; j++)  
		                        {  
		                            outputCsv[i] += dataGridView1.Rows[i - 1].Cells[j].Value.ToString() + ",";  
		                        }  
		                    }  
		  
		                    File.WriteAllLines(sfd.FileName, outputCsv, Encoding.UTF8);  
		                    MessageBox.Show("Export successful.", "Info");  
		                }  
		                catch(Exception ex)  
		                {  
		                    MessageBox.Show("Error :" + ex.Message);  
		                }  
		            }  
		        }  
		    }  
		    else  
		    {  
		        MessageBox.Show("No data to be exported.", "Info");  
		    }  
		}
		
	}
}
