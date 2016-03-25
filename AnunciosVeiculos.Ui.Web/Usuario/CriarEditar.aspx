<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="CriarEditar.aspx.cs" Inherits="AnunciosVeiculos.Ui.Web.Usuario.CriarEditar" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <blockquote>
        Criar/Editar Usuário
    </blockquote>

    <hr />

    <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>

    <asp:HiddenField ID="hidUsuarioId" runat="server" />

    <div class="form-horizontal">
        <div class="form-group">
            <asp:Label ID="Label1" runat="server" Text="Nome" CssClass="control-label col-md-2"></asp:Label>
            <div class="col-md-4">
                <asp:TextBox ID="txtNome" runat="server" CssClass="form-control"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Campo Obrigatório" ControlToValidate="txtNome" CssClass="text-danger" Display="Dynamic"></asp:RequiredFieldValidator>
            </div>
        </div>

        <div class="form-group">
            <asp:Label ID="Label2" runat="server" Text="Login" CssClass="control-label col-md-2"></asp:Label>
            <div class="col-md-2">
                <asp:TextBox ID="txtLogin" runat="server" CssClass="form-control"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Campo Obrigatório" ControlToValidate="txtLogin" CssClass="text-danger" Display="Dynamic"></asp:RequiredFieldValidator>
            </div>
        </div>

        <div class="form-group">
            <asp:Label ID="Label5" runat="server" Text="Senha" CssClass="control-label col-md-2"></asp:Label>
            <div class="col-md-2">
                <asp:TextBox TextMode="Password" ID="txtSenha" runat="server" CssClass="form-control"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="Campo Obrigatório" ControlToValidate="txtSenha" CssClass="text-danger" Display="Dynamic"></asp:RequiredFieldValidator>
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
            <asp:Label ID="Label4" runat="server" Text="E-mail" CssClass="control-label col-md-2"></asp:Label>
            <div class="col-md-4">
                <asp:TextBox ID="txtEmail" TextMode="Email" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
        </div>

        <div class="form-group">
            <div class="col-md-offset-2 col-md-2">
                <asp:Button ID="btnConfirmar" runat="server" Text="Confirmar" CssClass="btn btn-primary" OnClick="btnConfirmar_Click" />
            </div>
        </div>
    </div>
</asp:Content>

