﻿namespace projectoPOO
{
	partial class Enroll
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.comboBox2 = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.btnEnroll = new System.Windows.Forms.Button();
			this.btnCancelEnroll = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// comboBox1
			// 
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Location = new System.Drawing.Point(32, 79);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(121, 21);
			this.comboBox1.TabIndex = 0;
			// 
			// comboBox2
			// 
			this.comboBox2.FormattingEnabled = true;
			this.comboBox2.Location = new System.Drawing.Point(279, 79);
			this.comboBox2.Name = "comboBox2";
			this.comboBox2.Size = new System.Drawing.Size(121, 21);
			this.comboBox2.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(199, 34);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(81, 13);
			this.label1.TabIndex = 2;
			this.label1.Text = "Inscrever Aluno";
			// 
			// btnEnroll
			// 
			this.btnEnroll.Location = new System.Drawing.Point(325, 171);
			this.btnEnroll.Name = "btnEnroll";
			this.btnEnroll.Size = new System.Drawing.Size(75, 23);
			this.btnEnroll.TabIndex = 3;
			this.btnEnroll.Text = "Inscrever";
			this.btnEnroll.UseVisualStyleBackColor = true;
			// 
			// btnCancelEnroll
			// 
			this.btnCancelEnroll.Location = new System.Drawing.Point(202, 171);
			this.btnCancelEnroll.Name = "btnCancelEnroll";
			this.btnCancelEnroll.Size = new System.Drawing.Size(75, 23);
			this.btnCancelEnroll.TabIndex = 4;
			this.btnCancelEnroll.Text = "Cancelar";
			this.btnCancelEnroll.UseVisualStyleBackColor = true;
			this.btnCancelEnroll.Click += new System.EventHandler(this.btnCancelEnroll_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(29, 63);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(81, 13);
			this.label2.TabIndex = 5;
			this.label2.Text = "Inscrever Aluno";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(276, 63);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(81, 13);
			this.label3.TabIndex = 6;
			this.label3.Text = "Inscrever Aluno";
			// 
			// Enroll
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(442, 233);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.btnCancelEnroll);
			this.Controls.Add(this.btnEnroll);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.comboBox2);
			this.Controls.Add(this.comboBox1);
			this.Name = "Enroll";
			this.Text = "Enroll";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.ComboBox comboBox2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnEnroll;
		private System.Windows.Forms.Button btnCancelEnroll;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
	}
}