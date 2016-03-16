using AnunciosVeiculos.DAL;
using AnunciosVeiculos.DL;
using System;
using System.Collections.Generic;

namespace AnunciosVeiculos.BLL
{
    public class UsuarioBO
    {
        public static int Criar(Usuario usuario)
        {
            try
            {
                return UsuarioDAO.Criar(usuario);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static int Editar(Usuario usuario)
        {
            try
            {
                return UsuarioDAO.Editar(usuario);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static Usuario Encontrar(int id)
        {
            try
            {
                return UsuarioDAO.Encontrar(id);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static List<Usuario> Listar()
        {
            try
            {
                return UsuarioDAO.Listar();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static int Remover(Usuario usuario)
        {
            try
            {
                return UsuarioDAO.Remover(usuario);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
