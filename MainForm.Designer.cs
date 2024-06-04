/*
 * Created by SharpDevelop.
 * User: razvan
 * Date: 6/4/2024
 * Time: 2:05 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace elevatorHeight
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox textBox4;
		private System.Windows.Forms.Label label4;
		
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
			this.button1 = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.textBox4 = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(81, 221);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(270, 23);
			this.button1.TabIndex = 0;
			this.button1.Text = "calculate nr of feets elevator was traveling";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(75, 129);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(178, 23);
			this.label1.TabIndex = 1;
			this.label1.Text = "distance between floors of building ?";
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(281, 151);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(100, 20);
			this.textBox1.TabIndex = 2;
			this.textBox1.Text = "8";
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(281, 177);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(100, 20);
			this.textBox2.TabIndex = 4;
			this.textBox2.Text = "18";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(75, 180);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(190, 23);
			this.label2.TabIndex = 3;
			this.label2.Text = "to what floor you going up to ?";
			// 
			// textBox3
			// 
			this.textBox3.Location = new System.Drawing.Point(81, 295);
			this.textBox3.Multiline = true;
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(270, 276);
			this.textBox3.TabIndex = 6;
			this.textBox3.Text = "150";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(81, 268);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 23);
			this.label3.TabIndex = 5;
			this.label3.Text = "rezult";
			// 
			// textBox4
			// 
			this.textBox4.Location = new System.Drawing.Point(281, 126);
			this.textBox4.Name = "textBox4";
			this.textBox4.Size = new System.Drawing.Size(100, 20);
			this.textBox4.TabIndex = 7;
			this.textBox4.Text = "15";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(75, 157);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(178, 23);
			this.label4.TabIndex = 8;
			this.label4.Text = "what floor is elevator on now ?";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1142, 607);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.textBox4);
			this.Controls.Add(this.textBox3);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.button1);
			this.Name = "MainForm";
			this.Text = "elevatorHeight";
			this.Load += new System.EventHandler(this.MainFormLoad);
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
