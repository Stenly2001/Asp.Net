using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Hello_World
{
    public partial class SiteMaster : MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
            LabelCounter.Text = "You are visitor number " + Application["Counter"].ToString();
            if (!IsPostBack)
            {
                string headerText = ConfigurationManager.AppSettings["HeaderText"];
                string footerText = ConfigurationManager.AppSettings["FooterText"];
                LabelHeaderText.Text = headerText;
                LabelFooterText.Text = footerText;// Set the footer text
             
            }

        }

        protected void ButtonLogout_Click(object sender, EventArgs e)
        {
            Session.Remove("UserID");
            Response.Redirect("Default.aspx");
        }
    }
}