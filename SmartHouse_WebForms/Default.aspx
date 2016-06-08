<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="SmartHouse_WebForms._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

<p>
    <hr /> 
    <a href="CreateRoom.aspx" class="btn btn-default btn-block">Create New</a>
</p>
<div class="row">
    <div class="col-xs-10 col-xs-offset-1">
        <asp:PlaceHolder ID="PlaceHolder1" runat="server" />
    </div>
</div>

</asp:Content>
