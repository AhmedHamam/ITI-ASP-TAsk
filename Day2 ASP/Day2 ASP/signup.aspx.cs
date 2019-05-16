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
    public partial class signup : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Data Source=.;Initial Catalog=ITI;Integrated Security=True";
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "select * from Department";
                cmd.Connection = con;
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                ddl_departments.DataSource = dr;
                ddl_departments.DataTextField = "dept_name";
                ddl_departments.DataValueField = "dept_id";
                ddl_departments.DataBind();
                con.Close();
            }

        }

        protected void btn_submit_Click(object sender, EventArgs e)
        {
            if (IsValid)
            {
                SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["iticon"].ConnectionString);
                SqlCommand cmd = new SqlCommand("insert into dbo.userdata(name ,password ,age ,gender ,email,dep_id)values (@name ,@pass,@age,@gender,@email,@did)", con);
                cmd.Parameters.AddWithValue("name", txt_name.Text);
                cmd.Parameters.AddWithValue("pass", txt_pwd.Text);
                cmd.Parameters.AddWithValue("age", txt_age.Text);
                cmd.Parameters.AddWithValue("email", txt_email.Text);
                cmd.Parameters.AddWithValue("gender", rdb_gender.Text);
                cmd.Parameters.AddWithValue("did", ddl_departments.SelectedValue);
                con.Open();
                int roweffect = cmd.ExecuteNonQuery();
                con.Close();
                Response.Redirect("~/login.aspx");
            }
        }
    }
}