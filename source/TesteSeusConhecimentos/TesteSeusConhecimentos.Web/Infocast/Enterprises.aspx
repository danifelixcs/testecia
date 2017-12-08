<%@ Page Title="Empresas" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Enterprises.aspx.cs" Inherits="TesteSeusConhecimentos.Web.Infocast.Enterprises" %>


<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">
    <asp:GridView ID="grdEnterprises" AutoGenerateColumns="False" runat="server" CssClass="table table-bordered table-hover"
                  OnRowCommand="grdEnterprises_RowCommand">
        <Columns>
            <asp:TemplateField HeaderText="Codigo">
                <ItemTemplate>
                    <asp:Label ID="tbCodigo" Text='<%# Eval("Id")%>' runat="server" />
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Endereço">
                <ItemTemplate>
                    <asp:Label ID="lbName" Text='<%# Eval("StreetAddress")%>' runat="server" />
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Cidade">
                <ItemTemplate>
                    <asp:Label ID="lbLastName" Text='<%# Eval("City")%>' runat="server" />
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="CEP">
                <ItemTemplate>
                    <asp:Label ID="lbEmail" Text='<%#Eval("ZipCode") %>' runat="server" />
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Atividade Empresarial">
                <ItemTemplate>
                    <asp:Label ID="lbEmail" Text='<%#Eval("CorporateActivity") %>' runat="server" />
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
    <asp:Button ID="btnNovo" runat="server" Text="Nova Empresa" OnClick="btnNovo_Click" />
</asp:Content>