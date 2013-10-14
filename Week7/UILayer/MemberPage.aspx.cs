using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLayer;
using AnotherOne;
using ServiceLayer;

namespace UILayer
{
    public partial class MemberPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session != null)
            {
                try
                {
                    lbUserName.Text = Session["tommy"].ToString();
                    string userName = lbUserName.Text;
                    ValidateLogin vl = new ValidateLogin();

                    int id = vl.ReturnId(userName);
                    BusinessGrade bd = new BusinessGrade();
                    List<Grade> list = bd.SearchByUserName(id).ToList<Grade>();
                    TextBox1.Text = list.Count.ToString();
                    //Session["ObjectParameterName"] = list[0].PersonId;
                    //ObjectDataSource1.Select();
                    GridView1.DataSource = list;
                    GridView1.DataBind();
                    SqlDataSource2.SelectParameters.Add("id", id.ToString());
                    SqlDataSource2.SelectCommand = "SELECT activityId as Activity, Value as Grade from Grades where personId = @id)";
                }
                catch (Exception ex)
                {
                    lbUserName.Text = "Guest";
                }
                
            }
            
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        protected void SqlDataSource2_Selecting(object sender, SqlDataSourceSelectingEventArgs e)
        {

        }

        protected void GridView2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        }

        
    }
