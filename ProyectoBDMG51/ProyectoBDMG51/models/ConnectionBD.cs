using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace ProyectoBDMG51.models
{
    class ConnectionBD
    {
        public MySqlConnection connManager = new MySqlConnection();
        string server = "127.0.0.1;";
        string database = "proyectobdm;";
        string user = "root;";
        string pass = "root;";

        public MySqlConnection DataSource()
        {
            connManager = new MySqlConnection($"server={server} database={database} Uid={user} password={pass}");
            return connManager;
        }

        public void ConnectOpened()
        {
            connManager.Open();
        }

        public void ConnectClosed()
        {
            DataSource();
            connManager.Close();
        }

        public bool ExecuteQuery(string sql, string archivoRecurso)
        {
            bool result = false;
            FileStream fs;
            BinaryReader br;
            try
            {
                byte[] ImageData;
                fs = new FileStream(archivoRecurso, FileMode.Open, FileAccess.Read);
                br = new BinaryReader(fs);
                ImageData = br.ReadBytes((int)fs.Length);
                br.Close();
                fs.Close();

                MySqlCommand cmd = new MySqlCommand(sql, DataSource());
                cmd.Parameters.Add("@archivoRecurso", MySqlDbType.LongBlob);
                cmd.Parameters["@archivoRecurso"].Value = ImageData;

                ConnectOpened();
                int RowsAffected = cmd.ExecuteNonQuery();
                if(RowsAffected > 0)
                {
                    result = true;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("ERROR " + e);
                ConnectClosed();
            }
            finally
            {
                ConnectClosed();
            }

            return result;
        }

        public bool ExecuteQuery(string sql)
        {
            bool result = false;
            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, DataSource());
                ConnectOpened();

                cmd.ExecuteNonQuery();
                result = true;
            }
            catch (Exception w)
            {
                Console.WriteLine("ERROOOOOOOR" + w.Message);

                ConnectClosed();
            }
            finally
            {
                ConnectClosed();
            }
            return result;
        }
        public bool Login(string sql, string password)
        {
            bool resultado = false;

            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, DataSource());
                ConnectOpened();

                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    reader.Read();
                    string contrasenaGuardada = reader["password"].ToString();
                    if (password.Equals(contrasenaGuardada))
                    {
                        resultado = true;
                    }
                    reader.Close();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("ERRRRRRRRROOOOOOR" + e.Message);
                ConnectClosed();
            }
            finally
            {
                ConnectClosed();
            }

            return resultado;
        }
        public List<Comentario_docente> ReaderComentariosD(string sql, int filtro)
        {
            List<Comentario_docente> ListaComentarios = new List<Comentario_docente>();

            sql += "WHERE idRecursoMFK = @idRecursoMFK";

            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, DataSource());
                cmd.Parameters.AddWithValue("@idRecursoMFK", filtro);
                ConnectOpened();

                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Comentario_docente comentario = new Comentario_docente(
                        reader.GetInt32("idComentarioD"),
                        reader.GetString("contenidoComentarioD"),
                        reader.GetDateTime("fechaComentarioD"),
                        reader.GetInt32("idRecursoMFK"),
                        reader.GetInt32("idDocenteFK")
                    );
                    ListaComentarios.Add(comentario);
                }
                reader.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("ERRRROOOOORRRRR" + e.Message);
                ConnectClosed();
            }
            finally
            {
                ConnectClosed();
            }
            return ListaComentarios;
        }
        public List<Comentario_estudiante> ReaderComentariosE(string sql, int filtro)
        {
            List<Comentario_estudiante> ListaComentarios = new List<Comentario_estudiante>();

            sql += "WHERE idRecursoMFK = @idRecursoMFK";

            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, DataSource());
                cmd.Parameters.AddWithValue("@idRecursoMFK", filtro);
                ConnectOpened();

                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Comentario_estudiante comentario = new Comentario_estudiante(
                        reader.GetInt32("idComentarioE"),
                        reader.GetString("contenidoComentarioE"),
                        reader.GetString("fechaComentarioE"),
                        reader.GetInt32("idRecursoMFK"),
                        reader.GetInt32("idEstudianteFK")
                    );
                    ListaComentarios.Add(comentario);
                }
                reader.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("ERRRROOOOORRRRR" + e.Message);
                ConnectClosed();
            }
            finally
            {
                ConnectClosed();
            }
            return ListaComentarios;
        }
    }
}
