<%@ Page Title="" Language="C#" MasterPageFile="~/Layout_page.Master" AutoEventWireup="true" CodeBehind="Create.aspx.cs" Inherits="Content_Management_System.Create" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="body" runat="server">
    <h2>Create your own page</h2>
    <div>
        <label>Page Title:</label>
        <asp:TextBox runat="server" ID="page_title"></asp:TextBox>
    </div>
    <div>
        <label>Page Body:</label>
        <asp:textbox runat="server" ID="page_body"></asp:textbox>
    </div>
    <div>
        <label>Author Number:</label>
        <asp:textbox runat="server" ID="author_number"></asp:textbox>
    </div>
    <div>
        <asp:Button ID="new_page" runat="server" value="Submit" text="Submit" OnClick="Add_Page" />
    </div>
</asp:Content>
