using AnunciosVeiculos.BLL;
using System;
using System.Web.UI;

namespace AnunciosVeiculos.Ui.Web.Usuario
{
    public partial class CriarEditar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (!IsPostBack)
                {
                    var query = Request.QueryString["id"];

                    if (!string.IsNullOrEmpty(query))
                    {
                        var id = Convert.ToInt32(query);

                        var usuario = UsuarioBO.Encontrar(id);

                        if (usuario == null)
                            throw new Exception("Registro não existe");

                        hidUsuarioId.Value = usuario.UsuarioId.ToString();
                        txtNome.Text = usuario.Nome;
                        txtLogin.Text = usuario.Login;
                        txtDataCadastro.Text = usuario.DataCadastro.ToString("yyyy-MM-dd");
                        txtEmail.Text = usuario.Email;
                    }
                }
            }
            catch (Exception)
            {
                Response.Redirect("~/Usuario/Listar.aspx");
            }
        }

        protected void btnConfirmar_Click(object sender, EventArgs e)
        {
            try
            {
                if (Page.IsValid)
                {
                    var usuario = new DL.Usuario
                    {
                        UsuarioId = string.IsNullOrEmpty(hidUsuarioId.Value) ? 0 : Convert.ToInt32(hidUsuarioId.Value),
                        Nome = txtNome.Text,
                        Login = txtLogin.Text,
                        Senha = txtSenha.Text,
                        DataCadastro = Convert.ToDateTime(txtDataCadastro.Text),
                        Email = txtEmail.Text
                    };

                    UsuarioBO.Salvar(usuario);

                    Response.Redirect("~/Usuario/Listar.aspx");
                }
            }
            catch (Exception)
            {
                Response.Redirect("~/Usuario/Listar.aspx");
            }
        }
    }
}