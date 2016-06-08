<%@ Page Title="Contact" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CreateRoom.aspx.cs" Inherits="SmartHouse_WebForms.Contact" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <input name="__RequestVerificationToken" type="hidden" value="I78NNOyTyruudIW9Tik_LcYVWo6-TMNAQB9zM2ggGSY5CA2-L043ZwS9o88LQvJJU6rehhKcaTGkyO4UfqQKq46aqm3Q_ydF1s1Sj_UjxK01">
    <div class="form-horizontal">
        <h4>Room</h4>
        <hr />
        <div class="form-group">
            <asp:Label class="control-label col-md-2" ID="Label1" runat="server" Text="Name"></asp:Label>
            <div class="col-md-10">
                <asp:TextBox ID="InputForName" class="form-control text-box single-line" data-val="true" data-val-required="Требуется поле Name." runat="server"></asp:TextBox>
                <span class="field-validation-valid text-danger" data-valmsg-for="Name" data-valmsg-replace="true"></span>
            </div>
        </div>

        <div class="form-group">
            <div class="col-md-offset-2 col-md-10">
                <asp:Button ID="SubmitButton" runat="server"  class="btn btn-default" Text="Create" />
            </div>
        </div>
    </div>

    <div>
        <a href="Default.aspx">Back to List</a>
    </div>

</asp:Content>
