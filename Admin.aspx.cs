using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Hello_World
{
    public partial class Admin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["UserID"]==null)
            {
                Response.Redirect("");
            }

        }

        protected void ButtonSaveSetting_Click(object sender, EventArgs e)
        {
            try
            {
                Configuration config = WebConfigurationManager.OpenWebConfiguration("~");

                // Save the entered values in Web.config
                config.AppSettings.Settings["DefaultPageText1"].Value = TextBoxDefaultPageText1.Text;
                config.AppSettings.Settings["DefaultPageText2"].Value = TextBoxDefaultPageText2.Text;
                config.AppSettings.Settings["HeaderText"].Value = TextBoxHeaderText.Text;
                config.AppSettings.Settings["FooterText"].Value = TextBoxFooterText.Text;

                config.Save(ConfigurationSaveMode.Modified);
                // Refresh the section to load the updated settings
                ConfigurationManager.RefreshSection("appSettings");

                LabelMsg.Text = "Settings saved successfully!";
                LabelMsg.ForeColor = System.Drawing.Color.Green;

                // Redirect to Default.aspx after saving settings
                Response.Redirect("Default.aspx");
            }
            catch (Exception ex)
            {
                LabelMsg.Text = "Error saving settings: " + ex.Message;
                LabelMsg.ForeColor = System.Drawing.Color.Red;
            }
        }

        private void LoadSettings()
        {
            // Load the saved values into textboxes
            TextBoxDefaultPageText1.Text = ConfigurationManager.AppSettings["DefaultPageText1"];
            TextBoxDefaultPageText2.Text = ConfigurationManager.AppSettings["DefaultPageText2"];
            TextBoxHeaderText.Text = ConfigurationManager.AppSettings["HeaderText"];
            TextBoxFooterText.Text = ConfigurationManager.AppSettings["FooterText"];
        }
    }
}
