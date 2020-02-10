<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication6.WebForm1" %>
<asp:Content ID="id124" ContentPlaceHolderID="MainContent" runat="server" >
    <div class="jumbotran">
        </div>
    <asp:Label ID="Label1" runat="server" Text="Enter name"></asp:Label>
    <br/>
    <asp:TextBox ID="txtname" runat="server"></asp:TextBox>
    <br/>
    <asp:Label ID="Label2" runat="server" Text="Enter Date of Birth"></asp:Label>
    <br/>

    <asp:Calendar ID="Calendar1" runat="server"></asp:Calendar>
    <asp:Label ID="Label3" runat="server" Text="Enter Gender" ></asp:Label>
    <br/>
    <asp:RadioButtonList ID="RadioButtonList" runat="server">
        <asp:ListItem>female</asp:ListItem>
        <asp:ListItem>male</asp:ListItem>
    </asp:RadioButtonList>
    <br/>
    <asp:Label ID="Label4" runat="server" Text="Tick mark Hobbies"></asp:Label>
        <br/>
    <asp:CheckBoxList ID="CheckBoxList1" runat="server">
        <asp:ListItem>Travelling</asp:ListItem>
        <asp:ListItem>Reading </asp:ListItem>
        <asp:ListItem>Swimming</asp:ListItem>
        <asp:ListItem>Playing</asp:ListItem>
        <asp:ListItem>Cooking</asp:ListItem>
    </asp:CheckBoxList>
    <br/>
    <asp:Label ID="Label15" runat="server" Text="Education"></asp:Label>
    <asp:DropDownList ID="DropDownList" runat="server">
        <asp:ListItem>High School</asp:ListItem>
        <asp:ListItem>Pre University</asp:ListItem>
        <asp:ListItem>Graduation</asp:ListItem>
        <asp:ListItem>Post Graduation</asp:ListItem>
    </asp:DropDownList>
    <br/>
    <asp:Button ID="Button1" runat="server" Text="Submit" OnClick="Submit_Click" />
    <div class="jumbotran">
        </div>
    </asp:Content>