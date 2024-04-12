<%@ Page Title="" Language="C#" MasterPageFile="~/View/ThemeView/Theme.Master" AutoEventWireup="true" CodeBehind="EnterTable.aspx.cs" Inherits="CheckDatabaseAspDotNetWeb.View.ThemeView.EnterTable" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form id="enterTableForm" runat="server">
        <div class="text-center">
            <h4 class="h3 mb-2 text-gray-800">Please input Database Name and Table Name.</h4>
            <div class="input-group mb-3 px-2">
                <span class="input-group-text" id="basic-addon1">DB Name : </span>
                <asp:TextBox ID="txtDbName" CssClass="form-control" runat="server" required></asp:TextBox>
            </div>
            <div class="input-group mb-3 px-2">
                <span class="input-group-text" id="basic-addon1">Table Name : </span>
                <asp:TextBox ID="txtTableName" CssClass="form-control" runat="server" required></asp:TextBox>
            </div>
            <div class="mb-2">
                <asp:Button ID="btnEnterTable" CssClass="btn btn-sm btn-primary px-3 fw-bolder" OnClick="btnEnterTable_Click" runat="server" Text="Enter" />
            </div>
        </div>
    </form>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="jsScript" runat="server">
</asp:Content>
