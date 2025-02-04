using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Hello_World
{
    public partial class Login : System.Web.UI.Page
    {
        public object LabelMessage { get; private set; }

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ButtonLogin_Click(object sender, EventArgs e)
        {
            string Username = WebConfigurationManager.AppSettings["PFUserName"];
            string Password= WebConfigurationManager.AppSettings["PFPassword"];
            if (TextBoxUsername.Text == Username && TextBoxPassword.Text == Password)
            {
                Session.Add("UserID", Username);
                Response.Redirect("Admin.aspx");
            }
            else
            {
                LabelMsg.Text = "Please enter valid Username and Password";
            }

        }
    }
}