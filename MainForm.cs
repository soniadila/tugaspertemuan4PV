﻿/*
 * Created by SharpDevelop.
 * User: User
 * Date: 02/03/2022
 * Time: 14:53
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace tugaspertemuan4
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			MessageBox.Show ("Hello World " + this.textBox1.Text + ", NIM Anda : " + this.textBox2.Text + ", KOM Anda : " + this.textBox3.Text + ", Mata Kuliah : " + this.textBox4.Text);	
		}
		
	}
}
