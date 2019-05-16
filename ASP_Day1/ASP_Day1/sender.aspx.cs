using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASP_Day1
{
    public partial class sender : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack == false)
            {
                for (int i = 1; i < 32; i++)
                {
                    ddl_day.Items.Add(i.ToString());
                }
                for (int i = 1; i < 13; i++)
                {
                    ddl_month.Items.Add(i.ToString());
                }
                for (int i = Convert.ToInt32(DateTime.Now.Year); i > 1900; i--)
                {
                    ddl_year.Items.Add(i.ToString());
                }
            }
        }

        protected void btn_sender_quary_Click(object sender, EventArgs e)
        {
            int year = Convert.ToInt32(ddl_year.Text);
            int month = Convert.ToInt32(ddl_month.Text);
            int day = Convert.ToInt32(ddl_day.Text);
            DateTime birthdate = new DateTime(year, month, day);
            Response.Redirect("~/receiver.aspx?name="+txt_name.Text+"&age="+birthdate.ToString());

        }

        protected void btn_session_Click(object sender, EventArgs e)
        {
            int year = Convert.ToInt32(ddl_year.Text);
            int month = Convert.ToInt32(ddl_month.Text);
            int day = Convert.ToInt32(ddl_day.Text);
            DateTime birthdate = new DateTime(year, month, day);
            Session["name"] = txt_name.Text;
            Session["age"] = birthdate.ToShortDateString();//year.ToString()+ " years ," + month.ToString() + " months ," + day.ToString() + " days";
            Response.Redirect("~/receiver.aspx");

        }

        protected void btn_transffer_Click(object sender, EventArgs e)
        {
            int year = Convert.ToInt32(ddl_year.Text);
            int month = Convert.ToInt32(ddl_month.Text);
            int day = Convert.ToInt32(ddl_day.Text);
            DateTime birthdate = new DateTime(year, month, day);
            Server.Transfer("~/receiver.aspx?name=");
        }

        protected void ddl_month_SelectedIndexChanged(object sender, EventArgs e)
        {
            ddl_day.Items.Clear();
            switch (ddl_month.Text)
            {
                case "1":
                case "3":
                case "5":
                case "7":
                case "8":
                case "10":
                case "12":
                    for (int i = 1; i < 32; i++)
                    {
                        ddl_day.Items.Add(i.ToString());
                    }
                    break;
                case "4":
                case "6":
                case "9":
                case "11":
                    for (int i = 1; i < 31; i++)
                    {
                        ddl_day.Items.Add(i.ToString());
                    }
                    break;
                case "2":
                    if (Convert.ToInt32(ddl_year.Text) % 4 == 0)
                    {
                        for (int i = 1; i < 30; i++)
                        {
                            ddl_day.Items.Add(i.ToString());
                        }
                    }
                    else
                    {
                        for (int i = 1; i < 29; i++)
                        {
                            ddl_day.Items.Add(i.ToString());
                        }
                    }
                    break;
            }
        }
    }
}