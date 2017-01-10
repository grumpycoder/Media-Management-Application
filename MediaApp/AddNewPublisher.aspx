<%@ Page Title="Add New Publisher" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AddNewPublisher.aspx.cs" Inherits="MediaApp.AddNewPublisher" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="FeaturedContent" runat="server">
    <div class="content-wrapper">
        <hgroup class="title">
          <h1><%: Title %></h1>
        </hgroup>
        <!--Prefix -->
        <asp:Label ID="Label1" runat="server" Text="Prefix: "/>
        <asp:TextBox ID="TextBox1" runat="server" />
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" ControlToValidate="TextBox1" runat="server" CssClass="field-validation-error" Text="*"></asp:RequiredFieldValidator>
        <br/>
        <!--First Name -->
        <asp:Label ID="Label2" runat="server" Text="First Name: "></asp:Label>
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" ControlToValidate="TextBox2" runat="server" CssClass="field-validation-error" Text="*" ></asp:RequiredFieldValidator>
        <br/>
        <!--Middle Name-->
        <asp:Label ID="Label3" runat="server" Text="Middle Name: "></asp:Label>
        <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" ControlToValidate="TextBox3" runat="server" CssClass="field-validation-error" Text="*" ></asp:RequiredFieldValidator>
        <br/>
        <!--Last Name-->
        <asp:Label ID="Label4" runat="server" Text="Last Name: "></asp:Label>
        <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator4" ControlToValidate="TextBox4" runat="server" CssClass="field-validation-error" Text="*"></asp:RequiredFieldValidator>
        <br/>
        <!--Suffix-->
        <asp:Label ID="Label5" runat="server" Text="Suffix: "></asp:Label>
        <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator5" ControlToValidate="TextBox5" runat="server" CssClass="field-validation-error" Text="*"></asp:RequiredFieldValidator>
        <br/>
        <!--Publication Company-->
        <asp:Label ID="Label6" runat="server" Text="Publication Company: "></asp:Label>
        <asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator6" ControlToValidate="TextBox6" runat="server" CssClass="field-validation-error" Text="*"></asp:RequiredFieldValidator>
        <br/>
        <!--Department-->
        <asp:Label ID="Label7" runat="server" Text="Department: "></asp:Label>
        <asp:TextBox ID="TextBox7" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator7" ControlToValidate="TextBox7" runat="server" CssClass="field-validation-error" Text="*"></asp:RequiredFieldValidator>
        <br/>
        <!--Address1-->
        <asp:Label ID="Label8" runat="server" Text="Address1: "></asp:Label>
        <asp:TextBox ID="TextBox8" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator8" ControlToValidate="TextBox8" runat="server" CssClass="field-validation-error" Text="*"></asp:RequiredFieldValidator>
        <br/>
        <!--Address2-->
        <asp:Label ID="Label9" runat="server" Text="Address2: "></asp:Label>
        <asp:TextBox ID="TextBox9" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator9" ControlToValidate="TextBox9" runat="server" CssClass="field-validation-error" Text="*"></asp:RequiredFieldValidator>
        <br/>
        <!--City-->
        <asp:Label ID="Label10" runat="server" Text="City: "></asp:Label>
        <asp:TextBox ID="TextBox10" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator10" ControlToValidate="TextBox10" runat="server" CssClass="field-validation-error" Text="*"></asp:RequiredFieldValidator>
        <!--State-->
        <asp:Label ID="Label11" runat="server" Text="State: "></asp:Label>
        <asp:DropDownList ID="DropDownList1" runat="server" Width="120px"></asp:DropDownList>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator11" ControlToValidate="DropDownList1" runat="server" CssClass="field-validation-error" Text="*"></asp:RequiredFieldValidator>
        <br/>
        <!--Postal Code (Zip Code)-->
        <asp:Label ID="Label12" runat="server" Text="Postal Code: "></asp:Label>
        <asp:TextBox ID="TextBox11" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator12" ControlToValidate="TextBox11" runat="server" CssClass="field-validation-error" Text="*"></asp:RequiredFieldValidator>
        <br/>
        <!--Fax Number -->
        <asp:Label ID="Label13" runat="server" Text="Fax Number: "></asp:Label>
        <asp:TextBox ID="TextBox12" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator13" ControlToValidate="TextBox12" runat="server" CssClass="field-validation-error" Text="*"></asp:RequiredFieldValidator>
        <br/>
        <!--Phone Number-->
        <asp:Label ID="Label14" runat="server" Text="Phone Number: "></asp:Label>
        <asp:TextBox ID="TextBox13" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator14" ControlToValidate="TextBox13" runat="server" CssClass="field-validation-error" Text="*"></asp:RequiredFieldValidator>
        <br/>
        <!--Website -->
        <asp:Label ID="Label15" runat="server" Text="Website: "></asp:Label>
        <asp:TextBox ID="TextBox14" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator15" ControlToValidate="TextBox14" runat="server" CssClass="field-validation-error" Text="*"></asp:RequiredFieldValidator>
        <br/>
        <!--Email Address -->
        <asp:Label ID="Label16" runat="server" Text="Email Address: "></asp:Label>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator16" runat="server" ControlToValidate="TextBox15" CssClass="field-validation-error" Text="*"></asp:RequiredFieldValidator>
        <asp:TextBox ID="TextBox15" runat="server" OnTextChanged="TextBox15_TextChanged"></asp:TextBox>
        
        <br/>
        <!--Buttons-->
        <asp:Button ID="Button1" runat="server" Text="Submit" />
        <asp:Button ID="Button2" runat="server" Text="Clear"  CausesValidation="False" />
    </div>
 </asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
</asp:Content>
