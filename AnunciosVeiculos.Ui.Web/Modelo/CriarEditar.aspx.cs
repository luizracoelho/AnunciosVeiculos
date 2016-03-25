using AnunciosVeiculos.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AnunciosVeiculos.Ui.Web.Modelo
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

                    ddlMarca.DataSource = MarcaBO.Listar().OrderBy(x=>x.Nome);
                    ddlMarca.DataValueField = "MarcaId";
                    ddlMarca.DataTextField = "Nome";
                    ddlMarca.DataBind();

                    if (!string.IsNullOrEmpty(query))
                    {
                        var id = Convert.ToInt32(query);

                        var modelo = ModeloBO.Encontrar(id);

                        if (modelo == null)
                            throw new Exception("Registro não existe");

                        hidModeloId.Value = modelo.ModeloId.ToString();
                        txtNome.Text = modelo.Nome;
                        txtDataCadastro.Text = modelo.DataCadastro.ToString("yyyy-MM-dd");
                        ddlMarca.SelectedValue = modelo.Marca.MarcaId.ToString();
                    }
                }
            }
            catch (Exception)
            {
                Response.Redirect("~/Modelo/Listar.aspx");
            }
        }

        protected void btnConfirmar_Click(object sender, EventArgs e)
        {
            try
            {
                if (Page.IsValid)
                {
                    var modelo = new DL.Modelo
                    {
                        ModeloId = string.IsNullOrEmpty(hidModeloId.Value) ? 0 : Convert.ToInt32(hidModeloId.Value),
                        Nome = txtNome.Text,
                        DataCadastro = Convert.ToDateTime(txtDataCadastro.Text),
                        Marca = MarcaBO.Encontrar(Convert.ToInt32(ddlMarca.SelectedValue))
                    };

                    ModeloBO.Salvar(modelo);

                    Response.Redirect("~/Modelo/Listar.aspx");
                }
            }
            catch (Exception)
            {
                Response.Redirect("~/Modelo/Listar.aspx");
            }
        }
    }
}