<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="projectfri.WebForm1" %>

<asp:Content ID="id123" ContentPlaceHolderID="MainContent" runat="server">
    Trainee ID<br/>
    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox><br/>
    <asp:RangeValidator ID="RangeValidator1" runat="server" ErrorMessage="not exceed 9" ForeColor="Red" MaximumValue="9" MinimumValue="1" Type="Integer" ValidationGroup="vshg" ControlToValidate="TextBox1"></asp:RangeValidator><br />
    Trainee name<br/>
    <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox><br/>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Must Include Name" ForeColor="Red" ValidationGroup="vshg" ControlToValidate="TextBox2"></asp:RequiredFieldValidator><br />
    Trainee location<br/>
    <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox><br/>
    Tech Domain<br/>
    <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox><br/>
    StartDate<br/>
    <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox><br/>
    <asp:Button ID="Button1" runat="server" Text="Insert" OnClick="Insert" ValidationGroup="vshg"/>
    <asp:ValidationSummary ID="ValidationSummary1" runat="server" ForeColor="#FF3300" ValidationGroup="vshg" />
    <asp:GridView ID="GridView1" runat="server"></asp:GridView>
    </asp:Content>