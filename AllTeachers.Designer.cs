namespace projectoPOO
{
    partial class AllTeachers
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
            this.dgAllTeachers = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgAllTeachers)).BeginInit();
            this.SuspendLayout();
            // 
            // dgAllTeachers
            // 
            this.dgAllTeachers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgAllTeachers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgAllTeachers.Location = new System.Drawing.Point(0, 0);
            this.dgAllTeachers.Name = "dgAllTeachers";
            this.dgAllTeachers.Size = new System.Drawing.Size(739, 391);
            this.dgAllTeachers.TabIndex = 0;
            // 
            // AllTeachers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(739, 391);
            this.Controls.Add(this.dgAllTeachers);
            this.Name = "AllTeachers";
            this.Text = "Form5";
            ((System.ComponentModel.ISupportInitialize)(this.dgAllTeachers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgAllTeachers;
    }
}