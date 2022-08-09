/*
 * Created by SharpDevelop.
 * User: Charisse Oblefias
 * Date: 5/15/2021
 * Time: 5:11 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Machine_Problem_Checkbox
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.RadioButton radOption1;
		private System.Windows.Forms.RadioButton radOption2;
		private System.Windows.Forms.RadioButton radOption3;
		private System.Windows.Forms.TextBox txtOptionClicked;
		private System.Windows.Forms.CheckBox chkCheck1;
		private System.Windows.Forms.CheckBox chkCheck2;
		private System.Windows.Forms.CheckBox chkCheck3;
		private System.Windows.Forms.TextBox txtCheckClicked;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		
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
			this.radOption1 = new System.Windows.Forms.RadioButton();
			this.radOption2 = new System.Windows.Forms.RadioButton();
			this.radOption3 = new System.Windows.Forms.RadioButton();
			this.txtOptionClicked = new System.Windows.Forms.TextBox();
			this.chkCheck1 = new System.Windows.Forms.CheckBox();
			this.chkCheck2 = new System.Windows.Forms.CheckBox();
			this.chkCheck3 = new System.Windows.Forms.CheckBox();
			this.txtCheckClicked = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// radOption1
			// 
			this.radOption1.Location = new System.Drawing.Point(27, 30);
			this.radOption1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.radOption1.Name = "radOption1";
			this.radOption1.Size = new System.Drawing.Size(104, 25);
			this.radOption1.TabIndex = 0;
			this.radOption1.TabStop = true;
			this.radOption1.Text = "Option 1";
			this.radOption1.UseVisualStyleBackColor = true;
			this.radOption1.CheckedChanged += new System.EventHandler(this.RadOption1CheckedChanged);
			// 
			// radOption2
			// 
			this.radOption2.Location = new System.Drawing.Point(161, 29);
			this.radOption2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.radOption2.Name = "radOption2";
			this.radOption2.Size = new System.Drawing.Size(104, 25);
			this.radOption2.TabIndex = 1;
			this.radOption2.TabStop = true;
			this.radOption2.Text = "Option 2";
			this.radOption2.UseVisualStyleBackColor = true;
			this.radOption2.CheckedChanged += new System.EventHandler(this.RadOption2CheckedChanged);
			// 
			// radOption3
			// 
			this.radOption3.Location = new System.Drawing.Point(290, 30);
			this.radOption3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.radOption3.Name = "radOption3";
			this.radOption3.Size = new System.Drawing.Size(104, 25);
			this.radOption3.TabIndex = 2;
			this.radOption3.TabStop = true;
			this.radOption3.Text = "Option 3";
			this.radOption3.UseVisualStyleBackColor = true;
			this.radOption3.CheckedChanged += new System.EventHandler(this.RadOption3CheckedChanged);
			// 
			// txtOptionClicked
			// 
			this.txtOptionClicked.Location = new System.Drawing.Point(57, 87);
			this.txtOptionClicked.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.txtOptionClicked.Name = "txtOptionClicked";
			this.txtOptionClicked.Size = new System.Drawing.Size(255, 23);
			this.txtOptionClicked.TabIndex = 3;
			// 
			// chkCheck1
			// 
			this.chkCheck1.Location = new System.Drawing.Point(27, 154);
			this.chkCheck1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.chkCheck1.Name = "chkCheck1";
			this.chkCheck1.Size = new System.Drawing.Size(104, 25);
			this.chkCheck1.TabIndex = 4;
			this.chkCheck1.Text = "Check 1";
			this.chkCheck1.UseVisualStyleBackColor = true;
			this.chkCheck1.CheckedChanged += new System.EventHandler(this.ChkCheck1CheckedChanged);
			// 
			// chkCheck2
			// 
			this.chkCheck2.Location = new System.Drawing.Point(161, 154);
			this.chkCheck2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.chkCheck2.Name = "chkCheck2";
			this.chkCheck2.Size = new System.Drawing.Size(104, 25);
			this.chkCheck2.TabIndex = 5;
			this.chkCheck2.Text = "Check 2";
			this.chkCheck2.UseVisualStyleBackColor = true;
			this.chkCheck2.CheckedChanged += new System.EventHandler(this.ChkCheck2CheckedChanged);
			// 
			// chkCheck3
			// 
			this.chkCheck3.Location = new System.Drawing.Point(290, 154);
			this.chkCheck3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.chkCheck3.Name = "chkCheck3";
			this.chkCheck3.Size = new System.Drawing.Size(104, 25);
			this.chkCheck3.TabIndex = 6;
			this.chkCheck3.Text = "Check 3";
			this.chkCheck3.UseVisualStyleBackColor = true;
			this.chkCheck3.CheckedChanged += new System.EventHandler(this.ChkCheck3CheckedChanged);
			// 
			// txtCheckClicked
			// 
			this.txtCheckClicked.Location = new System.Drawing.Point(57, 216);
			this.txtCheckClicked.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.txtCheckClicked.Name = "txtCheckClicked";
			this.txtCheckClicked.Size = new System.Drawing.Size(255, 23);
			this.txtCheckClicked.TabIndex = 7;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(57, 269);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 36);
			this.button1.TabIndex = 8;
			this.button1.Text = "Clear";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(237, 268);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(75, 37);
			this.button2.TabIndex = 9;
			this.button2.Text = "Exit";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.Button2Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.OldLace;
			this.ClientSize = new System.Drawing.Size(398, 318);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.txtCheckClicked);
			this.Controls.Add(this.chkCheck3);
			this.Controls.Add(this.chkCheck2);
			this.Controls.Add(this.chkCheck1);
			this.Controls.Add(this.txtOptionClicked);
			this.Controls.Add(this.radOption3);
			this.Controls.Add(this.radOption2);
			this.Controls.Add(this.radOption1);
			this.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.Name = "MainForm";
			this.Text = "Machine Problem Checkbox";
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
