<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="ViewDetails.aspx.cs" Inherits="Movie_Recommendation_System.ViewDetails" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style8 {
            width: 175%;
            height: 948px;
        }
        .auto-style10 {
            height: 76px;
            text-align: center;
            background-color: #CCCCCC;
        }
        .auto-style12 {
            height: 133px;
            text-align: justify;
            width: 313px;
            background-color: #CCCCCC;
        }
        .auto-style13 {
            height: 56px;
            width: 313px;
            background-color: #CCCCCC;
        }
        .auto-style15 {
            width: 532px;
            text-align: center;
            background-color: #CCCCCC;
        }
        .auto-style19 {
            height: 46px;
            width: 532px;
            background-color: #CCCCCC;
        }
        .auto-style20 {
            height: 91px;
            text-align: center;
            width: 313px;
            background-color: #CCCCCC;
        }
        .auto-style21 {
            height: 46px;
            width: 313px;
            background-color: #CCCCCC;
        }
        .auto-style24 {
            height: 279px;
            width: 532px;
            background-color: #CCCCCC;
        }
        .auto-style25 {
            height: 279px;
            width: 313px;
            background-color: #CCCCCC;
        }
        .auto-style26 {
            height: 184px;
            width: 532px;
            text-align: justify;
            background-color: #CCCCCC;
        }
        .auto-style27 {
            height: 184px;
            width: 313px;
            background-color: #CCCCCC;
        }
        .auto-style29 {
            height: 55px;
            width: 313px;
            background-color: #CCCCCC;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
    <br />
</p>
<p>
    <asp:DataList ID="DataList1" runat="server" DataKeyField="MovieID" DataSourceID="SqlDataSource1" OnItemCommand="DataList1_ItemCommand">
        <ItemTemplate>
            <table class="auto-style8">
                <tr>
                    <td class="auto-style10" colspan="2">
                        <asp:Label ID="Label1" runat="server" Text='<%# Eval("MovieTitle") %>'></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style15" rowspan="5">
                        <asp:Image ID="Image1" runat="server" Height="305px" ImageUrl='<%# Eval("MovieImage") %>' Width="318px" />
                    </td>
                    <td class="auto-style29">Average Movie Rating:
                        <asp:Label ID="Label6" runat="server" Text='<%# Eval("MovieRatings") %>'></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style29">Movie ID:
                        <asp:Label ID="Label2" runat="server" Text='<%# Eval("MovieID") %>'></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style12">Movie Description:
                        <asp:Label ID="Label3" runat="server" Text='<%# Eval("MovieDescription") %>'></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style13">Tags:
                        <asp:Label ID="Label4" runat="server" Text='<%# Eval("Tags") %>'></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style20">
                        <asp:Button ID="btnDownload" runat="server" Text="Download" CommandArgument='<%# Eval("MovieID")%>' CommandName="download" />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style19">
                        <asp:Label ID="LblReview" runat="server" Text="User Review:"></asp:Label>
                        &nbsp;<asp:TextBox ID="TextBox1" runat="server" MaxLength="1" Text='<%# Eval("MovieRatings") %>' TextMode="Number"></asp:TextBox>
                        <br />
                        <asp:Button ID="btnSubmit" runat="server" OnClick="btnSubmit_Click" Text="Submit" />
                        <br />
                    </td>
                    <td class="auto-style21"></td>
                </tr>
                <tr>
                    <td class="auto-style26">
                        <br />
                        <br />
                        <br />
                    </td>
                    <td class="auto-style27"></td>
                </tr>
                <tr>
                    <td class="auto-style24"></td>
                    <td class="auto-style25"></td>
                </tr>
            </table>
            <br />
            <br />
        </ItemTemplate>
    </asp:DataList>
    <asp:ListView ID="ListView1" runat="server">
    </asp:ListView>
</p>
<p>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:pw3649fConnectionString %>" SelectCommand="SELECT * FROM [movies] WHERE ([MovieID] = @MovieID)">
        <SelectParameters>
            <asp:QueryStringParameter Name="MovieID" QueryStringField="id" Type="Int32" />
        </SelectParameters>
    </asp:SqlDataSource>
</p>
<p>
    <asp:GridView ID="GridView1" runat="server">
    </asp:GridView>
</p>
<p>
</p>
<p>
</p>
<p>
</p>
</asp:Content>
