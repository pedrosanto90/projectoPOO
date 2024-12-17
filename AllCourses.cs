using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace projectoPOO
{
	public partial class AllCourses : Form
	{
		public AllCourses()
		{
			InitializeComponent();
			LoadAllCourses();
		}
		private void LoadAllCourses()
		{
			try
			{
				// Obter a lista de todos os alunos
				List<Course> courses = Courses.GetAllCourses();


				// Configure o ListView
				lvCourses.View = View.Details; // Exibição em detalhes com colunas
				lvCourses.FullRowSelect = true; // Permite selecionar a linha inteira
				lvCourses.GridLines = true; // Mostra linhas entre os itens

				// Adiciona as colunas
				lvCourses.Columns.Add("Número");
				lvCourses.Columns.Add("Curso");
				lvCourses.Columns.Add("Nome");
				lvCourses.Columns.Add("Apelido");

				// Adiciona os dados dos alunos ao ListView
				foreach (var course in courses)
				{
					ListViewItem item = new ListViewItem(course.Ref);
					item.SubItems.Add(course.Name);
					item.SubItems.Add(course.Acronym);
					item.SubItems.Add(course.StartDate);

					lvCourses.Items.Add(item);
				}

				// Ajusta automaticamente a largura das colunas para caber o conteúdo
				foreach (ColumnHeader column in lvCourses.Columns)
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
