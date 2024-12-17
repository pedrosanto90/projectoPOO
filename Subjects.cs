using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

struct Subject
{
	public string Id;
	public string Course; // Join Curso
	public string Teacher; // Join Docente
	public string Name;
	public string Acronym;
	public string Credits;
	public string Year; // Join AnoLectivo 
	public string Semester;
};
namespace projectoPOO
{
	internal class Subjects
	{
		public static DataTable GetAllSubjects()
		{
			using (SqlConnection cn = new SqlConnection(Connection.Conn()))
			{
				cn.Open();

				string query = @"SELECT
									UnidadeCurricular.id AS Id,
									Curso.sigla AS Curso,
									CONCAT(Docente.NomeProprio, ' ', Docente.Apelido) AS Docente,
									UnidadeCurricular.nome AS Nome,
									UnidadeCurricular.sigla AS UC,
									creditos AS Créditos,
									ano AS Ano,
									semestre AS Semestre
								FROM UnidadeCurricular
								JOIN Curso ON Curso.referencia = UnidadeCurricular.referenciaCurso
								JOIN Docente ON Docente.numero = UnidadeCurricular.numeroDocente;";

				using (SqlCommand cmd = new SqlCommand(query, cn))
				{
					using (SqlConnection connection = new SqlConnection(Connection.Conn()))
					{
						try
						{
							connection.Open();
							SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
							DataTable dataTable = new DataTable();
							adapter.Fill(dataTable);
							return dataTable;
						}
						catch (Exception ex)
						{
							MessageBox.Show("Erro ao carregar dados: " + ex.Message);
							return null;
						}
					}

				}


			}

		}
		public static List<Subject> GetSubject(int id)
		{
			List<Subject> subjects = new List<Subject>();
			using (SqlConnection cn = new SqlConnection(Connection.Conn()))
			{
				cn.Open();

				string query = @"SELECT
									UnidadeCurricular.id AS Id,
									Curso.sigla AS Curso,
									CONCAT(Docente.NomeProprio, ' ', Docente.Apelido) AS Docente,
									UnidadeCurricular.nome AS Nome,
									UnidadeCurricular.sigla AS UC,
									creditos AS Créditos,
									ano AS Ano,
									semestre AS Semestre
								FROM UnidadeCurricular
								JOIN Curso ON Curso.referencia = UnidadeCurricular.referenciaCurso
								JOIN Docente ON Docente.numero = UnidadeCurricular.numeroDocente
								WHERE UnidadeCurricular.id = @id;";

				using (SqlCommand cmd = new SqlCommand(query, cn))
				{
					// Use parameterized query to prevent SQL injection
					cmd.Parameters.AddWithValue("@id", id);

					using (SqlDataReader reader = cmd.ExecuteReader())
					{
						while (reader.Read())
						{
							Subject subject = new Subject
							{
								Id = reader["Id"].ToString(),
								Course = reader["Curso"].ToString(),
								Teacher = reader["Docente"].ToString(),
								Name = reader["Nome"].ToString(),
								Acronym = reader["UC"].ToString(),
								Credits = reader["Créditos"].ToString(),
								Year = reader["Ano"].ToString(),
								Semester = reader["Semestre"].ToString()

							};
							subjects.Add(subject);
						}
					}
				}
			}
			return subjects;
		}
		public static bool UpdateSubject(Subject subject)
		{
			using (SqlConnection cn = new SqlConnection(Connection.Conn()))
			{
				cn.Open();

				string query = @"UPDATE UnidadeCurricular 
                             SET 
                                 creditos = @creditos,
								 numeroDocente = Docente.numero 
								 FROM	UnidadeCurricular
								 INNER JOIN Docente ON CONCAT(Docente.nomeProprio, ' ', Docente.apelido) = @nomeDocente
						         WHERE id = @id";


				using (SqlCommand cmd = new SqlCommand(query, cn))
				{
					cmd.Parameters.AddWithValue("@id", subject.Id);
					cmd.Parameters.AddWithValue("@creditos", Decimal.Parse(subject.Credits));
					cmd.Parameters.AddWithValue("@nomeDocente", subject.Teacher);

					return cmd.ExecuteNonQuery() > 0;
				}
			}
		}

	}
}
