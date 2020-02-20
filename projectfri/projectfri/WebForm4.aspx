<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="WebForm4.aspx.cs" Inherits="projectfri.WebForm4" %>

<asp:Content ID="id123" ContentPlaceHolderID="MainContent" runat="server">
    <asp:Label ID="Label1" runat="server" Text="Trainee ID"></asp:Label>
    <br/>
    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox><br/>
    
    <asp:Button ID="Button1" runat="server" Text="Show by ID" OnClick="sbyid"/>
    <asp:GridView ID="GridView1" runat="server"></asp:GridView>
    </asp:Content>
