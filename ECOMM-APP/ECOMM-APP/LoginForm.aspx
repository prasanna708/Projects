<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LoginForm.aspx.cs" Inherits="ECOMM_APP.LoginForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            font-size: x-large;
        }
        .auto-style2 {
            font-size: xx-large;
            font-weight: normal;
        }
        .auto-style3 {
            text-align: center;
            width: 669px;
            margin-left: 397px;
            box-shadow : 2px 4px blue;
            background-color : aliceblue;
        }
        .auto-style4 {
            font-size: x-large;
            color: #FFFFFF;
        }
        #btnLogin {
            border-radius : 7px;
            cursor : pointer;
            border : none;
            padding : 5px;
        }
    </style>
</head>
<body style="background-color : antiquewhite">
    <form id="form1" runat="server">
        <div>
            <div class="auto-style3">
                <h1 class="auto-style2"><strong>Login Form</strong></h1>
                
                <br />
                <span class="auto-style1">Enter User ID:</span><br class="auto-style1" />
                <br class="auto-style1" />
                <asp:TextBox ID="txtUserId" runat="server" CssClass="auto-style1"></asp:TextBox>
                <br />
                <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="txtUserId" ErrorMessage="Please Enter a Valid user id" ForeColor="Red" ValidationExpression="^[a-zA-Z0-9]{5,20}$"></asp:RegularExpressionValidator>
                <br class="auto-style1" />
                <br class="auto-style1" />
                <span class="auto-style1">Enter Password:</span><br class="auto-style1" />
                <br class="auto-style1" />
                <asp:TextBox ID="txtPassword" runat="server" CssClass="auto-style1" TextMode="Password"></asp:TextBox>
                <br />
                <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ErrorMessage="Please Enter a valid password" ForeColor="Red" ValidationExpression="^(?=.*[A-Z])(?=.*\d)(?=.*[#@$*])[A-Z][A-Za-z\d#@$*]{6,20}$" ControlToValidate="txtPassword"></asp:RegularExpressionValidator>
                <br class="auto-style1" />
                <br class="auto-style1" />
                <strong>
                <asp:Button ID="btnLogin" runat="server" CssClass="auto-style4" Text="Login" BackColor="Blue" OnClick="Button1_Click" />
                </strong>
                <br class="auto-style1" />
                <br class="auto-style1" />
                <asp:Label ID="lblMessage" runat="server" CssClass="auto-style1" ForeColor="Red"></asp:Label>
                
            </div>
        </div>
    </form>
</body>
</html>
