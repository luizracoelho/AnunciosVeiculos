using AnunciosVeiculos.BLL;
using System;
using System.Web.UI;

namespace AnunciosVeiculos.Ui.Web.Marca
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

                        var marca = MarcaBO.Encontrar(id);

                        if (marca == null)
                            throw new Exception("Registro não existe");

                        hidMarcaId.Value = marca.MarcaId.ToString();
                        txtNome.Text = marca.Nome;
                        txtDataCadastro.Text = marca.DataCadastro.ToString("yyyy-MM-dd");
                    }
                }
            }
            catch (Exception)
            {
                Response.Redirect("~/Marca/Listar.aspx");
            }
        }

        protected void btnConfirmar_Click(object sender, EventArgs e)
        {
            try
            {
                if (Page.IsValid)
                {
                    var marca = new DL.Marca
                    {
                        MarcaId = string.IsNullOrEmpty(hidMarcaId.Value) ? 0 : Convert.ToInt32(hidMarcaId.Value),
                        Nome = txtNome.Text,
                        DataCadastro = Convert.ToDateTime(txtDataCadastro.Text),
                    };

                    MarcaBO.Salvar(marca);

                    Response.Redirect("~/Marca/Listar.aspx");
                }
            }
            catch (Exception)
            {
                Response.Redirect("~/Marca/Listar.aspx");
            }
        }
    }
}