using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

public partial class Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        try
        {
            //Σύνδεση με τη βάση μου
            SqlDataReader dr;
            String conn = "Data Source=USER-PC\\SQLEXPRESS;Initial Catalog=TU;Integrated Security=True";
            SqlConnection myConn = new SqlConnection(conn);

            SqlCommand select = new SqlCommand("select  * from AllowedUsers where  username='" + TextBox1.Text + "' and pass='" + TextBox2.Text + "'", myConn);
            myConn.Open();
            select.ExecuteNonQuery();
            dr = select.ExecuteReader();

            //ανακατεύθυνση σελίδας
            if (dr.Read())
            {
                myConn.Close();
                Response.Redirect("Database.aspx");
               
            }
            else
            {
                //σε περίπτωση πληκτρολόγησης λάθους
                TextBox1.Text = "";
                TextBox2.Text = "";
                TextBox1.Focus();
                Label3.Text = "Invalid Username-Password";
            }
        }
        catch (Exception e1)
        {
            Console.WriteLine(e1.ToString());
            Label3.Text = e1.ToString();
        }
    }
    
}

