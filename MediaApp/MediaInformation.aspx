<%@ Page Title="Media Information" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="MediaInformation.aspx.cs" Inherits="MediaApp.MediaInformation" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="FeaturedContent" runat="server">
    <div class="content-wrapper">
        <hgroup class="title">
            <h1><%: Title %></h1>
        </hgroup>
        <asp:Label ID="Label1" runat="server" Text="Media Number:"/>
        <asp:TextBox ID="TextBox1" runat="server" ReadOnly="True"/>
        <br/>
        <asp:Label ID="Label2" runat="server" Text="Media Type:"/>
        <asp:TextBox ID="TextBox2" runat="server" ReadOnly="True"/>
        <br/>
        <asp:Label ID="Label3" runat="server" Text="Publisher:"/>
        <asp:TextBox ID="TextBox3" runat="server" ReadOnly="True"/>
        <br/>
        <asp:Label ID="Label4" runat="server" Text="Active:"/>
        <asp:TextBox ID="TextBox4" runat="server" ReadOnly="True"/>
        <br/>
        <asp:Label ID="Label5" runat="server" Text="Donate:"/>
        <asp:TextBox ID="TextBox5" runat="server" ReadOnly="True"/>
        <br/>
        <asp:Label ID="Label6" runat="server" Text="Magazine:"/>
        <asp:TextBox ID="TextBox6" runat="server" ReadOnly="True"/>
        <br/>
        <asp:Label ID="Label7" runat="server" Text="Purchased:"/>
        <asp:TextBox ID="TextBox7" runat="server" ReadOnly="True"/>
        <br/>
        <asp:Button ID="Button1" runat="server" Text="Review Tools Letter" />
        <asp:Button ID="Button2" runat="server" Text="Media Bound Request" />
    </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
</asp:Content>
