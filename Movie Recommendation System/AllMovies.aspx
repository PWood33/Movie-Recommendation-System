<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="AllMovies.aspx.cs" Inherits="Movie_Recommendation_System.AllMovies" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    </asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
    <asp:DataList ID="DataList1" runat="server">
    </asp:DataList>
        <asp:TextBox ID="txtsearch1" runat="server"></asp:TextBox>
        <asp:Button ID="btnsearch" runat="server" OnClick="btnsearch_Click" Text="Search" />
</p>
    <p>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:pw3649fConnectionString %>" SelectCommand="SELECT [MovieID], [GenreID] FROM [movies] WHERE ([GenreID] = @GenreID)">
            <SelectParameters>
            </SelectParameters>
        </asp:SqlDataSource>
</p>
<p>
    <asp:GridView ID="GridView1" runat="server" ShowHeader="False" OnRowCreated="GridView1_RowCreated" OnRowCommand="GridView1_RowCommand">
        <Columns>
            <asp:ImageField DataImageUrlField="MovieImage" HeaderText="Image" ControlStyle-CssClass="ImageStyle">
<ControlStyle CssClass="ImageStyle"></ControlStyle>
            </asp:ImageField>
            <asp:TemplateField HeaderText="Movie">
                <ItemTemplate>
                    <asp:LinkButton ID="LinkButton1" runat="server" Text='<%# Eval("[MovieTitle]") %>' CommandArgument='<%# Eval("MovieID")%>' CommandName="MovieTitle" ></asp:LinkButton>
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>
        <EmptyDataTemplate>
            <br />
        </EmptyDataTemplate>
    </asp:GridView>
    <br />
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
