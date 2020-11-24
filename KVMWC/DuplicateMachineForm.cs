/*
 * Created by SharpDevelop.
 * User: rseman
 * Date: 11/24/2020
 * Time: 12:56 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace KVMWC
{
	/// <summary>
	/// Description of DuplicateMachineForm.
	/// </summary>
	public partial class DuplicateMachineForm : Form
	{
		public string currentVMName;
		public DuplicateMachineForm(string selectedVM)
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			currentVMName = selectedVM;
		}
		void DuplicateVmButtonClick(object sender, EventArgs e)
		{
			if(!String.IsNullOrEmpty(textBoxNewVMName.Text))
			{
				string[] command = {"sudo virsh shutdown " + currentVMName + " --mode acpi", "sudo virt-clone --original "+ currentVMName +" --name "+ textBoxNewVMName.Text +" --auto-clone"};
				ProgramForm programForm = new ProgramForm();
				programForm.ExecCommand(command);
				this.Close();
			}
			else
			{
				MessageBox.Show("Please, enter name of new VM!", "Error");
			}
		}
	}
}
