using AnunciosVeiculos.BLL;
using System;

namespace AnunciosVeiculos.Ui.Web.Usuario
{
    public partial class Listar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Repeater1.DataSource = UsuarioBO.Listar();
            Repeater1.DataBind();
        }
    }
}