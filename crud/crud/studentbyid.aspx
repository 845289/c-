﻿<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="studentbyid.aspx.cs" Inherits="crud.studentbyid" %>

<asp:Content ID="id1213" ContentPlaceHolderID="MainContent" runat="server">
    student Id<asp:TextBox ID="TextBox1"  runat="server"></asp:TextBox><br />

   
    <asp:Button ID="Button1" runat="server" Text="Get" OnClick="Button1_Click" />
    <asp:GridView ID="GridView1" runat="server"></asp:GridView>
    </asp:Content>