<%@ Page Language="C#" Title="Relacionamentos"  MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Relationships.aspx.cs" Inherits="TesteSeusConhecimentos.Web.Infocast.Relationships" %>

<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">
    <asp:GridView ID="grdRelationships" AutoGenerateColumns="False" runat="server" CssClass="table table-bordered table-hover"
                  OnRowCommand="grdRelationships_RowCommand">
        <Columns>
            <asp:TemplateField HeaderText="Codigo">
                <ItemTemplate>
                    <asp:Label ID="tbCodigo" Text='<%# Eval("Id")%>' runat="server" />
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Usuário">
                <ItemTemplate>
                    <asp:Label ID="lbEmail" Text='<%#Eval("User.Name") %>' runat="server" />
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Atividade Empresarial">
                <ItemTemplate>
                    <asp:Label ID="Label1" Text='<%#Eval("Enterprise.CorporateActivity") %>' runat="server" />
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Opções">
                <ItemTemplate>
                    <asp:Button runat="server" ID="deleteButtom" Text="Excluir" CommandName="Remove" CommandArgument='<%#Eval("Id")%>' />
                    <asp:Button runat="server" ID="editButtom" Text="Editar" CommandName="Edit" CommandArgument='<%#Eval("Id")%>' />
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>
    </asp:GridView>
    <asp:Button ID="btnNovo" runat="server" Text="Relacionar" OnClick="btnNovo_Click" />
</asp:Content>
