<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="WebApplication6.WebForm2" %>

<asp:Content ID="id111" ContentPlaceHolderID="MainContent" runat="server">
<div class="jumbotran">
<asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage=" Name must be entered" ForeColor="Red" ValidationGroup="vg">Enter your name</asp:RequiredFieldValidator>
<br />
<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
<br />
<asp:RangeValidator ID="RangeValidator1" runat="server" ErrorMessage="Age between 18 to 60" MaximumValue="60" MinimumValue="18" ValidationGroup="vg" Type="Integer">Enter Age</asp:RangeValidator>
<br />
<asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
<br />

<asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ErrorMessage="Email must be in correct formart" ControlToValidate="TextBox3" ForeColor="Red" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" ValidationGroup="vg">Enter email id</asp:RegularExpressionValidator>
<br />
<asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
<br />
<asp:CompareValidator ID="CompareValidator1" runat="server" ErrorMessage="password must match" ControlToCompare="TextBox3" ControlToValidate="TextBox4" ForeColor="Red" ValidationGroup="vg">confirm password</asp:CompareValidator>
<br />
<asp:TextBox ID="TextBox4" runat="server" TextMode="Password"></asp:TextBox>
<br />
<asp:ValidationSummary ID="ValidationSummary1" runat="server" ForeColor="Red" ValidationGroup="vg" />
<br />
<asp:Button ID="Button1" runat="server" Text="Submit" OnClick="Button1_Click" />
<br />
<asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
</div>

 



</asp:Content>