﻿using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace projectoPOO
{
	public partial class MainScreen : Form
	{
		string connection;

		public MainScreen()
		{
			InitializeComponent();

			// Create a MenuStrip control with a new window.
			MenuStrip ms = new MenuStrip();
			ToolStripMenuItem windowMenu = new ToolStripMenuItem("Aluno");
			ToolStripMenuItem windowMenuTeacher = new ToolStripMenuItem("Docentes");
			ToolStripMenuItem windowMenuCourse = new ToolStripMenuItem("Cursos");
			ToolStripMenuItem windowMenuSubject = new ToolStripMenuItem("Unidade Curricular");
			ToolStripMenuItem newStudent = new ToolStripMenuItem("Novo Aluno", null, new EventHandler(newStudent_Click));
			ToolStripMenuItem updateStudent = new ToolStripMenuItem("Actualizar Aluno", null, new EventHandler(updateStudent_Click));
			ToolStripMenuItem showAllStudents = new ToolStripMenuItem("Mostrar todos os Alunos", null, new EventHandler(showAllStudents_Click));
			ToolStripMenuItem newTeacher = new ToolStripMenuItem("Novo Docente", null, new EventHandler(newTeacher_Click));
			ToolStripMenuItem updateTeacher = new ToolStripMenuItem("Actualizar Docente", null, new EventHandler(updateTeacher_Click));
			ToolStripMenuItem showAllTeachers = new ToolStripMenuItem("Mostrar todos os Docentes", null, new EventHandler(showAllTeachers_Click));
			ToolStripMenuItem newCourse = new ToolStripMenuItem("Novo Curso", null, new EventHandler(newCourse_Click));
			ToolStripMenuItem updateCourse = new ToolStripMenuItem("Atualizar Curso", null, new EventHandler(updateCourse_Click));
			ToolStripMenuItem showAllCourses = new ToolStripMenuItem("Mostrar todos os Cursos", null, new EventHandler(showAllCourses_Click));
			//	ToolStripMenuItem newSubject = new ToolStripMenuItem("Nova Unidade Curricular", null, new EventHandler(windowNewMenu_Click));

			windowMenu.DropDownItems.Add(newStudent);
			windowMenu.DropDownItems.Add(updateStudent);
			windowMenu.DropDownItems.Add(showAllStudents);
			windowMenuTeacher.DropDownItems.Add(newTeacher);
			windowMenuTeacher.DropDownItems.Add(updateTeacher);
			windowMenuTeacher.DropDownItems.Add(showAllTeachers);
			windowMenuCourse.DropDownItems.Add(newCourse);
			windowMenuCourse.DropDownItems.Add(updateCourse);
			windowMenuCourse.DropDownItems.Add(showAllCourses);

			((ToolStripDropDownMenu)(windowMenu.DropDown)).ShowImageMargin = false;
			((ToolStripDropDownMenu)(windowMenu.DropDown)).ShowCheckMargin = true;

			// Assign the ToolStripMenuItem that displays 
			// the list of child forms.
			ms.MdiWindowListItem = windowMenu;
			ms.MdiWindowListItem = windowMenuTeacher;
			ms.MdiWindowListItem = windowMenuCourse;
			ms.MdiWindowListItem = windowMenuSubject;

			// Add the window ToolStripMenuItem to the MenuStrip.
			ms.Items.Add(windowMenu);
			ms.Items.Add(windowMenuTeacher);
			ms.Items.Add(windowMenuCourse);
			ms.Items.Add(windowMenuSubject);

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
			btnCancelUpdateStudent.Visible = false;

			btnDeleteStudent.Visible = false;

			btnDeleteTeacher.Visible = false;

			txtTeacherNumber.ReadOnly = true;
			txtTeacherExtension.ReadOnly = true;
			txtTeacherName.ReadOnly = true;
			txtTeacherLastName.ReadOnly = true;
			txtTeacherBirthdate.ReadOnly = true;
			txtTeacherSalary.ReadOnly = true;
			txtTeacherEmail.ReadOnly = true;
			txtTeacherPhone.ReadOnly = true;

			btnUpdateTeacher.Visible = false;
			btnCancelUpdateTeacher.Visible = false;



			txtCourseRef.ReadOnly = true;
			txtCourseName.ReadOnly = true;
			txtCourseAcronym.ReadOnly = true;
			txtCourseStartDate.ReadOnly = true;

			btnUpdateCourse.Visible = false;
			btnCancelUpdateCourse.Visible = false;
			btnDeleteCourse.Visible = false;

		}

		private void btnSearchStudent_Click(object sender, System.EventArgs e)
		{
			int number = Int32.Parse(txtSearchStudent.Text);
			List<Student> student = Students.GetStudents(number);

			if (student.Count > 0)
			{
				txtStudentNumber.Text = student[0].Number;
				txtStudentCourse.Text = student[0].Course;
				txtStudentName.Text = student[0].Name;
				txtStudentLastName.Text = student[0].LastName;
				txtStudentBirthdate.Text = student[0].Birthday;
				txtStudentAddress.Text = student[0].Address;
				txtStudentEmail.Text = student[0].Email;
				txtStudentPhone.Text = student[0].Phone;

				btnDeleteStudent.Visible = true;
			}
			else
			{
				MessageBox.Show($"Nenhum aluno encontrado com o número {number}", "Info");
			}
		}
		void newStudent_Click(object sender, EventArgs e)
		{
			NewStudent f = new NewStudent();
			f.Text = "Novo Aluno";
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
			btnCancelUpdateStudent.Visible = true;
		}

		private void btnUpdateStudent_Click(object sender, EventArgs e)
		{
			try
			{
				// Criar um objeto aluno com os dados atualizados
				Student updatedStudent = new Student
				{
					Number = txtStudentNumber.Text,  // Número do aluno (não pode ser alterado)
					Course = txtStudentCourse.Text,
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
				btnCancelUpdateStudent.Visible = false;
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Erro: {ex.Message}", "Erro");
			}
		}
		private void btnCancelUpdateStudent_Click(object sender, EventArgs e)
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
			btnCancelUpdateStudent.Visible = false;
		}

		void showAllStudents_Click(object sender, EventArgs e)
		{
			AllStudents f = new AllStudents();
			f.Text = "Todos os Alunos";
			f.Show();
		}
		private List<Teacher> teacherInfo()
		{
			int number = Int32.Parse(txtSearchTeacher.Text);
			List<Teacher> teacher = Teachers.GetTeachers(number);

			txtTeacherNumber.Text = teacher[0].Number;
			txtTeacherExtension.Text = teacher[0].Extension;
			txtTeacherName.Text = teacher[0].Name;
			txtTeacherLastName.Text = teacher[0].LastName;
			txtTeacherBirthdate.Text = teacher[0].Birthday;
			txtTeacherSalary.Text = teacher[0].Salary;
			txtTeacherEmail.Text = teacher[0].Email;
			txtTeacherPhone.Text = teacher[0].Phone;

			return teacher;

		}

		private void btnSearchTeacher_Click(object sender, EventArgs e)
		{
			try
			{

				List<Teacher> teacher = teacherInfo();
				if (teacher.Count > 0)
				{
					teacherInfo();
					btnDeleteTeacher.Visible = true;
				}
			}
			catch
			{
				MessageBox.Show($"Nenhum docente encontrado", "Info");
			}
		}

		void newTeacher_Click(object sender, EventArgs e)
		{
			NewTeacher f = new NewTeacher();
			f.Text = "Novo Docente";
			f.Show();
		}

		void updateTeacher_Click(object sender, EventArgs e)
		{
			txtTeacherExtension.ReadOnly = false;
			txtTeacherName.ReadOnly = false;
			txtTeacherLastName.ReadOnly = false;
			txtTeacherBirthdate.ReadOnly = false;
			txtTeacherSalary.ReadOnly = false;
			txtTeacherPhone.ReadOnly = false;
			btnUpdateTeacher.Visible = true;
			btnCancelUpdateTeacher.Visible = true;
		}

		private void btnUpdateTeacher_Click(object sender, EventArgs e)
		{
			try
			{
				// Criar um objeto docente com os dados atualizados
				Teacher updatedTeacher = new Teacher
				{
					Number = txtTeacherNumber.Text,  // Número do docente (não pode ser alterado)
					Extension = txtTeacherExtension.Text,
					Name = txtTeacherName.Text,
					LastName = txtTeacherLastName.Text,
					Birthday = txtTeacherBirthdate.Text,
					Salary = txtTeacherSalary.Text,
					Phone = txtTeacherPhone.Text
				};

				// Atualizar docente no banco
				bool success = Teachers.UpdateTeacher(updatedTeacher);

				if (success)
				{
					MessageBox.Show("Docente atualizado com sucesso!", "Sucesso");
					teacherInfo();
				}
				else
				{
					MessageBox.Show("Erro ao atualizar o docente. Verifique os dados e tente novamente.", "Erro");
				}

				// Voltar os campos para somente leitura após atualização
				txtTeacherExtension.ReadOnly = true;
				txtTeacherName.ReadOnly = true;
				txtTeacherLastName.ReadOnly = true;
				txtTeacherBirthdate.ReadOnly = true;
				txtTeacherSalary.ReadOnly = true;
				txtTeacherPhone.ReadOnly = true;

				// Ocultar botão de atualização
				btnUpdateTeacher.Visible = false;
				btnCancelUpdateTeacher.Visible = false;
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Erro: {ex.Message}", "Erro");
			}
		}

		private void btnCancelUpdateTeacher_Click(object sender, EventArgs e)
		{
			txtTeacherNumber.ReadOnly = true;
			txtTeacherExtension.ReadOnly = true;
			txtTeacherName.ReadOnly = true;
			txtTeacherLastName.ReadOnly = true;
			txtTeacherBirthdate.ReadOnly = true;
			txtTeacherSalary.ReadOnly = true;
			txtTeacherEmail.ReadOnly = true;
			txtTeacherPhone.ReadOnly = true;
			btnUpdateTeacher.Visible = false;
			btnCancelUpdateTeacher.Visible = false;


		}

		void showAllTeachers_Click(object sender, EventArgs e)
		{
			AllTeachers f = new AllTeachers();
			f.Text = "Todos os Docentes";
			f.Show();
		}

		private void btnDeleteStudent_Click(object sender, EventArgs e)
		{
			int number = Int32.Parse(txtStudentNumber.Text);
			var confirmResult = MessageBox.Show(
					$"Tem certeza de que deseja eliminar o aluno com número {number}?",
					"Eliminar Aluno",
					MessageBoxButtons.YesNo,
					MessageBoxIcon.Warning);

			if (confirmResult == DialogResult.Yes)
			{
				bool success = Students.DeleteStudent(number);

				if (success)
				{
					MessageBox.Show("Aluno eliminado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
					CleanBox();
				}
				else
				{
					MessageBox.Show("Erro ao excluir o aluno. Verifique se o aluno existe.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
		}
		public void CleanBox()
		{
			txtStudentNumber.Text = string.Empty;
			txtStudentName.Text = string.Empty;
			txtStudentLastName.Text = string.Empty;
			txtStudentBirthdate.Text = string.Empty;
			txtStudentAddress.Text = string.Empty;
			txtStudentPhone.Text = string.Empty;
			txtStudentEmail.Text = string.Empty;
			txtSearchStudent.Text = string.Empty;
			txtStudentCourse.Text = string.Empty;

			btnDeleteStudent.Visible = false;

			txtTeacherNumber.Text = string.Empty;
			txtTeacherName.Text = string.Empty;
			txtTeacherLastName.Text = string.Empty;
			txtTeacherBirthdate.Text = string.Empty;
			txtTeacherExtension.Text = string.Empty;
			txtTeacherPhone.Text = string.Empty;
			txtTeacherEmail.Text = string.Empty;
			txtSearchTeacher.Text = string.Empty;
			txtTeacherSalary.Text = string.Empty;

			btnDeleteTeacher.Visible = false;

			txtSearchCourse.Text = string.Empty;
			txtCourseRef.Text = string.Empty;
			txtCourseName.Text = string.Empty;
			txtCourseAcronym.Text = string.Empty;
			txtCourseStartDate.Text = string.Empty;

			btnDeleteCourse.Visible = false;
		}

		private void btnDeleteTeacher_Click(object sender, EventArgs e)
		{
			int number = Int32.Parse(txtSearchTeacher.Text);

			var confirmResult = MessageBox.Show(
				   $"Tem certeza de que deseja eliminar o docente com número {number}?",
				   "Eliminar docente",
				   MessageBoxButtons.YesNo,
				   MessageBoxIcon.Warning);

			if (confirmResult == DialogResult.Yes)
			{
				bool success = Teachers.DeleteTeacher(number);

				if (success)
				{
					MessageBox.Show("Docente eliminado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
					CleanBox();
				}
				else
				{
					MessageBox.Show("Erro ao excluir o docente. Verifique se o docente existe.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
		}

		private void btnSearchCourse_Click(object sender, EventArgs e)
		{
			int reference = Int32.Parse(txtSearchCourse.Text);
			List<Course> course = Courses.GetCourses(reference);

			if (course.Count > 0)
			{
				txtCourseRef.Text = course[0].Ref;
				txtCourseName.Text = course[0].Name;
				txtCourseAcronym.Text = course[0].Acronym;
				txtCourseStartDate.Text = course[0].StartDate;

				btnDeleteCourse.Visible = true;
			}
			else
			{
				MessageBox.Show($"Nenhum curso encontrado com a referência {reference}", "Info");
			}
		}
		void newCourse_Click(object sender, EventArgs e)
		{
			NewCourse f = new NewCourse();
			f.Text = "Novo Curso";
			f.Show();
		}
		void showAllCourses_Click(object sender, EventArgs e)
		{
			AllCourses f = new AllCourses();
			f.Text = "Todos os Cursos";
			f.Show();
		}
		void updateCourse_Click(object sender, EventArgs e)
		{
			txtCourseName.ReadOnly = false;
			txtCourseStartDate.ReadOnly = false;

			btnUpdateCourse.Visible = true;
			btnCancelUpdateCourse.Visible = true;

		}

		private List<Course> courseInfo()
		{
			int reference = Int32.Parse(txtSearchCourse.Text);
			List<Course> course = Courses.GetCourses(reference);

			txtCourseRef.Text = course[0].Ref;
			txtCourseName.Text = course[0].Name;
			txtCourseAcronym.Text = course[0].Acronym;
			txtCourseStartDate.Text = course[0].StartDate;

			return course;

		}
		private void btnUpdateCourse_Click(object sender, EventArgs e)
		{
			try
			{
				// Criar um objeto docente com os dados atualizados
				Course updatedCourse = new Course
				{
					Ref = txtCourseRef.Text,
					Name = txtCourseName.Text,
					StartDate = txtCourseStartDate.Text,
					Acronym = txtCourseAcronym.Text
				};

				// Atualizar docente no banco
				bool success = Courses.UpdateCourse(updatedCourse);

				if (success)
				{
					MessageBox.Show("Curso atualizado com sucesso!", "Sucesso");
					courseInfo();
				}
				else
				{
					MessageBox.Show("Erro ao atualizar o curso. Verifique os dados e tente novamente.", "Erro");
				}

				// Voltar os campos para somente leitura após atualização
				txtCourseName.ReadOnly = true;
				txtCourseStartDate.ReadOnly = true;

				btnUpdateCourse.Visible = false;
				btnCancelUpdateCourse.Visible = false;
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Erro: {ex.Message}", "Erro");
			}

		}

		private void btnDeleteCourse_Click(object sender, EventArgs e)
		{
			int reference = Int32.Parse(txtCourseRef.Text);
			var confirmResult = MessageBox.Show(
					$"Tem certeza de que deseja eliminar o curso?",
					"Eliminar Curso",
					MessageBoxButtons.YesNo,
					MessageBoxIcon.Warning);

			if (confirmResult == DialogResult.Yes)
			{
				bool success = Courses.DeleteCourse(reference);

				if (success)
				{
					MessageBox.Show("Curso eliminado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
					CleanBox();
				}
				else
				{
					MessageBox.Show("Erro ao excluir o curso. Verifique se o aluno existe.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}

		}
	}
}