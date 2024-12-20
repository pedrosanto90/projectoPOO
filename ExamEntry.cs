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
    public partial class ExamEntry : Form
    {
        public ExamEntry()
        {
            InitializeComponent();

            btnAppealExam.Visible = false;
            btnSpecialExam.Visible = false;

        }

        private void PopCB()
        {
            int number = Int32.Parse(txtSearchStudentExam.Text);

            List<Student> student = Students.GetStudents(number);

            if (student.Count > 0)
            {

                lblStudentNameExam.Text = ($"Nome do Aluno: {student[0].Name} {student[0].LastName}");

                List<Enroll> subjects = Enrollment.GetSubjectsExam(number);
                List<Enroll> subjectsAppeal = Enrollment.GetSubjectsAppealExam(number);

                // Verificar se a lista tem dados
                if (subjects.Count == 0 && subjectsAppeal.Count == 0)
                {
                    MessageBox.Show("Este Aluno já está aprovado em todas as UCs.");
                }
                else
                {
                    // Limpar itens existentes no ComboBox
                    cbSubjectExam.Items.Clear();
                    cbAppealSubjectExam.Items.Clear();

                    // Adicionar as disciplinas ao ComboBox
                    foreach (var enroll in subjects)
                    {
                        // Verificar se enroll.Subject não está vazio ou nulo
                        if (!string.IsNullOrEmpty(enroll.Subject))
                        {
                            cbSubjectExam.Items.Add(enroll.Subject);
                        }
                        else
                        {
                            MessageBox.Show("Disciplina com nome vazio encontrada.");
                        }
                    }

                    // Adicionar as disciplinas ao ComboBox
                    foreach (var enroll in subjectsAppeal)
                    {
                        // Verificar se enroll.Subject não está vazio ou nulo
                        if (!string.IsNullOrEmpty(enroll.Subject))
                        {
                            cbAppealSubjectExam.Items.Add(enroll.Subject);
                        }
                        else
                        {
                            MessageBox.Show("Disciplina com nome vazio encontrada.");
                        }
                    }
                }
            }
        }

        private void btnSearchStudentExamEntry_Click(object sender, EventArgs e)
        {
            PopCB();
        }

        private void btnCancelExam_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAppealExam_Click(object sender, EventArgs e)
        {
            int number = Int32.Parse(txtSearchStudentExam.Text);
            Enroll AppealEnroll = new Enroll();
            //AppealEnroll.Subject = ;
            //Enrollment.AppealExamEntry(AppealEnroll, number);
        }

        private void btnSpecialExam_Click(object sender, EventArgs e)
        {
            int number = Int32.Parse(txtSearchStudentExam.Text);
            Enroll SpeciallEnroll = new Enroll();
            //SpeciallEnroll.Subject = ;
            //Enrollment.AppealExamEntry(SpeciallEnroll, number);
        }

        private void cbSubjectExam_SelectedIndexChanged(object sender, EventArgs e)
        {
            int number = Int32.Parse(txtSearchStudentExam.Text);
            string idSubject = cbSubjectExam.Text;

            btnAppealExam.Visible = true;
        }

        private void cbAppealSubjectExam_SelectedIndexChanged(object sender, EventArgs e)
        {
            int number = Int32.Parse(txtSearchStudentExam.Text);
            string idSubject = cbAppealSubjectExam.Text;

            btnSpecialExam.Visible = true;
        }
    }
}
