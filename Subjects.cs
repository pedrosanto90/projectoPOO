using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
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

		public static bool AddSubject(Subject subject)
		{

			using (SqlConnection cn = new SqlConnection(Connection.Conn()))
			{
				cn.Open();

				// Obter o maior número
				string query = @"SELECT MAX(UnidadeCurricular.id) AS maior_numero
								FROM UnidadeCurricular
								JOIN Curso ON CAST(UnidadeCurricular.id AS VARCHAR) LIKE '%' + 	CAST(Curso.referencia AS VARCHAR) + '%'
								WHERE Curso.sigla = @refCurso;";
				int subjectId = 1; // Caso não haja UCs na tabela, começamos do 1.

				using (SqlCommand command = new SqlCommand(query, cn))
				{
					command.Parameters.AddWithValue("@refCurso", subject.Course); //ITM
					using (SqlDataReader reader = command.ExecuteReader())
					{
						if (reader.Read() && !reader.IsDBNull(0)) // Verifica se há valor
						{
							subjectId = reader.GetInt32(0) + 10000; // Incrementa o maior número
						}
					}
				}

				// Criar Sigla
				string subjectName = subject.Name;
				string subjectAcronym = new string(subjectName.Where(char.IsUpper).ToArray());

				// Inserir a nova UC
				query = @"
						INSERT INTO	UnidadeCurricular 
							(id, referenciaCurso, numeroDocente, nome, sigla, creditos, ano, semestre) 
						SELECT
							@id,
							Curso.referencia,
							numeroDocente = (
								SELECT Docente.numero 
								FROM Docente 
								WHERE Docente.nomeProprio + ' ' + Docente.apelido = @nomeDocente
							),
							@nome, 
							@sigla,
							@creditos,
							@ano,
							@semestre
						FROM 
							Curso
						WHERE 
							Curso.sigla = @referenciaCurso;";


				using (SqlCommand cmd = new SqlCommand(query, cn))
				{
					cmd.Parameters.AddWithValue("@id", subjectId);
					cmd.Parameters.AddWithValue("@referenciaCurso", subject.Course);
					cmd.Parameters.AddWithValue("@nomeDocente", subject.Teacher);
					cmd.Parameters.AddWithValue("@nome", subject.Name);
					cmd.Parameters.AddWithValue("@sigla", subjectAcronym);
					cmd.Parameters.AddWithValue("@creditos", Convert.ToDecimal(subject.Credits, CultureInfo.InvariantCulture));
					cmd.Parameters.AddWithValue("@ano", subject.Year);
					cmd.Parameters.AddWithValue("@semestre", subject.Semester);

					return cmd.ExecuteNonQuery() > 0;
				}
			}
		}

		public static bool UpdateSubject(Subject subject)
		{
			using (SqlConnection cn = new SqlConnection(Connection.Conn()))
			{
				cn.Open();

				string query = @"
				UPDATE UnidadeCurricular 
				SET creditos = @creditos,
					numeroDocente = (
						SELECT Docente.numero 
						FROM Docente 
						WHERE Docente.nomeProprio + ' ' + Docente.apelido = @nomeDocente
					)
				FROM UnidadeCurricular
				WHERE id = @id";

				using (SqlCommand cmd = new SqlCommand(query, cn))
				{
					cmd.Parameters.AddWithValue("@id", subject.Id);
					cmd.Parameters.AddWithValue("@creditos", Convert.ToDecimal(subject.Credits, CultureInfo.InvariantCulture));
					cmd.Parameters.AddWithValue("@nomeDocente", subject.Teacher);


					return cmd.ExecuteNonQuery() > 0;

				}
			}
		}

		public static bool DeleteSubject(int id)
		{
			using (SqlConnection cn = new SqlConnection(Connection.Conn()))
			{
				cn.Open();

				string query = @"DELETE FROM UnidadeCurricular
                             WHERE id = @id";

				using (SqlCommand cmd = new SqlCommand(query, cn))
				{
					cmd.Parameters.AddWithValue("@id", id);
					return cmd.ExecuteNonQuery() > 0;
				}
			}
		}

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
    }
}
