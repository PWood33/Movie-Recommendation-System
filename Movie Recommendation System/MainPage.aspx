<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="MainPage.aspx.cs" Inherits="Movie_Recommendation_System.MainPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" runat="server" contentplaceholderid="ContentPlaceHolder1">
    <br />
    <asp:Timer ID="Timer1" runat="server" OnTick="Timer1_Tick1">
    </asp:Timer>
<br />
    <asp:ScriptManager ID="ScriptManager1" runat="server">
    </asp:ScriptManager>
    <br />
    Welcome to the MovieStar Movie Wesbite. Bringing you the best movies to download and to give you the best recommendations. You can now watch the movie you enjoy the most.<br />
    <br />
    <br />
    <br />
    <asp:Image ID="Image1" runat="server" Height="322px" Width="929px" ImageUrl="~/Images/Frozen.jpg" />
<br />
<br />
<br />
<br />
<br />
<br />
<br />
<br />
<br />
<br />
<br />
<br />
<br />
<p>
    &nbsp;</p>
</asp:Content>

