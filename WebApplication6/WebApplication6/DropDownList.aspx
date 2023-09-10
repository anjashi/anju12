<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DropDownList.aspx.cs" Inherits="WebApplication6.DropDownList" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Add Country</h1>
            <table border="1">
                <tr>
                    <th>Country Name</th>
                    <td>
                        <asp:TextBox ID="txtcname" runat="server" placeholder="Enter Name" required ></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td colspan="2">
                        <asp:Button ID="bt_Add" runat="server" Text="Add Country" OnClick="bt_Add_Click" />
                    </td>
                </tr>
                <tr>
                    <td colspan="2">
                        <asp:Label ID="Lb_result" runat="server"></asp:Label>

                    </td>
                </tr>

            </table>
        </div>
    </form>
</body>
</html>
