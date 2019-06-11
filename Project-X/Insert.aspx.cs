using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

public partial class Insert : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
  
        //κλικ χρήστη
    protected void Button1_Click1(object sender, EventArgs e)
    {
        try
        {
            String conn = "Data Source=USER-PC\\SQLEXPRESS;Initial Catalog=TU;Integrated Security=True";//Σύνδεση με τη βάση μου
            SqlConnection myConn = new SqlConnection(conn);
            SqlCommand select = new SqlCommand("select Movie_ID,Title,Main_Actor_ID,Publish_Studio_ID,Date_Published from Movie", myConn);

            myConn.Open();
            select.ExecuteNonQuery();
            SqlDataReader dr = select.ExecuteReader();   
            int flag = 0;

            while (dr.Read())
            {
                Label1.Text = "";
                DateTime date;
                String[] s;
                String[] d;
                flag = 0;              //Flag: Σε περιπτωση εμφάνισης κάποιου λάθους

                s = dr[3].ToString().Split(' ');

                if ((TextBox1.Text == "") || (TextBox2.Text == "") || (TextBox3.Text == "") || (TextBox4.Text == "")|| (TextBox5.Text == ""))
                {
                    Label1.Text = "Συμπληρώστε όλα τα πεδία...";             
                    flag++;
                    break;
                }

                else
                {
                    if (DateTime.TryParseExact(TextBox5.Text, "MM/dd/yyyy", null, DateTimeStyles.None, out date) == false)
                    {                                                
                        Label1.Text = "λανθασμένη Ημερομηνία(Πρέπει η μορφή της να είναι ΜΜ/dd/yyyy)";               
                        flag++;
                        break;
                    }
                    else
                    {
                        date = DateTime.Parse(TextBox5.Text);//Εισαγωγή ημερομηνίας
                        d = date.ToString().Split(' ');

                        if (dr[0].ToString() == TextBox1.Text)
                        {
                            Label1.Text = "Η ταινία υπάρχει ήδη";        
                            TextBox1.Text = "";
                            TextBox1.Focus();
                            flag++;
                            break;
                        }
                        else if ((dr[1].ToString() == TextBox2.Text) && (dr[2].ToString() == TextBox3.Text) && (s[0] == d[0]))//ύπαρξη ήδη καταχώρησης
                        {
                            Label1.Text = "Υπάρχει ήδη καταχώρηση";
                            TextBox2.Text = "";                         
                            TextBox3.Text = "";
                            TextBox4.Text = "";
                            TextBox1.Focus();
                            flag++;
                            break;
                        }
                    }
                }
            }
            if (flag == 0) //Αν έχουν συμπληρωθεί όλα τα πεδία
            {
                myConn.Close();
                SqlCommand insert = new SqlCommand("insert into Movie(Movie_ID,Title,Main_Actor_ID,Publish_Studio_ID,Date_Published) values ('" + TextBox1.Text + "','" + TextBox2.Text + "','" + TextBox3.Text + "','" + TextBox4.Text + "','" + TextBox5.Text + "')", myConn);
                myConn.Open();
                insert.ExecuteNonQuery();
                myConn.Close();
                TextBox1.Text = "";
                TextBox2.Text = "";
                TextBox3.Text = "";
                TextBox4.Text = "";
                TextBox5.Text = "";
                TextBox1.Focus();
                Label1.Text = "Επιτυχής Εισαγωγή ταινίας!!!";

            }
        }
        catch (Exception e1)
        {
            Console.WriteLine(e1.ToString());
            Label1.Text = e1.ToString();
        }
    }
    
}
