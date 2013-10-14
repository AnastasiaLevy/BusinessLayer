using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using AnotherOne;
using BusinessLayer;
using System.Data.SqlClient;
using System.Data;
using ServiceLayer;


namespace UILayer
{
    public partial class ProfessorLogIn : System.Web.UI.Page
    {
        List<string> controls = new List<string>();
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

       
      

 protected void Button2_Click(object sender, EventArgs e)
        {
            string strConnection = System.Configuration.ConfigurationManager.ConnectionStrings["NewDataBaseConnectionString"].ConnectionString;

            SqlConnection sqlConnection = new SqlConnection(strConnection);
            String SQLQuery = "SELECT count (*) from People";
            SqlCommand command = new SqlCommand(SQLQuery, sqlConnection);

            sqlConnection.Open();
            int count =Convert.ToInt32(command.ExecuteScalar());

            SqlCommand command2 = new SqlCommand("select id, fname, lname,' ' AS GRADE from people", sqlConnection);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(command2);
            da.Fill(dt);
            da.Dispose();
            sqlConnection.Close();

            TextBox tx = new TextBox();
            Literal lt = new Literal();
            Literal ltName = new Literal();
            List<TypeOfGrade> listGrade = new List<TypeOfGrade>();
            //List<Table> list = dt.AsEnumerable().Select(r => new Table()
            //{
            //    Fname = (string)r["Lname"],
            //    Lname = (string)r["fname"],
            //    Id = (int)r["Id"],
            //    grade = (string)r["grade"]
            //}
            // ).ToList();

            //;
            //List<DataRow> list = new List<DataRow>(dt.Select());
            //var list = dt.AsEnumerable().Select(r => new Person()
            //{
            //    Fname = (string)r["Lname"],
            //    Lname = (string)r["fname"],
            //    Id = (int)r["Id"],

            //    GRADE = (string)r["Grade"]
            //}
            //   ).ToList();

            ////;
            //GridView4.DataSource = list;
            //GridView4.DataBind(); 
               //int j = 0;
               //foreach (var item in list)
               //{

               //    ltName = new Literal();
               //    ltName.ID = "ltName" + j.ToString();
               //    ltName.Text =list[j].Fname.ToString()+ ", " +list[j].Lname.ToString()+ ": ";
               //    pn.Controls.Add(ltName);
               //    tx = new TextBox();
               //    //tx = (TextBox)Controls["tb" + j.ToString()];
               //    tx.ID = "tx_" + j.ToString();
               //    tx.Text = tx.ID;
               //    pn.Controls.Add(tx);
               //    lt = new Literal();
               //    lt.ID = "lt_" + j.ToString();
               //    lt.Text = "</br>";
                   
               //    pn.Controls.Add(lt);
               //    pn.Controls.Add(tx);
               //    controls.Add(tx.ID);
               //    j++;
                   
               //}

        }

 protected void TextBox3_TextChanged(object sender, EventArgs e)
 {

 }

 protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
 {
     

 }

 protected void Button3_Click(object sender, EventArgs e)
 {

     string strConnection = System.Configuration.ConfigurationManager.ConnectionStrings["NewDataBaseConnectionString"].ConnectionString;

     SqlConnection sqlConnection = new SqlConnection(strConnection);
     String SQLQuery = "SELECT count (*) from People";
     SqlCommand command = new SqlCommand(SQLQuery, sqlConnection);

     sqlConnection.Open();
     int count = Convert.ToInt32(command.ExecuteScalar());

     SqlCommand command2 = new SqlCommand("select id from people", sqlConnection);
     DataTable dt = new DataTable();
     SqlDataAdapter da = new SqlDataAdapter(command2);
     da.Fill(dt);
     da.Dispose();
     sqlConnection.Close();

     TextBox tx = new TextBox();
     Literal lt = new Literal();
     Literal ltName = new Literal();
     var list = dt.AsEnumerable().Select(r => new Table()
     {
         Fname = (string)r["Lname"],
         Lname = (string)r["fname"],
         Id = (int)r["Id"],
         grade = (string)r["grade"]
     }
        ).ToList();

     ;

     for (int j = 0; j < count; j++)
     {
         //int id = list[j].Id;
         //int actId = int.Parse(DropDownList1.SelectedValue);
         //int value = int.Parse(Controls["tx" + j.ToString].Text);
         TextBox3.Text = pn.Controls.Count.ToString();

         //TypeOfGrade gr = new TypeOfGrade();
         //gr.id = list[j].Id;
         //gr.actId=Convert.ToInt32(DropDownList1.SelectedValue);
         //gr.value =int.Parse(tx.Text) ;
         //listGrade.Add(gr);

         //ServiceLayer.AddGrade.CreateGrade(id, actId, value);
     }
 }

 protected void InsertReady_CheckedChanged(object sender, EventArgs e)
 {

 }

 protected void TextBox3_TextChanged1(object sender, EventArgs e)
 {

 }

 protected void GridView3_SelectedIndexChanged(object sender, EventArgs e)
 {

 }

 protected void GridView4_SelectedIndexChanged(object sender, EventArgs e)
 {

 }
    }
}