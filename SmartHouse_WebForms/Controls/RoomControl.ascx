<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="RoomControl.ascx.cs" Inherits="SmartHouse_WebForms.Controlls.RoomControl" %>
<div class="col-xs-2 col-xs-offset-2 col-xs-pull-1">
    <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
    <asp:ImageButton ID="ImageButton1" class="img-responsive" runat="server" />
    <p></p>
    <asp:Button ID="RenameButton" runat="server" class="btn btn-default btn-block" Text="Rename" />
    <asp:Button ID="DeleteButton" runat="server" class="btn btn-default btn-block" Text="Delete" />
</div>