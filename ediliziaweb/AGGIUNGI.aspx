<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="AGGIUNGI.aspx.cs" Inherits="ediliziaweb.AGGIUNGI" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <div class="row">
     <div class="col col-12  ">
    <asp:Label ID="Label1" runat="server" Text="NOME"></asp:Label>
    <asp:TextBox ID="NOME" runat="server"></asp:TextBox>
            </div>
  <div class="col col-12">
    <asp:Label ID="Label2" runat="server" Text="COGNOME"></asp:Label>
    <asp:TextBox ID="COGNOME" runat="server"></asp:TextBox>
                  </div>

       <div class="col col-12">
    <asp:Label ID="Label3" runat="server" Text="INDIRIZZO"></asp:Label>
    <asp:TextBox ID="INDIRIZZO" runat="server"></asp:TextBox>
                       </div>

 <div class="col col-12">
    <asp:Label ID="Label4" runat="server" Text="CF"></asp:Label>
    <asp:TextBox ID="CF" runat="server"></asp:TextBox>
                 </div>

      <div class="col col-12">
    <asp:Label ID="Label5" runat="server" Text="SPOSATO"></asp:Label>
    <asp:CheckBox ID="SPOSATO" runat="server" />
                      </div>

 <div class="col col-12">
    <asp:Label ID="Label6" runat="server" Text="NUMEROFIGLI"></asp:Label>
    <asp:TextBox ID="FIGLI" runat="server"></asp:TextBox>
                 </div>

      <div class="col col-12">
    <asp:Label ID="Label7" runat="server" Text="MANSIONE"></asp:Label>
    <asp:TextBox ID="MANSIONE" runat="server"></asp:TextBox>
                      </div>

          
        <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" />
              </div>
        </div>

</asp:Content>
