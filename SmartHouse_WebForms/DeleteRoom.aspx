<%@ Page Title="About" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="DeleteRoom.aspx.cs" Inherits="SmartHouse_WebForms.About" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <h3>Are you sure you want to delete this?</h3>
    <div>
        <h4>Room</h4>
        <hr />
        <input data-val="true" data-val-number="The field Id must be a number." data-val-required="Требуется поле Id." id="Id" name="Id" type="hidden" value="10">
        <dl class="dl-horizontal">
            <dt>
                <asp:Label class="control-label col-md-2" ID="Label1" runat="server" Text="Name"></asp:Label>
            </dt>
            <dd>
                <asp:Label class="control-label col-md-2" ID="Label2" runat="server" Text="Name"></asp:Label>
            </dd>
        </dl>
        <input name="__RequestVerificationToken" type="hidden" value="psN1X8H_cCMtZExml4mLcXpMHx_KFMYGQXSJxpudYIORi2ybRF6iPp5Y5tM7DXIAkScr86LhUzOVPdrCEtk29yQAX0Fotj4Fc0piQYRopXQ1">
        <div class="form-actions no-color">
            <input type="submit" value="Delete" class="btn btn-default" /> |
            <a href="Default.aspx">Cancel</a>
        </div>
    </div>
</asp:Content>
