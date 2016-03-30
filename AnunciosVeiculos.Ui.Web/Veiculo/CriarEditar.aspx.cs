using AnunciosVeiculos.BLL;
using System;
using System.Linq;
using System.Web.UI;

namespace AnunciosVeiculos.Ui.Web.Veiculo
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

                    ddlModelo.DataSource = ModeloBO.Listar().OrderBy(x => x.Nome);
                    ddlModelo.DataValueField = "ModeloId";
                    ddlModelo.DataTextField = "Nome";
                    ddlModelo.DataBind();

                    if (!string.IsNullOrEmpty(query))
                    {
                        var id = Convert.ToInt32(query);

                        var veiculo = VeiculoBO.Encontrar(id);

                        if (veiculo == null)
                            throw new Exception("Registro não existe");

                        hidVeiculoId.Value = veiculo.VeiculoId.ToString();
                        ddlModelo.SelectedValue = veiculo.Modelo.ModeloId.ToString();
                        txtAnoFabricacao.Text = veiculo.AnoFabricacao.ToString();
                        txtAnoMod.Text = veiculo.AnoModelo.ToString();
                        txtValor.Text = veiculo.Valor.ToString("F2");
                        txtHodometro.Text = veiculo.Hodometro.ToString();
                        txtDataCadastro.Text = veiculo.DataCadastro.ToString("yyyy-MM-dd");
                    }

                    AtualizarNomeDaMarca();
                }
            }
            catch (Exception)
            {
                Response.Redirect("~/Veiculo/Listar.aspx");
            }
        }

        protected void btnConfirmar_Click(object sender, EventArgs e)
        {
            try
            {
                if (Page.IsValid)
                {
                    var veiculo = new DL.Veiculo
                    {
                        VeiculoId = string.IsNullOrEmpty(hidVeiculoId.Value) ? 0 : Convert.ToInt32(hidVeiculoId.Value),
                        Modelo = ModeloBO.Encontrar(Convert.ToInt32(ddlModelo.SelectedValue)),
                        AnoFabricacao = Convert.ToInt32(txtAnoFabricacao.Text),
                        AnoModelo = Convert.ToInt32(txtAnoMod.Text),
                        Valor = Convert.ToDecimal(txtValor.Text),
                        Hodometro = string.IsNullOrEmpty(txtHodometro.Text) ? 0 : Convert.ToInt32(txtHodometro.Text),
                        DataCadastro = Convert.ToDateTime(txtDataCadastro.Text),
                        Usuario = UsuarioBO.EncontrarPeloLogin(User.Identity.Name)
                    };

                    VeiculoBO.Salvar(veiculo);

                    Response.Redirect("~/Veiculo/Listar.aspx");
                }
            }
            catch (Exception)
            {
                Response.Redirect("~/Veiculo/Listar.aspx");
            }
        }

        protected void ddlModelo_SelectedIndexChanged(object sender, EventArgs e)
        {
            AtualizarNomeDaMarca();
        }

        private void AtualizarNomeDaMarca()
        {
            if (!string.IsNullOrEmpty(ddlModelo.SelectedValue))
            {
                var modelo = ModeloBO.Encontrar(Convert.ToInt32(ddlModelo.SelectedValue));
                txtMarca.Text = modelo.Marca.Nome;
            }
        }
    }
}