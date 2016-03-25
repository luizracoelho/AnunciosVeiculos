using AnunciosVeiculos.DL;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;

namespace AnunciosVeiculos.DAL
{
    public class VeiculoDAO
    {
        public static int Criar(Veiculo veiculo)
        {
            using (var conn = new SqlConnection(ConfigurationManager.ConnectionStrings["AnunciosVeiculos"].ConnectionString))
            {
                try
                {
                    var query = "Insert Into Veiculos(ModeloId, UsuarioId, Valor, AnoFabricacao, AnoModelo, DataCadastro, Hodometro) Values(@modeloId, @usuarioId, @valor, @anoFabricacao, @anoModelo, @dataCadastro, @hodometro)";

                    using (var cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@modeloId", veiculo.Modelo.ModeloId);
                        cmd.Parameters.AddWithValue("@usuarioId", veiculo.Usuario.UsuarioId);
                        cmd.Parameters.AddWithValue("@valor", veiculo.Valor);
                        cmd.Parameters.AddWithValue("@anoFabricacao", veiculo.AnoFabricacao);
                        cmd.Parameters.AddWithValue("@anoModelo", veiculo.AnoModelo);
                        cmd.Parameters.AddWithValue("@dataCadastro", veiculo.DataCadastro);
                        cmd.Parameters.AddWithValue("@hodometro", veiculo.Hodometro);

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

        public static int Editar(Veiculo veiculo)
        {
            using (var conn = new SqlConnection(ConfigurationManager.ConnectionStrings["AnunciosVeiculos"].ConnectionString))
            {
                try
                {
                    var query = "Update Veiculos set ModeloId=@modeloId, UsuarioId=@usuarioId, Valor=@valor, AnoFabricacao=@anoFabricacao, AnoModelo=@anoModelo, DataCadastro=@dataCadastro, Hodometro=@hodometro Where VeiculoId=@veiculoId";

                    using (var cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@modeloId", veiculo.Modelo.ModeloId);
                        cmd.Parameters.AddWithValue("@usuarioId", veiculo.Usuario.UsuarioId);
                        cmd.Parameters.AddWithValue("@valor", veiculo.Valor);
                        cmd.Parameters.AddWithValue("@anoFabricacao", veiculo.AnoFabricacao);
                        cmd.Parameters.AddWithValue("@anoModelo", veiculo.AnoModelo);
                        cmd.Parameters.AddWithValue("@dataCadastro", veiculo.DataCadastro);
                        cmd.Parameters.AddWithValue("@hodometro", veiculo.Hodometro);
                        cmd.Parameters.AddWithValue("@veiculoId", veiculo.VeiculoId);

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

        public static Veiculo Encontrar(int id)
        {
            try
            {
                var veiculo = Listar().FirstOrDefault(x => x.VeiculoId == id);

                if (veiculo == null)
                    throw new Exception("Registro não encontrado.");

                return veiculo;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static List<Veiculo> Listar()
        {
            using (var conn = new SqlConnection(ConfigurationManager.ConnectionStrings["AnunciosVeiculos"].ConnectionString))
            {
                try
                {
                    var query = "Select * From Veiculos";

                    using (var cmd = new SqlCommand(query, conn))
                    {
                        conn.Open();

                        var reader = cmd.ExecuteReader();

                        var veiculos = new List<Veiculo>();
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                veiculos.Add(new Veiculo
                                {
                                    VeiculoId = Convert.ToInt32(reader["VeiculoId"]),
                                    Modelo = ModeloDAO.Encontrar(Convert.ToInt32(reader["ModeloId"])),
                                    Usuario = UsuarioDAO.Encontrar(Convert.ToInt32(reader["UsuarioId"])),
                                    Valor = Convert.ToDecimal(reader["Valor"]),
                                    AnoFabricacao = Convert.ToInt32(reader["AnoFabricacao"]),
                                    AnoModelo = Convert.ToInt32(reader["AnoModelo"]),
                                    DataCadastro = Convert.ToDateTime(reader["DataCadastro"]),
                                    Hodometro = Convert.ToInt32(reader["Hodometro"])
                                });
                            }

                        }
                        return veiculos;
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

        public static int Remover(Veiculo veiculo)
        {
            using (var conn = new SqlConnection(ConfigurationManager.ConnectionStrings["AnunciosVeiculos"].ConnectionString))
            {
                try
                {
                    var query = "Delete From Veiculos Where VeiculoId=@veiculoId";

                    using (var cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@veiculoId", veiculo.VeiculoId);

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
