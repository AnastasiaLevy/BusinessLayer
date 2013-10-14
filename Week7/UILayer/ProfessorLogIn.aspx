<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ProfessorLogIn.aspx.cs" Inherits="UILayer.ProfessorLogIn" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:ObjectDataSource ID="ObjectDataSource3" runat="server" DataObjectTypeName="AnotherOne.Activity" DeleteMethod="Delete" InsertMethod="Insert" SelectMethod="GetAll" TypeName="BusinessLayer.BusinessActivities" UpdateMethod="Update"></asp:ObjectDataSource>
    
        <asp:Label ID="Label1" runat="server" Text="Update Exams:" ForeColor="#990000"></asp:Label>
        <br />
        <br />
    
    </div>
        <asp:GridView ID="GridView3" runat="server" AutoGenerateColumns="False" DataSourceID="ObjectDataSource3" CellPadding="4" ForeColor="#333333" GridLines="None" OnSelectedIndexChanged="GridView3_SelectedIndexChanged">
            <AlternatingRowStyle BackColor="White" />
            <Columns>
                <asp:BoundField DataField="Id" HeaderText="Id" SortExpression="Id" />
                <asp:BoundField DataField="ActivityName" HeaderText="ActivityName" SortExpression="ActivityName" />
                <asp:BoundField DataField="Schedule" HeaderText="Schedule" SortExpression="Schedule" />
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
        <asp:Panel ID="Panel2" runat="server" Width="475px">
        </asp:Panel>
        <br />
        <asp:Label ID="Label3" runat="server" Text="Activity Name" ForeColor="#CC3300"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBox1" runat="server" Height="19px" OnTextChanged="TextBox1_TextChanged" Width="213px" BorderColor="#CC3300"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label4" runat="server" Text="Schedule" ForeColor="#CC3300"></asp:Label>
        <asp:TextBox ID="TextBox2" runat="server" style="margin-left: 56px" Width="213px" BorderColor="#CC3300" Height="19px"></asp:TextBox>
        <br />
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" style="margin-left: 92px" Text="Add" ForeColor="#CC3300" />
        <br />
        <asp:Label ID="Label2" runat="server" Text="Post Grades:"></asp:Label>
        <asp:ObjectDataSource ID="ObjectDataSource2" runat="server" DataObjectTypeName="AnotherOne.Grade" DeleteMethod="Delete" InsertMethod="Insert" SelectMethod="GetAll" TypeName="BusinessLayer.BusinessGrade" UpdateMethod="Update"></asp:ObjectDataSource>
        <asp:GridView ID="GridView2" runat="server" AutoGenerateColumns="False"  AutoGenerateEditButton="True" CellPadding="4" DataSourceID="SqlDataSource1" Height="147px" OnSelectedIndexChanged="GridView2_SelectedIndexChanged" Width="615px" BackColor="White" BorderColor="#3366CC" BorderStyle="None" BorderWidth="1px">
            <Columns>
                <asp:BoundField DataField="Lname" HeaderText="Lname" SortExpression="Lname" />
                <asp:BoundField DataField="Fname" HeaderText="Fname" SortExpression="Fname" />
                <asp:BoundField DataField="Value" HeaderText="Value" SortExpression="Value" />
                <asp:BoundField DataField="ActivityName" HeaderText="ActivityName" SortExpression="ActivityName" />
            </Columns>
            <FooterStyle BackColor="#99CCCC" ForeColor="#003399" />
            <HeaderStyle BackColor="#003399" Font-Bold="True" ForeColor="#CCCCFF" />
            <PagerStyle BackColor="#99CCCC" ForeColor="#003399" HorizontalAlign="Left" />
            <RowStyle BackColor="White" ForeColor="#003399" />
            <SelectedRowStyle BackColor="#009999" Font-Bold="True" ForeColor="#CCFF99" />
            <SortedAscendingCellStyle BackColor="#EDF6F6" />
            <SortedAscendingHeaderStyle BackColor="#0D4AC4" />
            <SortedDescendingCellStyle BackColor="#D6DFDF" />
            <SortedDescendingHeaderStyle BackColor="#002876" />
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:NewDataBaseConnectionString %>" SelectCommand="FillOutGradeTable" SelectCommandType="StoredProcedure"></asp:SqlDataSource>
        <asp:ObjectDataSource ID="ObjectDataSource1" runat="server"></asp:ObjectDataSource>
        <asp:Panel ID="pn" runat="server">
        </asp:Panel>
        <asp:ObjectDataSource ID="ObjectDataSource4" runat="server" SelectMethod="GetAll" TypeName="BusinessLayer.BusinessActivities"></asp:ObjectDataSource>
        <asp:DropDownList ID="DropDownList1" runat="server" DataSourceID="ObjectDataSource3" DataTextField="ActivityName" DataValueField="Id" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
        </asp:DropDownList>
        <asp:TextBox ID="TextBox3" runat="server" OnTextChanged="TextBox3_TextChanged1"></asp:TextBox>
        <asp:Panel ID="Panel1" runat="server" Height="127px" Width="510px">
            <asp:GridView ID="GridView4" runat="server" OnSelectedIndexChanged="GridView4_SelectedIndexChanged">
            </asp:GridView>
        </asp:Panel>
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <br />
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;
        <br />
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        </form>
</body>
</html>
