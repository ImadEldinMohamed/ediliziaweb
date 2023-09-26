<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="aggiungiPagamenti.aspx.cs" Inherits="ediliziaweb.aggiungiPagamenti" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="container">
    <div class="row">
        <div class="col-12 ">
            <h2>Inserisci un  Pagamento</h2>
        </div>
        <div class="col-12">
            <p class="h2">Data:</p>
            <asp:TextBox ID="Date" runat="server" CssClass="form-control w-50" TextMode="Date"></asp:TextBox>
        </div>
        <div class="col-12 ">
            <p class="h2">ammontare:</p>
            <asp:TextBox ID="IMPORTO" runat="server" CssClass="form-control w-50"></asp:TextBox>
        </div>
        <div class="col-12 ">
            <p class="h2 ">Stipendio:</p>
            <asp:CheckBox ID="Stipendio" runat="server" />
        </div>
         <div class="col-12 ">
     <p class="h2">id:</p>
     <asp:TextBox ID="IDDIP" runat="server" CssClass="form-control w-50"></asp:TextBox>
 </div>
         <div class="col-12 ">
            <asp:Button ID="button55" runat="server" Text="aggingi" CssClass="btn btn-outline-success my-5 w-50"    OnClick="InsertButton_Click"/>
        </div>
    </div>
</div>

</asp:Content>
