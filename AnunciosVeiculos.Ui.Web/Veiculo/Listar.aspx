<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Listar.aspx.cs" Inherits="AnunciosVeiculos.Ui.Web.Veiculo.Listar" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <a href="CriarEditar.aspx" class="btn btn-success pull-right"><i class="glyphicon glyphicon-plus"></i>Adicionar</a>
    <blockquote>
        Veículos
    </blockquote>

    <hr />

    <asp:Repeater ID="Repeater1" runat="server">
        <HeaderTemplate>
            <table class="table table-striped grid">
                <thead>
                    <tr>
                        <th></th>
                        <th class="text-muted">Id</th>
                        <th>Modelo</th>
                        <th>Marca</th>
                        <th>Ano Fabr.</th>
                        <th>Ano Mod.</th>
                        <th>Valor</th>
                        <th>Hodometro</th>
                        <th>Data de Cadastro</th>
                        <th>Usuário</th>
                    </tr>
                </thead>
                <tbody>
        </HeaderTemplate>
        <ItemTemplate>
            <tr>
                <td>
                    <span class="btn-group btn-group-xs" style="display: inline-flex;">
                        <a href="CriarEditar.aspx?id=<%# DataBinder.Eval(Container.DataItem, "VeiculoId")%>" class="btn btn-primary"><i class="glyphicon glyphicon-pencil"></i></a>
                        <a href="Remover.aspx?id=<%# DataBinder.Eval(Container.DataItem, "VeiculoId")%>" class="btn btn-danger"><i class="glyphicon glyphicon-remove"></i></a>
                    </span>
                </td>
                <td class="text-muted"><%# DataBinder.Eval(Container.DataItem, "VeiculoId") %></td>
                <td><%# DataBinder.Eval(Container.DataItem, "Modelo.Nome") %></td>
                <td><%# DataBinder.Eval(Container.DataItem, "Modelo.Marca.Nome") %></td>
                <td><%# DataBinder.Eval(Container.DataItem, "AnoFabricacao") %></td>
                <td><%# DataBinder.Eval(Container.DataItem, "AnoModelo") %></td>
                <td><%# String.Format("{0:C}", DataBinder.Eval(Container.DataItem, "Valor")) %></td>
                <td><%# String.Format("{0:N0}", DataBinder.Eval(Container.DataItem, "Hodometro")) %></td>
                <td><%# String.Format("{0:dd/MM/yyyy}", DataBinder.Eval(Container.DataItem, "DataCadastro")) %></td>
                <td><%# DataBinder.Eval(Container.DataItem, "Usuario.Nome") %></td>
            </tr>
        </ItemTemplate>
        <AlternatingItemTemplate>
            <tr>
                <td>
                    <span class="btn-group btn-group-xs">
                        <a href="CriarEditar.aspx?id=<%# DataBinder.Eval(Container.DataItem, "VeiculoId")%>" class="btn btn-primary"><i class="glyphicon glyphicon-pencil"></i></a>
                        <a href="Remover.aspx?id=<%# DataBinder.Eval(Container.DataItem, "VeiculoId")%>" class="btn btn-danger"><i class="glyphicon glyphicon-remove"></i></a>
                    </span>
                </td>
                <td class="text-muted"><%# DataBinder.Eval(Container.DataItem, "VeiculoId") %></td>
                <td><%# DataBinder.Eval(Container.DataItem, "Modelo.Nome") %></td>
                <td><%# DataBinder.Eval(Container.DataItem, "Modelo.Marca.Nome") %></td>
                <td><%# DataBinder.Eval(Container.DataItem, "AnoFabricacao") %></td>
                <td><%# DataBinder.Eval(Container.DataItem, "AnoModelo") %></td>
                <td><%# String.Format("{0:C}", DataBinder.Eval(Container.DataItem, "Valor")) %></td>
                <td><%# String.Format("{0:N0}", DataBinder.Eval(Container.DataItem, "Hodometro")) %></td>
                <td><%# String.Format("{0:dd/MM/yyyy}", DataBinder.Eval(Container.DataItem, "DataCadastro")) %></td>
                <td><%# DataBinder.Eval(Container.DataItem, "Usuario.Nome") %></td>
            </tr>
        </AlternatingItemTemplate>
        <FooterTemplate>
            </tbody>
            </table>
        </FooterTemplate>
    </asp:Repeater>
</asp:Content>

