/*
 * Created by SharpDevelop.
 * User: Charisse Oblefias
 * Date: 5/15/2021
 * Time: 5:11 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Machine_Problem_Checkbox
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
		void RadOption1CheckedChanged(object sender, EventArgs e)
		{
			this.txtOptionClicked.Text = "Option 1 clicked";
		}
		void RadOption2CheckedChanged(object sender, EventArgs e)
		{
			this.txtOptionClicked.Text = "Option 2 clicked";
		}
		void RadOption3CheckedChanged(object sender, EventArgs e)
		{
			this.txtOptionClicked.Text = "Option 3 clicked";
		}
		void ChkCheck1CheckedChanged(object sender, EventArgs e)
		{
			this.txtCheckClicked.Text = "Check 1 clicked";
		}
		void ChkCheck2CheckedChanged(object sender, EventArgs e)
		{
			this.txtCheckClicked.Text ="Check 2 clicked";
		}
		void ChkCheck3CheckedChanged(object sender, EventArgs e)
		{
			this.txtCheckClicked.Text ="Check 3 clicked";
		}
		void Button1Click(object sender, EventArgs e)
		{
			txtOptionClicked.Clear();
			txtCheckClicked.Clear();
			radOption1.Checked = false;
			radOption2.Checked = false;
			radOption3.Checked = false;
			chkCheck1.Checked = false;
			chkCheck2.Checked = false;
			chkCheck3.Checked = false;
		}
		void Button2Click(object sender, EventArgs e)
		{
			Application.Exit();
		}
	}
}
