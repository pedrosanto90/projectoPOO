namespace projectoPOO
{
	partial class NewYear
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
			this.btnCancelYear = new System.Windows.Forms.Button();
			this.txtStartYear = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txtEndYear = new System.Windows.Forms.TextBox();
			this.btnAddYear = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(149, 91);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(56, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Ano Inicial";
			// 
			// btnCancelYear
			// 
			this.btnCancelYear.Location = new System.Drawing.Point(337, 231);
			this.btnCancelYear.Name = "btnCancelYear";
			this.btnCancelYear.Size = new System.Drawing.Size(75, 23);
			this.btnCancelYear.TabIndex = 1;
			this.btnCancelYear.Text = "Cancelar";
			this.btnCancelYear.UseVisualStyleBackColor = true;
			this.btnCancelYear.Click += new System.EventHandler(this.btnCancelYear_Click);
			// 
			// txtStartYear
			// 
			this.txtStartYear.Location = new System.Drawing.Point(152, 107);
			this.txtStartYear.Name = "txtStartYear";
			this.txtStartYear.Size = new System.Drawing.Size(100, 20);
			this.txtStartYear.TabIndex = 2;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(309, 91);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(51, 13);
			this.label2.TabIndex = 3;
			this.label2.Text = "Ano Final";
			// 
			// txtEndYear
			// 
			this.txtEndYear.Location = new System.Drawing.Point(312, 107);
			this.txtEndYear.Name = "txtEndYear";
			this.txtEndYear.Size = new System.Drawing.Size(100, 20);
			this.txtEndYear.TabIndex = 4;
			// 
			// btnAddYear
			// 
			this.btnAddYear.Location = new System.Drawing.Point(461, 231);
			this.btnAddYear.Name = "btnAddYear";
			this.btnAddYear.Size = new System.Drawing.Size(75, 23);
			this.btnAddYear.TabIndex = 5;
			this.btnAddYear.Text = "Adcionar";
			this.btnAddYear.UseVisualStyleBackColor = true;
			this.btnAddYear.Click += new System.EventHandler(this.btnAddYear_Click);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(232, 34);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(105, 13);
			this.label3.TabIndex = 6;
			this.label3.Text = "Adicinar Ano Lectivo";
			// 
			// NewYear
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(568, 279);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.btnAddYear);
			this.Controls.Add(this.txtEndYear);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txtStartYear);
			this.Controls.Add(this.btnCancelYear);
			this.Controls.Add(this.label1);
			this.Name = "NewYear";
			this.Text = "NewYear";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnCancelYear;
		private System.Windows.Forms.TextBox txtStartYear;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtEndYear;
		private System.Windows.Forms.Button btnAddYear;
		private System.Windows.Forms.Label label3;
	}
}