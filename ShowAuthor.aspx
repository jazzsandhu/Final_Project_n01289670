<%@ Page Title="" Language="C#" MasterPageFile="~/Layout_page.Master" AutoEventWireup="true" CodeBehind="ShowAuthor.aspx.cs" Inherits="Content_Management_System.ShowAuthor" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="body" runat="server">
    <h2>Author:</h2>
    <div class="table" runat="server">
        <div class="listitem">
            <div class="col5">First Name</div>
            <div class="col5">Last Name</div>
            <div class="col5">Author Number</div>
            <div class="col5">Email Id</div>
        </div>
        <div id="author_result"  runat="server"></div>
    </div>
</asp:Content>
