﻿<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Facinsert.aspx.cs" Inherits="crud.Facinsert" %>

<asp:Content ID="id1213" ContentPlaceHolderID="MainContent" runat="server">
    Faculty Id<asp:TextBox ID="TextBox1"  runat="server"></asp:TextBox>
    Faculty Name<asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
    <asp:Button ID="Button1" runat="server" Text="Insert" OnClick="Button1_Click" />
    </asp:Content>