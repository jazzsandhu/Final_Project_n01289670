<%@ Page Title="" Language="C#" MasterPageFile="~/Layout_page.Master" AutoEventWireup="true" CodeBehind="UpdatePage.aspx.cs" Inherits="Content_Management_System.UpdatePage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="body" runat="server">
    <div id="update">
    <h2>Update Page <span runat="server" id="page_title"></span></h2>
        
        <div class="row">
            <label>Page Title</label>
            <asp:TextBox runat="server" ID="pageTitle"></asp:TextBox>
        </div>
        <div class="row">
            <label>Page Body</label>
            <asp:TextBox runat="server" ID="page_body"></asp:TextBox>
        </div>
        <div class="row">
            <label>Author Name:</label>
            <asp:TextBox runat="server" ID="author_number"></asp:TextBox>
        </div>
    
       <%-- <div class="row">
            <label>Created Date</label>
            <asp:TextBox runat="server" ID="created_date"></asp:TextBox>
        </div>--%>
    <div>
        <asp:Button runat="server" ID="edit_button" Text="Update" OnClick="Update_Page" />
    </div>
        </div>
</asp:Content>
