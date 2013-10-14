<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MemberPage.aspx.cs" Inherits="UILayer.MemberPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Welcom to Psychology 2010</title>
</head>

<body style="height: 506px; width: 596px;">
    
    <form id="form1" runat="server">
    
        <asp:Panel ID="Panel3" runat="server" BorderColor="#993300" BorderStyle="Solid" Direction="LeftToRight" Height="70px" Width="1070px">
            <h4 style="color: #800000; text-align: left; height: 52px; width: 1064px">Welcome to Psychology 2010&nbsp;&nbsp; Research Metods,
                <asp:Label ID="lbUserName" runat="server"></asp:Label>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </h4>
        </asp:Panel>
        </p>
        <asp:Panel ID="Panel1" runat="server" Height="134px" Width="1075px">
            <br />
            <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" SelectMethod="SearchByUserName" TypeName="BusinessLayer.BusinessGrade">
                <SelectParameters>
                    <asp:Parameter Name="Id" Type="Int32" />
                </SelectParameters>
            </asp:ObjectDataSource>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server"></asp:SqlDataSource>
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" CellPadding="4" DataSourceID="ObjectDataSource1" ForeColor="#333333" GridLines="None" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" ShowHeaderWhenEmpty="True">
                <AlternatingRowStyle BackColor="White" />
                <Columns>
                    <asp:CommandField ShowSelectButton="True" />
                    <asp:BoundField DataField="Id" HeaderText="Id" SortExpression="Id" Visible="False" />
                    <asp:BoundField DataField="Value" HeaderText="Grade: " SortExpression="Value" />
                    <asp:BoundField DataField="PersonId" HeaderText="PersonId" SortExpression="PersonId" Visible="False" />
                    <asp:BoundField DataField="ActivityId" HeaderText="Activity:" SortExpression="ActivityId" />
                </Columns>
                <FooterStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
                <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="#FFCC66" ForeColor="#333333" HorizontalAlign="Center" />
                <RowStyle BackColor="#FFFBD6" ForeColor="#333333" />
                <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="Navy" />
                <SortedAscendingCellStyle BackColor="#FDF5AC" />
                <SortedAscendingHeaderStyle BackColor="#4D0000" />
                <SortedDescendingCellStyle BackColor="#FCF6C0" />
                <SortedDescendingHeaderStyle BackColor="#820000" />
            </asp:GridView>
            <asp:TextBox ID="TextBox1" runat="server" OnTextChanged="TextBox1_TextChanged" Width="155px"></asp:TextBox>
            <br />
            <br />
            <br />
            <br />
            <br />
            <asp:GridView ID="GridView2" runat="server" AutoGenerateColumns="False" DataSourceID="SqlDataSource2" OnSelectedIndexChanged="GridView2_SelectedIndexChanged">
                <Columns>
                    <asp:BoundField DataField="Activity" HeaderText="Activity" SortExpression="Activity" />
                    <asp:BoundField DataField="Grade" HeaderText="Grade" SortExpression="Grade" />
                </Columns>
            </asp:GridView>
            <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:NewDataBaseConnectionString %>" OnSelecting="SqlDataSource2_Selecting" SelectCommand="SELECT ActivityId AS Activity, Value AS Grade FROM Grades WHERE (PersonId = @id)">
                <SelectParameters>
                    <asp:Parameter Name="id" />
                </SelectParameters>
            </asp:SqlDataSource>
            <br />
            <br />
        </asp:Panel>
    </form>
    
</body>
</html>
