namespace projectoPOO
{
	partial class AllSubjects
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
			this.dgAllSubjects = new System.Windows.Forms.DataGridView();
			((System.ComponentModel.ISupportInitialize)(this.dgAllSubjects)).BeginInit();
			this.SuspendLayout();
			// 
			// dgAllSubjects
			// 
			this.dgAllSubjects.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgAllSubjects.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dgAllSubjects.Location = new System.Drawing.Point(0, 0);
			this.dgAllSubjects.Name = "dgAllSubjects";
			this.dgAllSubjects.Size = new System.Drawing.Size(800, 450);
			this.dgAllSubjects.TabIndex = 0;
			// 
			// AllSubjects
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.dgAllSubjects);
			this.Name = "AllSubjects";
			this.Text = "AllSubjects";
			((System.ComponentModel.ISupportInitialize)(this.dgAllSubjects)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView dgAllSubjects;
	}
}