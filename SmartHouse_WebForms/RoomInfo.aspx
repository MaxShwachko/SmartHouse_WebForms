<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="RoomInfo.aspx.cs" Inherits="SmartHouse_WebForms.RoomInfo" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

<p>
    <hr /> 
    <a href="CreateDevice.aspx" class="btn btn-default btn-block">Create New</a>
    <%--<a href="CreateDevice.aspx" class="btn btn-default btn-block">Create New</a>--%>
</p>
<div class="row">
    <div class="col-xs-10 col-xs-offset-1">
        <asp:PlaceHolder ID="PlaceHolder1" runat="server" />
    </div>
</div>

    <script></script>
</asp:Content>