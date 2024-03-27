<%@ Page Title="" Language="C#" MasterPageFile="~/View/View.Master" AutoEventWireup="true" CodeBehind="FirstPage.aspx.cs" Inherits="CheckDatabaseAspDotNetWeb.View.FirstPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="body" runat="server">
    <h1 class="ml6 text-center mt-5 fs">
        <span class="text-wrapper">
            <span class="letters">Do you want to enter server :
                <asp:Label ID="lblServerName" CssClass="fs-2" runat="server" Text=""></asp:Label></span>
        </span>
    </h1>

    <form id="submitForm" runat="server">
        <div class="text-center mt-4">
            <asp:Button ID="btnNo" runat="server" Text="No" CssClass="btn btn-sm btn-secondary fw-bold" />
            <asp:Button ID="btnYes" runat="server" Text="Yes" CssClass="btn btn-sm btn-secondary fw-bold" OnClick="btnYes_Click" />
        </div>
    </form>
    <div class="mt-4 d-flex justify-content-center">
        <div>
    <%if (isEnterServer)
        {%>
    <table class="table tbl-sm table-secondary">
        <thead >
            <tr>
                <td class="fw-bold">No</td>
                <td class="fw-bold">Table Name</td>
            </tr>
        </thead>
        <tbody>
            <%foreach (var obj in GetTableName())
                {  %>
            <tr>
                <td><%=obj.No %></td>
                <td><%=obj.TableName %></td>
            </tr>
            <%} %>
        </tbody>
    </table>
    <% } %>
</div>
    </div>
</asp:Content>
