<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="DeviceControl.ascx.cs" Inherits="SmartHouse_WebForms.Controls.DeviceControl" %>
<div class="col-xs-2 col-xs-offset-2 col-xs-pull-1">
    <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
    <asp:Image ID="img" class="img-responsive"  runat="server" />
    <asp:Button ID="OnOff" runat="server" Text="On/Off" CssClass="payt-label" Width="134px" />
    <asp:PlaceHolder ID="PlaceHolder1" runat="server"></asp:PlaceHolder>
    <asp:Button ID="Rename" runat="server" class="btn btn-default btn-block" Text="Rename" />
    <asp:Button ID="Delete" runat="server" class="btn btn-default btn-block" Text="Delete" />
</div>
