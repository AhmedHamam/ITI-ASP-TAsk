<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="profile.aspx.cs" Inherits="Day2_ASP.profile" %>
<asp:Content ID="Content1" ContentPlaceHolderID="main_placeholder" runat="server">
    <table style="width: 100%">
        <tr>
            <td style="width: 163px">user Name:</td>
            <td style="width: 370px">
                <asp:Label ID="lb_name" runat="server" Text="Label"></asp:Label>
                <asp:TextBox ID="txt_username" runat="server" Visible="False"></asp:TextBox>
            </td>
            <td style="width: 233px">
                <asp:LinkButton ID="btn_logout" runat="server" OnClick="btn_logout_Click">LogOut</asp:LinkButton>
            </td>
        </tr>
        <tr>
            <td style="width: 163px">Age:</td>
            <td style="width: 370px">
                <asp:Label ID="lb_age" runat="server" Text="Label"></asp:Label>
                <asp:TextBox ID="txt_age" runat="server" Visible="False"></asp:TextBox>
            </td>
            <td style="width: 233px">&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 163px">gender:</td>
            <td style="width: 370px">
                <asp:RadioButtonList ID="rdb_gender" runat="server" Enabled="False" RepeatDirection="Horizontal">
                    <asp:ListItem>Male</asp:ListItem>
                    <asp:ListItem>Female</asp:ListItem>
                </asp:RadioButtonList>
            </td>
            <td style="width: 233px">&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 163px">email:</td>
            <td style="width: 370px">
                <asp:Label ID="lb_email" runat="server" Text="Label"></asp:Label>
                <asp:TextBox ID="txt_email" runat="server" Visible="False"></asp:TextBox>
            </td>
            <td style="width: 233px">&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 163px">Department:</td>
            <td style="width: 370px">
                <asp:Label ID="lb_department" runat="server" Text="Label"></asp:Label>
                <asp:DropDownList ID="ddl_department" runat="server" Visible="False">
                </asp:DropDownList>
            </td>
            <td style="width: 233px">
                <asp:LinkButton ID="btn_row_effect" runat="server" OnClick="btn_cancl_edit_Click"></asp:LinkButton>
            </td>
        </tr>
        <tr>
            <td style="width: 163px; height: 26px;">
                <asp:LinkButton ID="btn_ChangePassword" runat="server" OnClick="btn_ChangePassword_Click">Change Password</asp:LinkButton>
            </td>
            <td style="width: 370px; height: 26px;">
                <asp:LinkButton ID="btn_editprofile" runat="server" OnClick="btn_editprofile_Click">Edit Profile</asp:LinkButton>
                <asp:LinkButton ID="btn_Save" runat="server" OnClick="btn_Save_Click" Visible="False">Save</asp:LinkButton>
            </td>
            <td style="width: 233px; height: 26px;">
                <asp:LinkButton ID="btn_cancl_edit" runat="server" OnClick="btn_cancl_edit_Click" Visible="False">Cancl</asp:LinkButton>
            </td>
        </tr>
    </table>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="NewsPlaceholder" runat="server">
</asp:Content>
