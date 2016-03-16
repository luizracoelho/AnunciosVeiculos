using AnunciosVeiculos.DL;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;

namespace AnunciosVeiculos.DAL
{
    public class UsuarioDAO
    {
        public static int Criar(Usuario usuario)
        {
            using (var conn = new SqlConnection(ConfigurationManager.ConnectionStrings["AnunciosVeiculos"].ConnectionString))
            {
                try
                {
                    var query = "Insert Into Usuarios(Nome, Login, Senha, DataCadastro, Email) Values(@nome, @login, @senha, @dataCadastro, @email)";

                    using (var cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@nome", usuario.Nome);
                        cmd.Parameters.AddWithValue("@login", usuario.Login);
                        cmd.Parameters.AddWithValue("@senha", usuario.Senha);
                        cmd.Parameters.AddWithValue("@dataCadastro", usuario.DataCadastro);
                        cmd.Parameters.AddWithValue("@email", usuario.Email);

                        conn.Open();

                        var registrosAfetados = cmd.ExecuteNonQuery();

                        return registrosAfetados;
                    }
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        public static int Editar(Usuario usuario)
        {
            using (var conn = new SqlConnection(ConfigurationManager.ConnectionStrings["AnunciosVeiculos"].ConnectionString))
            {
                try
                {
                    var query = "Update Usuarios Set Nome=@nome, Login=@login, Senha=@senha, DataCadastro=@dataCadastro, Email=@email Where UsuarioId=@usuarioId";

                    using (var cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@nome", usuario.Nome);
                        cmd.Parameters.AddWithValue("@login", usuario.Login);
                        cmd.Parameters.AddWithValue("@senha", usuario.Senha);
                        cmd.Parameters.AddWithValue("@dataCadastro", usuario.DataCadastro);
                        cmd.Parameters.AddWithValue("@email", usuario.Email);
                        cmd.Parameters.AddWithValue("@usuarioId", usuario.UsuarioId);

                        conn.Open();

                        var registrosAfetados = cmd.ExecuteNonQuery();

                        return registrosAfetados;
                    }
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        public static Usuario Encontrar(int id)
        {
            try
            {
                var usuario = Listar().FirstOrDefault(x => x.UsuarioId == id);

                if (usuario == null)
                    throw new Exception("Registro não encontrado.");

                return usuario;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static List<Usuario> Listar()
        {
            using (var conn = new SqlConnection(ConfigurationManager.ConnectionStrings["AnunciosVeiculos"].ConnectionString))
            {
                try
                {
                    var query = "Select * From Usuarios";

                    using (var cmd = new SqlCommand(query, conn))
                    {
                        conn.Open();

                        var reader = cmd.ExecuteReader();

                        var usuarios = new List<Usuario>();
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                usuarios.Add(new Usuario
                                {
                                    UsuarioId = Convert.ToInt32(reader["UsuarioId"]),
                                    Nome = (string)reader["Nome"],
                                    Login = (string)reader["Login"],
                                    Senha = (string)reader["Senha"],
                                    DataCadastro = Convert.ToDateTime(reader["DataCadastro"]),
                                    Email = (string)reader["email"]
                                });
                            }

                        }
                        return usuarios;
                    }
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        public static int Remover(Usuario usuario)
        {
            using (var conn = new SqlConnection(ConfigurationManager.ConnectionStrings["AnunciosVeiculos"].ConnectionString))
            {
                try
                {
                    var query = "Delete From Usuarios Where UsuarioId=@usuarioId";

                    using (var cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@usuarioId", usuario.UsuarioId);

                        conn.Open();

                        var registrosAfetados = cmd.ExecuteNonQuery();

                        return registrosAfetados;
                    }
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    conn.Close();
                }
            }
        }
    }
}
