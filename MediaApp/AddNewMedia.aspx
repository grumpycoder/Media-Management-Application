<%@ Page Title="Add New Media" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AddNewMedia.aspx.cs" Inherits="MediaApp.AddNewMedia" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="FeaturedContent" runat="server">
    <div class="content-wrapper">
            <hgroup class="title">
                <h1><%: Title %></h1>
            </hgroup>
        
        <asp:Label ID="Label1" runat="server" Text="Media Number: "></asp:Label>
        <asp:TextBox ID="TextBox1" runat="server" ></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" Display="Dynamic"
        ControlToValidate="TextBox1" CssClass="field-validation-error" Text="*"></asp:RequiredFieldValidator>
        <br/>
        <asp:Label ID="Label2" runat="server" Text="Media Title: "></asp:Label>
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" Display="Dynamic"
        ControlToValidate="TextBox2" CssClass="field-validation-error" Text="*"></asp:RequiredFieldValidator>
        <br/>
        <asp:Label ID="Label9" runat="server" Text="Publisher: "></asp:Label>
        <asp:DropDownList ID="DropDownList3" runat="server" Width="120px" ></asp:DropDownList>
         <asp:RequiredFieldValidator ID="RequiredFieldValidator9" runat="server" Display="Dynamic"
        ControlToValidate="DropDownList3" CssClass="field-validation-error" Text="*"></asp:RequiredFieldValidator>
        <br/>
        <br/>
        <asp:Label ID="Label3" runat="server" Text="Receipt Date: "></asp:Label>
        <asp:DropDownList ID="DropDownList1" runat="server" Width="120px" ></asp:DropDownList>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" Display="Dynamic"
        ControlToValidate="DropDownList1" CssClass="field-validation-error" Text="*"></asp:RequiredFieldValidator>
        <br/>
        <br/>
        <asp:Label ID="Label4" runat="server" Text="Media Type: "></asp:Label>
        <asp:DropDownList ID="DropDownList2" runat="server" Width="120px" ></asp:DropDownList>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" Display="Dynamic"
        ControlToValidate="DropDownList2" CssClass="field-validation-error" Text="*"></asp:RequiredFieldValidator>
        <br/>
        <br/>
        <asp:Label ID="Label5" runat="server" Text="Purchased: " />
        <asp:RadioButtonList ID="RadioButtonList1" runat="server" RepeatDirection="Horizontal" RepeatLayout="Table" CssClass="radioButtonLists" >
            <asp:ListItem>Yes</asp:ListItem>
            <asp:ListItem>No</asp:ListItem>
         </asp:RadioButtonList>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" Display="Dynamic"
        ControlToValidate="RadioButtonList1" CssClass="field-validation-error" Text="*"></asp:RequiredFieldValidator>
        <br/>
        <asp:Label ID="Label6" runat="server" Text="Active:"></asp:Label>
        <asp:RadioButtonList ID="RadioButtonList2" runat="server" RepeatDirection="Horizontal" RepeatLayout="Table" CssClass="radioButtonLists">
            <asp:ListItem>Yes</asp:ListItem>
            <asp:ListItem>No</asp:ListItem>
        </asp:RadioButtonList>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" Display="Dynamic"
        ControlToValidate="RadioButtonList2" CssClass="field-validation-error" Text="*"></asp:RequiredFieldValidator>
        <br/>
        <asp:Label ID="Label7" runat="server" Text="Magazine:"></asp:Label>
        <asp:RadioButtonList ID="RadioButtonList3" runat="server" RepeatDirection="Horizontal" RepeatLayout="Table" CssClass="radioButtonLists">
            <asp:ListItem>Yes</asp:ListItem>
            <asp:ListItem>No</asp:ListItem>
        </asp:RadioButtonList>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" Display="Dynamic"
        ControlToValidate="RadioButtonList3" CssClass="field-validation-error" Text="*"></asp:RequiredFieldValidator>
        <br/>
        <asp:Label ID="Label8" runat="server" Text="Donate:"></asp:Label>
        <asp:RadioButtonList ID="RadioButtonList4" runat="server" RepeatDirection="Horizontal" RepeatLayout="Table" CssClass="radioButtonLists">
            <asp:ListItem>Yes</asp:ListItem>
            <asp:ListItem>No</asp:ListItem>
        </asp:RadioButtonList>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server" Display="Dynamic"
        ControlToValidate="RadioButtonList4" CssClass="field-validation-error" Text="*"></asp:RequiredFieldValidator>
        <br/>
        <asp:Button ID="Button1" runat="server" Text="Submit"/>
        <asp:Button ID="Button2" runat="server" Text="Clear" OnClick="Button2_Click" />
        
     </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
</asp:Content>
