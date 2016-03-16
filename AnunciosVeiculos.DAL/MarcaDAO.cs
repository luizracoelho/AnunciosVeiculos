using AnunciosVeiculos.DL;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;

namespace AnunciosVeiculos.DAL
{
    public class MarcaDAO
    {
        public static int Criar(Marca marca)
        {
            using (var conn = new SqlConnection(ConfigurationManager.ConnectionStrings["AnunciosVeiculos"].ConnectionString))
            {
                try
                {
                    var query = "Insert Into Marcas(Nome, DataCadastro) Values(@nome, @dataCadastro)";

                    using (var cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@nome", marca.Nome);
                        cmd.Parameters.AddWithValue("@dataCadastro", marca.DataCadastro);

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

        public static int Editar(Marca marca)
        {
            using (var conn = new SqlConnection(ConfigurationManager.ConnectionStrings["AnunciosVeiculos"].ConnectionString))
            {
                try
                {
                    var query = "Update Usuarios Set Nome=@nome, DataCadastro=@dataCadastro Where MarcaId=@marcaId";

                    using (var cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@nome", marca.Nome);
                        cmd.Parameters.AddWithValue("@dataCadastro", marca.DataCadastro);
                        cmd.Parameters.AddWithValue("@marcaId", marca.MarcaId);

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

        public static Marca Encontrar(int id)
        {
            try
            {
                var marca = Listar().FirstOrDefault(x => x.MarcaId == id);

                if (marca == null)
                    throw new Exception("Registro não encontrado.");

                return marca;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static List<Marca> Listar()
        {
            using (var conn = new SqlConnection(ConfigurationManager.ConnectionStrings["AnunciosVeiculos"].ConnectionString))
            {
                try
                {
                    var query = "Select * From Marcas";

                    using (var cmd = new SqlCommand(query, conn))
                    {
                        conn.Open();

                        var reader = cmd.ExecuteReader();

                        var marcas = new List<Marca>();
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                marcas.Add(new Marca
                                {
                                    MarcaId = Convert.ToInt32(reader["MarcaId"]),
                                    Nome = (string)reader["Nome"],
                                    DataCadastro = Convert.ToDateTime(reader["DataCadastro"]),
                                });
                            }

                        }
                        return marcas;
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

        public static int Remover(Marca marca)
        {
            using (var conn = new SqlConnection(ConfigurationManager.ConnectionStrings["AnunciosVeiculos"].ConnectionString))
            {
                try
                {
                    var query = "Delete From Marcas Where MarcaId=@marcaId";

                    using (var cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@marcaId", marca.MarcaId);

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
