<%@ Page Title="" Language="C#" MasterPageFile="~/Layout_page.Master" AutoEventWireup="true" CodeBehind="HTTP_Page.aspx.cs" Inherits="Content_Management_System.HTTP_Page" %>

<asp:Content ID="Page_list" ContentPlaceHolderID="body" runat="server">
    <div id="create">
        <a href="https://localhost:44398/ShowAuthor.aspx" id="au_btn">Author</a>
        <a href="https://localhost:44398/Create.aspx" id="c_btn">Create More</a>
        <label>Search:</label>
        <asp:TextBox ID="search_box" runat="server"></asp:TextBox>
        <asp:Button runat="server" Text="submit" />
    </div>
    <h2>Check our work here:</h2>
    <div class="table" runat="server">
        <div class="listitem">
            <div class="col5">Title</div>
            <div class="col5">Body</div>
            <div class="col5">Author Name</div>
            <div class="col5">Created_Date</div>
            <div class="col5last">Action</div>
        </div>
        <div id="page_result"  runat="server"></div>
    </div>
</asp:Content>
