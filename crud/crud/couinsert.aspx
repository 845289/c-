<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="couinsert.aspx.cs" Inherits="crud.couinsert" %>
<asp:Content ID="id1213" ContentPlaceHolderID="MainContent" runat="server">
    Course Id<asp:TextBox ID="TextBox1"  runat="server"></asp:TextBox>
    Course Name<asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
    No of Students<asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>

    <asp:Button ID="Button1" runat="server" Text="Insert" OnClick="Button1_Click" />
    </asp:Content>
