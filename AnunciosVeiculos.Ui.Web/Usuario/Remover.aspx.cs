using AnunciosVeiculos.BLL;
using System;

namespace AnunciosVeiculos.Ui.Web.Usuario
{
    public partial class Remover : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (!IsPostBack)
                {
                    var query = Request.QueryString["id"];

                    if (string.IsNullOrEmpty(query))
                        throw new Exception("Registro não existe");

                    var id = Convert.ToInt32(query);

                    var usuario = UsuarioBO.Encontrar(id);

                    if (usuario == null)
                        throw new Exception("Registro não existe");

                    lblUsuarioId.Text = usuario.UsuarioId.ToString();
                    lblNome.Text = usuario.Nome;
                    lblLogin.Text = usuario.Login;
                    lblDataCadastro.Text = usuario.DataCadastro.ToShortDateString();
                    lblEmail.Text = usuario.Email;
                }
            }
            catch (Exception)
            {
                Response.Redirect("~/Usuario/Listar.aspx");
            }
        }

        protected void btnRemover_Click(object sender, EventArgs e)
        {
            try
            {
                var usuario = UsuarioBO.Encontrar(Convert.ToInt32(lblUsuarioId.Text));

                UsuarioBO.Remover(usuario);

                Response.Redirect("~/Usuario/Listar.aspx");
            }
            catch (Exception)
            {
                Response.Redirect("~/Usuario/Listar.aspx");
            }
        }
    }
}