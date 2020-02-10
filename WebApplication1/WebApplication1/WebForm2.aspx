<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="WebApplication1.WebForm2" %>

<asp:Content ID="cont1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="jumbotran">
        <asp:Label ID="Label1" Text="res_name" runat="server"></asp:Label>
        <asp:TextBox ID="TextBox1" runat="server" Height="22px" Width="128px"></asp:TextBox>
        <asp:Label ID="Label2" Text="res_location" runat="server"></asp:Label>
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        <asp:Label ID="Label3" Text="res_timings" runat="server"></asp:Label>
        <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
        <asp:Label ID="Label4" Text="res_close" runat="server"></asp:Label>
        <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
        <asp:Button ID="Button1" OnClick="Button-Click" runat="server" Text="insert"/>
        </div>
</asp:Content>
