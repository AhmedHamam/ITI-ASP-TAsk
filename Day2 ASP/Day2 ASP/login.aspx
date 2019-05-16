<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="Day2_ASP.login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="main_placeholder" runat="server">
    <table style="width: 100%">
        <tr>
            <td style="width: 133px; height: 17px; font-size: x-large; font-weight: bold;">User Name</td>
            <td style="width: 171px; height: 17px">
                <asp:TextBox ID="txt_user_name" runat="server"></asp:TextBox>
            </td>
            <td style="height: 17px">
                <asp:RequiredFieldValidator ID="user_vaildetor" runat="server" ControlToValidate="txt_user_name" ErrorMessage="*" ForeColor="Red" ValidationGroup="login"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td style="height: 17px; width: 133px; font-size: large; font-weight: bold;">PassWord</td>
            <td style="height: 17px; width: 171px">
                <asp:TextBox ID="txt_password" runat="server" TextMode="Password"></asp:TextBox>
            </td>
            <td style="height: 17px">
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txt_password" ErrorMessage="*" ForeColor="Red" ValidationGroup="login"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td style="width: 133px">&nbsp;</td>
            <td style="width: 171px">
                <asp:CheckBox ID="cb_remember" runat="server" Text="Remmber Me" />
            </td>
            <td>
                <asp:Label ID="lbl_status" runat="server" Font-Bold="True" Font-Size="Large" ForeColor="Red"></asp:Label>
            </td>
        </tr>
        <tr>
            <td style="width: 133px">&nbsp;</td>
            <td style="width: 171px">
                <asp:Button ID="btn_Login" runat="server" OnClick="btn_Login_Click" Text="Login" Width="103px" ValidationGroup="login" />
            </td>
            <td>
                <asp:LinkButton ID="btn_signup" runat="server" Font-Size="Large" Font-Underline="False" OnClick="btn_signup_Click">Sign Up</asp:LinkButton>
            </td>
        </tr>
    </table>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="NewsPlaceholder" runat="server">
</asp:Content>
