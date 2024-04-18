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
        <%if (isEnterTable)
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
                                <%foreach (var result in Headers)
                                    {  %>
                                <th><%=result %></th>
                                <%} %>
                                <th>Actions</th>
                            </tr>
                        </thead>
                        <tbody>
                            <%int rowCount = Datas.Count / Headers.Count; %>
                            <%for (int i = 0; i < rowCount; i++)
                                {
                                    string itemId = Datas[i * Headers.Count]; %>
                            <tr>
                                <%for (int j = 0; j < Headers.Count; j++)
                                    { %>

                                <td><%=Datas[i*Headers.Count+j]%></td>


                                <%} %>
                                <td>
                                    <a href="EditForm.aspx?id=<%=itemId %>"><i class="fa-solid fa-pen-to-square"></i>Edit</a> |
                                    <a href="DeleteForm.aspx?id=<%=itemId %>"><i class="fa-solid fa-trash" style="color: #ee1127;"></i>Delete</a>
                                </td>
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
