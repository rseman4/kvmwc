/*
 * Created by SharpDevelop.
 * User: rseman
 * Date: 10/24/2020
 * Time: 2:07 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Diagnostics;
using System.Net;
using System.IO;

namespace KVMWC
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	/// 
	
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			ServicePointManager.Expect100Continue = true;
			ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
			
			if(!File.Exists(@"plink.exe") || !File.Exists(@"putty.exe"))
			{
				DialogResult clientResult = MessageBox.Show("This program uses third-party programs like plink.exe and putty.exe. Would you like me to download it for you?\n\nBy continuing you agree with all licence agreements of third-party programs distributor.",
                "Missing putty.exe or plink.exe",
                MessageBoxButtons.YesNo);
				if(clientResult == DialogResult.Yes)
				{
					try
					{
						if(!File.Exists(@"plink.exe"))
						{
							using (var client = new WebClient())
							{
							    client.DownloadFile("https://the.earth.li/~sgtatham/putty/latest/w32/plink.exe", "plink.exe");
							}
						}
						if(!File.Exists(@"putty.exe"))
						{
							using (var client = new WebClient())
							{
							    client.DownloadFile("https://the.earth.li/~sgtatham/putty/latest/w32/putty.exe", "putty.exe");
							}
						}
					}
					catch(Exception e)
					{
						MessageBox.Show(e.ToString());
						Environment.Exit(1);
					}
				}
				else
				{
					MessageBox.Show("Unable to proceed without plink.exe and putty.exe!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					Environment.Exit(1);
				}
			}
			
			string path = @"connection.ini";
	        if(File.Exists(path))
	        {
	        	System.IO.StreamReader file = new System.IO.StreamReader(@"connection.ini");
	        	int counter = 0;
	        	string line;
	        	while((line = file.ReadLine()) != null)  
				{  
	        		if(counter == 0)
	        		{
	        			textBoxHostname.Text = line;
	        			counter++;
	        		}
	        		else if(counter == 1)
	        		{
	        			textBoxUsername.Text = line;
	        			counter++;
	        		}
	        		else if(counter > 1)
	        		{
	        			break;
	        		}
				}  
				file.Close();
				this.ActiveControl = textBoxPassword;
	        }
		}
		void LoginButtonClick(object sender, EventArgs e)
		{
			if(textBoxHostname.Text == "" || textBoxUsername.Text == "" || textBoxPassword.Text == "")
			{
				MessageBox.Show("Please, fill all fields!", "Error");
			}
			else
			{
				ConnectionVariables connVars = new ConnectionVariables();
				connVars.SetConnectionInfo(textBoxHostname.Text, textBoxUsername.Text, textBoxPassword.Text);
				Form ProgramForm = new ProgramForm();
				
				string path = @"connection.ini";
		        if(!File.Exists(path))
		        {
		            using (StreamWriter sw = File.CreateText(path))
		            {
		                sw.WriteLine(textBoxHostname.Text);
		                sw.WriteLine(textBoxUsername.Text);
		            }	
		        }
		        else
		        {
		        	File.Delete(path);
		        	using (StreamWriter sw = File.CreateText(path))
		            {
		                sw.WriteLine(textBoxHostname.Text);
		                sw.WriteLine(textBoxUsername.Text);
		            }		
		        }
				this.Hide();
				
				ProgramForm.Show();
			}
		}
		void TextBoxPasswordKeyUp(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Return)
            {
				loginButton.PerformClick();
            }
		}
	}
}
