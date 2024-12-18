namespace projectoPOO
{
    partial class AllStudents
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
            this.dgAllStudents = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgAllStudents)).BeginInit();
            this.SuspendLayout();
            // 
            // dgAllStudents
            // 
            this.dgAllStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgAllStudents.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgAllStudents.Location = new System.Drawing.Point(0, 0);
            this.dgAllStudents.Name = "dgAllStudents";
            this.dgAllStudents.Size = new System.Drawing.Size(748, 402);
            this.dgAllStudents.TabIndex = 0;
            // 
            // AllStudents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 402);
            this.Controls.Add(this.dgAllStudents);
            this.Name = "AllStudents";
            this.Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)(this.dgAllStudents)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgAllStudents;
    }
}