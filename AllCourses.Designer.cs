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
			this.lvCourses = new System.Windows.Forms.ListView();
			this.SuspendLayout();
			// 
			// lvCourses
			// 
			this.lvCourses.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lvCourses.HideSelection = false;
			this.lvCourses.Location = new System.Drawing.Point(0, 0);
			this.lvCourses.Name = "lvCourses";
			this.lvCourses.Size = new System.Drawing.Size(800, 450);
			this.lvCourses.TabIndex = 0;
			this.lvCourses.UseCompatibleStateImageBehavior = false;
			// 
			// AllCourses
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.lvCourses);
			this.Name = "AllCourses";
			this.Text = "AllCourses";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.ListView lvCourses;
	}
}