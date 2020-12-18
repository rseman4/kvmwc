/*
 * Created by SharpDevelop.
 * User: rseman
 * Date: 10/26/2020
 * Time: 2:12 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace KVMWC
{
	/// <summary>
	/// Description of NewMachineForm.
	/// </summary>
	public partial class NewMachineForm : Form
	{
		
		public static int PAGES_AVAILABLE_INDEX = 0;
		public static TabPage[] PAGES_AVAILABLE;
		public static int MAX_PAGE_INDEX;
		
		public NewMachineForm()
		{
			InitializeComponent();
			
			PAGES_AVAILABLE = new TabPage[]{tabPage1, tabPage2, tabPage3, tabPage5};
			MAX_PAGE_INDEX = PAGES_AVAILABLE.Length - 1;
						
			/*sudo virt-install \
			--name centos7 \
			--description "Test VM with CentOS 7" \
			--ram=1024 \
			--vcpus=2 \
			--os-type=Linux \
			--os-variant=rhel7 \
			--disk path=/var/lib/libvirt/images/centos7.qcow2,bus=virtio,size=10 \
			--graphics none \
			--location $HOME/iso/CentOS-7-x86_64-Everything-1611.iso \
			--network bridge:virbr0
			 sudo virsh autostart test
			 sudo qemu-img create -f qcow2 windows_10_x64.qcow2 75G*/
			
		}
		public string[] ComposeCommands()
		{
			string vmName = textBoxNewVMName.Text.Replace(" ", "_");
			//string createDiskCommand = "sudo qemu-img create -f qcow2 "+ vmName +".qcow2 " + textBoxNewVMDisk.Text;
			string mainCommand = "sudo virt-install  --name "+ vmName +"  --description '"+ richTextBoxNewVMDescription.Text +"' --ram="+ textBoxNewVMRAM.Text +" --vcpus="+ textBoxNewVMCPUCores.Text +" --os-type="+ comboBoxNewVMOSType.Text +" --os-variant="+ comboBoxNewVMOSVariant.Text +" --disk path='/var/lib/libvirt/images/"+ vmName +".qcow2',bus=virtio,size="+ textBoxNewVMDisk.Text +" --location "+ textBoxNewVMISOPath.Text +" --network type=direct,source=eno1,source_mode=bridge,model=virtio --extra-args='console=ttyS0' --noautoconsole";
			string autostartEnabled = (checkBoxNewVMAutostart.Checked) ? "sudo virsh autostart " + vmName : "";
			string[] commands = {mainCommand, autostartEnabled};
			return commands;
		}
		
		// ======================================= EVENTS ==============================================
		void ButtonNewVMWizardPreviousClick(object sender, EventArgs e)
		{
			PAGES_AVAILABLE_INDEX--;
			if(PAGES_AVAILABLE_INDEX == 0)
			{
				buttonNewVMWizardPrevious.Enabled = false;
				buttonNewVMWizardNext.Enabled = true;
			}
			else if(PAGES_AVAILABLE_INDEX < MAX_PAGE_INDEX)
			{
				buttonNewVMWizardNext.Enabled = true;
				buttonNewVMWizardFinish.Enabled = false;
			}
			buttonNewVMWizardFinish.Enabled = false;
			tabControl1.SelectedIndex = PAGES_AVAILABLE_INDEX;
		}
		void ButtonNewVMWizardNextClick(object sender, EventArgs e)
		{			
			PAGES_AVAILABLE_INDEX++;
			if(PAGES_AVAILABLE_INDEX > 0)
			{
				buttonNewVMWizardPrevious.Enabled = true;
			}
			
			if(PAGES_AVAILABLE_INDEX == MAX_PAGE_INDEX)
			{
				buttonNewVMWizardNext.Enabled = false;
				buttonNewVMWizardFinish.Enabled = true;
				
				richTextBoxNewVMCommand.Text = "";
				foreach(string command in ComposeCommands())
					richTextBoxNewVMCommand.Text += command + "\n";
			}
			else if(PAGES_AVAILABLE_INDEX < MAX_PAGE_INDEX)
			{
				buttonNewVMWizardNext.Enabled = true;
				buttonNewVMWizardFinish.Enabled = false;
			}
			tabControl1.SelectedIndex = PAGES_AVAILABLE_INDEX;
		}
		void ButtonNewVMWizardFinishClick(object sender, EventArgs e)
		{
			if(string.IsNullOrEmpty(textBoxNewVMName.Text) || string.IsNullOrEmpty(textBoxNewVMCPUCores.Text) || string.IsNullOrEmpty(textBoxNewVMRAM.Text))
			{
				MessageBox.Show("Name, CPU cores and Memory are mandatory fields!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			else
			{
				ProgramForm programForm = new ProgramForm();
				programForm.ExecCommand(ComposeCommands());
				this.Close();
			}
		}
		void TabControl1Selecting(object sender, TabControlCancelEventArgs e)
		{
			tabControl1.SelectedTab = PAGES_AVAILABLE[PAGES_AVAILABLE_INDEX];
		}
	}
}
