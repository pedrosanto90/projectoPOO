namespace projectoPOO
{
	partial class AllCourses
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
            this.dgAllCourses = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgAllCourses)).BeginInit();
            this.SuspendLayout();
            // 
            // dgAllCourses
            // 
            this.dgAllCourses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgAllCourses.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgAllCourses.Location = new System.Drawing.Point(0, 0);
            this.dgAllCourses.Name = "dgAllCourses";
            this.dgAllCourses.Size = new System.Drawing.Size(800, 450);
            this.dgAllCourses.TabIndex = 0;
            // 
            // AllCourses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgAllCourses);
            this.Name = "AllCourses";
            this.Text = "AllCourses";
            ((System.ComponentModel.ISupportInitialize)(this.dgAllCourses)).EndInit();
            this.ResumeLayout(false);

		}

        #endregion

        private System.Windows.Forms.DataGridView dgAllCourses;
    }
}