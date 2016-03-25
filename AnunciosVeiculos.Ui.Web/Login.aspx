<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="AnunciosVeiculos.Ui.Web.Usuario.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Login Anúncios Veículos</title>

    <script src='<%= ResolveUrl("~/scripts/jquery-1.11.3.min.js") %>'></script>
    <script src='<%= ResolveUrl("~/scripts/bootstrap.min.js") %>'></script>
    <script src='<%= ResolveUrl("~/scripts/jquery.dataTables.min.js") %>'></script>
    <script src='<%= ResolveUrl("~/scripts/dataTables.bootstrap.min.js") %>'></script>

    <link href="Content/bootstrap.min.css" rel="stylesheet" />
    <link href="Content/jquery.dataTables.min.css" rel="stylesheet" />
    <link href="Content/dataTables.bootstrap.min.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <br />

        <div class="container">
            <div class="col-md-4 col-md-offset-4 col-sm-6 col-sm-offset-3 col-xs-10 col-xs-offset-1">

                <ul class="breadcrumb">
                    <li><i class="glyphicon glyphicon-lock"></i> Autenticação</li>
                </ul>

                <div class="form-horizontal">
                    <div class="form-group">
                        <asp:Label ID="Label3" runat="server" Text="Login" CssClass="control-label col-md-2"></asp:Label>
                        <div class="col-md-10">
                            <asp:TextBox ID="txtUsuario" runat="server" CssClass="form-control"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ErrorMessage="Campo Obrigatório" ControlToValidate="txtUsuario" CssClass="text-danger" Display="Dynamic"></asp:RequiredFieldValidator>
                        </div>
                    </div>

                    <div class="form-group">
                        <asp:Label ID="Label1" runat="server" Text="Senha" CssClass="control-label col-md-2"></asp:Label>
                        <div class="col-md-10">
                            <asp:TextBox ID="txtSenha" TextMode="Password" runat="server" CssClass="form-control"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Campo Obrigatório" ControlToValidate="txtSenha" CssClass="text-danger" Display="Dynamic"></asp:RequiredFieldValidator>
                        </div>
                    </div>

                    <div class="form-group">
                        <div class="col-md-offset-2 col-md-2">
                            <asp:Button ID="btnConfirmar" runat="server" Text="Entrar" CssClass="btn btn-primary" OnClick="btnConfirmar_Click" />
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </form>
</body>
</html>
