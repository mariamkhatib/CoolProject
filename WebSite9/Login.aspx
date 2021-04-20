<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
            height: 162px;
        }
        .auto-style2 {
            text-align: center;
            font-size: x-large;
            text-decoration: underline;
            color: #990033;
        }
        .auto-style3 {
            text-align: center;
        }
        .auto-style4 {
            width:50%;
            text-align: right;
        }
        .auto-style5 {
            width: 50%;
            text-align: left;
        }
    </style>
</head>
<body bgcolor="pink">
    <form id="form1" runat="server">
    <div>
    
        <table class="auto-style1">
            <tr>
                <td class="auto-style2" colspan="2"><strong><em>Login</em></strong></td>
            </tr>
            <tr>
                <td class="auto-style4">
                    <asp:Label ID="Label1" runat="server" Text="Email :"></asp:Label>
                </td>
                <td class="auto-style5">
                    <asp:TextBox ID="TextBox1"  runat="server" TextMode="Email"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style4">
                    <asp:Label ID="Label2" runat="server" Text="Password :"></asp:Label>
                </td>
                <td class="auto-style5">
                    <asp:TextBox ID="TextBox2" runat="server" TextMode="Password"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style3" colspan="2">
                    <asp:Button ID="Button1" runat="server" Text="Log in" Width="70px" OnClick="Button1_Click" />
                    <asp:Label ID="Label3" runat="server" Text="Label" Visible="False" ForeColor="#990033"></asp:Label>
                    <br />
                    <br />
                    <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="register" />
                </td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
