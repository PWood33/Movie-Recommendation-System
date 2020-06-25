<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="Admin.aspx.cs" Inherits="Movie_Recommendation_System.Admin" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style5 {
            width: 100%;
            height: 369px;
            margin-top: 0px;
        }
        .auto-style6 {
            height: 195px;
        }
        .auto-style7 {
            width: 101%;
            height: 244px;
        }
        .auto-style8 {
            height: 39px;
        }
        .auto-style11 {
            height: 39px;
            width: 641px;
        }
        .auto-style12 {
            height: 195px;
            width: 641px;
        }
        .auto-style13 {
            width: 641px;
        }
        .auto-style15 {
            width: 184px;
        }
        .auto-style16 {
            width: 184px;
            height: 18px;
        }
        .auto-style17 {
            height: 18px;
        }
        .auto-style18 {
            text-align: center;
        }
        .auto-style19 {
            width: 184px;
            height: 28px;
        }
        .auto-style20 {
            height: 28px;
        }
        .auto-style21 {
            width: 184px;
            height: 31px;
        }
        .auto-style22 {
            height: 31px;
        }
        .auto-style23 {
            width: 184px;
            height: 30px;
        }
        .auto-style24 {
            height: 30px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" runat="server" contentplaceholderid="ContentPlaceHolder2">
    <tr>
        <td>
    <br />
<br />
<br />
<br />
    <table class="auto-style5">
        <tr>
            <td class="auto-style11"></td>
            <td class="auto-style8">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style12">
                <asp:Panel ID="Panel1" runat="server" Height="270px">
                    <table class="auto-style7">
                        <tr>
                            <td class="auto-style15">Category:</td>
                            <td>
                                <asp:DropDownList ID="DropDownList1" runat="server" DataSourceID="SqlDataSource1" DataTextField="CategoryID" DataValueField="CategoryID">
                                </asp:DropDownList>
                                <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:pw3649fConnectionString %>" SelectCommand="SELECT * FROM [category]"></asp:SqlDataSource>
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style19">Genre</td>
                            <td class="auto-style20">
                                <asp:DropDownList ID="DropDownList2" runat="server" DataSourceID="SqlDataSource2" DataTextField="GenreID" DataValueField="GenreID">
                                </asp:DropDownList>
                                <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:pw3649fConnectionString %>" SelectCommand="SELECT * FROM [genre]"></asp:SqlDataSource>
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style15">&nbsp;</td>
                            <td>&nbsp;</td>
                        </tr>
                        <tr>
                            <td class="auto-style23">
                                <asp:Label ID="Label2" runat="server" Text="Movie Title"></asp:Label>
                            </td>
                            <td class="auto-style24">
                                <asp:TextBox ID="txtMovie" runat="server"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style21">
                                <asp:Label ID="Label3" runat="server" Text="Movie Description"></asp:Label>
                            </td>
                            <td class="auto-style22">
                                <asp:TextBox ID="txtMovdes" runat="server"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style21">
                                <asp:Label ID="Label4" runat="server" Text="MovieImage"></asp:Label>
                            </td>
                            <td class="auto-style22">
                                <asp:FileUpload ID="imageUpload" runat="server" />
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style16">Tags:</td>
                            <td class="auto-style17">
                                <asp:TextBox ID="txtmovtags" runat="server"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style18" colspan="2">
                                <asp:Button ID="btnAddMovie" runat="server" OnClick="btnAddMovie_Click" Text="Add" />
                            </td>
                        </tr>
                    </table>
                </asp:Panel>
            </td>
            <td class="auto-style6"></td>
        </tr>
        <tr>
            <td class="auto-style13">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
    </table>
<br />
<br />
<br />
<br />
<br />
<p>
</p>
        </td>
    </tr>
</asp:Content>

