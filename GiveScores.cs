using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace projectoPOO
{
	public partial class GiveScores : Form
	{
		public GiveScores()
		{
			InitializeComponent();
		}

		private void PopCB()
		{
			int number = Int32.Parse(txtSearchStudentScore.Text);

			List<Student> student = Students.GetStudents(number);

			if (student.Count > 0)
			{

				lblStudentName.Text = ($"Nome do Aluno: {student[0].Name} {student[0].LastName}");

				List<Enroll> subjects = Enrollment.GetStudentSubjects(number);

				// Verificar se a lista tem dados
				if (subjects.Count == 0)
				{
					MessageBox.Show("Este Aluno não tem notas em falta.");
				}
				else
				{
					// Limpar itens existentes no ComboBox
					cbSubject.Items.Clear();

					// Adicionar as disciplinas ao ComboBox
					foreach (var enroll in subjects)
					{
						// Verificar se enroll.Subject não está vazio ou nulo
						if (!string.IsNullOrEmpty(enroll.Subject))
						{
							cbSubject.Items.Add(enroll.Subject);
						}
						else
						{
							MessageBox.Show("Disciplina com nome vazio encontrada.");
						}
					}
				}
			}

			cbScore.Items.Clear();

			int[] score = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };

			foreach (int i in score)
			{
				cbScore.Items.Add(i);
			}
		}
		private void btnSearchStudentScore_Click(object sender, EventArgs e)
		{
			PopCB();
		}

		private void btnCancelScoreAttribution_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void btnScoreAttribution_Click(object sender, EventArgs e)
		{
			Enroll giveScore = new Enroll();

			giveScore.StudentNumber = txtSearchStudentScore.Text;
			giveScore.Subject = cbSubject.SelectedItem.ToString();
			giveScore.EvaluationSeason = lblSeason.Text;

			if (cbAttendance.Checked)
			{
				giveScore.Attendance = "F";
				giveScore.Score = null;
			}
			else
			{
				giveScore.Attendance = "P";
				giveScore.Score = cbScore.SelectedItem.ToString();
			}
			Enrollment.SubjectScores(giveScore);
			if (lblSeason.Text == "Época Normal de Exame")
			{
				MessageBox.Show("Nota inserida com sucesso");

                cbScore.SelectedIndex = -1;
                cbSubject.SelectedIndex = -1;
				cbAttendance.Checked = false;
				PopCB();
            }
			else
			{
				MessageBox.Show("Nota inserida com sucesso");



				if (giveScore.Score == null || Int32.Parse(giveScore.Score) < 10)
				{
					Enroll enrollExam = new Enroll();

					enrollExam.StudentNumber = txtSearchStudentScore.Text;
					enrollExam.Subject = cbSubject.SelectedItem.ToString();
					enrollExam.EvaluationSeason = "ENEX";

					Enrollment.EnrollStudentN(enrollExam);
					MessageBox.Show("Aluno inscrito na Época Normal de Exame");

				}

				cbScore.SelectedIndex = -1;
                cbSubject.SelectedIndex = -1;
                cbAttendance.Checked = false;
                PopCB();
            }

		}

		private void cbAttendance_CheckedChanged(object sender, EventArgs e)
		{
			cbScore.Enabled = !cbAttendance.Checked;
		}

		private void cbSubject_SelectedIndexChanged(object sender, EventArgs e)
		{
			int number = Int32.Parse(txtSearchStudentScore.Text);
			string idSubject = cbSubject.Text;
			string subjects = Enrollment.GetSeason(number, idSubject);
			lblSeason.Text = ($"{subjects}");
		}
	}
}

