using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using AnotherOne;
using BusinessLayer;

namespace UILayer
{
    public partial class RegisterUser : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Person p = new Person();
            p.Fname = TextBox1.Text;
            p.Lname = TextBox2.Text;
            p.UserName = TextBox3.Text;
            p.Password = TextBox4.Text;
            p.LabId = GridView1.SelectedIndex;

            var labRepo = ServiceLayer.ServiceLayer.RepoFactory.Create("Person");
            labRepo.Insert(p);

        }
    }
}