<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="MediaApp._Default" %>

<asp:Content runat="server" ID="FeaturedContent" ContentPlaceHolderID="FeaturedContent">
    <section>
        <div class="content-wrapper">
            <hgroup class="title">
                <h1><%: Title %>.</h1>
                <h2>Please select one of the options below:</h2>
            </hgroup>
            
        </div>
    </section>
</asp:Content>
<asp:Content runat="server" ID="BodyContent"  ContentPlaceHolderID="MainContent">
       
        <asp:Button OnClick="Button1_OnClick" CssClass="MenuButtons"  ID="Button1" runat="server" BorderStyle="none" Height="50px"  Text="Add New Publisher"  /> 
        <asp:Button OnClick="Button2_OnClick" CssClass="MenuButtons" ID="Button2" runat="server" BorderStyle="none" Height="50px"  Text="Search for Media/Publisher" />
        <asp:Button OnClick="Button3_OnClick" CssClass="MenuButtons" ID="Button3" runat="server" BorderStyle="none" Height="50px" Text="Add New Media" />
        
</asp:Content>
