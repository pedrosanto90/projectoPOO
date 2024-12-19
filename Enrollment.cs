using System;
using System.Collections.Generic;
using System.Data.SqlClient;

public struct Enroll
{
	public string StudentNumber;
	public string Subject;
	public string Year;
	public string EvaluationSeason;
	public string SeasonStatus;
	public string Attendance;
	public string Score;
}

namespace projectoPOO
{
	internal class Enrollment
	{
		public static bool EnrollStudent(Enroll enroll)
		{
			using (SqlConnection cn = new SqlConnection(Connection.Conn()))
			{
				cn.Open();

				string getYear = "SELECT MAX(id) AS maior_ano FROM AnoLetivo;";
				int year = 1;

				using (SqlCommand command = new SqlCommand(getYear, cn))
				{
					using (SqlDataReader reader = command.ExecuteReader())
					{
						if (reader.Read() && !reader.IsDBNull(0))
						{
							year = reader.GetInt16(0);
						}
					}
				}

				string evaluation = "EFRE";
				int seasonStatus = 10;

				string query = @"
            INSERT INTO Inscricao (numeroAluno, idUnidadeCurricular, idAnoLetivo, idEpocaAvaliacao, idEstadoEpoca)
            SELECT 
                @numeroAluno, 
                UnidadeCurricular.id, 
                @idAnoLetivo, 
                @idEpocaAvalicao, 
                @idEstadoEpoca
            FROM UnidadeCurricular
            INNER JOIN Curso ON UnidadeCurricular.referenciaCurso = Curso.referencia
            WHERE Curso.sigla = @idUnidadeCurricular";

				using (SqlCommand cmd = new SqlCommand(query, cn))
				{
					cmd.Parameters.AddWithValue("@numeroAluno", Int32.Parse(enroll.StudentNumber));
					cmd.Parameters.AddWithValue("@idUnidadeCurricular", enroll.Subject);
					cmd.Parameters.AddWithValue("@idAnoLetivo", year);
					cmd.Parameters.AddWithValue("@idEpocaAvalicao", evaluation);
					cmd.Parameters.AddWithValue("@idEstadoEpoca", seasonStatus);

					return cmd.ExecuteNonQuery() > 0;
				}
			}
		}

		public static bool SubjectScores(Enroll enroll)
		{
			using (SqlConnection cn = new SqlConnection(Connection.Conn()))
			{
				cn.Open();

				string query = @"UPDATE Inscricao
                               SET presenca = @presenca, nota = @nota
                               WHERE numeroAluno = @numeroAluno
                               AND idUnidadeCurricular = 
                               (SELECT id FROM UnidadeCurricular WHERE nome = @nomeUnidade)
							   AND idEpocaAvaliacao = (SELECT id FROM EpocaAvaliacao WHERE descricao = @epoca);"; // tem de ser mudado para uma variavel e ser ajustado no form

				using (SqlCommand cmd = new SqlCommand(query, cn))
				{
					cmd.Parameters.AddWithValue("@numeroAluno", Int32.Parse(enroll.StudentNumber));
					cmd.Parameters.AddWithValue("@nomeUnidade", enroll.Subject);
					cmd.Parameters.AddWithValue("@presenca", enroll.Attendance);
					cmd.Parameters.AddWithValue("@epoca", enroll.EvaluationSeason);
					if (enroll.Score == null)
					{
						cmd.Parameters.AddWithValue("@nota", DBNull.Value);
					}
					else
					{
						cmd.Parameters.AddWithValue("@nota", enroll.Score);
					}
					return cmd.ExecuteNonQuery() > 0;
				}
			}
		}


		public static bool EnrollStudentN(Enroll enroll)
		{
			using (SqlConnection cn = new SqlConnection(Connection.Conn()))
			{
				cn.Open();

				// Obtém o ano letivo atual
				string getYear = "SELECT MAX(id) AS maior_ano FROM AnoLetivo;";
				int year = 1;

				using (SqlCommand command = new SqlCommand(getYear, cn))
				{
					using (SqlDataReader reader = command.ExecuteReader())
					{
						if (reader.Read() && !reader.IsDBNull(0))
						{
							year = reader.GetInt16(0);
						}
					}
				}

				// string evaluation = "EFRE";  // Época de avaliação original


				// Inserir a inscrição do aluno na nova época de avaliação
				string query = @"
        INSERT INTO Inscricao (numeroAluno, idUnidadeCurricular, idAnoLetivo, idEpocaAvaliacao, idEstadoEpoca)
		VALUES (@numeroAluno, (SELECT id FROM UnidadeCurricular WHERE nome = @idUnidadeCurricular), @idAnoLetivo, @idEpocaAvaliacao, @idEstadoEpoca);";

				using (SqlCommand cmd = new SqlCommand(query, cn))
				{
					cmd.Parameters.AddWithValue("@numeroAluno", Int32.Parse(enroll.StudentNumber));
					cmd.Parameters.AddWithValue("@idUnidadeCurricular", enroll.Subject);
					cmd.Parameters.AddWithValue("@idAnoLetivo", year);
					cmd.Parameters.AddWithValue("@idEpocaAvaliacao", enroll.EvaluationSeason);
					cmd.Parameters.AddWithValue("@idEstadoEpoca", 10);

					return cmd.ExecuteNonQuery() > 0;  // Retorna true se a inserção for bem-sucedida
				}
			}
		}




		public static List<Enroll> GetStudentSubjects(int number)
		{
			List<Enroll> enrolls = new List<Enroll>();
			using (SqlConnection cn = new SqlConnection(Connection.Conn()))
			{
				cn.Open();

				string query = @"SELECT UnidadeCurricular.nome, idEpocaAvaliacao
                                 FROM UnidadeCurricular
                                 INNER JOIN Inscricao ON UnidadeCurricular.id = Inscricao.idUnidadeCurricular
                                 INNER JOIN Aluno ON Inscricao.numeroAluno = Aluno.numero
                                 WHERE Aluno.numero = @numeroAluno
								 AND nota IS NULL;";

				using (SqlCommand cmd = new SqlCommand(query, cn))
				{
					// Use parameterized query to prevent SQL injection
					cmd.Parameters.AddWithValue("@numeroAluno", number);

					using (SqlDataReader reader = cmd.ExecuteReader())
					{
						while (reader.Read())
						{
							Enroll enroll = new Enroll
							{
								Subject = reader["nome"].ToString(),
								EvaluationSeason = reader["idEpocaAvaliacao"].ToString()
							};
							enrolls.Add(enroll);
						}
					}
				}
			}
			return enrolls;
		}

		public static string GetSeason(int number, string idSubject)
		{
			string season = null;
			using (SqlConnection cn = new SqlConnection(Connection.Conn()))
			{
				cn.Open();

				string query = @"SELECT EpocaAvaliacao.descricao AS Epoca
								FROM Inscricao 
								JOIN EpocaAvaliacao ON EpocaAvaliacao.id = Inscricao.idEpocaAvaliacao 
								WHERE numeroAluno = @numero AND idUnidadeCurricular = (SELECT id FROM UnidadeCurricular WHERE nome = @idUC) 
								AND nota IS NULL;	";

				using (SqlCommand cmd = new SqlCommand(query, cn))
				{
					// Use parameterized query to prevent SQL injection
					cmd.Parameters.AddWithValue("@numero", number);
					cmd.Parameters.AddWithValue("@idUC", idSubject);

					using (SqlDataReader reader = cmd.ExecuteReader())
					{
						while (reader.Read())
						{
							season = reader["Epoca"].ToString();
						}
					}
				}
			}
			return season;
		}
	}
}
