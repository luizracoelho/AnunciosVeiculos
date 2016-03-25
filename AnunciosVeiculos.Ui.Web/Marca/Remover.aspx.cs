using AnunciosVeiculos.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AnunciosVeiculos.Ui.Web.Marca
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

                    var marca = MarcaBO.Encontrar(id);

                    if (marca == null)
                        throw new Exception("Registro não existe");

                    lblMarcaId.Text = marca.MarcaId.ToString();
                    lblNome.Text = marca.Nome;
                    lblDataCadastro.Text = marca.DataCadastro.ToShortDateString();
                }
            }
            catch (Exception)
            {
                Response.Redirect("~/Marca/Listar.aspx");
            }
        }

        protected void btnRemover_Click(object sender, EventArgs e)
        {
            try
            {
                var marca = MarcaBO.Encontrar(Convert.ToInt32(lblMarcaId.Text));

                MarcaBO.Remover(marca);

                Response.Redirect("~/Marca/Listar.aspx");
            }
            catch (Exception)
            {
                Response.Redirect("~/Marca/Listar.aspx");
            }
        }
    }
}