using AnunciosVeiculos.DAL;
using AnunciosVeiculos.DL;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AnunciosVeiculos.BLL
{
    public class UsuarioBO
    {
        public static int Salvar(Usuario usuario)
        {
            try
            {
                if (usuario.UsuarioId == 0)
                    return Criar(usuario);
                else
                    return Editar(usuario);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static bool Autenticar(string nomeUsuario, string senha)
        {
            try
            {
                var usuario = EncontrarPeloLogin(nomeUsuario);

                if (usuario == null)
                    return false;

                if (!usuario.Senha.Trim().Equals(senha))
                    return false;

                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }

        private static int Criar(Usuario usuario)
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

        private static int Editar(Usuario usuario)
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

        public static Usuario EncontrarPeloLogin(string nomeUsuario)
        {
            try
            {
                return Listar().FirstOrDefault(x => x.Login.Equals(nomeUsuario));
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
