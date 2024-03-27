<%@ Page Title="" Language="C#" MasterPageFile="~/View/View.Master" AutoEventWireup="true" CodeBehind="FirstPage.aspx.cs" Inherits="CheckDatabaseAspDotNetWeb.View.FirstPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="body" runat="server">
    <h1 class="ml6 text-center mt-3 fs">
        <span class="text-wrapper">
            <span class="letters">Do you want to enter server :
                <asp:Label ID="lblServerName" CssClass="fs-2" runat="server" Text=""></asp:Label></span>
        </span>
    </h1>
</asp:Content>
