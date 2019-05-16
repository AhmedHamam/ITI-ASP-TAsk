<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="signup.aspx.cs" Inherits="Day2_ASP.signup" %>
<asp:Content ID="Content1" ContentPlaceHolderID="main_placeholder" runat="server">
    <table style="width: 100%">
        <tr>
            <td style="width: 175px; height: 26px">Name</td>
            <td style="height: 26px">
                <asp:TextBox ID="txt_name" runat="server"></asp:TextBox>
            </td>
            <td style="height: 26px"></td>
        </tr>
        <tr>
            <td style="width: 175px">Email</td>
            <td>
                <asp:TextBox ID="txt_email" runat="server"></asp:TextBox>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 175px">Age</td>
            <td>
                <asp:TextBox ID="txt_age" runat="server"></asp:TextBox>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 175px">Gender</td>
            <td>
                <asp:RadioButtonList ID="rdb_gender" runat="server" RepeatDirection="Horizontal">
                    <asp:ListItem Selected="True">Male</asp:ListItem>
                    <asp:ListItem>Female</asp:ListItem>
                </asp:RadioButtonList>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 175px">Department</td>
            <td>
                <asp:DropDownList ID="ddl_departments" runat="server">
                </asp:DropDownList>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 175px">Password</td>
            <td>
                <asp:TextBox ID="txt_pwd" runat="server" TextMode="Password"></asp:TextBox>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 175px; height: 26px">comifirm Password</td>
            <td style="height: 26px">
                <asp:TextBox ID="txt_conf_pwd" runat="server" TextMode="Password"></asp:TextBox>
            </td>
            <td style="height: 26px"></td>
        </tr>
        <tr>
            <td style="width: 175px">&nbsp;</td>
            <td>
                <asp:Button ID="btn_submit" runat="server" OnClick="btn_submit_Click" Text="Submit" />
            </td>
            <td>&nbsp;</td>
        </tr>
    </table>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="NewsPlaceholder" runat="server">
</asp:Content>
