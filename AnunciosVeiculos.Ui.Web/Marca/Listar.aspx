<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Listar.aspx.cs" Inherits="AnunciosVeiculos.Ui.Web.Marca.Listar" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <a href="CriarEditar.aspx" class="btn btn-success pull-right"><i class="glyphicon glyphicon-plus"></i>Adicionar</a>
    <blockquote>
        Marcas
    </blockquote>

    <hr />

    <asp:Repeater ID="Repeater1" runat="server">
        <HeaderTemplate>
            <table class="table table-striped grid">
                <thead>
                    <tr>
                        <th></th>
                        <th class="text-muted">Id</th>
                        <th>Nome</th>
                        <th>Data de Cadastro</th>
                    </tr>
                </thead>
                <tbody>
        </HeaderTemplate>
        <ItemTemplate>
            <tr>
                <td>
                    <span class="btn-group btn-group-xs">
                        <a href="CriarEditar.aspx?id=<%# DataBinder.Eval(Container.DataItem, "MarcaId")%>" class="btn btn-primary"><i class="glyphicon glyphicon-pencil"></i></a>
                        <a href="Remover.aspx?id=<%# DataBinder.Eval(Container.DataItem, "MarcaId")%>" class="btn btn-danger"><i class="glyphicon glyphicon-remove"></i></a>
                    </span>
                </td>
                <td class="text-muted"><%# DataBinder.Eval(Container.DataItem, "MarcaId") %></td>
                <td><%# DataBinder.Eval(Container.DataItem, "Nome") %></td>
                <td><%# String.Format("{0:dd/MM/yyyy}", DataBinder.Eval(Container.DataItem, "DataCadastro")) %></td>
            </tr>
        </ItemTemplate>
        <AlternatingItemTemplate>
            <tr>
                <td>
                    <span class="btn-group btn-group-xs">
                        <a href="CriarEditar.aspx?id=<%# DataBinder.Eval(Container.DataItem, "MarcaId")%>" class="btn btn-primary"><i class="glyphicon glyphicon-pencil"></i></a>
                        <a href="Remover.aspx?id=<%# DataBinder.Eval(Container.DataItem, "MarcaId")%>" class="btn btn-danger"><i class="glyphicon glyphicon-remove"></i></a>
                    </span>
                </td>
                <td class="text-muted"><%# DataBinder.Eval(Container.DataItem, "MarcaId") %></td>
                <td><%# DataBinder.Eval(Container.DataItem, "Nome") %></td>
                <td><%# String.Format("{0:dd/MM/yyyy}", DataBinder.Eval(Container.DataItem, "DataCadastro")) %></td>
            </tr>
        </AlternatingItemTemplate>
        <FooterTemplate>
            </tbody>
            </table>
        </FooterTemplate>
    </asp:Repeater>
</asp:Content>

