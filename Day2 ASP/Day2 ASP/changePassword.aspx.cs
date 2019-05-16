using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Day2_ASP
{
    public partial class changePassword : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;
            if (Session["name"] != null)
            {
            }
            else
            {
                Response.Redirect("~/login.aspx");
            }

        }

        protected void btn_submit_Click(object sender, EventArgs e)
        {
            if (IsValid)
            {
                if (Session["name"] != null)
                {
                    SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["iticon"].ConnectionString);
                    SqlCommand cmd = new SqlCommand("select password from [dbo].[user] where id=@id;", con);
                    cmd.Parameters.AddWithValue("id", Session["name"]);
                    con.Open();
                    SqlDataReader dr = cmd.ExecuteReader();
                    dr.Read();
                    if (dr["password"].ToString() == txt_oldpwd.Text)
                    {
                        con.Close();
                        con.Open();
                        cmd.CommandText = "update [dbo].[user] set [password]=@pwd where id=@idd;";
                        cmd.Parameters.AddWithValue("idd", Session["name"]);
                        cmd.Parameters.AddWithValue("pwd", txt_new_pwd.Text);
                        int r=cmd.ExecuteNonQuery();
                        if(r>0)
                            Response.Redirect("~/login.aspx");
                        else
                            lb_wrongpwd.Text = "not updated";
                    }
                    else
                    {
                        lb_wrongpwd.Text = "Wrong Password";
                    }
                    con.Close();
                }
                else
                {
                    Response.Redirect("~/login.aspx");
                }
            }
        }
    }
}