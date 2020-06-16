<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="EditPlayer.aspx.cs" Inherits="HockeyVladyslavBanasko.EditPlayer" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    Edit Player<br />
    <asp:Label ID="lblName" runat="server" Text="Input name"></asp:Label>
&nbsp;<asp:TextBox ID="txtboxName" runat="server" AutoPostBack="True" style="height: 25px"></asp:TextBox>
&nbsp;<asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtboxName" ErrorMessage="Name is required" ForeColor="Red"></asp:RequiredFieldValidator>
    <br />
    <asp:Button ID="btn1" runat="server" OnClick="btn1_Click" Text="Search" />
    <br />
    <br />
    <asp:RadioButtonList ID="rblistNames" runat="server">
    </asp:RadioButtonList>
    <br />
    <br />
&nbsp;<asp:Label ID="lblNewName" runat="server" Text="New Name"></asp:Label>
&nbsp;<asp:TextBox ID="txtboxNewName" runat="server"></asp:TextBox>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtboxNewName" ErrorMessage="RequiredField" ForeColor="Red"></asp:RequiredFieldValidator>
    <br />
    <asp:Label ID="lblNewNumber" runat="server" Text="New Number"></asp:Label>
    <asp:TextBox ID="txtboxNewNumber" runat="server"></asp:TextBox>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txtboxNewNumber" ErrorMessage="RequiredField" ForeColor="Red"></asp:RequiredFieldValidator>
    <br />
    <br />
    <asp:Button ID="btnUpdate" runat="server" Text="Update " OnClick="btnUpdate_Click" />
&nbsp;&nbsp;&nbsp;
    <asp:Button ID="btnDelete" runat="server" Text="Delete" OnClick="btnDelete_Click" />
    <br />
    <br />
    <br />
    <br />
&nbsp;
</asp:Content>
