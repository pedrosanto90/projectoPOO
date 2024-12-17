namespace projectoPOO
{
	partial class NewCourse
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
			this.txtAddNameCourse = new System.Windows.Forms.TextBox();
			this.txtAddStartDateCourse = new System.Windows.Forms.DateTimePicker();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.btnCancelNewCourse = new System.Windows.Forms.Button();
			this.btnAddCourse = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// txtAddNameCourse
			// 
			this.txtAddNameCourse.Location = new System.Drawing.Point(23, 110);
			this.txtAddNameCourse.Name = "txtAddNameCourse";
			this.txtAddNameCourse.Size = new System.Drawing.Size(207, 20);
			this.txtAddNameCourse.TabIndex = 0;
			// 
			// txtAddStartDateCourse
			// 
			this.txtAddStartDateCourse.Location = new System.Drawing.Point(260, 110);
			this.txtAddStartDateCourse.Name = "txtAddStartDateCourse";
			this.txtAddStartDateCourse.Size = new System.Drawing.Size(200, 20);
			this.txtAddStartDateCourse.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(222, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(63, 13);
			this.label1.TabIndex = 2;
			this.label1.Text = "Novo Curso";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(20, 94);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(35, 13);
			this.label2.TabIndex = 3;
			this.label2.Text = "Nome";
			// 
			// btnCancelNewCourse
			// 
			this.btnCancelNewCourse.Location = new System.Drawing.Point(328, 231);
			this.btnCancelNewCourse.Name = "btnCancelNewCourse";
			this.btnCancelNewCourse.Size = new System.Drawing.Size(75, 23);
			this.btnCancelNewCourse.TabIndex = 4;
			this.btnCancelNewCourse.Text = "Cancelar";
			this.btnCancelNewCourse.UseVisualStyleBackColor = true;
			this.btnCancelNewCourse.Click += new System.EventHandler(this.btnCancelNewCourse_Click);
			// 
			// btnAddCourse
			// 
			this.btnAddCourse.Location = new System.Drawing.Point(426, 231);
			this.btnAddCourse.Name = "btnAddCourse";
			this.btnAddCourse.Size = new System.Drawing.Size(75, 23);
			this.btnAddCourse.TabIndex = 5;
			this.btnAddCourse.Text = "Adicionar";
			this.btnAddCourse.UseVisualStyleBackColor = true;
			this.btnAddCourse.Click += new System.EventHandler(this.btnAddCourse_Click);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(257, 94);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(73, 13);
			this.label3.TabIndex = 6;
			this.label3.Text = "Data de Inicio";
			// 
			// Form6
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(525, 275);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.btnAddCourse);
			this.Controls.Add(this.btnCancelNewCourse);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtAddStartDateCourse);
			this.Controls.Add(this.txtAddNameCourse);
			this.Name = "Form6";
			this.Text = "Form6";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txtAddNameCourse;
		private System.Windows.Forms.DateTimePicker txtAddStartDateCourse;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button btnCancelNewCourse;
		private System.Windows.Forms.Button btnAddCourse;
		private System.Windows.Forms.Label label3;
	}
}