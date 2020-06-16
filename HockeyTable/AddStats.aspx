<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="AddStats.aspx.cs" Inherits="HockeyVladyslavBanasko.AddStats" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
        Add Statistics
    </p>
    <p>
        &nbsp;</p>
    <p>
        Player
        <asp:DropDownList ID="ddlPlayers" runat="server">
        </asp:DropDownList>
    </p>
    <p>
        <asp:Label ID="lblMatchesPlayed" runat="server" Text="Matches Played"></asp:Label>
&nbsp;<asp:TextBox ID="txtboxMathesPlayed" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtboxMathesPlayed" ErrorMessage="required" ForeColor="Red"></asp:RequiredFieldValidator>
    </p>
    <p>
&nbsp;<asp:Label ID="lblMatchesWon" runat="server" Text="Matches Won"></asp:Label>
&nbsp;<asp:TextBox ID="txtboxMathesWon" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtboxMathesWon" ErrorMessage="required" ForeColor="Red"></asp:RequiredFieldValidator>
        <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="txtboxMathesPlayed" ControlToValidate="txtboxMathesWon" ErrorMessage="Can't be more then matches played" ForeColor="Red" Operator="LessThanEqual" Type="Integer"></asp:CompareValidator>
    </p>
    <p>
        <asp:Label ID="lblAssists" runat="server" Text="Assists"></asp:Label>
&nbsp;<asp:TextBox ID="txtboxAssists" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txtboxAssists" ErrorMessage="required" ForeColor="Red"></asp:RequiredFieldValidator>
    </p>
    <p>
        <asp:Label ID="lblGoals" runat="server" Text="Goals"></asp:Label>
&nbsp;<asp:TextBox ID="txtboxGoals" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="txtboxGoals" ErrorMessage="required" ForeColor="Red"></asp:RequiredFieldValidator>
    </p>
    <asp:Button ID="btnAdd" runat="server" Text="Add" OnClick="btnAdd_Click" />
    <br />
    <asp:Label ID="Label1" runat="server"></asp:Label>
    <br />
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
</asp:Content>
