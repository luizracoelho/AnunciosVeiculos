using AnunciosVeiculos.DL;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;

namespace AnunciosVeiculos.DAL
{
    public class ModeloDAO
    {
        public static int Criar(Modelo modelo)
        {
            using (var conn = new SqlConnection(ConfigurationManager.ConnectionStrings["AnunciosVeiculos"].ConnectionString))
            {
                try
                {
                    var query = "Insert Into Modelos(Nome, DataCadastro, MarcaId) Values(@nome, @dataCadastro, @marcaId)";

                    using (var cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@nome", modelo.Nome);
                        cmd.Parameters.AddWithValue("@dataCadastro", modelo.DataCadastro);
                        cmd.Parameters.AddWithValue("@marcaId", modelo.Marca.MarcaId);

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

        public static int Editar(Modelo modelo)
        {
            using (var conn = new SqlConnection(ConfigurationManager.ConnectionStrings["AnunciosVeiculos"].ConnectionString))
            {
                try
                {
                    var query = "Update Modelos Set Nome=@nome, DataCadastro=@dataCadastro, MarcaId=@marcaId Where ModeloId=@modeloId";

                    using (var cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@nome", modelo.Nome);
                        cmd.Parameters.AddWithValue("@dataCadastro", modelo.DataCadastro);
                        cmd.Parameters.AddWithValue("@marcaId", modelo.Marca.MarcaId);
                        cmd.Parameters.AddWithValue("@modeloId", modelo.ModeloId);

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

        public static Modelo Encontrar(int id)
        {
            try
            {
                var modelo = Listar().FirstOrDefault(x => x.ModeloId == id);

                if (modelo == null)
                    throw new Exception("Registro não encontrado.");

                return modelo;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static List<Modelo> Listar()
        {
            using (var conn = new SqlConnection(ConfigurationManager.ConnectionStrings["AnunciosVeiculos"].ConnectionString))
            {
                try
                {
                    var query = "Select * From Modelos";

                    using (var cmd = new SqlCommand(query, conn))
                    {
                        conn.Open();

                        var reader = cmd.ExecuteReader();

                        var modelos = new List<Modelo>();
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                modelos.Add(new Modelo
                                {
                                    ModeloId = Convert.ToInt32(reader["ModeloId"]),
                                    Nome = (string)reader["Nome"],
                                    DataCadastro = Convert.ToDateTime(reader["DataCadastro"]),
                                    Marca = MarcaDAO.Encontrar(Convert.ToInt32(reader["MarcaId"]))
                                });
                            }

                        }
                        return modelos;
                    }
                }
                catch (Exception ex)
                {
                    throw;
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        public static int Remover(Modelo modelo)
        {
            using (var conn = new SqlConnection(ConfigurationManager.ConnectionStrings["AnunciosVeiculos"].ConnectionString))
            {
                try
                {
                    var query = "Delete From Modelos Where ModeloId=@modeloId";

                    using (var cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@modeloId", modelo.ModeloId);

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
