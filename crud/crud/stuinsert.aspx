<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup ="true" CodeBehind="stuinsert.aspx.cs" Inherits="crud.stuinsert" %>

<asp:Content ID="id1213" ContentPlaceHolderID="MainContent" runat="server">
    student Id<asp:TextBox ID="TextBox1"  runat="server"></asp:TextBox><br />

    Student Name<asp:TextBox ID="TextBox2" runat="server"></asp:TextBox><br />
    <asp:Button ID="Button1" runat="server" Text="Insert" OnClick="Button1_Click" />
    </asp:Content>
