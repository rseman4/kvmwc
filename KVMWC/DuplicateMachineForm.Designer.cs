/*
 * Created by SharpDevelop.
 * User: rseman
 * Date: 11/24/2020
 * Time: 12:56 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace KVMWC
{
	partial class DuplicateMachineForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox textBoxNewVMName;
		private System.Windows.Forms.Button duplicateVmButton;
		
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
			this.panel1 = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.textBoxNewVMName = new System.Windows.Forms.TextBox();
			this.duplicateVmButton = new System.Windows.Forms.Button();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.panel1.Controls.Add(this.label1);
			this.panel1.Location = new System.Drawing.Point(0, 1);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(450, 55);
			this.panel1.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(4, 15);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(443, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "Duplicate a Virtual Machine";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(12, 64);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(174, 23);
			this.label2.TabIndex = 1;
			this.label2.Text = "Enter name of new VM:";
			// 
			// textBoxNewVMName
			// 
			this.textBoxNewVMName.Location = new System.Drawing.Point(13, 90);
			this.textBoxNewVMName.Name = "textBoxNewVMName";
			this.textBoxNewVMName.Size = new System.Drawing.Size(424, 22);
			this.textBoxNewVMName.TabIndex = 2;
			// 
			// duplicateVmButton
			// 
			this.duplicateVmButton.Location = new System.Drawing.Point(325, 128);
			this.duplicateVmButton.Name = "duplicateVmButton";
			this.duplicateVmButton.Size = new System.Drawing.Size(112, 31);
			this.duplicateVmButton.TabIndex = 3;
			this.duplicateVmButton.Text = "Duplicate";
			this.duplicateVmButton.UseVisualStyleBackColor = true;
			this.duplicateVmButton.Click += new System.EventHandler(this.DuplicateVmButtonClick);
			// 
			// DuplicateMachineForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(449, 170);
			this.Controls.Add(this.duplicateVmButton);
			this.Controls.Add(this.textBoxNewVMName);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "DuplicateMachineForm";
			this.Text = "Duplicate VM";
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
