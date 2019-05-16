<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="changePassword.aspx.cs" Inherits="Day2_ASP.changePassword" %>
<asp:Content ID="Content1" ContentPlaceHolderID="main_placeholder" runat="server">
    <table style="width: 100%">
        <tr>
            <td style="width: 163px">Old Password</td>
            <td style="width: 259px">
                <asp:TextBox ID="txt_oldpwd" runat="server" TextMode="Password"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txt_oldpwd" ErrorMessage="*" ForeColor="Red"></asp:RequiredFieldValidator>
                <asp:Label ID="lb_wrongpwd" runat="server" ForeColor="Red"></asp:Label>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 163px">New Password</td>
            <td style="width: 259px">
                <asp:TextBox ID="txt_new_pwd" runat="server" TextMode="Password"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txt_new_pwd" ErrorMessage="*" ForeColor="Red"></asp:RequiredFieldValidator>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 163px; height: 26px">Confirm Password</td>
            <td style="height: 26px; width: 259px">
                <asp:TextBox ID="txt_conf_pwd" runat="server" TextMode="Password"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txt_conf_pwd" ErrorMessage="*" ForeColor="Red"></asp:RequiredFieldValidator>
                <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="txt_conf_pwd" ControlToValidate="txt_new_pwd" ErrorMessage="Not Matched" ForeColor="Red"></asp:CompareValidator>
            </td>
            <td style="height: 26px"></td>
        </tr>
        <tr>
            <td style="width: 163px">&nbsp;</td>
            <td style="width: 259px">
                <asp:Button ID="btn_submit" runat="server" OnClick="btn_submit_Click" Text="Submit" Width="112px" />
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 163px">&nbsp;</td>
            <td style="width: 259px">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
    </table>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="NewsPlaceholder" runat="server">
</asp:Content>
