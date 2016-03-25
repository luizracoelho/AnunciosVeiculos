using AnunciosVeiculos.BLL;
using System;

namespace AnunciosVeiculos.Ui.Web.Veiculo
{
    public partial class Listar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Repeater1.DataSource = VeiculoBO.Listar();
            Repeater1.DataBind();
        }
    }
}