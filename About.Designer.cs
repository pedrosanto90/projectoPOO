namespace projectoPOO
{
	partial class About
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
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.btnCloseAbout = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(46, 31);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(695, 24);
			this.label1.TabIndex = 0;
			this.label1.Text = "Trabalho Realizado No Âmbito da Disciplina de Programação Orientada a Objetos";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(241, 227);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(151, 13);
			this.label2.TabIndex = 1;
			this.label2.Text = "João Pinheiro Ferreira n 82269";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(328, 113);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(135, 20);
			this.label3.TabIndex = 2;
			this.label3.Text = "Desenvolvido Por:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(241, 192);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(145, 13);
			this.label4.TabIndex = 3;
			this.label4.Text = "Pedro Espirito Santo n 82264";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(427, 194);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(140, 13);
			this.label5.TabIndex = 4;
			this.label5.Text = "Contato: aluno82264@ipt.pt";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(427, 227);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(140, 13);
			this.label6.TabIndex = 5;
			this.label6.Text = "Contato: aluno82269@ipt.pt";
			// 
			// btnCloseAbout
			// 
			this.btnCloseAbout.Location = new System.Drawing.Point(374, 395);
			this.btnCloseAbout.Name = "btnCloseAbout";
			this.btnCloseAbout.Size = new System.Drawing.Size(75, 23);
			this.btnCloseAbout.TabIndex = 6;
			this.btnCloseAbout.Text = "OK";
			this.btnCloseAbout.UseVisualStyleBackColor = true;
			this.btnCloseAbout.Click += new System.EventHandler(this.btnCloseAbout_Click);
			// 
			// About
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.btnCloseAbout);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "About";
			this.Text = "About";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Button btnCloseAbout;
	}
}