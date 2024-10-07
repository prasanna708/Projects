<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/AdminForm.Master" AutoEventWireup="true" CodeBehind="UpdateOrDeleteStudents.aspx.cs" Inherits="StudentManagementSystem.Admin.UpdateOrDeleteStudents" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style5 {
            color: #FF0000;
            text-align: center;
            text-decoration: underline;
        }
        .auto-style6 {
            font-size: x-large;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div style="background-color:aliceblue">
        <h1 class="auto-style5">Update (or) Delete Student Records:</h1>
        <br />
        <asp:GridView ID="GridView1" runat="server" DataKeyNames="RegNo" AutoGenerateColumns="false" AutoGenerateEditButton="true" BackColor="White" BorderColor="#DEDFDE" BorderStyle="None" BorderWidth="1px" CellPadding="4" ForeColor="Black" GridLines="Vertical" OnRowCancelingEdit="GridView1_RowCancelingEdit" OnRowDeleting="GridView1_RowDeleting" OnRowEditing="GridView1_RowEditing" OnRowUpdating="GridView1_RowUpdating">
            <AlternatingRowStyle BackColor="White" />
            <FooterStyle BackColor="#CCCC99" />
            <HeaderStyle BackColor="#6B696B" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#F7F7DE" ForeColor="Black" HorizontalAlign="Right" />
            <RowStyle BackColor="#F7F7DE" />
            <SelectedRowStyle BackColor="#CE5D5A" Font-Bold="True" ForeColor="White" />
            <SortedAscendingCellStyle BackColor="#FBFBF2" />
            <SortedAscendingHeaderStyle BackColor="#848384" />
            <SortedDescendingCellStyle BackColor="#EAEAD3" />
            <SortedDescendingHeaderStyle BackColor="#575357" />
            <Columns>
                <asp:TemplateField HeaderText="RegNo">
                    <ItemTemplate>
                        <asp:Label ID="Label0" runat="server" Text='<%#Bind("RegNo") %>' />
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Name">
                    <EditItemTemplate>
                        <asp:TextBox ID="TextBox1" runat="server" Text='<%#Bind("Name") %>' />
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="Label1" runat="server" Text='<%#Bind("Name") %>' />
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Password">
                    <EditItemTemplate>
                        <asp:TextBox ID="TextBox2" runat="server" Text='<%#Bind("Password") %>' />
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="Label2" runat="server" Text='<%#Bind("Password") %>' />
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Gender">
                    <EditItemTemplate>
                        <asp:TextBox ID="TextBox3" runat="server" Text='<%#Bind("Gender") %>' />
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="Label3" runat="server" Text='<%#Bind("Gender") %>' />
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Course">
                    <EditItemTemplate>
                        <asp:TextBox ID="TextBox4" runat="server" Text='<%#Bind("Course") %>' />
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="Label4" runat="server" Text='<%#Bind("Course") %>' />
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="FinalFee">
                    <EditItemTemplate>
                        <asp:TextBox ID="TextBox5" runat="server" Text='<%#Bind("FinalFee") %>' />
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="Label5" runat="server" Text='<%#Bind("FinalFee") %>' />
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="FeePaid">
                    <EditItemTemplate>
                        <asp:TextBox ID="TextBox6" runat="server" Text='<%#Bind("FeePaid") %>' />
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="Label6" runat="server" Text='<%#Bind("FeePaid") %>' />
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="MobileNo">
                    <EditItemTemplate>
                        <asp:TextBox ID="TextBox7" runat="server" Text='<%#Bind("MobileNo") %>' />
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="Label7" runat="server" Text='<%#Bind("MobileNo") %>' />
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Email ID">
                    <EditItemTemplate>
                        <asp:TextBox ID="TextBox8" runat="server" Text='<%#Bind("EmailId") %>' />
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="Label8" runat="server" Text='<%#Bind("EmailId") %>' />
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Address">
                    <EditItemTemplate>
                        <asp:TextBox ID="TextBox9" runat="server" Text='<%#Bind("Address") %>' />
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="Label9" runat="server" Text='<%#Bind("Address") %>' />
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Pincode">
                    <EditItemTemplate>
                        <asp:TextBox ID="TextBox10" runat="server" Text='<%#Bind("Pincode") %>' />
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="Label10" runat="server" Text='<%#Bind("Pincode") %>' />
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Graduation">
                    <EditItemTemplate>
                        <asp:TextBox ID="TextBox11" runat="server" Text='<%#Bind("Graduation") %>' />
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="Label11" runat="server" Text='<%#Bind("Graduation") %>' />
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Branch">
                    <EditItemTemplate>
                        <asp:TextBox ID="TextBox12" runat="server" Text='<%#Bind("Branch") %>' />
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="Label12" runat="server" Text='<%#Bind("Branch") %>' />
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="YOP">
                    <EditItemTemplate>
                        <asp:TextBox ID="TextBox13" runat="server" Text='<%#Bind("YOP") %>' />
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="Label13" runat="server" Text='<%#Bind("YOP") %>' />
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="CGPA/SGPA">
                    <EditItemTemplate>
                        <asp:TextBox ID="TextBox14" runat="server" Text='<%#Bind("CGPA") %>' />
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="Label14" runat="server" Text='<%#Bind("CGPA") %>' />
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Security Question">
                    <EditItemTemplate>
                        <asp:TextBox ID="TextBox15" runat="server" Text='<%#Bind("SECURITYQUESTION") %>' />
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="Label15" runat="server" Text='<%#Bind("SECURITYQUESTION") %>' />
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Answer">
                    <EditItemTemplate>
                        <asp:TextBox ID="TextBox16" runat="server" Text='<%#Bind("ANSWER") %>' />
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="Label16" runat="server" Text='<%#Bind("ANSWER") %>' />
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField>
                    <ItemTemplate>
                        <asp:Button ID="Button1" runat="server" Text="Delete" CommandName="Delete" OnClientClick="return confirm('Are you sure you want to delete this student record?')" />
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
        </asp:GridView>
        <br />
        <br />
        <asp:Label ID="lblMessage" runat="server" CssClass="auto-style6" ForeColor="Blue"></asp:Label>
        <br /><br />
    </div>
</asp:Content>
