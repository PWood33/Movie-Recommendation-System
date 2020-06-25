<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="DownloadPage.aspx.cs" Inherits="Movie_Recommendation_System.DownloadPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
    <br />
</p>
<p>
    <asp:GridView ID="dgvDownload" runat="server" DataSourceID="SqlDataSource1" Height="192px" Width="347px">
        <Columns>
            <asp:BoundField DataField="MID" HeaderText="MovieID" />
            <asp:BoundField DataField="movietitle" HeaderText="Movie Title" />
        </Columns>
    </asp:GridView>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server"></asp:SqlDataSource>
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
