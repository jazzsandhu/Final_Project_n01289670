<%@ Page Title="" Language="C#" MasterPageFile="~/Layout_page.Master" AutoEventWireup="true" CodeBehind="Details_of_Page.aspx.cs" Inherits="Content_Management_System.Details_of_Page" %>

<asp:Content ID="Content2" ContentPlaceHolderID="body" runat="server">
    <div class="viewnav">
        <a class="right" href="UpdatePage.aspx?pageid=<%= Request.QueryString["pageid"] %>">Edit</a>
        <div id="dell">
           <asp:Button OnClick="Delete_Page" Text="Delete" runat="server" />
        </div>
       
    </div>
    <div id="D_page" runat="server">
        <h2>Welcome to <span id="page_header_title" runat="server"></span></h2>
         Title:<span id="page_title" runat="server"></span><br />
         Body:<span id="page_body" runat="server"></span><br />
        Author Name: <span id="author_number" runat="server"></span><br />
        Created Date:<span id="created_date" runat="server"></span><br />

    </div>
    
</asp:Content>
