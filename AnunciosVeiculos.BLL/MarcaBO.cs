using AnunciosVeiculos.DAL;
using AnunciosVeiculos.DL;
using System;
using System.Collections.Generic;

namespace AnunciosVeiculos.BLL
{
    public class MarcaBO
    {
        private static int Criar(Marca marca)
        {
            try
            {
                return MarcaDAO.Criar(marca);
            }
            catch (Exception)
            {
                throw;
            }
        }

        private static int Editar(Marca marca)
        {
            try
            {
                return MarcaDAO.Editar(marca);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static Marca Encontrar(int id)
        {
            try
            {
                return MarcaDAO.Encontrar(id);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static List<Marca> Listar()
        {
            try
            {
                return MarcaDAO.Listar();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static int Remover(Marca marca)
        {
            try
            {
                return MarcaDAO.Remover(marca);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static int Salvar(Marca marca)
        {
            try
            {
                if (marca.MarcaId == 0)
                    return Criar(marca);
                else
                    return Editar(marca);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
