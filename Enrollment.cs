using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

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

                int failed = 20;
				int passed = 30;

				string query = @"UPDATE Inscricao
                               SET presenca = @presenca, nota = @nota, idEstadoEpoca = @estado
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
                        cmd.Parameters.AddWithValue("@estado", failed);
                    }
					else if (Int32.Parse(enroll.Score) < 10)
					{
						cmd.Parameters.AddWithValue("@nota", enroll.Score);
                        cmd.Parameters.AddWithValue("@estado", failed);
                    }
					else
					{
                        cmd.Parameters.AddWithValue("@nota", enroll.Score);
                        cmd.Parameters.AddWithValue("@estado", passed);
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

				int admited = 10;

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
					cmd.Parameters.AddWithValue("@idEstadoEpoca", admited);

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
								 AND (nota IS NULL AND presenca IS NULL);";

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

        public static List<Enroll> GetAllScores(int number)
        {
            List<Enroll> enrollList = new List<Enroll>();

            using (SqlConnection cn = new SqlConnection(Connection.Conn()))
            {
                try
                {
                    cn.Open();

                    int failed = 20;
                    string exam = "ENEX";

                    string query = @"SELECT 
                        UnidadeCurricular.nome, 
                        Inscricao.presenca, 
                        Inscricao.nota 
                     FROM 
                        Inscricao
                     INNER JOIN 
                        UnidadeCurricular 
                     ON 
                        Inscricao.idUnidadeCurricular = UnidadeCurricular.id
                     WHERE 
                        Inscricao.numeroAluno = @numero AND Inscricao.idEpocaAvaliacao = @avaliacao AND Inscricao.idEstadoEpoca = @epoca;";

                    using (SqlCommand cmd = new SqlCommand(query, cn))
                    {
                        cmd.Parameters.AddWithValue("@numero", number);
                        cmd.Parameters.AddWithValue("@avaliacao", exam);
                        cmd.Parameters.AddWithValue("@epoca", failed);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Enroll enroll = new Enroll
                                {
                                    Subject = reader["nome"].ToString(),
                                    Attendance = reader["presenca"].ToString(),
                                    Score = reader["nota"].ToString()
                                };
                                enrollList.Add(enroll);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao carregar dados: " + ex.Message);
                }
            }

            return enrollList;
        }


        public static DataTable GetAllAppealScores(int number)
        {
            using (SqlConnection cn = new SqlConnection(Connection.Conn()))
            {
                try
                {
                    cn.Open();

                    int failed = 20;
                    string exam = "EREC";

                    string query = @"SELECT 
                                UnidadeCurricular.nome, 
                                Inscricao.presenca, 
                                Inscricao.nota 
                             FROM 
                                Inscricao
                             INNER JOIN 
                                UnidadeCurricular 
                             ON 
                                Inscricao.idUnidadeCurricular = UnidadeCurricular.id
                             WHERE 
                                Inscricao.numeroAluno = @numero AND Inscricao.idEpocaAvaliacao = @avaliacao AND Inscricao.idEstadoEpoca = @epoca;";

                    using (SqlCommand cmd = new SqlCommand(query, cn))
                    {
                        cmd.Parameters.AddWithValue("@numero", number);
                        cmd.Parameters.AddWithValue("@avaliacao", exam);
                        cmd.Parameters.AddWithValue("@epoca", failed);

                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);
                            return dataTable;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao carregar dados: " + ex.Message);
                    return null;
                }
            }
        }

        //entrar na epoca de recurso
        public static bool AppealExamEntry(Enroll enroll, int numero)
        {
            using (SqlConnection cn = new SqlConnection(Connection.Conn()))
            {
                cn.Open();

                // Obtém o ano letivo atual
                string getYear = "SELECT idAnoLetivo FROM Inscricao WHERE numeroAluno = @numero;";
                int year = 1;

                using (SqlCommand command = new SqlCommand(getYear, cn))
                {
					command.Parameters.AddWithValue("@numero", numero);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read() && !reader.IsDBNull(0))
                        {
                            year = reader.GetInt16(0);
                        }
                    }
                }

                int admited = 10;
				string season = "EREC";

                // Inserir a inscrição do aluno na nova época de avaliação
                string query = @"
        INSERT INTO Inscricao (numeroAluno, idUnidadeCurricular, idAnoLetivo, idEpocaAvaliacao, idEstadoEpoca)
		VALUES (@numeroAluno, (SELECT id FROM UnidadeCurricular WHERE nome = @idUnidadeCurricular), @idAnoLetivo, @idEpocaAvaliacao, @idEstadoEpoca);";

                using (SqlCommand cmd = new SqlCommand(query, cn))
                {
                    cmd.Parameters.AddWithValue("@numeroAluno", numero);
                    cmd.Parameters.AddWithValue("@idUnidadeCurricular", enroll.Subject);
                    cmd.Parameters.AddWithValue("@idAnoLetivo", year);
                    cmd.Parameters.AddWithValue("@idEpocaAvaliacao", season);
                    cmd.Parameters.AddWithValue("@idEstadoEpoca", admited);

                    return cmd.ExecuteNonQuery() > 0;  // Retorna true se a inserção for bem-sucedida
                }
            }
        }

        //entrar na epoca especial
        public static bool SpecialExamEntry(Enroll enroll, int numero)
        {
            using (SqlConnection cn = new SqlConnection(Connection.Conn()))
            {
                cn.Open();

                // Obtém o ano letivo atual
                string getYear = "SELECT idAnoLetivo FROM Inscricao WHERE numeroAluno = @numero;";
                int year = 1;

                using (SqlCommand command = new SqlCommand(getYear, cn))
                {
                    command.Parameters.AddWithValue("@numero", numero);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read() && !reader.IsDBNull(0))
                        {
                            year = reader.GetInt16(0);
                        }
                    }
                }

                int admited = 10;
                string season = "EESP";

                // Inserir a inscrição do aluno na nova época de avaliação
                string query = @"
        INSERT INTO Inscricao (numeroAluno, idUnidadeCurricular, idAnoLetivo, idEpocaAvaliacao, idEstadoEpoca)
		VALUES (@numeroAluno, (SELECT id FROM UnidadeCurricular WHERE nome = @idUnidadeCurricular), @idAnoLetivo, @idEpocaAvaliacao, @idEstadoEpoca);";

                using (SqlCommand cmd = new SqlCommand(query, cn))
                {
                    cmd.Parameters.AddWithValue("@numeroAluno", numero);
                    cmd.Parameters.AddWithValue("@idUnidadeCurricular", enroll.Subject);
                    cmd.Parameters.AddWithValue("@idAnoLetivo", year);
                    cmd.Parameters.AddWithValue("@idEpocaAvaliacao", season);
                    cmd.Parameters.AddWithValue("@idEstadoEpoca", admited);

                    return cmd.ExecuteNonQuery() > 0;  // Retorna true se a inserção for bem-sucedida
                }
            }
        }

        public static List<Enroll> GetSubjectsExam(int number)
        {
            List<Enroll> subjectExam = new List<Enroll>();
            using (SqlConnection cn = new SqlConnection(Connection.Conn()))
            {
                cn.Open();

                string query = @"SELECT DISTINCT UnidadeCurricular.nome AS UC
                                FROM Inscricao
                                JOIN UnidadeCurricular ON UnidadeCurricular.id = Inscricao.idUnidadeCurricular
                                WHERE numeroAluno = @numero
                                  AND nota < 10
                                  AND idUnidadeCurricular = Inscricao.idUnidadeCurricular;";

                using (SqlCommand cmd = new SqlCommand(query, cn))
                {
                    // Use parameterized query to prevent SQL injection
                    cmd.Parameters.AddWithValue("@numero", number);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Enroll enroll = new Enroll
                            {
                                Subject = reader["UC"].ToString()
                            };
                            subjectExam.Add(enroll);
                        }
                        
                    }
                }
            }
            return subjectExam;
        }

        public static List<Enroll> GetSubjectsAppealExam(int number)
        {
            List<Enroll> subjectAppealExam = new List<Enroll>();
            using (SqlConnection cn = new SqlConnection(Connection.Conn()))
            {
                cn.Open();

                string query = @"SELECT DISTINCT UnidadeCurricular.nome AS UC
                                    FROM Inscricao
                                    JOIN UnidadeCurricular ON UnidadeCurricular.id = Inscricao.idUnidadeCurricular
                                    WHERE Inscricao.numeroAluno = @numero
                                      AND Inscricao.nota < 10
                                      AND EXISTS (
                                        SELECT 1
                                        FROM Inscricao i
                                        WHERE i.idUnidadeCurricular = Inscricao.idUnidadeCurricular
                                          AND i.idEpocaAvaliacao = 'EREC'
                                      )
                                      AND NOT EXISTS (
                                        SELECT 1
                                        FROM Inscricao i
                                        WHERE i.idUnidadeCurricular = Inscricao.idUnidadeCurricular
                                          AND i.idEpocaAvaliacao = 'EESP'
                                      );";

                using (SqlCommand cmd = new SqlCommand(query, cn))
                {
                    // Use parameterized query to prevent SQL injection
                    cmd.Parameters.AddWithValue("@numero", number);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Enroll enroll = new Enroll
                            {
                                Subject = reader["UC"].ToString()
                            };
                            subjectAppealExam.Add(enroll);
                        }

                    }
                }
            }
            return subjectAppealExam;
        }
    }
}
