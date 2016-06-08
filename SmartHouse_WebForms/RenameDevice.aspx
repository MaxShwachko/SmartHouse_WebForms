<%@ Page Language="C#" AutoEventWireup="true"  MasterPageFile="~/Site.Master" CodeBehind="RenameDevice.aspx.cs" Inherits="SmartHouse_WebForms.RenameDevice" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <input name="__RequestVerificationToken" type="hidden" value="A0XS0dVR8916grtgmMpbpB9MilF2NIUdiH1t5aPROt_9AMWBv22WjZPMHM2u762s6txL9Oz3cOarXjHe6GhTYihq8ZLXfQAtFCiYYVFVNu41">
    <div class="form-horizontal">
        <h4>Device</h4>
        <hr />
        <input data-val="true" data-val-number="The field Id must be a number." data-val-required="Требуется поле Id." id="Id" name="Id" type="hidden" value="10">
        <div class="form-group">
            <asp:label class="control-label col-md-2" runat="server" text="Name"></asp:label>
            <div class="col-md-10">
                <asp:textbox id="DeviceName" class="form-control text-box single-line" data-val="true" data-val-required="Требуется поле Name." runat="server"></asp:textbox>

                <span class="field-validation-valid text-danger" data-valmsg-for="Name" data-valmsg-replace="true"></span>
            </div>
        </div>
        <div class="form-group">
            <div class="col-md-offset-2 col-md-10">
                <asp:button id="SubmitButton" runat="server" class="btn btn-default" text="Save" />
            </div>
        </div>
    </div>
<div>
    <a href="RoomInfo.aspx">Cancel</a>
</div>
</asp:Content>
