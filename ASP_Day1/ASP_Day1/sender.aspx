<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="sender.aspx.cs" Inherits="ASP_Day1.sender" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
            border: 1px solid #800000;
        }
        .auto-style2 {
            height: 32px;
        }
        .auto-style4 {
            width: 93px;
        }
        .auto-style5 {
            height: 32px;
            width: 93px;
        }
        .auto-style6 {
            width: 86px;
        }
        .auto-style7 {
            height: 32px;
            width: 86px;
        }
        .auto-style8 {
            width: 81px;
        }
        .auto-style9 {
            height: 32px;
            width: 81px;
        }
        .auto-style10 {
            width: 95px;
        }
        .auto-style11 {
            height: 32px;
            width: 95px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table class="auto-style1" dir="ltr">
                <tr>
                    <td class="auto-style4" colspan="1">Name :</td>
                    <td colspan="3">
                        <asp:TextBox ID="txt_name" runat="server" Width="245px"></asp:TextBox>
                    </td>
                    <td class="auto-style6">&nbsp;</td>
                    <td class="auto-style8">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style4" colspan="1">Birth Date :</td>
                    <td class="auto-style10" colspan="1">
                        <asp:DropDownList ID="ddl_year" runat="server" AutoPostBack="True" Height="16px" Width="89px" OnSelectedIndexChanged="ddl_month_SelectedIndexChanged">
                        </asp:DropDownList>
                    </td>
                    <td class="auto-style6">
                        <asp:DropDownList ID="ddl_month" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddl_month_SelectedIndexChanged">
                        </asp:DropDownList>
                    </td>
                    <td class="auto-style8">
                        <asp:DropDownList ID="ddl_day" runat="server" AutoPostBack="True">
                        </asp:DropDownList>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style5"></td>
                    <td class="auto-style11">
                        <asp:Button ID="btn_sender_quary" runat="server" Text="queary string" Width="91px" OnClick="btn_sender_quary_Click" />
                    </td>
                    <td class="auto-style7">
                        <asp:Button ID="btn_transffer" runat="server" Text="transfer" Width="91px" OnClick="btn_transffer_Click" style="height: 26px" />
                    </td>
                    <td class="auto-style9">
                        <asp:Button ID="btn_session" runat="server" Text="session" Width="91px" OnClick="btn_session_Click" />
                    </td>
                    <td class="auto-style2"></td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
