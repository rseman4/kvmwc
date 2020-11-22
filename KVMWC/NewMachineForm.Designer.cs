/*
 * Created by SharpDevelop.
 * User: rseman
 * Date: 10/26/2020
 * Time: 2:12 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace KVMWC
{
	partial class NewMachineForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Button buttonNewVMWizardNext;
		private System.Windows.Forms.Button buttonNewVMWizardPrevious;
		private System.Windows.Forms.Button buttonNewVMWizardFinish;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.TabPage tabPage3;
		private System.Windows.Forms.TabPage tabPage5;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.RichTextBox richTextBoxNewVMDescription;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox textBoxNewVMName;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.ComboBox comboBoxNewVMOSVariant;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.ComboBox comboBoxNewVMOSType;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox textBoxNewVMCPUCores;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox textBoxNewVMRAM;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox textBoxNewVMISOPath;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.TextBox textBoxNewVMDisk;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.ComboBox comboBoxNewVMNetworkType;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.CheckBox checkBoxNewVMAutostart;
		private System.Windows.Forms.RichTextBox richTextBoxNewVMCommand;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.panel1 = new System.Windows.Forms.Panel();
			this.panel2 = new System.Windows.Forms.Panel();
			this.buttonNewVMWizardFinish = new System.Windows.Forms.Button();
			this.buttonNewVMWizardPrevious = new System.Windows.Forms.Button();
			this.buttonNewVMWizardNext = new System.Windows.Forms.Button();
			this.tabPage5 = new System.Windows.Forms.TabPage();
			this.richTextBoxNewVMCommand = new System.Windows.Forms.RichTextBox();
			this.label12 = new System.Windows.Forms.Label();
			this.tabPage3 = new System.Windows.Forms.TabPage();
			this.checkBoxNewVMAutostart = new System.Windows.Forms.CheckBox();
			this.comboBoxNewVMNetworkType = new System.Windows.Forms.ComboBox();
			this.label11 = new System.Windows.Forms.Label();
			this.textBoxNewVMDisk = new System.Windows.Forms.TextBox();
			this.textBoxNewVMISOPath = new System.Windows.Forms.TextBox();
			this.textBoxNewVMCPUCores = new System.Windows.Forms.TextBox();
			this.textBoxNewVMRAM = new System.Windows.Forms.TextBox();
			this.label10 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.comboBoxNewVMOSVariant = new System.Windows.Forms.ComboBox();
			this.label8 = new System.Windows.Forms.Label();
			this.comboBoxNewVMOSType = new System.Windows.Forms.ComboBox();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.richTextBoxNewVMDescription = new System.Windows.Forms.RichTextBox();
			this.textBoxNewVMName = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.tabPage5.SuspendLayout();
			this.tabPage3.SuspendLayout();
			this.tabPage2.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.tabControl1.SuspendLayout();
			this.SuspendLayout();
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.pictureBox1.Image = global::KVMWC.Images.kvm_banner;
			this.pictureBox1.Location = new System.Drawing.Point(12, 6);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(200, 62);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// panel1
			// 
			this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
			| System.Windows.Forms.AnchorStyles.Left)));
			this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.panel1.Controls.Add(this.pictureBox1);
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(231, 402);
			this.panel1.TabIndex = 0;
			// 
			// panel2
			// 
			this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.panel2.BackColor = System.Drawing.SystemColors.Control;
			this.panel2.Controls.Add(this.buttonNewVMWizardFinish);
			this.panel2.Controls.Add(this.buttonNewVMWizardPrevious);
			this.panel2.Controls.Add(this.buttonNewVMWizardNext);
			this.panel2.Location = new System.Drawing.Point(0, 400);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(668, 68);
			this.panel2.TabIndex = 1;
			// 
			// buttonNewVMWizardFinish
			// 
			this.buttonNewVMWizardFinish.Enabled = false;
			this.buttonNewVMWizardFinish.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonNewVMWizardFinish.Location = new System.Drawing.Point(534, 17);
			this.buttonNewVMWizardFinish.Name = "buttonNewVMWizardFinish";
			this.buttonNewVMWizardFinish.Size = new System.Drawing.Size(121, 38);
			this.buttonNewVMWizardFinish.TabIndex = 2;
			this.buttonNewVMWizardFinish.Text = "Finish";
			this.buttonNewVMWizardFinish.UseVisualStyleBackColor = true;
			this.buttonNewVMWizardFinish.Click += new System.EventHandler(this.ButtonNewVMWizardFinishClick);
			// 
			// buttonNewVMWizardPrevious
			// 
			this.buttonNewVMWizardPrevious.Enabled = false;
			this.buttonNewVMWizardPrevious.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonNewVMWizardPrevious.Location = new System.Drawing.Point(265, 17);
			this.buttonNewVMWizardPrevious.Name = "buttonNewVMWizardPrevious";
			this.buttonNewVMWizardPrevious.Size = new System.Drawing.Size(121, 38);
			this.buttonNewVMWizardPrevious.TabIndex = 1;
			this.buttonNewVMWizardPrevious.Text = "Previous";
			this.buttonNewVMWizardPrevious.UseVisualStyleBackColor = true;
			this.buttonNewVMWizardPrevious.Click += new System.EventHandler(this.ButtonNewVMWizardPreviousClick);
			// 
			// buttonNewVMWizardNext
			// 
			this.buttonNewVMWizardNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonNewVMWizardNext.Location = new System.Drawing.Point(392, 17);
			this.buttonNewVMWizardNext.Name = "buttonNewVMWizardNext";
			this.buttonNewVMWizardNext.Size = new System.Drawing.Size(121, 38);
			this.buttonNewVMWizardNext.TabIndex = 0;
			this.buttonNewVMWizardNext.Text = "Next";
			this.buttonNewVMWizardNext.UseVisualStyleBackColor = true;
			this.buttonNewVMWizardNext.Click += new System.EventHandler(this.ButtonNewVMWizardNextClick);
			// 
			// tabPage5
			// 
			this.tabPage5.Controls.Add(this.richTextBoxNewVMCommand);
			this.tabPage5.Controls.Add(this.label12);
			this.tabPage5.Location = new System.Drawing.Point(4, 25);
			this.tabPage5.Name = "tabPage5";
			this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage5.Size = new System.Drawing.Size(409, 365);
			this.tabPage5.TabIndex = 4;
			this.tabPage5.Text = "Summary";
			this.tabPage5.UseVisualStyleBackColor = true;
			// 
			// richTextBoxNewVMCommand
			// 
			this.richTextBoxNewVMCommand.Location = new System.Drawing.Point(7, 47);
			this.richTextBoxNewVMCommand.Name = "richTextBoxNewVMCommand";
			this.richTextBoxNewVMCommand.Size = new System.Drawing.Size(396, 312);
			this.richTextBoxNewVMCommand.TabIndex = 1;
			this.richTextBoxNewVMCommand.Text = "";
			// 
			// label12
			// 
			this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label12.Location = new System.Drawing.Point(7, 10);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(396, 33);
			this.label12.TabIndex = 0;
			this.label12.Text = "This is a preview of command being commited: ";
			this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// tabPage3
			// 
			this.tabPage3.Controls.Add(this.checkBoxNewVMAutostart);
			this.tabPage3.Controls.Add(this.comboBoxNewVMNetworkType);
			this.tabPage3.Controls.Add(this.label11);
			this.tabPage3.Controls.Add(this.textBoxNewVMDisk);
			this.tabPage3.Controls.Add(this.textBoxNewVMISOPath);
			this.tabPage3.Controls.Add(this.textBoxNewVMCPUCores);
			this.tabPage3.Controls.Add(this.textBoxNewVMRAM);
			this.tabPage3.Controls.Add(this.label10);
			this.tabPage3.Controls.Add(this.label9);
			this.tabPage3.Controls.Add(this.comboBoxNewVMOSVariant);
			this.tabPage3.Controls.Add(this.label8);
			this.tabPage3.Controls.Add(this.comboBoxNewVMOSType);
			this.tabPage3.Controls.Add(this.label7);
			this.tabPage3.Controls.Add(this.label6);
			this.tabPage3.Controls.Add(this.label5);
			this.tabPage3.Location = new System.Drawing.Point(4, 25);
			this.tabPage3.Name = "tabPage3";
			this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage3.Size = new System.Drawing.Size(409, 365);
			this.tabPage3.TabIndex = 2;
			this.tabPage3.Text = "System Info";
			this.tabPage3.UseVisualStyleBackColor = true;
			// 
			// checkBoxNewVMAutostart
			// 
			this.checkBoxNewVMAutostart.Location = new System.Drawing.Point(7, 289);
			this.checkBoxNewVMAutostart.Name = "checkBoxNewVMAutostart";
			this.checkBoxNewVMAutostart.Size = new System.Drawing.Size(104, 24);
			this.checkBoxNewVMAutostart.TabIndex = 17;
			this.checkBoxNewVMAutostart.Text = "Autostart";
			this.checkBoxNewVMAutostart.UseVisualStyleBackColor = true;
			// 
			// comboBoxNewVMNetworkType
			// 
			this.comboBoxNewVMNetworkType.FormattingEnabled = true;
			this.comboBoxNewVMNetworkType.Items.AddRange(new object[] {
			"Bridged",
			"NAT",
			"Virtio"});
			this.comboBoxNewVMNetworkType.Location = new System.Drawing.Point(6, 259);
			this.comboBoxNewVMNetworkType.Name = "comboBoxNewVMNetworkType";
			this.comboBoxNewVMNetworkType.Size = new System.Drawing.Size(396, 24);
			this.comboBoxNewVMNetworkType.TabIndex = 11;
			// 
			// label11
			// 
			this.label11.Location = new System.Drawing.Point(6, 232);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(100, 23);
			this.label11.TabIndex = 15;
			this.label11.Text = "Network Type";
			this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// textBoxNewVMDisk
			// 
			this.textBoxNewVMDisk.Location = new System.Drawing.Point(278, 47);
			this.textBoxNewVMDisk.Name = "textBoxNewVMDisk";
			this.textBoxNewVMDisk.Size = new System.Drawing.Size(100, 22);
			this.textBoxNewVMDisk.TabIndex = 7;
			this.textBoxNewVMDisk.Text = "10";
			// 
			// textBoxNewVMISOPath
			// 
			this.textBoxNewVMISOPath.Location = new System.Drawing.Point(7, 207);
			this.textBoxNewVMISOPath.Name = "textBoxNewVMISOPath";
			this.textBoxNewVMISOPath.Size = new System.Drawing.Size(396, 22);
			this.textBoxNewVMISOPath.TabIndex = 10;
			this.textBoxNewVMISOPath.Text = "/srv/install_images/";
			// 
			// textBoxNewVMCPUCores
			// 
			this.textBoxNewVMCPUCores.Location = new System.Drawing.Point(23, 47);
			this.textBoxNewVMCPUCores.Name = "textBoxNewVMCPUCores";
			this.textBoxNewVMCPUCores.Size = new System.Drawing.Size(100, 22);
			this.textBoxNewVMCPUCores.TabIndex = 5;
			this.textBoxNewVMCPUCores.Text = "1";
			// 
			// textBoxNewVMRAM
			// 
			this.textBoxNewVMRAM.Location = new System.Drawing.Point(150, 47);
			this.textBoxNewVMRAM.Name = "textBoxNewVMRAM";
			this.textBoxNewVMRAM.Size = new System.Drawing.Size(100, 22);
			this.textBoxNewVMRAM.TabIndex = 6;
			this.textBoxNewVMRAM.Text = "1024";
			// 
			// label10
			// 
			this.label10.Location = new System.Drawing.Point(278, 20);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(100, 23);
			this.label10.TabIndex = 13;
			this.label10.Text = "Disk Size (GB)";
			this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label9
			// 
			this.label9.Location = new System.Drawing.Point(7, 180);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(137, 23);
			this.label9.TabIndex = 11;
			this.label9.Text = "Install ISO Path";
			this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// comboBoxNewVMOSVariant
			// 
			this.comboBoxNewVMOSVariant.FormattingEnabled = true;
			this.comboBoxNewVMOSVariant.Items.AddRange(new object[] {
			"win7",
			"vista",
			"winxp64",
			"winxp",
			"win2k",
			"win2k8",
			"win2k3",
			"openbsd4",
			"freebsd8",
			"freebsd7",
			"freebsd6",
			"solaris9",
			"solaris10",
			"opensolaris",
			"netware6",
			"netware5",
			"netware4",
			"msdos",
			"generic",
			"debianwheezy",
			"debiansqueeze",
			"debianlenny",
			"debianetch",
			"fedora18",
			"fedora17",
			"fedora16",
			"fedora15",
			"fedora14",
			"fedora13",
			"fedora12",
			"fedora11",
			"fedora10",
			"fedora9",
			"fedora8",
			"fedora7",
			"fedora6",
			"fedora5",
			"mageia1",
			"mes5.1",
			"mes5",
			"mandriva2010",
			"mandriva2009",
			"rhel7",
			"rhel6",
			"rhel5.4",
			"rhel5",
			"rhel4",
			"rhel3",
			"rhel2.1",
			"sles11",
			"sles10",
			"opensuse12",
			"opensuse11",
			"ubuntutrusty",
			"ubuntusaucy",
			"ubunturaring",
			"ubuntuquantal",
			"ubuntuprecise",
			"ubuntuoneiric",
			"ubuntunatty",
			"ubuntumaverick",
			"ubuntulucid",
			"ubuntukarmic",
			"ubuntujaunty",
			"ubuntuintrepid",
			"ubuntuhardy",
			"virtio26",
			"generic26",
			"generic24"});
			this.comboBoxNewVMOSVariant.Location = new System.Drawing.Point(7, 153);
			this.comboBoxNewVMOSVariant.Name = "comboBoxNewVMOSVariant";
			this.comboBoxNewVMOSVariant.Size = new System.Drawing.Size(396, 24);
			this.comboBoxNewVMOSVariant.TabIndex = 9;
			// 
			// label8
			// 
			this.label8.Location = new System.Drawing.Point(7, 126);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(100, 23);
			this.label8.TabIndex = 9;
			this.label8.Text = "OS Variant";
			this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// comboBoxNewVMOSType
			// 
			this.comboBoxNewVMOSType.FormattingEnabled = true;
			this.comboBoxNewVMOSType.Items.AddRange(new object[] {
			"Linux",
			"Windows"});
			this.comboBoxNewVMOSType.Location = new System.Drawing.Point(7, 99);
			this.comboBoxNewVMOSType.Name = "comboBoxNewVMOSType";
			this.comboBoxNewVMOSType.Size = new System.Drawing.Size(396, 24);
			this.comboBoxNewVMOSType.TabIndex = 8;
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(7, 72);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(100, 23);
			this.label7.TabIndex = 6;
			this.label7.Text = "OS Type";
			this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(23, 20);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(100, 23);
			this.label6.TabIndex = 4;
			this.label6.Text = "CPU Cores";
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(150, 20);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(100, 23);
			this.label5.TabIndex = 2;
			this.label5.Text = "RAM (MB)";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// tabPage2
			// 
			this.tabPage2.Controls.Add(this.richTextBoxNewVMDescription);
			this.tabPage2.Controls.Add(this.textBoxNewVMName);
			this.tabPage2.Controls.Add(this.label4);
			this.tabPage2.Controls.Add(this.label3);
			this.tabPage2.Location = new System.Drawing.Point(4, 25);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new System.Drawing.Size(409, 365);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "Name";
			this.tabPage2.UseVisualStyleBackColor = true;
			// 
			// richTextBoxNewVMDescription
			// 
			this.richTextBoxNewVMDescription.Location = new System.Drawing.Point(6, 98);
			this.richTextBoxNewVMDescription.Name = "richTextBoxNewVMDescription";
			this.richTextBoxNewVMDescription.Size = new System.Drawing.Size(397, 261);
			this.richTextBoxNewVMDescription.TabIndex = 4;
			this.richTextBoxNewVMDescription.Text = "";
			// 
			// textBoxNewVMName
			// 
			this.textBoxNewVMName.Location = new System.Drawing.Point(7, 46);
			this.textBoxNewVMName.Name = "textBoxNewVMName";
			this.textBoxNewVMName.Size = new System.Drawing.Size(396, 22);
			this.textBoxNewVMName.TabIndex = 1;
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(7, 71);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(149, 23);
			this.label4.TabIndex = 2;
			this.label4.Text = "VM Description";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(7, 19);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 23);
			this.label3.TabIndex = 0;
			this.label3.Text = "VM Name";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.Add(this.label2);
			this.tabPage1.Controls.Add(this.label1);
			this.tabPage1.Location = new System.Drawing.Point(4, 25);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(409, 365);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "Welcome";
			this.tabPage1.UseVisualStyleBackColor = true;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(7, 64);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(396, 287);
			this.label2.TabIndex = 1;
			this.label2.Text = "This wizard will help you to create a new virtual machine.\r\n\r\nLet\'s get started!";
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(7, 7);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(396, 36);
			this.label1.TabIndex = 0;
			this.label1.Text = "Welcome to New VM Wizard";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Controls.Add(this.tabPage2);
			this.tabControl1.Controls.Add(this.tabPage3);
			this.tabControl1.Controls.Add(this.tabPage5);
			this.tabControl1.Location = new System.Drawing.Point(238, 0);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(417, 394);
			this.tabControl1.TabIndex = 0;
			this.tabControl1.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.TabControl1Selecting);
			// 
			// NewMachineForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(667, 467);
			this.Controls.Add(this.tabControl1);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = global::KVMWC.Images.KVMWC;
			this.Name = "NewMachineForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "New Virtual Machine";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			this.tabPage5.ResumeLayout(false);
			this.tabPage3.ResumeLayout(false);
			this.tabPage3.PerformLayout();
			this.tabPage2.ResumeLayout(false);
			this.tabPage2.PerformLayout();
			this.tabPage1.ResumeLayout(false);
			this.tabControl1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
	}
}
