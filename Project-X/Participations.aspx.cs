using System;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;
using System.ComponentModel;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
public partial class Participations : System.Web.UI.Page
{

 protected void Page_Load(object sender, EventArgs e)
 {
 
}

 protected void Button1_Click1(object sender, EventArgs e)
 {
     try
     {
         String conn = "Data Source=USER-PC\\SQLEXPRESS;Initial Catalog=TU;Integrated Security=True";
         SqlConnection myConn = new SqlConnection(conn);

         SqlCommand insert = new SqlCommand("insert into Participation(Movie_ID,Actor_ID) values ('" + TextBox2.Text + "','" + TextBox3.Text + "')", myConn);
         myConn.Open();
         insert.ExecuteNonQuery();
         myConn.Close();
         Label1.Text = "Επιτυχής Εισαγωγή ταινίας!!!";
         SqlDataSource1.SelectCommand = "commandString";
         GridView1.DataBind();

     }
     catch (Exception e1)
     {
         Console.WriteLine(e1.ToString());

     }
 }
}


