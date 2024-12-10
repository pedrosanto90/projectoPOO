using System;
using System.Collections.Generic;
using System.Data.SqlClient;

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
            string connectionString = "Data Source=(local); User ID=joao; Initial Catalog=escoladb; Integrated Security=True;";
            List<Teacher> teachers = new List<Teacher>();

            using (SqlConnection cn = new SqlConnection(connectionString))
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
    }
}
