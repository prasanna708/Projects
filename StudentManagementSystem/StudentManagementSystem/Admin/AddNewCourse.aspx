<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/AdminForm.Master" AutoEventWireup="true" CodeBehind="AddNewCourse.aspx.cs" Inherits="StudentManagementSystem.Admin.AddNewCourse" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
    .auto-style5 {
        width: 1120px;
        background-color : #DEDFDE;
        text-align: center;
        margin-left: 199px;
    }
    .auto-style6 {
        font-size: x-large;
        border-radius : 12px;
    }
    .auto-style7 {
        border-style: none;
    border-color: inherit;
    border-width: medium;
    padding: 8px;
    cursor : pointer;
        border-radius : 12px;
        font-size: x-large;
}
</style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div style="background-color : aliceblue;">
    <div>
        <br />
        <h1 class="auto-style1">Adding a new Course to Courses List:</h1>
    </div>
    <br />
    <div class="auto-style5">
        <br class="auto-style6" />
        <span class="auto-style6">Enter Course Name:</span><br class="auto-style6" />
        <asp:TextBox ID="txtCourseName" runat="server" autofocus CssClass="auto-style6"></asp:TextBox>
        <br class="auto-style6" />
        <br class="auto-style6" />
        <span class="auto-style6">Enter Course Fee Amount(in INR):</span><br class="auto-style6" />
        <asp:TextBox ID="txtAmount" runat="server" CssClass="auto-style6"></asp:TextBox>
        <br class="auto-style6" />
        <br class="auto-style6" />
        <span class="auto-style6">Enter Duration of Course(approx.):</span><br class="auto-style6" />
        <asp:TextBox ID="txtDuration" runat="server" CssClass="auto-style6"></asp:TextBox>
        <br class="auto-style6" />
        <br />
        <br class="auto-style6" />
        <asp:Button ID="btnAdd" runat="server" Text="Add to List" CssClass="auto-style7" BackColor="Blue" ForeColor="White" Width="173px" OnClick="btnAdd_Click"/>
        <br class="auto-style6" />
        <br class="auto-style6" />
        <asp:Label ID="lblMessage" runat="server" CssClass="auto-style6" ForeColor="Green"></asp:Label>
        <br />
        <br />

    </div>
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
</div>
</asp:Content>
