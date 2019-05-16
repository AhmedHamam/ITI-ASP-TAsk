<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Task2.aspx.cs" Inherits="ASPDay1Tasks.CurrencyConverter" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }

        .auto-style2 {
            height: 211px;
        }

        .auto-style3 {
            height: 211px;
            width: 542px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        &nbsp;
        <table class="auto-style1">
            <tr>
                <td class="auto-style3" style="background-color: #FF9933">
                    <asp:Label ID="Label1" runat="server" Text="EGP Value"></asp:Label>
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:TextBox ID="txt_egpValue" runat="server" OnTextChanged="txt_egpValue_TextChanged">0</asp:TextBox>
                    <br />
                    <br />
                    <br />
                    <br />
                    <asp:Label ID="Label2" runat="server" Text="Convert to"></asp:Label>
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:DropDownList ID="ddl_convert" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddl_convert_SelectedIndexChanged">
                        <asp:ListItem Value="25">Euro</asp:ListItem>
                        <asp:ListItem Value="20">Doller</asp:ListItem>
                        <asp:ListItem Value="5">Rls</asp:ListItem>
                    </asp:DropDownList>
                </td>
                <td class="auto-style2" style="background-color: #FF6600">
                    <asp:Label ID="lbl_message" runat="server" Text=""></asp:Label>
                    <br />
                    <br />
                    <br />
                    <asp:Label ID="lbl_message2" runat="server" Text=""></asp:Label>
                    <br />
                </td>
            </tr>
        </table>

    </form>
</body>
</html>
