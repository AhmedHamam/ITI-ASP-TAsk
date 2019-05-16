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
    public partial class profile : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["iticon"].ConnectionString);
            SqlCommand cmd = new SqlCommand("select u.name,u.age,u.email,u.gender,d.Dept_Name from [dbo].[userdata] u,[dbo].[Department] d where u.id=@id and u.dep_id=d.Dept_Id;", con);
            SqlDataReader dr;
            if (Session["name"] != null)
            {
                if (!IsPostBack)
                {
                    UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;
                    cmd.CommandText = "select * from Department";
                    cmd.Connection = con;
                    con.Open();
                    dr= cmd.ExecuteReader();
                    ddl_department.DataSource = dr;
                    ddl_department.DataTextField = "dept_name";
                    ddl_department.DataValueField = "dept_id";
                    ddl_department.DataBind();
                    con.Close();
                }
                cmd = new SqlCommand("select u.name,u.age,u.email,u.gender,d.Dept_Name from [dbo].[userdata] u,[dbo].[Department] d where u.id=@id and u.dep_id=d.Dept_Id;", con);
                cmd.Parameters.AddWithValue("id", Session["name"]);
                con.Open();
                dr = cmd.ExecuteReader();
                dr.Read();
                lb_age.Text = dr["age"].ToString();
                lb_email.Text = dr["email"].ToString();
                lb_department.Text = dr["Dept_Name"].ToString();
                lb_name.Text = dr["name"].ToString();
                switch (dr["gender"].ToString().ToLower())
                {
                    case "male":
                        rdb_gender.Items[0].Selected = true;
                        break;
                    case "female":
                        rdb_gender.Items[1].Selected = true;
                        break;
                }
                con.Close();
            }
            else
            {
                Response.Redirect("~/login.aspx");
            }
        }

        protected void btn_logout_Click(object sender, EventArgs e)
        {
            Session["name"] = null;
            HttpCookie co = new HttpCookie("local");
            co.Expires = DateTime.Now.AddDays(-15);
            Response.Cookies.Add(co);
            Response.Redirect("~/login.aspx");
        }

        protected void btn_ChangePassword_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/changePassword.aspx");
        }

        protected void btn_editprofile_Click(object sender, EventArgs e)
        {
            
            lb_age.Visible = false;
            lb_department.Visible = false;
            lb_email.Visible = false;
            lb_name.Visible = false;
            btn_editprofile.Visible = false;
            //=========================================
            txt_age.Visible = true;
            txt_username.Visible = true;
            txt_email.Visible = true;
            ddl_department.Visible = true;
            btn_cancl_edit.Visible = true;
            btn_Save.Visible = true;
            //============================================
            txt_age.Text = lb_age.Text;
            txt_email.Text = lb_email.Text;
            txt_username.Text = lb_name.Text;

        }

        protected void btn_Save_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["iticon"].ConnectionString);
            SqlCommand cmd = new SqlCommand("update dbo.userdata set name=@name ,age=@age ,gender=@gender ,email=@email,dep_id=@did where id=@id;", con);
            cmd.Parameters.AddWithValue("id", Session["name"].ToString());
            cmd.Parameters.AddWithValue("name", txt_username.Text);
            cmd.Parameters.AddWithValue("age", txt_age.Text);
            cmd.Parameters.AddWithValue("email", txt_email.Text);
            cmd.Parameters.AddWithValue("gender", rdb_gender.Text);
            cmd.Parameters.AddWithValue("did", ddl_department.SelectedValue);
            con.Open();
            int roweffect = cmd.ExecuteNonQuery();
            con.Close();
            btn_row_effect.Text = roweffect.ToString();
            lb_age.Visible = true;
            lb_department.Visible = true;
            lb_email.Visible = true;
            lb_name.Visible = true;
            btn_editprofile.Visible = true;
            //=========================================
            txt_age.Visible = false;
            txt_username.Visible = false;
            txt_email.Visible = false;
            ddl_department.Visible = false;
            btn_cancl_edit.Visible = false;
            btn_Save.Visible = false;
            //=========================================
            
        }

        protected void btn_cancl_edit_Click(object sender, EventArgs e)
        {
               
            lb_age.Visible = true;
            lb_department.Visible = true;
            lb_email.Visible = true;
            lb_name.Visible = true;
            btn_editprofile.Visible = true;
            //=========================================
            txt_age.Visible = false;
            txt_username.Visible = false;
            txt_email.Visible = false;
            ddl_department.Visible = false;
            btn_cancl_edit.Visible = false;
            btn_Save.Visible = false;
            //============================================
         
        }
    }
}