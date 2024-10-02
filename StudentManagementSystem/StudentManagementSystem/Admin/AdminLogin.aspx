<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AdminLogin.aspx.cs" Inherits="StudentManagementSystem.Admin.AdminLogin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Admin Login Form</title>
    <link rel="icon" href="/Images/Admin.jpg" />
    <style type="text/css">
        .auto-style1 {
            font-size: xx-large;
        }
        .auto-style2 {
            font-size: x-large;
            border : none;
            border-radius : 8px;
            
        }
        .auto-style3 {
            color : #3498db;
            text-align: center;
            background-color : lightcyan;
            margin-top : 80px;
            border-radius : 17px;
            width: 530px;
            box-shadow: 4px 6px blue;
        }
        .auto-style4 {
            width: 643px;
            height: 413px;
            margin-left: 512px;
        }
        .auto-style5 {
            font-size: x-large;
            border : none;
            border-radius : 8px;
            cursor : pointer;
            padding : 10px;
            transition: background-color 0.3s ease-in-out;
        }
        body {
           background-color : #3498db;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server" class="auto-style4">
        <div>
            <div class="auto-style3">
                
                <strong><span class="auto-style1">Admin Login Form:</span></strong><br />
                <br />
                <span class="auto-style2">Enter User ID:</span><br class="auto-style2" />
                <asp:TextBox ID="txtUserID" runat="server" BorderStyle="Ridge" style="border : 1px solid #3498db;" autofocus CssClass="auto-style2"></asp:TextBox>
                <br class="auto-style2" />
                <br class="auto-style2" />
                <span class="auto-style2">Enter Password:</span><br class="auto-style2" />
                <asp:TextBox ID="txtPassword" runat="server" CssClass="auto-style2" style="border : 1px solid #3498db;" BorderStyle="Ridge" TextMode="Password"></asp:TextBox>
                <br class="auto-style2" />
                <br class="auto-style2" />
                <asp:Button ID="btnLogin" runat="server" CssClass="auto-style5" Text="Login"  BackColor="#2980b9" ForeColor="White" Height="44px" Width="106px" OnClick="btnLogin_Click" />
                <br class="auto-style2" />
                <br class="auto-style2" />
                <asp:Label ID="lblMessage" runat="server" CssClass="auto-style2" ForeColor="Red"></asp:Label>
                
            </div>
        </div>
    </form>
</body>
</html>
