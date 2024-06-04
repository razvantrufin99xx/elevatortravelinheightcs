/*
 * Created by SharpDevelop.
 * User: razvan
 * Date: 6/4/2024
 * Time: 2:05 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace elevatorHeight
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
		void MainFormLoad(object sender, EventArgs e)
		{
	
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			calculate();
		}
		public double parseTextBox2Double(ref TextBox t)
		{
			double x = -1000000000;
			try{
				x = double.Parse(t.Text);
			}
			catch{}
			if(x!=-1000000000)
			{
				return x;
			}
			else
			{
				return -1;
			}
		}
		public void parseDouble2TextBoxText(ref double x,ref TextBox t, string typeofadding)
		{
			if(typeofadding=="concatenate")
			{
				t.Text += x.ToString();
			}
			else if(typeofadding=="replace")
			{
				t.Text = x.ToString();
			}
		}
		public void calculate()
		{
			double fbfb = parseTextBox2Double(ref textBox4);
			double wfig = parseTextBox2Double(ref textBox2);
			double cf = parseTextBox2Double(ref textBox1);
			double r = fbfb * Math.Abs(cf-wfig);
			parseDouble2TextBoxText(ref r, ref this.textBox3,"replace");
		}
	}
}
