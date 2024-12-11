using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace projectoPOO
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
            LoadAllTeachers();
        }

        private void LoadAllTeachers()
        {
            try
            {
                // Obter a lista de todos os docentes
                List<Teacher> teachers = Teachers.GetAllTeachers();

                // Configure o ListView
                lvTeachers.View = View.Details; // Exibição em detalhes com colunas
                lvTeachers.FullRowSelect = true; // Permite selecionar a linha inteira
                lvTeachers.GridLines = true; // Mostra linhas entre os itens

                // Adiciona as colunas
                lvTeachers.Columns.Add("Número");
                lvTeachers.Columns.Add("Nome");
                lvTeachers.Columns.Add("Apelido");
                lvTeachers.Columns.Add("Data de Nascimento");
                lvTeachers.Columns.Add("E-mail");
                lvTeachers.Columns.Add("Telefone");
                lvTeachers.Columns.Add("Extensão");
                lvTeachers.Columns.Add("Salário");

                // Adiciona os dados dos docentes ao ListView
                foreach (var teacher in teachers)
                {
                    ListViewItem item = new ListViewItem(teacher.Number);
                    item.SubItems.Add(teacher.Name);
                    item.SubItems.Add(teacher.LastName);
                    item.SubItems.Add(teacher.Birthday);
                    item.SubItems.Add(teacher.Email);
                    item.SubItems.Add(teacher.Phone);
                    item.SubItems.Add(teacher.Extension);
                    item.SubItems.Add(teacher.Salary);

                    lvTeachers.Items.Add(item);
                }

                // Ajusta automaticamente a largura das colunas para caber o conteúdo
                foreach (ColumnHeader column in lvTeachers.Columns)
                {
                    column.Width = -2; // Ajuste automático para o conteúdo
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao carregar docentes: {ex.Message}", "Erro");
            }
        }
    }
}
