<%@ Page Title="Search" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="SearchForMediaPublisher.aspx.cs" Inherits="MediaApp.SearchForMediaPublisher" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="FeaturedContent" runat="server">
    <div class="content-wrapper">
        <hgroup class="title">
            <h1><%: Title %></h1>
        </hgroup>
        <asp:Label ID="Label1" runat="server" Text="Search By:"/>
        <asp:TextBox ID="TextBox1" runat="server"/>
        <asp:Button ID="Button1" runat="server" Text="Search"/>
        <br/>
        <asp:GridView ID="GridView1" runat="server" Width = "869px" ShowHeaderWhenEmpty="True" AutoGenerateColumns="False" style="margin-top: 0px" >
            <Columns>
                <asp:BoundField HeaderText="Media #" />
                <asp:BoundField HeaderText="Title" />
                <asp:BoundField HeaderText="Publisher" />
                <asp:BoundField HeaderText="Media Type" />
                <asp:BoundField HeaderText="Active" />
                <asp:BoundField HeaderText="Magazine" />
                <asp:BoundField HeaderText="Donate" />
            </Columns>
        </asp:GridView>
    </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
</asp:Content>
