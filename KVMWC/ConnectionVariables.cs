/*
 * Created by SharpDevelop.
 * User: rseman
 * Date: 10/26/2020
 * Time: 8:13 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace KVMWC
{
	/// <summary>
	/// Description of ConnectionVariables.
	/// </summary>
	public class ConnectionVariables
	{
		private static string HOST;
		private static string USERNAME;
		private static string PASSWORD;
		
		public ConnectionVariables()
		{
		}
		
		public string[] GetConnectionInfo()
		{
			string[] info = {HOST, USERNAME, PASSWORD};
			return info;
		}
		
		public void SetConnectionInfo(string host, string user, string password)
		{
			HOST = host;
			USERNAME = user;
			PASSWORD = password;
		}
	}
}
