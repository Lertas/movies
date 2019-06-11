<%@ Page Title="Search" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true"
    CodeFile="Search.aspx.cs" Inherits="Search" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" Runat="Server">
    <style type="text/css">
    .style1
    {
        font-size: medium;
    }
</style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" Runat="Server">
    <strong><em style="font-size: medium">Αναζήτηση Ταινίας με βάση το Επώνυμο του πρωταγωνιστή:</em></strong><br />
<br />
    <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Επώνυμο πρωταγωνιστή:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;
<asp:TextBox ID="TextBox1" runat="server" Height="20px" Width="128px"></asp:TextBox>
<br />
    <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
<asp:Button ID="Button1" runat="server" onclick="Button1_Click" 
    Text="Αναζήτηση " />

<span class="style1">
    <asp:Label ID="Label1" runat="server" Text="WAIT..."></asp:Label>
</span>
<br />
<br />

<span class="style1"><strong>Αποτελέσματα:</strong><br />
<br />
</span>

    <asp:Table ID="Table1" runat="server" BorderStyle="Groove" CellPadding="0" 
        GridLines="Both" Height="24px" HorizontalAlign="Left" 
        style="margin-left: 0px; margin-top: 0px" Width="877px">
        <asp:TableRow ID="TableRow1" runat="server" BorderStyle="Groove" 
            HorizontalAlign="Center" VerticalAlign="Middle" Width="175px">
            <asp:TableCell ID="Author_ID" runat="server">Movie_ID</asp:TableCell>
            <asp:TableCell ID="name" runat="server">Title</asp:TableCell>
            <asp:TableCell ID="surname" runat="server">Main_Actor_ID</asp:TableCell>
            <asp:TableCell ID="birth_date" runat="server">Publish_Studio_ID</asp:TableCell>
            <asp:TableCell runat="server">Date_Published</asp:TableCell>
        </asp:TableRow>
    </asp:Table>
    <br />

    <br />
    <br />

<br />
<br />
</asp:Content>

