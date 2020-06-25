<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Recommendations.aspx.cs" Inherits="Movie_Recommendation_System.Recommendations" %>
<asp:Content ID="Content1" runat="server" contentplaceholderid="ContentPlaceHolder1">
    <p>
        <br />
        <asp:DataList ID="DataList1" runat="server">
        </asp:DataList>
    </p>
    <p>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server"></asp:SqlDataSource>
    </p>
    <p>
        <asp:LinqDataSource ID="LinqDataSource1" runat="server">
        </asp:LinqDataSource>
    </p>
<p>
        <asp:Label ID="Label2" runat="server" Text="Top Rated Movies"></asp:Label>
    </p>
    <p>
        <asp:GridView ID="GridViewRec" runat="server" Height="145px" OnRowDataBound="GridViewRec_RowDataBound" Width="320px" OnRowCommand="GridViewRec_RowCommand" OnRowCreated="GridViewRec_RowCreated">
            <Columns>
                <asp:BoundField DataField="MovieRatings" HeaderText="MovieRatings" />
                <asp:TemplateField HeaderText="MovieTitle">
                    <ItemTemplate>
                    <asp:LinkButton ID="LinkButton1" runat="server" Text='<%# Eval("[MovieTitle]") %>' CommandArgument='<%# Eval("MovieRatings")%>' CommandName="MovieTitle" ></asp:LinkButton>
                </ItemTemplate>
                </asp:TemplateField>
            </Columns>
        </asp:GridView>
    </p>
    <p>
    </p>
    <p>
    </p>
    <p>
    </p>
    <p>
    </p>
    <p>
    </p>
    <p>
    </p>
    <p>
    </p>
</asp:Content>

