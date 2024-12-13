﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projectoPOO
{
    public partial class GiveScores : Form
    {
        public GiveScores()
        {
            InitializeComponent();
        }

        private void btnSearchStudentScore_Click(object sender, EventArgs e)
        {
            int number = Int32.Parse(txtSearchStudentScore.Text);

            List<Student> student = Students.GetStudents(number);

            if (student.Count > 0)
            {
                lblStudentName.Text = student[0].Name + " " + student[0].LastName;

                List<Enroll> subjects = Enrollment.GetStudentSubjects(number);

                // Verificar se a lista tem dados
                if (subjects.Count == 0)
                {
                    MessageBox.Show("Nenhuma disciplina encontrada para este aluno.");
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

            foreach (var i in score)
            {
                cbScore.Items.Add((int)i);
            }
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
            MessageBox.Show("Nota inserida com sucesso");

            if (giveScore.Score == null || (Int32.Parse(giveScore.Score) < 10))
            {
                Enroll enrollExam = new Enroll();

                enrollExam.StudentNumber = txtSearchStudentScore.Text;
                enrollExam.Subject = cbSubject.SelectedItem.ToString();

                Enrollment.EnrollStudentN(enrollExam);
            }
        }

        private void cbAttendance_CheckedChanged(object sender, EventArgs e)
        {
            cbScore.Enabled = !cbAttendance.Checked;
        }
    }
}

