<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="calcu._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <table>
        <tr>
            <td>
                <asp:Label ID="Label1" runat="server" Text="x"></asp:Label></td>
            <td>
                <asp:TextBox ID="txt_x" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label2" runat="server" Text="y"></asp:Label></td>
            <td>
                <asp:TextBox ID="txt_y" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label3" runat="server" Text="z"></asp:Label></td>
            <td>
                <asp:TextBox ID="txt_z" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label4" runat="server" Text="a"></asp:Label></td>
            <td>
                <asp:TextBox ID="txt_a" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label5" runat="server" Text="b"></asp:Label></td>
            <td>
                <asp:TextBox ID="txt_b" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td>
                <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" />
            </td>
        </tr>
        <tr>
            <td><asp:Label ID="Label6" runat="server" Text="Label"></asp:Label></td>
        </tr>
    </table>
</asp:Content>
