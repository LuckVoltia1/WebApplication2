<%@Page Title="Jack" AutoEventWireup="True" Inherits="WebApplication2.About" CodeBehind="~/About.aspx.vb"  Language="VB"   %>

<form runat="server">
        <asp:Label ID="id" runat="server" Text="id"> </asp:Label>
<asp:TextBox ID="txtId" runat="server"></asp:TextBox>
    <asp:Label ID="user" runat="server" Text="User"> </asp:Label>
<asp:TextBox ID="txtUser" runat="server"></asp:TextBox>
            <asp:Label ID="pass" runat="server" Text="Password"> </asp:Label>

    <asp:TextBox ID="txtPass" runat="server"></asp:TextBox>
    <asp:Button ID="Insert" runat="server" OnClick="handleInsert" Text="Insert"></asp:Button>
        <asp:Button ID="Update" runat="server" OnClick="UpdateData" Text="Update"></asp:Button>
    <asp:Button ID="Delete" runat="server" OnClick="DeleteData" Text="Delete"></asp:Button>


     <asp:TextBox ID="txtSearch" runat="server"></asp:TextBox>
 <asp:Button ID="Button1" runat="server" OnClick="btnSearch_Click" Text="Search"></asp:Button>
    <asp:GridView ID="gridView" runat="server">  </asp:GridView>



</form>