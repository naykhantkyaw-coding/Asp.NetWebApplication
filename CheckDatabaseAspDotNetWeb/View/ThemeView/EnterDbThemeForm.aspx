<%@ Page Title="" Language="C#" MasterPageFile="~/View/ThemeView/Theme.Master" AutoEventWireup="true" CodeBehind="EnterDbThemeForm.aspx.cs" Inherits="CheckDatabaseAspDotNetWeb.View.EnterDbThemeForm" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form id="enterDbForm" runat="server">

        <div class="text-center">
            <h4 class="h3 mb-2 text-gray-800">Please input Database Name.</h4>
            <div class="input-group mb-3 px-2">
                <span class="input-group-text" id="basic-addon1">DB Name : </span>
                <asp:TextBox ID="txtDbName" CssClass="form-control" runat="server" required></asp:TextBox>
            </div>

            <div class="mb-2">
                <asp:Button ID="Button1" CssClass="btn btn-sm btn-primary px-3 fw-bolder" OnClick="btnEnter_Click" runat="server" Text="Enter" />
            </div>
        </div>

        <%if (isEnterDb)
            {  %>
        <div class="card shadow mb-4">
            <div class="card-header py-3">
                <h6 class="m-0 font-weight-bold text-primary">DataTables Example</h6>
            </div>
            <div class="card-body">
                <div class="table-responsive">
                    <table class="table table-bordered" id="dataTableName" width="100%" cellspacing="0">
                        <thead>
                            <tr>
                                <th class="text-start">No</th>
                                <th>Table Names</th>
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
        </div>
        <%} %>
    </form>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="jsScript" runat="server">
    <script>
        new DataTable('#dataTableName', {
            pageLength: 4,
            lengthChange: false
        });
    </script>
</asp:Content>
