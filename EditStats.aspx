<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="EditStats.aspx.cs" Inherits="HockeyVladyslavBanasko.EditStats" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
        Edit Statistics</p>
    <p>
        <asp:Label ID="lblName" runat="server" Text="Input name"></asp:Label>
&nbsp;<asp:TextBox ID="txtboxName" runat="server"></asp:TextBox>
&nbsp;<asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtboxName" ErrorMessage="Name is required" ForeColor="Red"></asp:RequiredFieldValidator>
    </p>
    <p>
        <asp:Button ID="btnSearch" runat="server" OnClick="btnSearch_Click" Text="Search" />
    </p>
    <asp:RadioButtonList ID="rblistNames" runat="server">
    </asp:RadioButtonList>
    <p>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtboxName" ErrorMessage="Choose Player" ForeColor="Red"></asp:RequiredFieldValidator>
    </p>
    <p>
        <asp:Label ID="lblMathesPlayed" runat="server" Text="Mathes Played"></asp:Label>
&nbsp;<asp:TextBox ID="txtboxMathesPlayed" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txtboxMathesPlayed" ErrorMessage="RequiredField" ForeColor="Red"></asp:RequiredFieldValidator>
    </p>
    <p>
&nbsp;<asp:Label ID="lblMathesWon" runat="server" Text="Mathes Won"></asp:Label>
&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtboxMathesWon" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="txtboxMathesWon" ErrorMessage="RequiredField" ForeColor="Red"></asp:RequiredFieldValidator>
        <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="txtboxMathesPlayed" ControlToValidate="txtboxMathesWon" ErrorMessage="Can't be nore then played matches" ForeColor="Red" Operator="LessThan" Type="Integer"></asp:CompareValidator>
    </p>
    <p>
        <asp:Label ID="lblAssists" runat="server" Text="Assists"></asp:Label>
&nbsp;<asp:TextBox ID="txtboxAssists" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="txtboxAssists" ErrorMessage="RequiredField" ForeColor="Red"></asp:RequiredFieldValidator>
    </p>
    <p>
        <asp:Label ID="lblGoals" runat="server" Text="Goals"></asp:Label>
&nbsp;<asp:TextBox ID="txtboxGoals" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="txtboxGoals" ErrorMessage="RequiredField" ForeColor="Red"></asp:RequiredFieldValidator>
    </p>
    <p>
        <asp:Button ID="btnUpdate" runat="server" Text="Update " OnClick="btnUpdate_Click" />
&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnDelete" runat="server" Text="Delete" OnClick="btnDelete_Click" />
    </p>
    <p>
        <asp:Label ID="Label1" runat="server"></asp:Label>
    </p>
    <p>
        &nbsp;</p>
</asp:Content>
