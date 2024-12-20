﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

struct Course
{
	public string Ref;
	public string Name;
	public string Acronym;
	public string StartDate;
}


namespace projectoPOO
{

	internal class Courses
	{


		public static List<Course> GetCourses(int referencia)
		{

			List<Course> courses = new List<Course>();

			using (SqlConnection cn = new SqlConnection(Connection.Conn()))
			{
				cn.Open();

				string query = "SELECT * FROM Curso WHERE referencia = @referencia";
				using (SqlCommand cmd = new SqlCommand(query, cn))
				{
					// Use parameterized query to prevent SQL injection
					cmd.Parameters.AddWithValue("@referencia", referencia);

					using (SqlDataReader reader = cmd.ExecuteReader())
					{
						while (reader.Read())
						{
							Course course = new Course
							{
								Ref = reader["referencia"].ToString(),
								Name = reader["nome"].ToString(),
								Acronym = reader["sigla"].ToString(),
								StartDate = reader["dataInicio"].ToString(),
							};
							courses.Add(course);
						}
					}
				}
			}
			return courses;
		}
		public static bool AddCourse(Course course)
		{

			using (SqlConnection cn = new SqlConnection(Connection.Conn()))
			{
				cn.Open();

				// Obter o maior número
				string query = "SELECT MAX(referencia) AS maior_numero FROM Curso;";
				int courseRef = 100; // Caso não haja cursos na tabela, começamos do 100.

				using (SqlCommand command = new SqlCommand(query, cn))
				{
					using (SqlDataReader reader = command.ExecuteReader())
					{
						if (reader.Read() && !reader.IsDBNull(0)) // Verifica se há valor
						{
							courseRef = reader.GetInt32(0) + 100; // Incrementa o maior número
						}
					}
				}
				// Criar Sigla
				string courseName = course.Name;
				string courseAcronym = new string(courseName.Where(char.IsUpper).ToArray());

				// Inserir o novo aluno
				query = @"
						INSERT INTO	Curso 
							(referencia, nome, sigla, dataInicio) 
						VALUES (
							@referencia, 
							@nome, 
							@sigla, 
							@dataInicio);";

				using (SqlCommand cmd = new SqlCommand(query, cn))
				{
					cmd.Parameters.AddWithValue("@referencia", courseRef);
					cmd.Parameters.AddWithValue("@nome", course.Name);
					cmd.Parameters.AddWithValue("@sigla", courseAcronym);
					cmd.Parameters.AddWithValue("@dataInicio", DateTime.Parse(course.StartDate));

					return cmd.ExecuteNonQuery() > 0;
				}
			}
		}
		public static bool UpdateCourse(Course course)
		{

			string courseName = course.Name;
			string courseAcronym = new string(courseName.Where(char.IsUpper).ToArray());


			using (SqlConnection cn = new SqlConnection(Connection.Conn()))
			{
				cn.Open();

				string query = @"UPDATE Curso 
                             SET nome = @nome,
                                 sigla = @sigla,
                                 dataInicio = @dataInicio
                             WHERE referencia = @referencia";


				using (SqlCommand cmd = new SqlCommand(query, cn))
				{
					cmd.Parameters.AddWithValue("@referencia", course.Ref);
					cmd.Parameters.AddWithValue("@nome", course.Name);
					cmd.Parameters.AddWithValue("@sigla", courseAcronym);
					cmd.Parameters.AddWithValue("@dataInicio", DateTime.Parse(course.StartDate));

					return cmd.ExecuteNonQuery() > 0;
				}
			}


		}

		public static DataTable GetAllCourses()
		{
			List<Course> allCourses = new List<Course>();

			using (SqlConnection cn = new SqlConnection(Connection.Conn()))
			{
				cn.Open();

				string query = @"SELECT * FROM Curso;";


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

		public static bool DeleteCourse(int referencia)
		{
			using (SqlConnection cn = new SqlConnection(Connection.Conn()))
			{
				cn.Open();

				string query = @"DELETE FROM Curso
                             WHERE referencia = @referencia";

				using (SqlCommand cmd = new SqlCommand(query, cn))
				{
					cmd.Parameters.AddWithValue("@referencia", referencia);
					return cmd.ExecuteNonQuery() > 0;
				}
			}
		}
	}
}
