<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="crud._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1>ASP.NET WEBFORM</h1>
        
    </div>

    <div class="row">
        <div class="col-md-4">
            <h2>SHOW DATA</h2>
            
             <p>
                <a class="btn btn-default" href="show.aspx">show student &raquo;</a>
            </p>
             <p>
                <a class="btn btn-default" href="showc.aspx">show course &raquo;</a>
            </p>
             <p>
                <a class="btn btn-default" href="showf.aspx">show faculty &raquo;</a>
            </p>
        </div>
        <div class="col-md-4">
            <h2>INSERT DATA</h2>
            
            
            <p>
                <a class="btn btn-default" href="stuinsert.aspx">student insert &raquo;</a>
            </p>
            <p>
                <a class="btn btn-default" href="couinsert.aspx">insert course &raquo;</a>
            </p>
             <p>
                <a class="btn btn-default" href="Facinsert.aspx">insert Faculty &raquo;</a>
            </p>

        </div>
        <div class="col-md-4">
            <h2>UPDATE DATA</h2>
            
             <p>
                <a class="btn btn-default" href="stuupdate.aspx">student update &raquo;</a>
            </p>
            <p>
                <a class="btn btn-default" href="courseupdate.aspx">course update &raquo;</a>
            </p>
            <p>
                <a class="btn btn-default" href="Facultyupdate.aspx">Faculty update &raquo;</a>
            </p>
            </div>
        <div class="col-md-4">
            <h2>DELETE DATA</h2>
            
             <p>
                <a class="btn btn-default" href="deletestu.aspx">student delete &raquo;</a>
            </p>
             <p>
                <a class="btn btn-default" href="deletecou.aspx">course delete &raquo;</a>
            </p>
             <p>
                <a class="btn btn-default" href="deletefac.aspx">Faculty delete &raquo;</a>
            </p>
            </div>
        <div class="col-md-4">
            <h2>GET BY ID</h2>
             <p>
                <a class="btn btn-default" href="studentbyid.aspx">studnet by id &raquo;</a>
            </p>
             <p>
                <a class="btn btn-default" href="cobyid.aspx">course by id &raquo;</a>
            </p>
             <p>
                <a class="btn btn-default" href="facbyid.aspx">Faculty by id &raquo;</a>
            </p>
        </div>
    </div>

</asp:Content>
