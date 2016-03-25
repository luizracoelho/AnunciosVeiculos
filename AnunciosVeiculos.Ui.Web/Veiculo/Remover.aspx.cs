using AnunciosVeiculos.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AnunciosVeiculos.Ui.Web.Veiculo
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

                    var veiculo = VeiculoBO.Encontrar(id);

                    if (veiculo == null)
                        throw new Exception("Registro não existe");

                    lblVeiculoId.Text = veiculo.VeiculoId.ToString();
                    lblModelo.Text = veiculo.Modelo.Nome;
                    lblMarca.Text = veiculo.Modelo.Marca.Nome;
                    lblAnoFabricacao.Text = veiculo.AnoFabricacao.ToString();
                    lblAnoMod.Text = veiculo.AnoModelo.ToString();
                    lblValor.Text = veiculo.Valor.ToString("C");
                    lblHodometro.Text = veiculo.Hodometro.ToString("N0");
                    lblDataCadastro.Text = veiculo.DataCadastro.ToShortDateString();
                    lblUsuario.Text = veiculo.Usuario.Nome;
                }
            }
            catch (Exception)
            {
                Response.Redirect("~/Veiculo/Listar.aspx");
            }
        }

        protected void btnRemover_Click(object sender, EventArgs e)
        {
            try
            {
                var veiculo = VeiculoBO.Encontrar(Convert.ToInt32(lblVeiculoId.Text));

                VeiculoBO.Remover(veiculo);

                Response.Redirect("~/Veiculo/Listar.aspx");
            }
            catch (Exception)
            {
                Response.Redirect("~/Veiculo/Listar.aspx");
            }
        }
    }
}