/*
 * Created by SharpDevelop.
 * User: rseman
 * Date: 10/24/2020
 * Time: 10:18 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace KVMWC
{
	partial class ProgramForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.StatusStrip statusStrip1;
		private System.Windows.Forms.ToolStripStatusLabel toolStripConnectionStatus;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.DataGridViewTextBoxColumn columnVMName;
		private System.Windows.Forms.DataGridViewTextBoxColumn columnVMStatus;
		private System.Windows.Forms.DataGridViewTextBoxColumn columnVMDescription;
		private System.Windows.Forms.DataGridViewTextBoxColumn columnVMUtilizationCPU;
		private System.Windows.Forms.DataGridViewTextBoxColumn columnVMUtilizationMEM;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem actionsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem statisticsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
		private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemNewMachine;
		private System.Windows.Forms.ToolStripMenuItem diskToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemRefreshVMList;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemNewConnection;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemExit;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemAbout;
		private System.Windows.Forms.ToolStripContainer toolStripContainer1;
		private System.Windows.Forms.ToolStripPanel BottomToolStripPanel;
		private System.Windows.Forms.ToolStripPanel TopToolStripPanel;
		private System.Windows.Forms.ToolStripPanel RightToolStripPanel;
		private System.Windows.Forms.ToolStripPanel LeftToolStripPanel;
		private System.Windows.Forms.ToolStripContentPanel ContentPanel;
		private System.Windows.Forms.ToolStrip toolStrip1;
		private System.Windows.Forms.ToolStripSplitButton toolStripSplitButtonNew;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemNewVM;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemNewDisk;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
		private System.Windows.Forms.ToolStripButton toolStripButtonStartVM;
		private System.Windows.Forms.ToolStripSplitButton toolStripSplitButtonShutdownVM;
		private System.Windows.Forms.ToolStripButton toolStripButtonRestartVM;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemForceShutdown;
		private System.Windows.Forms.ToolStripButton toolStripButtonEditVM;
		private System.Windows.Forms.ToolStripButton toolStripButtonDeleteVM;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
		private System.Windows.Forms.SplitContainer splitContainer1;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.RichTextBox richTextBoxVMLog;
		private System.Windows.Forms.Label labelVMName;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ToolStripMenuItem exportListToolStripMenuItem;
		private System.Windows.Forms.Label labelVMUUID;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label labelVMDescription;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label labelVMCPUs;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label labelVMMemory;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.TreeView treeView1;
		private System.Windows.Forms.ToolStripButton toolStripButtonDuplicateVM;
		
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProgramForm));
			System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Disks");
			System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("CDs");
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItemNewConnection = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.toolStripMenuItemExit = new System.Windows.Forms.ToolStripMenuItem();
			this.actionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItemRefreshVMList = new System.Windows.Forms.ToolStripMenuItem();
			this.statisticsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.exportListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItemAbout = new System.Windows.Forms.ToolStripMenuItem();
			this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.toolStripMenuItemNewMachine = new System.Windows.Forms.ToolStripMenuItem();
			this.diskToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.columnVMName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.columnVMStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.columnVMDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.columnVMUtilizationCPU = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.columnVMUtilizationMEM = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.toolStripConnectionStatus = new System.Windows.Forms.ToolStripStatusLabel();
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.BottomToolStripPanel = new System.Windows.Forms.ToolStripPanel();
			this.TopToolStripPanel = new System.Windows.Forms.ToolStripPanel();
			this.RightToolStripPanel = new System.Windows.Forms.ToolStripPanel();
			this.LeftToolStripPanel = new System.Windows.Forms.ToolStripPanel();
			this.ContentPanel = new System.Windows.Forms.ToolStripContentPanel();
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.toolStripSplitButtonNew = new System.Windows.Forms.ToolStripSplitButton();
			this.toolStripMenuItemNewVM = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItemNewDisk = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripButtonEditVM = new System.Windows.Forms.ToolStripButton();
			this.toolStripButtonDeleteVM = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.toolStripButtonStartVM = new System.Windows.Forms.ToolStripButton();
			this.toolStripButtonRestartVM = new System.Windows.Forms.ToolStripButton();
			this.toolStripSplitButtonShutdownVM = new System.Windows.Forms.ToolStripSplitButton();
			this.toolStripMenuItemForceShutdown = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.treeView1 = new System.Windows.Forms.TreeView();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.label1 = new System.Windows.Forms.Label();
			this.labelVMMemory = new System.Windows.Forms.Label();
			this.labelVMName = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.labelVMCPUs = new System.Windows.Forms.Label();
			this.labelVMDescription = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.labelVMUUID = new System.Windows.Forms.Label();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.richTextBoxVMLog = new System.Windows.Forms.RichTextBox();
			this.toolStripButtonDuplicateVM = new System.Windows.Forms.ToolStripButton();
			this.menuStrip1.SuspendLayout();
			this.contextMenuStrip1.SuspendLayout();
			this.toolStripContainer1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.statusStrip1.SuspendLayout();
			this.toolStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			this.tabControl1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.tabPage2.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.menuToolStripMenuItem,
			this.actionsToolStripMenuItem,
			this.statisticsToolStripMenuItem,
			this.helpToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(1096, 28);
			this.menuStrip1.TabIndex = 6;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// menuToolStripMenuItem
			// 
			this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.toolStripMenuItemNewConnection,
			this.toolStripSeparator1,
			this.toolStripMenuItemExit});
			this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
			this.menuToolStripMenuItem.Size = new System.Drawing.Size(58, 24);
			this.menuToolStripMenuItem.Text = "Menu";
			// 
			// toolStripMenuItemNewConnection
			// 
			this.toolStripMenuItemNewConnection.Name = "toolStripMenuItemNewConnection";
			this.toolStripMenuItemNewConnection.Size = new System.Drawing.Size(191, 26);
			this.toolStripMenuItemNewConnection.Text = "New connection";
			this.toolStripMenuItemNewConnection.Click += new System.EventHandler(this.ToolStripMenuItemNewConnectionClick);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(188, 6);
			// 
			// toolStripMenuItemExit
			// 
			this.toolStripMenuItemExit.Name = "toolStripMenuItemExit";
			this.toolStripMenuItemExit.Size = new System.Drawing.Size(191, 26);
			this.toolStripMenuItemExit.Text = "Exit";
			this.toolStripMenuItemExit.Click += new System.EventHandler(this.ToolStripMenuItemExitClick);
			// 
			// actionsToolStripMenuItem
			// 
			this.actionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.toolStripMenuItemRefreshVMList});
			this.actionsToolStripMenuItem.Name = "actionsToolStripMenuItem";
			this.actionsToolStripMenuItem.Size = new System.Drawing.Size(70, 24);
			this.actionsToolStripMenuItem.Text = "Actions";
			// 
			// toolStripMenuItemRefreshVMList
			// 
			this.toolStripMenuItemRefreshVMList.Name = "toolStripMenuItemRefreshVMList";
			this.toolStripMenuItemRefreshVMList.Size = new System.Drawing.Size(162, 26);
			this.toolStripMenuItemRefreshVMList.Text = "Refresh (F5)";
			this.toolStripMenuItemRefreshVMList.Click += new System.EventHandler(this.ToolStripMenuItemRefreshVMListClick);
			// 
			// statisticsToolStripMenuItem
			// 
			this.statisticsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.exportListToolStripMenuItem});
			this.statisticsToolStripMenuItem.Name = "statisticsToolStripMenuItem";
			this.statisticsToolStripMenuItem.Size = new System.Drawing.Size(79, 24);
			this.statisticsToolStripMenuItem.Text = "Statistics";
			// 
			// exportListToolStripMenuItem
			// 
			this.exportListToolStripMenuItem.Name = "exportListToolStripMenuItem";
			this.exportListToolStripMenuItem.Size = new System.Drawing.Size(157, 26);
			this.exportListToolStripMenuItem.Text = "Export CSV";
			this.exportListToolStripMenuItem.Click += new System.EventHandler(this.ExportListToolStripMenuItemClick);
			// 
			// helpToolStripMenuItem
			// 
			this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.toolStripMenuItemAbout});
			this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
			this.helpToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
			this.helpToolStripMenuItem.Text = "Help";
			// 
			// toolStripMenuItemAbout
			// 
			this.toolStripMenuItemAbout.Name = "toolStripMenuItemAbout";
			this.toolStripMenuItemAbout.Size = new System.Drawing.Size(125, 26);
			this.toolStripMenuItemAbout.Text = "About";
			this.toolStripMenuItemAbout.Click += new System.EventHandler(this.ToolStripMenuItemAboutClick);
			// 
			// contextMenuStrip1
			// 
			this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.toolStripMenuItemNewMachine,
			this.diskToolStripMenuItem});
			this.contextMenuStrip1.Name = "contextMenuStrip1";
			this.contextMenuStrip1.Size = new System.Drawing.Size(107, 52);
			// 
			// toolStripMenuItemNewMachine
			// 
			this.toolStripMenuItemNewMachine.Name = "toolStripMenuItemNewMachine";
			this.toolStripMenuItemNewMachine.Size = new System.Drawing.Size(106, 24);
			this.toolStripMenuItemNewMachine.Text = "VM";
			this.toolStripMenuItemNewMachine.Click += new System.EventHandler(this.ToolStripMenuItemNewMachineClick);
			// 
			// diskToolStripMenuItem
			// 
			this.diskToolStripMenuItem.Name = "diskToolStripMenuItem";
			this.diskToolStripMenuItem.Size = new System.Drawing.Size(106, 24);
			this.diskToolStripMenuItem.Text = "Disk";
			// 
			// toolStripContainer1
			// 
			this.toolStripContainer1.BottomToolStripPanelVisible = false;
			// 
			// toolStripContainer1.ContentPanel
			// 
			this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(150, 175);
			this.toolStripContainer1.LeftToolStripPanelVisible = false;
			this.toolStripContainer1.Location = new System.Drawing.Point(0, 0);
			this.toolStripContainer1.Name = "toolStripContainer1";
			this.toolStripContainer1.Size = new System.Drawing.Size(150, 175);
			this.toolStripContainer1.TabIndex = 0;
			this.toolStripContainer1.Text = "toolStripContainer1";
			this.toolStripContainer1.TopToolStripPanelVisible = false;
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToAddRows = false;
			this.dataGridView1.AllowUserToDeleteRows = false;
			this.dataGridView1.AllowUserToResizeRows = false;
			this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
			| System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
			this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
			this.columnVMName,
			this.columnVMStatus,
			this.columnVMDescription,
			this.columnVMUtilizationCPU,
			this.columnVMUtilizationMEM});
			this.dataGridView1.Location = new System.Drawing.Point(3, 3);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.ReadOnly = true;
			this.dataGridView1.RowHeadersVisible = false;
			this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader;
			this.dataGridView1.RowTemplate.Height = 24;
			this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataGridView1.Size = new System.Drawing.Size(853, 133);
			this.dataGridView1.TabIndex = 0;
			this.dataGridView1.SelectionChanged += new System.EventHandler(this.DataGridView1SelectionChanged);
			// 
			// columnVMName
			// 
			this.columnVMName.HeaderText = "VM Name";
			this.columnVMName.Name = "columnVMName";
			this.columnVMName.ReadOnly = true;
			// 
			// columnVMStatus
			// 
			this.columnVMStatus.HeaderText = "Status";
			this.columnVMStatus.Name = "columnVMStatus";
			this.columnVMStatus.ReadOnly = true;
			// 
			// columnVMDescription
			// 
			this.columnVMDescription.HeaderText = "Description";
			this.columnVMDescription.Name = "columnVMDescription";
			this.columnVMDescription.ReadOnly = true;
			// 
			// columnVMUtilizationCPU
			// 
			this.columnVMUtilizationCPU.HeaderText = "CPU";
			this.columnVMUtilizationCPU.Name = "columnVMUtilizationCPU";
			this.columnVMUtilizationCPU.ReadOnly = true;
			// 
			// columnVMUtilizationMEM
			// 
			this.columnVMUtilizationMEM.HeaderText = "Memory";
			this.columnVMUtilizationMEM.Name = "columnVMUtilizationMEM";
			this.columnVMUtilizationMEM.ReadOnly = true;
			// 
			// toolStripConnectionStatus
			// 
			this.toolStripConnectionStatus.ForeColor = System.Drawing.Color.DarkGreen;
			this.toolStripConnectionStatus.Name = "toolStripConnectionStatus";
			this.toolStripConnectionStatus.Size = new System.Drawing.Size(101, 20);
			this.toolStripConnectionStatus.Text = "Connected to:";
			// 
			// statusStrip1
			// 
			this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.toolStripConnectionStatus});
			this.statusStrip1.Location = new System.Drawing.Point(0, 494);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new System.Drawing.Size(1096, 25);
			this.statusStrip1.SizingGrip = false;
			this.statusStrip1.TabIndex = 8;
			this.statusStrip1.Text = "statusStrip1";
			// 
			// BottomToolStripPanel
			// 
			this.BottomToolStripPanel.Location = new System.Drawing.Point(0, 0);
			this.BottomToolStripPanel.Name = "BottomToolStripPanel";
			this.BottomToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
			this.BottomToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
			this.BottomToolStripPanel.Size = new System.Drawing.Size(0, 0);
			// 
			// TopToolStripPanel
			// 
			this.TopToolStripPanel.Location = new System.Drawing.Point(0, 0);
			this.TopToolStripPanel.Name = "TopToolStripPanel";
			this.TopToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
			this.TopToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
			this.TopToolStripPanel.Size = new System.Drawing.Size(0, 0);
			// 
			// RightToolStripPanel
			// 
			this.RightToolStripPanel.Location = new System.Drawing.Point(0, 0);
			this.RightToolStripPanel.Name = "RightToolStripPanel";
			this.RightToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
			this.RightToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
			this.RightToolStripPanel.Size = new System.Drawing.Size(0, 0);
			// 
			// LeftToolStripPanel
			// 
			this.LeftToolStripPanel.Location = new System.Drawing.Point(0, 0);
			this.LeftToolStripPanel.Name = "LeftToolStripPanel";
			this.LeftToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
			this.LeftToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
			this.LeftToolStripPanel.Size = new System.Drawing.Size(0, 0);
			// 
			// ContentPanel
			// 
			this.ContentPanel.Size = new System.Drawing.Size(221, 387);
			// 
			// toolStrip1
			// 
			this.toolStrip1.AutoSize = false;
			this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Right;
			this.toolStrip1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
			this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.toolStripSplitButtonNew,
			this.toolStripButtonEditVM,
			this.toolStripButtonDuplicateVM,
			this.toolStripButtonDeleteVM,
			this.toolStripSeparator2,
			this.toolStripButtonStartVM,
			this.toolStripButtonRestartVM,
			this.toolStripSplitButtonShutdownVM});
			this.toolStrip1.Location = new System.Drawing.Point(874, 28);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.Size = new System.Drawing.Size(222, 466);
			this.toolStrip1.TabIndex = 9;
			this.toolStrip1.Text = "toolStrip1";
			// 
			// toolStripSplitButtonNew
			// 
			this.toolStripSplitButtonNew.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.toolStripMenuItemNewVM,
			this.toolStripMenuItemNewDisk});
			this.toolStripSplitButtonNew.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSplitButtonNew.Image")));
			this.toolStripSplitButtonNew.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.toolStripSplitButtonNew.ImageTransparentColor = System.Drawing.Color.Transparent;
			this.toolStripSplitButtonNew.Name = "toolStripSplitButtonNew";
			this.toolStripSplitButtonNew.Size = new System.Drawing.Size(220, 27);
			this.toolStripSplitButtonNew.Text = "New";
			// 
			// toolStripMenuItemNewVM
			// 
			this.toolStripMenuItemNewVM.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItemNewVM.Image")));
			this.toolStripMenuItemNewVM.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.toolStripMenuItemNewVM.Name = "toolStripMenuItemNewVM";
			this.toolStripMenuItemNewVM.Size = new System.Drawing.Size(124, 28);
			this.toolStripMenuItemNewVM.Text = "VM";
			this.toolStripMenuItemNewVM.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.toolStripMenuItemNewVM.Click += new System.EventHandler(this.ToolStripMenuItemNewVMClick);
			// 
			// toolStripMenuItemNewDisk
			// 
			this.toolStripMenuItemNewDisk.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItemNewDisk.Image")));
			this.toolStripMenuItemNewDisk.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.toolStripMenuItemNewDisk.Name = "toolStripMenuItemNewDisk";
			this.toolStripMenuItemNewDisk.Size = new System.Drawing.Size(124, 28);
			this.toolStripMenuItemNewDisk.Text = "Disk";
			this.toolStripMenuItemNewDisk.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// toolStripButtonEditVM
			// 
			this.toolStripButtonEditVM.Image = global::KVMWC.Images.edit;
			this.toolStripButtonEditVM.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.toolStripButtonEditVM.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButtonEditVM.Name = "toolStripButtonEditVM";
			this.toolStripButtonEditVM.Size = new System.Drawing.Size(220, 27);
			this.toolStripButtonEditVM.Text = "Edit VM";
			this.toolStripButtonEditVM.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// toolStripButtonDeleteVM
			// 
			this.toolStripButtonDeleteVM.Image = global::KVMWC.Images.delete;
			this.toolStripButtonDeleteVM.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.toolStripButtonDeleteVM.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButtonDeleteVM.Name = "toolStripButtonDeleteVM";
			this.toolStripButtonDeleteVM.Size = new System.Drawing.Size(220, 27);
			this.toolStripButtonDeleteVM.Text = "Delete VM";
			this.toolStripButtonDeleteVM.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.toolStripButtonDeleteVM.Click += new System.EventHandler(this.ToolStripButtonDeleteVMClick);
			// 
			// toolStripSeparator2
			// 
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new System.Drawing.Size(220, 6);
			// 
			// toolStripButtonStartVM
			// 
			this.toolStripButtonStartVM.Image = global::KVMWC.Images.start;
			this.toolStripButtonStartVM.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.toolStripButtonStartVM.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButtonStartVM.Name = "toolStripButtonStartVM";
			this.toolStripButtonStartVM.Size = new System.Drawing.Size(220, 27);
			this.toolStripButtonStartVM.Text = "Start VM";
			this.toolStripButtonStartVM.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.toolStripButtonStartVM.Click += new System.EventHandler(this.ToolStripButtonStartVMClick);
			// 
			// toolStripButtonRestartVM
			// 
			this.toolStripButtonRestartVM.Image = global::KVMWC.Images.restart;
			this.toolStripButtonRestartVM.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.toolStripButtonRestartVM.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButtonRestartVM.Name = "toolStripButtonRestartVM";
			this.toolStripButtonRestartVM.Size = new System.Drawing.Size(220, 27);
			this.toolStripButtonRestartVM.Text = "Restart VM";
			this.toolStripButtonRestartVM.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.toolStripButtonRestartVM.Click += new System.EventHandler(this.ToolStripButtonRestartVMClick);
			// 
			// toolStripSplitButtonShutdownVM
			// 
			this.toolStripSplitButtonShutdownVM.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.toolStripMenuItemForceShutdown,
			this.toolStripMenuItem1});
			this.toolStripSplitButtonShutdownVM.Image = global::KVMWC.Images.stop;
			this.toolStripSplitButtonShutdownVM.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.toolStripSplitButtonShutdownVM.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripSplitButtonShutdownVM.Name = "toolStripSplitButtonShutdownVM";
			this.toolStripSplitButtonShutdownVM.Size = new System.Drawing.Size(220, 27);
			this.toolStripSplitButtonShutdownVM.Text = "Shutdown VM";
			this.toolStripSplitButtonShutdownVM.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.toolStripSplitButtonShutdownVM.ButtonClick += new System.EventHandler(this.ToolStripSplitButtonShutdownVMButtonClick);
			// 
			// toolStripMenuItemForceShutdown
			// 
			this.toolStripMenuItemForceShutdown.Image = global::KVMWC.Images.stop;
			this.toolStripMenuItemForceShutdown.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.toolStripMenuItemForceShutdown.Name = "toolStripMenuItemForceShutdown";
			this.toolStripMenuItemForceShutdown.Size = new System.Drawing.Size(229, 28);
			this.toolStripMenuItemForceShutdown.Text = "Force Shutdown";
			this.toolStripMenuItemForceShutdown.Click += new System.EventHandler(this.ToolStripMenuItemForceShutdownClick);
			// 
			// toolStripMenuItem1
			// 
			this.toolStripMenuItem1.Image = global::KVMWC.Images.SaveStatus;
			this.toolStripMenuItem1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.toolStripMenuItem1.Name = "toolStripMenuItem1";
			this.toolStripMenuItem1.Size = new System.Drawing.Size(229, 28);
			this.toolStripMenuItem1.Text = "Save State";
			this.toolStripMenuItem1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// splitContainer1
			// 
			this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
			| System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.splitContainer1.Location = new System.Drawing.Point(12, 31);
			this.splitContainer1.Name = "splitContainer1";
			this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// splitContainer1.Panel1
			// 
			this.splitContainer1.Panel1.Controls.Add(this.dataGridView1);
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.Controls.Add(this.tabControl1);
			this.splitContainer1.Size = new System.Drawing.Size(859, 463);
			this.splitContainer1.SplitterDistance = 139;
			this.splitContainer1.TabIndex = 10;
			// 
			// tabControl1
			// 
			this.tabControl1.Alignment = System.Windows.Forms.TabAlignment.Bottom;
			this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
			| System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Controls.Add(this.tabPage2);
			this.tabControl1.Location = new System.Drawing.Point(3, 3);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(853, 314);
			this.tabControl1.TabIndex = 0;
			// 
			// tabPage1
			// 
			this.tabPage1.AutoScroll = true;
			this.tabPage1.Controls.Add(this.groupBox2);
			this.tabPage1.Controls.Add(this.groupBox1);
			this.tabPage1.Location = new System.Drawing.Point(4, 4);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(845, 285);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "General";
			this.tabPage1.UseVisualStyleBackColor = true;
			// 
			// groupBox2
			// 
			this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox2.AutoSize = true;
			this.groupBox2.Controls.Add(this.treeView1);
			this.groupBox2.Location = new System.Drawing.Point(6, 108);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(832, 158);
			this.groupBox2.TabIndex = 11;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Attached Disks";
			// 
			// treeView1
			// 
			this.treeView1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.treeView1.Location = new System.Drawing.Point(3, 18);
			this.treeView1.Name = "treeView1";
			treeNode3.Name = "disks";
			treeNode3.Text = "Disks";
			treeNode4.Name = "cds";
			treeNode4.Text = "CDs";
			this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
			treeNode3,
			treeNode4});
			this.treeView1.Size = new System.Drawing.Size(826, 137);
			this.treeView1.TabIndex = 0;
			// 
			// groupBox1
			// 
			this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.labelVMMemory);
			this.groupBox1.Controls.Add(this.labelVMName);
			this.groupBox1.Controls.Add(this.label10);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.labelVMCPUs);
			this.groupBox1.Controls.Add(this.labelVMDescription);
			this.groupBox1.Controls.Add(this.label8);
			this.groupBox1.Controls.Add(this.label6);
			this.groupBox1.Controls.Add(this.labelVMUUID);
			this.groupBox1.Location = new System.Drawing.Point(6, 6);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(832, 96);
			this.groupBox1.TabIndex = 10;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "General";
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(6, 18);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(69, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "Name:";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// labelVMMemory
			// 
			this.labelVMMemory.Location = new System.Drawing.Point(523, 41);
			this.labelVMMemory.Name = "labelVMMemory";
			this.labelVMMemory.Size = new System.Drawing.Size(142, 23);
			this.labelVMMemory.TabIndex = 9;
			this.labelVMMemory.Text = "0";
			this.labelVMMemory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// labelVMName
			// 
			this.labelVMName.Location = new System.Drawing.Point(137, 18);
			this.labelVMName.Name = "labelVMName";
			this.labelVMName.Size = new System.Drawing.Size(226, 23);
			this.labelVMName.TabIndex = 1;
			this.labelVMName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label10
			// 
			this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label10.Location = new System.Drawing.Point(410, 41);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(74, 23);
			this.label10.TabIndex = 8;
			this.label10.Text = "Memory:";
			this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(5, 41);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(112, 23);
			this.label4.TabIndex = 2;
			this.label4.Text = "Description:";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// labelVMCPUs
			// 
			this.labelVMCPUs.Location = new System.Drawing.Point(523, 18);
			this.labelVMCPUs.Name = "labelVMCPUs";
			this.labelVMCPUs.Size = new System.Drawing.Size(142, 23);
			this.labelVMCPUs.TabIndex = 7;
			this.labelVMCPUs.Text = "0";
			this.labelVMCPUs.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// labelVMDescription
			// 
			this.labelVMDescription.Location = new System.Drawing.Point(137, 41);
			this.labelVMDescription.Name = "labelVMDescription";
			this.labelVMDescription.Size = new System.Drawing.Size(226, 23);
			this.labelVMDescription.TabIndex = 3;
			this.labelVMDescription.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label8
			// 
			this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.Location = new System.Drawing.Point(410, 18);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(74, 23);
			this.label8.TabIndex = 6;
			this.label8.Text = "vCPUs:";
			this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label6
			// 
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(6, 64);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(112, 23);
			this.label6.TabIndex = 4;
			this.label6.Text = "UUID:";
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// labelVMUUID
			// 
			this.labelVMUUID.Location = new System.Drawing.Point(137, 64);
			this.labelVMUUID.Name = "labelVMUUID";
			this.labelVMUUID.Size = new System.Drawing.Size(226, 23);
			this.labelVMUUID.TabIndex = 5;
			this.labelVMUUID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// tabPage2
			// 
			this.tabPage2.Controls.Add(this.richTextBoxVMLog);
			this.tabPage2.Location = new System.Drawing.Point(4, 4);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new System.Drawing.Size(845, 285);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "Log";
			this.tabPage2.UseVisualStyleBackColor = true;
			// 
			// richTextBoxVMLog
			// 
			this.richTextBoxVMLog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
			| System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.richTextBoxVMLog.Location = new System.Drawing.Point(6, 6);
			this.richTextBoxVMLog.Name = "richTextBoxVMLog";
			this.richTextBoxVMLog.ReadOnly = true;
			this.richTextBoxVMLog.Size = new System.Drawing.Size(833, 273);
			this.richTextBoxVMLog.TabIndex = 0;
			this.richTextBoxVMLog.Text = "This is a test.";
			// 
			// toolStripButtonDuplicateVM
			// 
			this.toolStripButtonDuplicateVM.Image = global::KVMWC.Images.duplicate;
			this.toolStripButtonDuplicateVM.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.toolStripButtonDuplicateVM.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButtonDuplicateVM.Name = "toolStripButtonDuplicateVM";
			this.toolStripButtonDuplicateVM.Size = new System.Drawing.Size(220, 27);
			this.toolStripButtonDuplicateVM.Text = "Duplicate VM";
			this.toolStripButtonDuplicateVM.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.toolStripButtonDuplicateVM.Click += new System.EventHandler(this.ToolStripButtonDuplicateVMClick);
			// 
			// ProgramForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoScroll = true;
			this.ClientSize = new System.Drawing.Size(1096, 519);
			this.Controls.Add(this.splitContainer1);
			this.Controls.Add(this.toolStrip1);
			this.Controls.Add(this.statusStrip1);
			this.Controls.Add(this.menuStrip1);
			this.Icon = global::KVMWC.Images.KVMWC;
			this.Name = "ProgramForm";
			this.Text = "KVM Windows Console";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ProgramFormFormClosed);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.contextMenuStrip1.ResumeLayout(false);
			this.toolStripContainer1.ResumeLayout(false);
			this.toolStripContainer1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.statusStrip1.ResumeLayout(false);
			this.statusStrip1.PerformLayout();
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
			this.splitContainer1.ResumeLayout(false);
			this.tabControl1.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.tabPage1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.tabPage2.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
