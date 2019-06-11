<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title></title>
    <style type="text/css">


h2
{
    font-size: 1.5em;
    font-weight: 600;
}

h1, h2, h3, h4, h5, h6
{
    font-size: 1.5em;
    color: #666666;
    font-variant: small-caps;
    text-transform: none;
    font-weight: 200;
    margin-bottom: 0px;
            background-color: #00FFFF;
        }

p
{
    margin-bottom: 10px;
    line-height: 1.6em;
}


        .style1
        {
            font-size: xx-large;
            color: #000000;
        }
        .style2
        {
            font-size: medium;
        }


    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <h2 class="style1">
            <strong><em>Movie center</em></strong></h2>
    <p>
    <img src="images/movies-1.jpg" alt="" style="height: 444px; width: 415px" />

        </p>
        <span class="style2">Γεια χαρά... παρακαλώ συνδεθείτε:</span><br />
        <br />
    <asp:Label ID="Label1" runat="server" ForeColor="#165858" Text="Username"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
    <br />
    <br />
    <asp:Label ID="Label2" runat="server" ForeColor="#155555" Text="Password"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
    <br />
    <br />
    <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Button ID="Button1" runat="server" onclick="Button1_Click" 
        Text="Connect" />
<br />
<br />
<asp:Label ID="Label3" runat="server" Text="Waiting..."></asp:Label>
    
    </div>
    </form>
</body>
</html>
