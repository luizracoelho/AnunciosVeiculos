<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Remover.aspx.cs" Inherits="AnunciosVeiculos.Ui.Web.Veiculo.Remover" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <blockquote>
        Remover Veículo
    </blockquote>

    <hr />

    <asp:scriptmanager id="ScriptManager1" runat="server"></asp:scriptmanager>
    <dl class="dl-horizontal">
        <dt class="text-muted">Id</dt>
        <dd class="text-muted">
            <asp:label id="lblVeiculoId" runat="server" text=""></asp:label>
        </dd>
        <dt>Modelo</dt>
        <dd>
            <asp:label id="lblModelo" runat="server" text=""></asp:label>
        </dd>
        <dt>Marca</dt>
        <dd>
            <asp:label id="lblMarca" runat="server" text=""></asp:label>
        </dd>
        <dt>Ano de Fabr.</dt>
        <dd>
            <asp:label id="lblAnoFabricacao" runat="server" text=""></asp:label>
        </dd>
        <dt>Ano de Mod.</dt>
        <dd>
            <asp:label id="lblAnoMod" runat="server" text=""></asp:label>
        </dd>
        <dt>Valor</dt>
        <dd>
            <asp:label id="lblValor" runat="server" text=""></asp:label>
        </dd>
        <dt>Hodômetro</dt>
        <dd>
            <asp:label id="lblHodometro" runat="server" text=""></asp:label>
        </dd>
        <dt>Data de Cadastro</dt>
        <dd>
            <asp:label id="lblDataCadastro" runat="server" text=""></asp:label>
        </dd>
        <dt>Usuário</dt>
        <dd>
            <asp:label id="lblUsuario" runat="server" text=""></asp:label>
        </dd>
    </dl>

    <asp:button id="btnRemover" runat="server" text="Remover" cssclass="btn btn-danger" onclick="btnRemover_Click" />
</asp:Content>

