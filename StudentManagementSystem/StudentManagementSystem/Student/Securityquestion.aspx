<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Securityquestion.aspx.cs" Inherits="StudentManagementSystem.Student.Securityquestion" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            font-size: xx-large;
            text-align: center;
        }
        .auto-style2 {
            font-size: x-large;
        }
        .auto-style3 {
            font-size: large;
        }
        .auto-style4 {
            font-size: large;
            margin-left: 0px;
        }
        body {
            background-color : aliceblue;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="auto-style1">

            <strong>Answer security Question Below Correctly to Change Password<br />
            <br />
            <br />
            </strong><span class="auto-style2">
            <asp:Label ID="lblsecurityQuest" runat="server"></asp:Label>
            <br />
            </span>
            <asp:TextBox ID="txtAnswer" runat="server" CssClass="auto-style3"></asp:TextBox>
            <br />
            <asp:Button ID="btnSubmit" runat="server" CssClass="auto-style3" Text="Submit" OnClick="btnSubmit_Click" />
            <span class="auto-style2">
            <br />
            <br />
            <asp:Label ID="lblMessage" runat="server" CssClass="auto-style3" ForeColor="Red"></asp:Label>
            </span>
            <br />
            <asp:HyperLink ID="HyperLink1" runat="server" CssClass="auto-style3" NavigateUrl="~/Student/StudentHomePage.aspx">Go back to student home page</asp:HyperLink>
            <br />
            
        </div>
            <div>

                <asp:Panel ID="Panel1" runat="server">
                    <span class="auto-style2">Enter New Password:&nbsp;&nbsp;&nbsp;&nbsp; </span>
                    <asp:TextBox ID="txtPassword" runat="server" CssClass="auto-style2"></asp:TextBox>
                    <br />
                    <br class="auto-style2" />
                    <span class="auto-style2">Re-Enter Password:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </span>
                    <asp:TextBox ID="txtRePassword" runat="server" CssClass="auto-style2"></asp:TextBox>
                    <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="txtPassword" ControlToValidate="txtRePassword" CssClass="auto-style3" ErrorMessage="Please enter same password as above" ForeColor="Red"></asp:CompareValidator>
                    <br />
                    <br class="auto-style2" />
                    <span class="auto-style2">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </span>
                    <asp:Button ID="btnChangePassword" runat="server" CssClass="auto-style4" Height="30px" OnClick="btnChangePassword_Click" Text="Change Password" Width="165px" />
                    <br />
                    <br />
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Label ID="lblPannelMessage" runat="server" CssClass="auto-style3" ForeColor="Blue"></asp:Label>
                    <br />
                    <br />
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                </asp:Panel>

            </div>
    </form>
</body>
</html>
