using AnunciosVeiculos.DAL;
using AnunciosVeiculos.DL;
using System;
using System.Collections.Generic;

namespace AnunciosVeiculos.BLL
{
    public class VeiculoBO
    {
        private static int Criar(Veiculo veiculo)
        {
            try
            {
                return VeiculoDAO.Criar(veiculo);
            }
            catch (Exception)
            {
                throw;
            }
        }

        private static int Editar(Veiculo veiculo)
        {
            try
            {
                return VeiculoDAO.Editar(veiculo);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static Veiculo Encontrar(int id)
        {
            try
            {
                return VeiculoDAO.Encontrar(id);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static List<Veiculo> Listar()
        {
            try
            {
                return VeiculoDAO.Listar();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static int Remover(Veiculo veiculo)
        {
            try
            {
                return VeiculoDAO.Remover(veiculo);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static int Salvar(Veiculo veiculo)
        {
            try
            {
                if (veiculo.VeiculoId == 0)
                    return Criar(veiculo);
                else
                    return Editar(veiculo);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
