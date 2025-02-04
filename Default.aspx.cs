using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Hello_World
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadAdminDetails();
                if (Session["TextShown"] == null || (bool)Session["TextShown"] == false)
                {
                    LabelDefaultPageText1.Visible = true;
                    LabelDefaultPageText2.Visible = false;
                    Session["TextShown"] = true; // Set session flag
                }
                else
                {
                    LabelDefaultPageText1.Visible = false;
                    LabelDefaultPageText2.Visible = true;
                    Session["TextShown"] = false; // Toggle flag back
                }
            }

        }
        private void LoadAdminDetails()
        {
            // Retrieve values from Web.config and display on Default.aspx
            string defaultText1 = ConfigurationManager.AppSettings["DefaultPageText1"];
            string defaultText2 = ConfigurationManager.AppSettings["DefaultPageText2"];
            string headerText = ConfigurationManager.AppSettings["HeaderText"];
            string footerText = ConfigurationManager.AppSettings["FooterText"];

            // Check if the values are loaded correctly
            System.Diagnostics.Debug.WriteLine("DefaultPageText1: " + defaultText1);
            System.Diagnostics.Debug.WriteLine("DefaultPageText2: " + defaultText2);
            System.Diagnostics.Debug.WriteLine("HeaderText: " + headerText);
            System.Diagnostics.Debug.WriteLine("FooterText: " + footerText);

            LabelDefaultPageText1.Text = defaultText1;
            LabelDefaultPageText2.Text = defaultText2;
            
        }
    }
}
