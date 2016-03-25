using AnunciosVeiculos.DAL;
using AnunciosVeiculos.DL;
using System;
using System.Collections.Generic;

namespace AnunciosVeiculos.BLL
{
    public class ModeloBO
    {
        private static int Criar(Modelo modelo)
        {
            try
            {
                return ModeloDAO.Criar(modelo);
            }
            catch (Exception)
            {
                throw;
            }
        }

        private static int Editar(Modelo modelo)
        {
            try
            {
                return ModeloDAO.Editar(modelo);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static Modelo Encontrar(int id)
        {
            try
            {
                return ModeloDAO.Encontrar(id);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static List<Modelo> Listar()
        {
            try
            {
                return ModeloDAO.Listar();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static int Remover(Modelo modelo)
        {
            try
            {
                return ModeloDAO.Remover(modelo);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static int Salvar(Modelo modelo)
        {
            try
            {
                if (modelo.ModeloId == 0)
                    return Criar(modelo);
                else
                    return Editar(modelo);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
