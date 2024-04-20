<%@ Page Title="" Language="C#" MasterPageFile="~/View/ThemeView/Theme.Master" AutoEventWireup="true" CodeBehind="EditForm.aspx.cs" Inherits="CheckDatabaseAspDotNetWeb.View.ThemeView.EditForm" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form id="form1" runat="server">
        <div class="text-center">
            <div class="input-group mb-3 px-2">
                <%for (int i = 0; i < resModel.Headers.Count; i++)
                    { %>
                <span class="input-group-text" id="basic-addon1"><%=resModel.Headers[i] %> </span>
                <%  } %>
                
                <asp:PlaceHolder ID="PlaceHolder1" runat="server"></asp:PlaceHolder>
                <%-- <span class="input-group-text" id="basic-addon1">DB Name : </span>
        <asp:TextBox ID="txtDbName" CssClass="form-control" runat="server" required></asp:TextBox>--%>
            </div>
        </div>
    </form>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="jsScript" runat="server">
</asp:Content>
