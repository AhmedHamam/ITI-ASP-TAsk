using System;

namespace ASPDay1Tasks
{
    public partial class CurrencyConverter : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ddl_convert_SelectedIndexChanged(object sender, EventArgs e)
        {
            convert();
        }

        protected void txt_egpValue_TextChanged(object sender, EventArgs e)
        {
            convert();
        }
        protected void convert()
        {
            lbl_message.Text = txt_egpValue.Text + " Eygption Pound =" + (Convert.ToDouble(txt_egpValue.Text) / Convert.ToDouble(ddl_convert.SelectedValue)).ToString() + "  " + ddl_convert.SelectedItem.Text;
            lbl_message2.Text = txt_egpValue.Text + " " + ddl_convert.SelectedItem + " =" + (Convert.ToDouble(ddl_convert.SelectedValue) * Convert.ToDouble(txt_egpValue.Text)).ToString() + " EGP";
        }
    }
}