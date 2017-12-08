<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="InfoRelationship.aspx.cs" Inherits="TesteSeusConhecimentos.Web.Infocast.InfoRelationship" %>

<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">
    <div class="form-width"> 
        <h2 id="formStatus"  runat="server">Relacionar</h2>
        <div class="form-group">
            <asp:Label ID="lbEnterprise" runat="server" Text="Label">Empresa:</asp:Label>
            <asp:DropDownList runat="server" id="ddlEnterprise"/>
        </div>
        <div class="form-group">
            <asp:Label ID="lbUser" runat="server" Text="Label">Usuário:</asp:Label>
            <asp:DropDownList runat="server" id="ddlUser"/>
        </div>
        <div class="form-group">
            <asp:Button ID="btnSalvar" runat="server" Text="Salvar" OnClick="btnSalvar_Click" />
        </div>
    </div>
</asp:Content>
