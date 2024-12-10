using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace projectoPOO
{
	public partial class Form1 : Form
	{
		string connection;

		public Form1()
		{
			InitializeComponent();

			// Create a MenuStrip control with a new window.
			MenuStrip ms = new MenuStrip();
			ToolStripMenuItem windowMenu = new ToolStripMenuItem("Aluno");
			ToolStripMenuItem windowMenuTeacher = new ToolStripMenuItem("Docentes");
			ToolStripMenuItem newStudent = new ToolStripMenuItem("Novo Aluno", null, new EventHandler(newStudent_Click));
            ToolStripMenuItem updateStudent = new ToolStripMenuItem("Actualizar Aluno", null, new EventHandler(updateStudent_Click));
            //	ToolStripMenuItem newTeacher = new ToolStripMenuItem("Novo Professor", null, new EventHandler(windowNewMenu_Click));
            //	ToolStripMenuItem newCourse = new ToolStripMenuItem("Novo Curso", null, new EventHandler(windowNewMenu_Click));
            //	ToolStripMenuItem newSubject = new ToolStripMenuItem("Nova Unidade Curricular", null, new EventHandler(windowNewMenu_Click));

            windowMenu.DropDownItems.Add(newStudent);
			windowMenu.DropDownItems.Add(updateStudent);
			//	windowMenu.DropDownItems.Add(newCourse);
			//	windowMenu.DropDownItems.Add(newSubject);
			((ToolStripDropDownMenu)(windowMenu.DropDown)).ShowImageMargin = false;
			((ToolStripDropDownMenu)(windowMenu.DropDown)).ShowCheckMargin = true;

			// Assign the ToolStripMenuItem that displays 
			// the list of child forms.
			ms.MdiWindowListItem = windowMenu;
			ms.MdiWindowListItem = windowMenuTeacher;

			// Add the window ToolStripMenuItem to the MenuStrip.
			ms.Items.Add(windowMenu);
			ms.Items.Add(windowMenuTeacher);

			// Dock the MenuStrip to the top of the form.
			ms.Dock = DockStyle.Top;

			// The Form.MainMenuStrip property determines the merge target.
			this.MainMenuStrip = ms;

			// Add the MenuStrip last.
			// This is important for correct placement in the z-order.
			this.Controls.Add(ms);

			Sql.SqlConn();
			connection = Sql.SqlConn();
			lbl_conn.Text = connection.ToString();

			txtStudentNumber.ReadOnly = true;
			txtStudentCourse.ReadOnly = true;
			txtStudentName.ReadOnly = true;
			txtStudentLastName.ReadOnly = true;
			txtStudentBirthdate.ReadOnly = true;
			txtStudentAddress.ReadOnly = true;
			txtStudentEmail.ReadOnly = true;
			txtStudentPhone.ReadOnly = true;
			btnUpdateStudent.Visible = false;
            btnCancelUpdate.Visible = false;

		}

		private void btnSearchStudent_Click(object sender, System.EventArgs e)
		{
			int number = Int32.Parse(txtSearchStudent.Text);
			List<Student> student = Students.GetStudents(number);

			if (student.Count > 0)
			{
				txtStudentNumber.Text = student[0].Number;
				txtStudentCourse.Text = student[0].CourseRef;
				txtStudentName.Text = student[0].Name;
				txtStudentLastName.Text = student[0].LastName;
				txtStudentBirthdate.Text = student[0].Birthday;
				txtStudentAddress.Text = student[0].Address;
				txtStudentEmail.Text = student[0].Email;
				txtStudentPhone.Text = student[0].Phone;
			}
			else
			{
				MessageBox.Show($"Nenhum aluno encontrado com o número {number}", "Info");
			}
		}
		void newStudent_Click(object sender, EventArgs e)
		{
			Form2 f = new Form2();
			f.Text = "Novo Aluno" + this.MdiChildren.Length.ToString();
			f.Show();
		}

        void updateStudent_Click(object sender, EventArgs e)
        {
            txtStudentCourse.ReadOnly = false;
            txtStudentName.ReadOnly = false;
            txtStudentLastName.ReadOnly = false;
            txtStudentBirthdate.ReadOnly = false;
            txtStudentAddress.ReadOnly = false;
            txtStudentPhone.ReadOnly = false;
			btnUpdateStudent.Visible = true;
            btnCancelUpdate.Visible = true;
        }

        private void btnUpdateStudent_Click(object sender, EventArgs e)
        {
            try
            {
                // Criar um objeto aluno com os dados atualizados
                Student updatedStudent = new Student
                {
                    Number = txtStudentNumber.Text,  // Número do aluno (não pode ser alterado)
                    CourseRef = txtStudentCourse.Text,
                    Name = txtStudentName.Text,
                    LastName = txtStudentLastName.Text,
                    Birthday = txtStudentBirthdate.Text,
                    Address = txtStudentAddress.Text,
                    Phone = txtStudentPhone.Text
                };

                // Atualizar aluno no banco
                bool success = Students.UpdateStudent(updatedStudent);

                if (success)
                {
                    MessageBox.Show("Aluno atualizado com sucesso!", "Sucesso");
                }
                else
                {
                    MessageBox.Show("Erro ao atualizar o aluno. Verifique os dados e tente novamente.", "Erro");
                }

                // Voltar os campos para somente leitura após atualização
                txtStudentCourse.ReadOnly = true;
                txtStudentName.ReadOnly = true;
                txtStudentLastName.ReadOnly = true;
                txtStudentBirthdate.ReadOnly = true;
                txtStudentAddress.ReadOnly = true;
                txtStudentPhone.ReadOnly = true;

                // Ocultar botão de atualização
                btnUpdateStudent.Visible = false;
                btnCancelUpdate.Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro: {ex.Message}", "Erro");
            }
        }
        private void btnCancelUpdate_Click(object sender, EventArgs e)
        {
            txtStudentNumber.ReadOnly = true;
            txtStudentCourse.ReadOnly = true;
            txtStudentName.ReadOnly = true;
            txtStudentLastName.ReadOnly = true;
            txtStudentBirthdate.ReadOnly = true;
            txtStudentAddress.ReadOnly = true;
            txtStudentEmail.ReadOnly = true;
            txtStudentPhone.ReadOnly = true;
            btnUpdateStudent.Visible = false;
            btnCancelUpdate.Visible = false;
        }

        private void btnSearchTeacher_Click(object sender, EventArgs e)
        {
            int number = Int32.Parse(txtSearchTeacher.Text);
            List<Teacher> teacher = Teachers.GetTeachers(number);

            if (teacher.Count > 0)
            {
                txtTeacherNumber.Text = teacher[0].Number;
                txtTeacherExtension.Text = teacher[0].Extension;
                txtTeacherName.Text = teacher[0].Name;
                txtTeacherLastName.Text = teacher[0].LastName;
                txtTeacherBirthdate.Text = teacher[0].Birthday;
                txtTeacherSalary.Text = teacher[0].Salary;
                txtTeacherEmail.Text = teacher[0].Email;
                txtTeacherPhone.Text = teacher[0].Phone;
            }
            else
            {
                MessageBox.Show($"Nenhum docente encontrado com o número {number}", "Info");
            }
        }
    }
}




