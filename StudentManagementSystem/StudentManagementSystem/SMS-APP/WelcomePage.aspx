<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WelcomePage.aspx.cs" Inherits="StudentManagementSystem.SMS_APP.WelcomePage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Dashboard Page</title>
    <link rel="icon" href="\Images\dashboard-icon.png" />
    <style type="text/css">
        .auto-style1 {
            font-size: xx-large;
            text-align: center;
        }
        .auto-style2 {
            font-size: x-large;
        }
        body {
            background-image : url("/Images/sms.jpg");
            background-size : cover;
        }
        .auto-style3 {
            color: #FF0000;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="auto-style1">
            <strong>Welcome To Dashboard:</strong></div>
        <p>
            &nbsp;</p>
        <p class="auto-style2">
            <span class="auto-style3">Are you a Student?</span><asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Student/StudentLogin.aspx">Click here</asp:HyperLink>
        </p>
        <p>
            &nbsp;</p>
        <p class="auto-style2">
            <span class="auto-style3">Are you an Admin?</span><asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl="~/Admin/AdminLogin.aspx">Click here</asp:HyperLink>
        </p>
    </form>
</body>
</html>
