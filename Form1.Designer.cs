namespace projectoPOO
{
	partial class Form1
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
			this.studentSearch = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.lbl_conn = new System.Windows.Forms.Label();
			this.lb_students_list = new System.Windows.Forms.ListBox();
			this.btn_get_students = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// studentSearch
			// 
			this.studentSearch.Location = new System.Drawing.Point(68, 63);
			this.studentSearch.Name = "studentSearch";
			this.studentSearch.Size = new System.Drawing.Size(100, 20);
			this.studentSearch.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(75, 36);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(83, 13);
			this.label1.TabIndex = 1;
			this.label1.Text = "Pesquisar Aluno";
			// 
			// lbl_conn
			// 
			this.lbl_conn.AutoSize = true;
			this.lbl_conn.Location = new System.Drawing.Point(179, 165);
			this.lbl_conn.Name = "lbl_conn";
			this.lbl_conn.Size = new System.Drawing.Size(35, 13);
			this.lbl_conn.TabIndex = 2;
			this.lbl_conn.Text = "label2";
			// 
			// lb_students_list
			// 
			this.lb_students_list.FormattingEnabled = true;
			this.lb_students_list.Location = new System.Drawing.Point(379, 83);
			this.lb_students_list.Name = "lb_students_list";
			this.lb_students_list.Size = new System.Drawing.Size(409, 134);
			this.lb_students_list.TabIndex = 3;
			// 
			// btn_get_students
			// 
			this.btn_get_students.Location = new System.Drawing.Point(390, 240);
			this.btn_get_students.Name = "btn_get_students";
			this.btn_get_students.Size = new System.Drawing.Size(75, 23);
			this.btn_get_students.TabIndex = 4;
			this.btn_get_students.Text = "Alunos";
			this.btn_get_students.UseVisualStyleBackColor = true;
			this.btn_get_students.Click += new System.EventHandler(this.btn_get_students_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.btn_get_students);
			this.Controls.Add(this.lb_students_list);
			this.Controls.Add(this.lbl_conn);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.studentSearch);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox studentSearch;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label lbl_conn;
		private System.Windows.Forms.ListBox lb_students_list;
		private System.Windows.Forms.Button btn_get_students;
	}
}

