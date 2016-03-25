using AnunciosVeiculos.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AnunciosVeiculos.Ui.Web.Usuario
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnConfirmar_Click(object sender, EventArgs e)
        {
            var autenticar = UsuarioBO.Autenticar(txtUsuario.Text, txtSenha.Text);

            if (autenticar)
            {
                FormsAuthentication.RedirectFromLoginPage(txtUsuario.Text, false);
                Response.Redirect("Default.aspx", true);
            }
            else
            {
                Response.Redirect("Login.aspx", true);
            }
        }
    }
}