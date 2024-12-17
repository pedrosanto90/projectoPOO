using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace projectoPOO
{
    public partial class AllStudents : Form
    {
        public AllStudents()
        {
            InitializeComponent();
            LoadAllStudents();
        }

        private void LoadAllStudents()
        {
            try
            {
                // Obter a lista de todos os alunos
                List<Student> students = Students.GetAllStudents();

                // Configure o ListView
                lvStudents.View = View.Details; // Exibição em detalhes com colunas
                lvStudents.FullRowSelect = true; // Permite selecionar a linha inteira
                lvStudents.GridLines = true; // Mostra linhas entre os itens

                // Adiciona as colunas
                lvStudents.Columns.Add("Número");
                lvStudents.Columns.Add("Curso");
                lvStudents.Columns.Add("Nome");
                lvStudents.Columns.Add("Apelido");
                lvStudents.Columns.Add("Data de Nascimento");
                lvStudents.Columns.Add("Morada");
                lvStudents.Columns.Add("E-mail");
                lvStudents.Columns.Add("Telefone");

                // Adiciona os dados dos alunos ao ListView
                foreach (var student in students)
                {
                    ListViewItem item = new ListViewItem(student.Number);
                    item.SubItems.Add(student.Course);
                    item.SubItems.Add(student.Name);
                    item.SubItems.Add(student.LastName);
                    item.SubItems.Add(student.Birthday);
                    item.SubItems.Add(student.Address);
                    item.SubItems.Add(student.Email);
                    item.SubItems.Add(student.Phone);

                    lvStudents.Items.Add(item);
                }

                // Ajusta automaticamente a largura das colunas para caber o conteúdo
                foreach (ColumnHeader column in lvStudents.Columns)
                {
                    column.Width = -2; // Ajuste automático para o conteúdo
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao carregar alunos: {ex.Message}", "Erro");
            }
        }
    }
}
