using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using AnotherOne;
using BusinessLayer;
using System.Data.SqlClient;

namespace UILayer
{
    public partial class ProfessorLogIn : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            

        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Activity act = new Activity();
            act.Schedule = Convert.ToDateTime(TextBox2.Text);
            act.ActivityName = TextBox1.Text;

            var labRepo = ServiceLayer.ServiceLayer.RepoFactory.Create("Activity");
            labRepo.Insert(act);

        }

        protected void GridView2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}