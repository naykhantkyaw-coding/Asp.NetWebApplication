<%@ Page Title="" Language="C#" MasterPageFile="~/View/Theme.Master" AutoEventWireup="true" CodeBehind="ThemeForm.aspx.cs" Inherits="CheckDatabaseAspDotNetWeb.View.ThemeForm" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <form id="formSubmit" runat="server">

        <div class="text-center">
            <h4 class="h3 mb-0 text-gray-800">Do you want to enter server : 
        <asp:Label ID="lblServerName" CssClass="text-gray-800" runat="server" Text=""></asp:Label></h4>
        </div>

        <div class="text-center mt-4 mb-4">
            <asp:Button ID="btnNo" runat="server" Text="No" CssClass="btn btn-sm btn-danger fw-boler px-5" />
            <asp:Button ID="btnYes" runat="server" Text="Yes" CssClass="btn btn-sm btn-primary fw-bolder px-5" OnClick="btnYes_Click" />
        </div>

    </form>

    <%if (isEnterServer)
        {  %>
    <div class="card shadow mb-4">
        <div class="card-header py-3">
            <h6 class="m-0 font-weight-bold text-primary">DataTables Example</h6>
        </div>
        <div class="card-body">
            <div class="table-responsive">
                <table class="table table-bordered" id="dataTable" width="100%" cellspacing="0">
                    <thead>
                        <tr>
                            <th class="text-start">No</th>
                            <th>Db Names</th>
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
            </div>
        </div>
    </div>
    <%} %>
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="jsScript" runat="server">
    <script>
        new DataTable('#dataTable', {
            pageLength: 4,
            lengthChange: false
        });
    </script>
</asp:Content>
