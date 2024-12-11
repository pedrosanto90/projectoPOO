namespace projectoPOO
{
    partial class Form3
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
            this.lvStudents = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // lvStudents
            // 
            this.lvStudents.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvStudents.HideSelection = false;
            this.lvStudents.Location = new System.Drawing.Point(0, 0);
            this.lvStudents.Name = "lvStudents";
            this.lvStudents.Size = new System.Drawing.Size(748, 402);
            this.lvStudents.TabIndex = 0;
            this.lvStudents.UseCompatibleStateImageBehavior = false;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 402);
            this.Controls.Add(this.lvStudents);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvStudents;
    }
}