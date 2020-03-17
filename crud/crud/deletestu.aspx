<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="deletestu.aspx.cs" Inherits="crud.deletestu" %>

<asp:Content ID="id1213" ContentPlaceHolderID="MainContent" runat="server">
    student Id<asp:TextBox ID="TextBox1"  runat="server"></asp:TextBox><br />

   
    <asp:Button ID="Button1" runat="server" Text="Delete" OnClick="Button1_Click" />
    </asp:Content>