<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SignUp.aspx.cs" Inherits="Movie_Recommendation_System.SignUp" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style2 {
            width: 100%;
            height: 549px;
            margin-bottom: 0px;
        }
        .auto-style6 {
            width: 171px;
            height: 233px;
        }
        .auto-style8 {
            height: 681px;
        }
        .auto-style25 {
            height: 233px;
        }
        .auto-style28 {
            width: 171px;
            height: 46px;
        }
        .auto-style29 {
            height: 46px;
        }
        .auto-style30 {
            height: 81px;
        }
        .auto-style31 {
            width: 171px;
            height: 45px;
        }
        .auto-style32 {
            height: 45px;
        }
        .auto-style33 {
            width: 171px;
            height: 47px;
        }
        .auto-style34 {
            height: 47px;
        }
        .auto-style35 {
            height: 61px;
            background-color: #2F4454;
        }
        .auto-style36 {
            width: 171px;
            height: 79px;
        }
        .auto-style37 {
            height: 79px;
        }
        .auto-style38 {
            border-style: none;
            border-color: inherit;
            border-width: medium;
            color: #000000;
            padding: 16px 20px;
            margin: 8px 0;
            cursor: pointer;
            opacity: 0.9;
            font-family: Arial;
            font-style: normal;
            font-size: large;
            background-color: #2F4454;
        }
        .auto-style39 {
            height: 44px;
        }
    </style>
          <link rel="stylesheet" type="text/css" href="StyleSheet.css" />
</head>
<body style="height: 737px">
    <form id="form1" runat="server" class="auto-style8">
        <table class="auto-style2">
            <tr>
                <td class="auto-style35" colspan="2">
                    <asp:Label ID="Label6" runat="server" Text="MovieStar" Font-Bold="True" Font-Names="Arial" Font-Size="X-Large" ForeColor="White"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style39" colspan="2">
                </td>
            </tr>
            <tr>
                <td class="auto-style30" colspan="2">
                    <asp:Label ID="LabelReg" runat="server" Font-Names="Arial" Font-Size="Large" Text="Registration"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style28">
                    <asp:Label ID="FNameLbl" runat="server" Text="First Name"></asp:Label>
                    :</td>
                <td class="auto-style29">
                    <asp:TextBox ID="FNameTextBox" runat="server" Width="201px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style31">
                    <asp:Label ID="Label1" runat="server" Text="Last Name"></asp:Label>
                </td>
                <td class="auto-style32">
                    <asp:TextBox ID="LNameTextBox" runat="server" Width="200px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style28">
                    <asp:Label ID="Label2" runat="server" Text="Address:"></asp:Label>
                </td>
                <td class="auto-style29">
                    <asp:TextBox ID="AddressTextBox" runat="server" Width="200px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style28">
                    <asp:Label ID="Label3" runat="server" Text="Phone Number:"></asp:Label>
                </td>
                <td class="auto-style29">
                    <asp:TextBox ID="PhoneTextBox" runat="server" Width="200px" MaxLength="11"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style33">
                    <asp:Label ID="Label5" runat="server" Text="Email:"></asp:Label>
                    :</td>
                <td class="auto-style34">
                    <asp:TextBox ID="EmailTextBox" runat="server" Width="200px" TextMode="Email"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style28">
                    <asp:Label ID="Label4" runat="server" Text="Password"></asp:Label>
                    :</td>
                <td class="auto-style29">
                    <asp:TextBox ID="PasswordTextBox" TextMode="Password" runat="server" Width="201px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style28">
                    &nbsp;</td>
                <td class="auto-style29">
                    Already Registered? <asp:LinkButton ID="LinkButton" runat="server" OnClick="LinkButton_Click">Sign In</asp:LinkButton>
                </td>
            </tr>
            <tr>
                <td class="auto-style36">
                    </td>
                <td class="auto-style37">
                    <asp:Button ID="ConfirmButton" runat="server" Height="47px" OnClick="ConfirmButton_Click" Text="Confirm Details" Width="129px" CssClass="auto-style38" Font-Bold="True" Font-Names="Arial" Font-Size="Smaller" ForeColor="White" />
                    <br />
                    <asp:Label ID="LblMessage" runat="server" Text=".."></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style6"></td>
                <td class="auto-style25">
                    &nbsp;</td>
            </tr>
        </table>
    </form>
</body>
</html>
