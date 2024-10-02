<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ImagesData.aspx.cs" Inherits="ImagesDataToDBTable.ImagesData" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            font-size: x-large;
        }
        .auto-style2 {
            font-size: x-large;
            color: #FFFFFF;
        }
    </style>
</head>
<body>
    <h1>Uploading Images Data to DataBase Table</h1>
    <p>&nbsp;</p>
    <form id="form1" runat="server">
        <div>

            <asp:FileUpload ID="ImageFileUpload" runat="server" CssClass="auto-style1" />
            <br class="auto-style1" />
            <br class="auto-style1" />
            <asp:Button ID="btnAdd" runat="server" BackColor="Blue" CssClass="auto-style2" OnClick="btnAdd_Click" Text="Add" />
            <br />
            <br />
            <br />
            <asp:Image ID="Image1" runat="server" Width="600px" Height="400px" />
            <br />
            <br />
            <br />
            <asp:Label ID="lblMessage" runat="server" CssClass="auto-style1" ForeColor="Green"></asp:Label>

        </div>
    </form>
</body>
</html>
