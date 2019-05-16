using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace Day2_ASP
{
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;
            if (Request.Cookies["local"] != null)
            {

                Session["name"] = Request.Cookies["local"].Values["name"];
                Response.Redirect("~/profile.aspx");
            }
        }

        protected void btn_Login_Click(object sender, EventArgs e)
        {
            if (IsValid)
            {
                SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["iticon"].ConnectionString);
                SqlCommand cmd = new SqlCommand("select id from [dbo].[userdata] where name=@name and password=@pass", con);
                cmd.Parameters.AddWithValue("name", txt_user_name.Text);
                cmd.Parameters.AddWithValue("pass", txt_password.Text);
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                dr.Read();
                if (dr.HasRows)
                {
                    Session.Add("name", dr["id"]);
                    if (cb_remember.Checked)
                    {
                        //define obj
                        HttpCookie co = new HttpCookie("local");
                        //add values
                        co.Values.Add("name", dr["id"].ToString());
                        //limit expire
                        co.Expires = DateTime.Now.AddDays(15);
                        //write cookie
                        Response.Cookies.Add(co);
                    }
                    Response.Redirect("~/profile.aspx");
                }
                else
                {
                    lbl_status.Text = "invalid username or password";
                }
                con.Close();
            }
        }

        protected void btn_signup_Click(object sender, EventArgs e)
        {
            if(IsValid||!IsValid)
            Response.Redirect("~/signup.aspx");
        }
    }
}