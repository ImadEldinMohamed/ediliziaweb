<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="ediliziaweb.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <asp:GridView ID="GridView12" runat="server" CssClass="table table-bordered"   AutoGenerateColumns="false"  ItemType="ediliziaweb.classi.Dipendenti"  >

         <Columns>
            <asp:TemplateField>
                <HeaderTemplate>
                    <strong>Nome</strong>
                </HeaderTemplate>
                <ItemTemplate>
                    <%#Item.Nome %>
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>

         <Columns>
            <asp:TemplateField>
                <HeaderTemplate>
                    <strong>cognome</strong>
                </HeaderTemplate>
                <ItemTemplate>
                    <%#Item.Cognome %>
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>

         <Columns>
            <asp:TemplateField>
                <HeaderTemplate>
                    <strong>indirizzo</strong>
                </HeaderTemplate>
                <ItemTemplate>
                    <%#Item.Indirizzo %>
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>
         <Columns>
            <asp:TemplateField>
                <HeaderTemplate>
                    <strong>mansione</strong>
                </HeaderTemplate>
                <ItemTemplate>
                    <%#Item.Mansione %>
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>
         <Columns>
            <asp:TemplateField>
                <ItemTemplate>
                    <asp:Button ID="pagamento" runat="server" Text=" Pagamento" CssClass="btn btn-primary" CommandArgument="<%# Item.IDdipendente %>"   OnClick="pagamento_Click" />
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>
      

    </asp:GridView>


</asp:Content>
