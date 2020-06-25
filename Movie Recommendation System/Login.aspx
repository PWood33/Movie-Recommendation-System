<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Movie_Recommendation_System.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
            height: 507px;
            margin-top: 0px;
        }
        .auto-style2 {
            height: 55px;
            background-color:#2F4454;
        }
       
        .auto-style4 {
            width: 100%;
            height: 331px;
        }
        .auto-style7 {
            height: 32px;
            width: 206px;
        }
        .auto-style8 {
            width: 206px;
            height: 539px;
        }
        .auto-style9 {
            height: 37px;
        }
        .auto-style10 {
            height: 361px;
        }
        .auto-style11 {
            height: 37px;
            width: 446px;
        }
        .auto-style12 {
            height: 361px;
            width: 446px;
        }
        .auto-style13 {
            width: 446px;
        }
        .auto-style14 {
            height: 539px;
        }
        .auto-style15 {
            width: 100%;
            height: 337px;
        }
        .auto-style16 {
            height: 48px;
            background-color: #2F4454;
        }
        .auto-style19 {
            height: 79px;
            text-align: left;
        }
        .auto-style20 {
            width: 169px;
        }
    </style>
       <link rel="stylesheet" type="text/css" href="StyleSheet.css" />
</head>
<body style="height: 736px">
    <form id="form1" runat="server">
    <table class="auto-style1">
        <tr>
            <td class="auto-style2" colspan="3">
                <asp:Label ID="Label2" runat="server" Text="MovieStar" Font-Bold="True" Font-Names="Arial" Font-Size="X-Large" ForeColor="White"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style7"></td>
            <td class="auto-style3"></td>
            <td class="auto-style3"></td>
        </tr>
        <tr>
            <td class="auto-style8"></td>
            <td class="auto-style14">
                <table class="auto-style4">
                    <tr>
                        <td class="auto-style9"></td>
                        <td class="auto-style11"></td>
                        <td class="auto-style9"></td>
                    </tr>
                    <tr>
                        <td class="auto-style10"></td>
                        <td class="auto-style12">
                            <asp:Panel ID="LoginPanel" runat="server" Height="342px" BorderStyle="Groove">
                                <table class="auto-style15">
                                    <tr>
                                        <td class="auto-style16" colspan="2">
                                            <asp:Label ID="LoginLabel" runat="server" CssClass="Loginlabel" Text="Login" ForeColor="White"></asp:Label>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td class="auto-style20">
                                            <asp:Label ID="Label1" runat="server" Text="Email:"></asp:Label>
                                        </td>
                                        <td>
                                            <asp:TextBox ID="EmailTextBox" runat="server" Width="210px" TextMode="Email"></asp:TextBox>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td class="auto-style20">
                                            <asp:Label ID="lblPassword" runat="server" Text="Password:"></asp:Label>
                                        </td>
                                        <td>
                                            <asp:TextBox ID="PasswordTextBox" TextMode="Password" runat="server" Width="210px"></asp:TextBox>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td class="auto-style20">Not registered?
                                            <asp:LinkButton ID="LBSignup" runat="server" OnClick="LBSignup_Click">SignUp</asp:LinkButton>
                                            </td>
                                        <td>&nbsp;</td>
                                    </tr>
                                    <tr>
                                         <td class="auto-style19" colspan="2">
                                        <asp:Button ID="Button1" runat="server" CssClass="Loginbutton" Text="Login" OnClick="LoginButton_Click" ForeColor="White"/>
                                             <br />
                                             <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Admin" />
                                             <br />
                                             <asp:Label ID="LblMessage1" runat="server" Text="..."></asp:Label>
                                        </td>
                                    </tr>
                                </table>
                            </asp:Panel>
                        </td>
                        <td class="auto-style10"></td>
                    </tr>
                    <tr>
                        <td>&nbsp;</td>
                        <td class="auto-style13">&nbsp;</td>
                        <td>&nbsp;</td>
                    </tr>
                </table>
            </td>
            <td class="auto-style14"></td>
        </tr>
    </table>
    </form>
    </body>
</html>
