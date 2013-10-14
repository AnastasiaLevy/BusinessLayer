using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ServiceLayer;
using AnotherOne;

namespace UILayer
{
    public partial class LogInPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Login1_Authenticate(object sender, AuthenticateEventArgs e)
        {
            
            ValidateLogin vl = new ValidateLogin();
            if (vl.ValidateMyLogin(Login1.UserName, Login1.Password))
            {
                Session["UserName"] = Login1.UserName;
                e.Authenticated = true;
                Login1.Visible = false;
                Response.Redirect("MemberPage.aspx");   

            }
            else 
            

                e.Authenticated = false;
            }
                


        }

    }
        
    
