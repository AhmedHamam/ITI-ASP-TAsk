using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASP_Day1
{
    public partial class receiver : System.Web.UI.Page
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {
            int year, month, day;
            lbl_name.Text = Request.QueryString["name"];
            DateTime birthdate = DateTime.Parse(Request.QueryString["age"]);
            lbl_Age.Text = Request.QueryString["birthdate"];
            //===================================using Controle =============================
            // year = Convert.ToInt32(((DropDownList)PreviousPage.FindControl("ddl_year")).Text);
            // month = Convert.ToInt32(((DropDownList)PreviousPage.FindControl("ddl_month")).Text);
            // day = Convert.ToInt32(((DropDownList)PreviousPage.FindControl("ddl_day")).Text);
            //DateTime birthdate = new DateTime(year, month, day);
            //lbl_name.Text = ((TextBox)PreviousPage.FindControl("txt_name")).Text;
            //=================================using Session==============================
            //lbl_name.Text = Session["name"].ToString();
            //DateTime birthdate = DateTime.Parse(Session["age"].ToString());


            //================calculate the Age
            TimeSpan age = DateTime.Now.Subtract(birthdate);
           // DateTime dt = new DateTime() + age;
            int x = (int)age.TotalDays;
            year = (x / 365);
            x = x - year * 365;
            month = x / 30;
            x = x - month * 30;
            day = x;
            //lbl_Age.Text = (dt.Year - 1).ToString() + " year " + (dt.Month - 1).ToString() + " months " + dt.Day + " days ";

            lbl_Age.Text = year  + " year " + month + " months " + day + " days ";
        }
    }
}