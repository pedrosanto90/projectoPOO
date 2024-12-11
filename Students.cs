using System;
using System.Collections.Generic;
using System.Data.SqlClient;
struct Student
{
	public string Number;
	public string CourseRef;
	public string Name;
	public string LastName;
	public string Birthday;
	public string Address;
	public string Email;
	public string Phone;
}

namespace projectoPOO
{

	internal class Students
	{
		public static List<Student> GetStudents(int numero)
		{
			string connectionString = "Data Source=(local); User ID=joao; Initial Catalog=escoladb; Integrated Security=True;";
			List<Student> students = new List<Student>();

			using (SqlConnection cn = new SqlConnection(connectionString))
			{
				cn.Open();

				string query = "SELECT * FROM Aluno WHERE numero = @numero";
				using (SqlCommand cmd = new SqlCommand(query, cn))
				{
					// Use parameterized query to prevent SQL injection
					cmd.Parameters.AddWithValue("@numero", numero);

					using (SqlDataReader reader = cmd.ExecuteReader())
					{
						while (reader.Read())
						{
							Student student = new Student
							{
								Number = reader["numero"].ToString(),
								CourseRef = reader["referenciaCurso"].ToString(),
								Name = reader["nomeProprio"].ToString(),
								LastName = reader["apelido"].ToString(),
								Birthday = reader["dataNascimento"].ToString(),
								Address = reader["morada"].ToString(),
								Email = reader["email"].ToString(),
								Phone = reader["telefone"].ToString()
							};
							students.Add(student);
						}
					}
				}
			}
			return students;
		}

        public static bool AddStudent(Student student)
        {
            string connectionString = "Data Source=(local); User ID=joao; Initial Catalog=EscolaDB; Integrated Security=True;";

            using (SqlConnection cn = new SqlConnection(connectionString))
            {
                cn.Open();

                // Obter o maior número
                string query = "SELECT MAX(numero) AS maior_numero FROM Aluno;";
                int studentNumber = 1; // Caso não haja alunos na tabela, começamos do 1.

                using (SqlCommand command = new SqlCommand(query, cn))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read() && !reader.IsDBNull(0)) // Verifica se há valor
                        {
                            studentNumber = reader.GetInt32(0) + 1; // Incrementa o maior número
                        }
                    }
                }

                // Gerar o e-mail do aluno
                string studentEmail = $"aluno{studentNumber}@ipw.pt";

                // Inserir o novo aluno
                query = @"INSERT INTO Aluno 
                    (numero, referenciaCurso, nomeProprio, apelido, dataNascimento, morada, email, telefone) 
                  VALUES 
                    (@numero, @referenciaCurso, @nomeProprio, @apelido, @dataNascimento, @morada, @email, @telefone)";

                using (SqlCommand cmd = new SqlCommand(query, cn))
                {
                    cmd.Parameters.AddWithValue("@numero", studentNumber);
                    cmd.Parameters.AddWithValue("@referenciaCurso", 100);
                    cmd.Parameters.AddWithValue("@nomeProprio", student.Name);
                    cmd.Parameters.AddWithValue("@apelido", student.LastName);
                    cmd.Parameters.AddWithValue("@dataNascimento", DateTime.Parse(student.Birthday));
                    cmd.Parameters.AddWithValue("@morada", student.Address);
                    cmd.Parameters.AddWithValue("@email", studentEmail);
                    cmd.Parameters.AddWithValue("@telefone", student.Phone);

                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        public static bool UpdateStudent(Student student)
        {
            string connectionString = "Data Source=(local); User ID=joao; Initial Catalog=EscolaDB; Integrated Security=True;";

            using (SqlConnection cn = new SqlConnection(connectionString))
            {
                cn.Open();

                string query = @"UPDATE Aluno 
                             SET referenciaCurso = @referenciaCurso,
                                 nomeProprio = @nomeProprio,
                                 apelido = @apelido,
                                 dataNascimento = @dataNascimento,
                                 morada = @morada,
                                 telefone = @telefone
                             WHERE numero = @numero";

                using (SqlCommand cmd = new SqlCommand(query, cn))
                {
                    cmd.Parameters.AddWithValue("@numero", student.Number);
                    cmd.Parameters.AddWithValue("@referenciaCurso", student.CourseRef);
                    cmd.Parameters.AddWithValue("@nomeProprio", student.Name);
                    cmd.Parameters.AddWithValue("@apelido", student.LastName);
                    cmd.Parameters.AddWithValue("@dataNascimento", DateTime.Parse(student.Birthday));
                    cmd.Parameters.AddWithValue("@morada", student.Address);
                    cmd.Parameters.AddWithValue("@telefone", student.Phone);

                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        public static List<Student> GetAllStudents()
        {
            string connectionString = "Data Source=(local); User ID=joao; Initial Catalog=EscolaDB; Integrated Security=True;";
            List<Student> allStudents = new List<Student>();

            using (SqlConnection cn = new SqlConnection(connectionString))
            {
                cn.Open();

                string query = @"SELECT numero, referenciaCurso, nomeProprio, apelido, dataNascimento, morada, email, telefone FROM Aluno";

                using (SqlCommand cmd = new SqlCommand(query, cn))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Student student = new Student
                            {
                                Number = reader["numero"].ToString(),
                                CourseRef = reader["referenciaCurso"].ToString(),
                                Name = reader["nomeProprio"].ToString(),
                                LastName = reader["apelido"].ToString(),
                                Birthday = reader["dataNascimento"].ToString(),
                                Address = reader["morada"].ToString(),
                                Email = reader["email"].ToString(),
                                Phone = reader["telefone"].ToString()
                            };
                            allStudents.Add(student);
                        }
                    }
                }
            }
            return allStudents;
        }
    }
}
