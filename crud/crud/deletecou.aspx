<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="deletecou.aspx.cs" Inherits="crud.deletecou" %>

<asp:Content ID="id1213" ContentPlaceHolderID="MainContent" runat="server">
    Course Id<asp:TextBox ID="TextBox1"  runat="server"></asp:TextBox>
    

    <asp:Button ID="Button1" runat="server" Text="Delete" OnClick="Button1_Click" />
    </asp:Content>