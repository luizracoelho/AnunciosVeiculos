using AnunciosVeiculos.BLL;
using System;

namespace AnunciosVeiculos.Ui.Web.Modelo
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

                    var modelo = ModeloBO.Encontrar(id);

                    if (modelo == null)
                        throw new Exception("Registro não existe");

                    lblModeloId.Text = modelo.ModeloId.ToString();
                    lblNome.Text = modelo.Nome;
                    lblDataCadastro.Text = modelo.DataCadastro.ToShortDateString();
                    lblMarca.Text = modelo.Marca.Nome;
                }
            }
            catch (Exception)
            {
                Response.Redirect("~/Modelo/Listar.aspx");
            }
        }

        protected void btnRemover_Click(object sender, EventArgs e)
        {
            try
            {
                var modelo = ModeloBO.Encontrar(Convert.ToInt32(lblModeloId.Text));

                ModeloBO.Remover(modelo);

                Response.Redirect("~/Modelo/Listar.aspx");
            }
            catch (Exception)
            {
                Response.Redirect("~/Modelo/Listar.aspx");
            }
        }
    }
}