using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

struct Teacher
{
	public string Number;
	public string Extension;
	public string Name;
	public string LastName;
	public string Birthday;
	public string Salary;
	public string Email;
	public string Phone;
}

namespace projectoPOO
{
	internal class Teachers
	{
		public static List<Teacher> GetTeachers(int numero)
		{

			List<Teacher> teachers = new List<Teacher>();

			using (SqlConnection cn = new SqlConnection(Connection.Conn()))
			{
				cn.Open();

				string query = "SELECT * FROM Docente WHERE numero = @numero";
				using (SqlCommand cmd = new SqlCommand(query, cn))
				{
					// Use parameterized query to prevent SQL injection
					cmd.Parameters.AddWithValue("@numero", numero);

					using (SqlDataReader reader = cmd.ExecuteReader())
					{
						while (reader.Read())
						{
							Teacher teacher = new Teacher
							{
								Number = reader["numero"].ToString(),
								Extension = reader["extensao"].ToString(),
								Name = reader["nomeProprio"].ToString(),
								LastName = reader["apelido"].ToString(),
								Birthday = reader["dataNascimento"].ToString(),
								Salary = reader["salario"].ToString(),
								Email = reader["email"].ToString(),
								Phone = reader["telefone"].ToString()
							};
							teachers.Add(teacher);
						}
					}
				}
			}
			return teachers;
		}

		public static string RemoveAccents(string input)
		{
			if (string.IsNullOrWhiteSpace(input))
				return input;

			string normalized = input.Normalize(NormalizationForm.FormD);
			Regex regex = new Regex(@"\p{Mn}");
			return regex.Replace(normalized, string.Empty);
		}

		public static bool AddTeacher(Teacher teacher)
		{


			using (SqlConnection cn = new SqlConnection(Connection.Conn()))
			{
				cn.Open();

				// Obter o maior número
				string query = "SELECT MAX(numero) AS maior_numero FROM Docente;";
				int teacherNumber = 1; // Caso não haja docentes na tabela, começamos do 1.

				using (SqlCommand command = new SqlCommand(query, cn))
				{
					using (SqlDataReader reader = command.ExecuteReader())
					{
						if (reader.Read() && !reader.IsDBNull(0)) // Verifica se há valor
						{
							teacherNumber = reader.GetInt32(0) + 1000; // Incrementa o maior número
						}
					}
				}

				// Gerar o e-mail com o primeiro nome e o apelido em letras minúsculas e sem acentos
				string firstName = RemoveAccents(teacher.Name.Split(' ')[0].ToLower()); // Pega o primeiro nome
				string lastName = RemoveAccents(teacher.LastName.Split(' ')[0].ToLower()); // Pega o último nome
				string email = $"{firstName}.{lastName}@ipk.pt"; // Formato do e-mail

				// Inserir o novo docente
				query = @"INSERT INTO Docente 
            (numero, nomeProprio, apelido, dataNascimento, email, telefone, extensao, salario) 
          VALUES 
            (@numero, @nomeProprio, @apelido, @dataNascimento, @email, @telefone, @extensao, @salario)";

				using (SqlCommand cmd = new SqlCommand(query, cn))
				{
					cmd.Parameters.AddWithValue("@numero", teacherNumber);
					cmd.Parameters.AddWithValue("@nomeProprio", teacher.Name);
					cmd.Parameters.AddWithValue("@apelido", teacher.LastName);
					cmd.Parameters.AddWithValue("@dataNascimento", DateTime.Parse(teacher.Birthday));
					cmd.Parameters.AddWithValue("@email", email); // Usando o e-mail gerado
					cmd.Parameters.AddWithValue("@telefone", teacher.Phone);
					cmd.Parameters.AddWithValue("@extensao", 1000);
					cmd.Parameters.AddWithValue("@salario", 280000);

					return cmd.ExecuteNonQuery() > 0;
				}
			}
		}

		public static bool UpdateTeacher(Teacher teacher)
		{
			using (SqlConnection cn = new SqlConnection(Connection.Conn()))
			{
				cn.Open();
				// Gerar o e-mail com o primeiro nome e o apelido em letras minúsculas e sem acentos
				string firstName = RemoveAccents(teacher.Name.Split(' ')[0].ToLower()); // Pega o primeiro nome
				string lastName = RemoveAccents(teacher.LastName.Split(' ')[0].ToLower()); // Pega o último nome
				string email = $"{firstName}.{lastName}@ipk.pt"; // Formato do e-mail

				string query = @"UPDATE Docente 
                             SET nomeProprio = @nomeProprio,
                                 apelido = @apelido,
                                 dataNascimento = @dataNascimento,
								 email = @email,
                                 telefone = @telefone,
                                 extensao = @extensao,
                                 salario = @salario
                             WHERE numero = @numero";

				using (SqlCommand cmd = new SqlCommand(query, cn))
				{
					cmd.Parameters.AddWithValue("@numero", teacher.Number);
					cmd.Parameters.AddWithValue("@nomeProprio", teacher.Name);
					cmd.Parameters.AddWithValue("@apelido", teacher.LastName);
					cmd.Parameters.AddWithValue("@dataNascimento", DateTime.Parse(teacher.Birthday));
					cmd.Parameters.AddWithValue("@email", email);
					cmd.Parameters.AddWithValue("@telefone", teacher.Phone);
					cmd.Parameters.AddWithValue("@extensao", teacher.Extension);
					cmd.Parameters.AddWithValue("@salario", teacher.Salary);

					return cmd.ExecuteNonQuery() > 0;
				}
			}
		}

		public static DataTable GetAllTeachers()
		{
			List<Teacher> allTeachers = new List<Teacher>();

			using (SqlConnection cn = new SqlConnection(Connection.Conn()))
			{
				cn.Open();

				string query = @"SELECT * FROM Docente";

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
		public static bool DeleteTeacher(int numero)
		{
			using (SqlConnection cn = new SqlConnection(Connection.Conn()))
			{
				cn.Open();

				string query = @"DELETE FROM Docente
                             WHERE numero = @numero";

				using (SqlCommand cmd = new SqlCommand(query, cn))
				{
					cmd.Parameters.AddWithValue("@numero", numero);
					return cmd.ExecuteNonQuery() > 0;
				}
			}
		}
	}
}
