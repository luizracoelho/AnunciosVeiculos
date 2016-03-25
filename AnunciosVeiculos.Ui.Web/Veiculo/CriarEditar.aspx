<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="CriarEditar.aspx.cs" Inherits="AnunciosVeiculos.Ui.Web.Veiculo.CriarEditar" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <blockquote>
        Criar/Editar Veículo
    </blockquote>

    <hr />

    <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>

    <asp:HiddenField ID="hidVeiculoId" runat="server" />

    <div class="form-horizontal">
        <div class="form-group">
            <asp:Label ID="Label2" runat="server" Text="Modelo" CssClass="control-label col-md-2"></asp:Label>
            <div class="col-md-4">
                <asp:DropDownList ID="ddlModelo" runat="server" CssClass="form-control" AutoPostBack="True" OnSelectedIndexChanged="ddlModelo_SelectedIndexChanged"></asp:DropDownList>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Campo Obrigatório" ControlToValidate="ddlModelo" CssClass="text-danger" Display="Dynamic"></asp:RequiredFieldValidator>
            </div>
        </div>

        <div class="form-group">
            <asp:Label ID="Label1" runat="server" Text="Marca" CssClass="control-label col-md-2"></asp:Label>
            <div class="col-md-4">
                <asp:TextBox ID="txtMarca" runat="server" CssClass="form-control" disabled="disabled"></asp:TextBox>
            </div>
        </div>

        <div class="form-group">
            <asp:Label ID="Label4" runat="server" Text="Ano de Fabr." CssClass="control-label col-md-2"></asp:Label>
            <div class="col-md-2">
                <asp:TextBox ID="txtAnoFabricacao" TextMode="Number" runat="server" CssClass="form-control"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="Campo Obrigatório" ControlToValidate="txtAnoFabricacao" CssClass="text-danger" Display="Dynamic"></asp:RequiredFieldValidator>
            </div>
        </div>

        <div class="form-group">
            <asp:Label ID="Label5" runat="server" Text="Ano de Mod." CssClass="control-label col-md-2"></asp:Label>
            <div class="col-md-2">
                <asp:TextBox ID="txtAnoMod" TextMode="Number" runat="server" CssClass="form-control"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Campo Obrigatório" ControlToValidate="txtAnoMod" CssClass="text-danger" Display="Dynamic"></asp:RequiredFieldValidator>
            </div>
        </div>

        <div class="form-group">
            <asp:Label ID="Label6" runat="server" Text="Valor" CssClass="control-label col-md-2"></asp:Label>
            <div class="col-md-2">
                <div class="input-group">
                    <span class="input-group-addon">R$</span>
                    <asp:TextBox ID="txtValor" runat="server" CssClass="form-control"></asp:TextBox>
                </div>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ErrorMessage="Campo Obrigatório" ControlToValidate="txtValor" CssClass="text-danger" Display="Dynamic"></asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ErrorMessage="O Valor está em um formato incorreto." ControlToValidate="txtValor" Display="Dynamic" ValidationExpression="(^[0-9]*[1-9]+[0-9]*\,[0-9]*$)|(^[0-9]*\,[0-9]*[1-9]+[0-9]*$)|(^[0-9]*[1-9]+[0-9]*$)" CssClass="text-danger"></asp:RegularExpressionValidator>
            </div>
        </div>

        <div class="form-group">
            <asp:Label ID="Label7" runat="server" Text="Hodômetro" CssClass="control-label col-md-2"></asp:Label>
            <div class="col-md-2">
                <asp:TextBox ID="txtHodometro" TextMode="Number" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
        </div>

        <div class="form-group">
            <asp:Label ID="Label3" runat="server" Text="Data de Cadastro" CssClass="control-label col-md-2"></asp:Label>
            <div class="col-md-2">
                <asp:TextBox ID="txtDataCadastro" TextMode="Date" runat="server" CssClass="form-control"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ErrorMessage="Campo Obrigatório" ControlToValidate="txtDataCadastro" CssClass="text-danger" Display="Dynamic"></asp:RequiredFieldValidator>
            </div>
        </div>

        <div class="form-group">
            <div class="col-md-offset-2 col-md-2">
                <asp:Button ID="btnConfirmar" runat="server" Text="Confirmar" CssClass="btn btn-primary" OnClick="btnConfirmar_Click" />
            </div>
        </div>
    </div>
</asp:Content>



