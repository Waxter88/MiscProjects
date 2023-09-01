using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EmmasWebApp
{
    public partial class Home : System.Web.UI.Page
    {
        const string username = "admin";
        const string password = "password";
        
        protected void Page_Load(object sender, EventArgs e)
        {
            ValidationSettings.UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;
            

        }
        //login button
        protected void Button1_Click(object sender, EventArgs e)
        {
            
        }

        protected void LoginControl_Authenticate(object sender, AuthenticateEventArgs e)
        {
            if (LoginControl.UserName == username && LoginControl.Password == password)
            {
                welcome.Visible = true;
                LoginName.Visible = true;
                LoginStatus.Visible = true;
                
                e.Authenticated = true;
                LoginControl.Visible = false;
                FormsAuthentication.SetAuthCookie(username, false);
                Response.Redirect("login.aspx");

                FormsAuthentication.RedirectFromLoginPage(LoginControl.UserName, LoginControl.RememberMeSet);
            }
            else
            {
                welcome.Visible = false;
                LoginName.Visible = false;
                LoginStatus.Visible = false;
                e.Authenticated = false;
            }
        }
    }
}