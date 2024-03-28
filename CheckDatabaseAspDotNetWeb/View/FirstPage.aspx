<%@ Page Title="" Language="C#" MasterPageFile="~/View/View.Master" AutoEventWireup="true" CodeBehind="FirstPage.aspx.cs" Inherits="CheckDatabaseAspDotNetWeb.View.FirstPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="body" runat="server">
    <%--<h1 class="ml6 text-center mt-5 fs">
        <span class="text-wrapper">
            <span class="letters">Do you want to enter server :
                <asp:Label ID="lblServerName" CssClass="fs-2" runat="server" Text=""></asp:Label></span>
        </span>
    </h1>--%>

    <h4 class="text-center text-white mt-5">Do you want to enter server :
        <asp:Label ID="lblServerName" CssClass="fs-5" runat="server" Text=""></asp:Label>
    </h4>

    <form id="submitForm" runat="server">
        <div class="text-center mt-4">
            <asp:Button ID="btnNo" runat="server" Text="No" CssClass="btn btn-sm btn-secondary fw-bold" />
            <asp:Button ID="btnYes" runat="server" Text="Yes" CssClass="btn btn-sm btn-secondary fw-bold" OnClick="btnYes_Click" />
        </div>



        <div class="mt-4 d-flex justify-content-center">
            <div>
                <%if (isEnterServer)
                    {%>
                <table class="table tbl-sm table-secondary">
                    <thead>
                        <tr>
                            <td class="fw-bold">No</td>
                            <td class="fw-bold">Database Name</td>
                        </tr>
                    </thead>
                    <tbody>
                        <%foreach (var obj in GetDbName())
                            {  %>
                        <tr>
                            <td><%=obj.No %></td>
                            <td><%=obj.DbName %></td>
                        </tr>
                        <%} %>
                    </tbody>
                </table>
                <% }%>
            </div>
        </div>

        <%if (isEnterServer)
            {  %>
        <h4 class="text-center text-white mt-5">Please enter database name.</h4>
        <div class="container">
            <div class="row justify-content-center">
                <div class="col-4">
                    <div class="input-group ">
                        <span class="input-group-text fw-bold" id="basic-addon1">Db Name :</span>
                        <asp:TextBox CssClass="form-control" ID="txtdbName" runat="server" required></asp:TextBox>
                    </div>
                </div>
            </div>
        </div>
        <div class="text-center mt-3">
            <asp:Button ID="btnEnter" runat="server" Text="Enter" CssClass="btn btn-sm btn-secondary fw-bold mb-3" OnClick="btnEnter_Click" />
        </div>
        <%}%>
        <%if (isEnterDb)
            {  %>
        <div class="d-flex justify-content-center">
            <div>
                <table class="table tbl-sm table-secondary">
                    <thead>
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
            </div>
        </div>
        <%} %>
    </form>
</asp:Content>
