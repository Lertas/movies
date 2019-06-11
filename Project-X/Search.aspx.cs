using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Data.SqlTypes;

public partial class Search : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    //κλικ χρήστη
    protected void Button1_Click(object sender, EventArgs e)
    {
        try
        {
            //σύνδεση με τη βάση μου
            String conn = "Data Source=USER-PC\\SQLEXPRESS;Initial Catalog=TU;Integrated Security=True";
            SqlConnection myConn = new SqlConnection(conn);
            SqlDataAdapter select = new SqlDataAdapter("select * from Movie,Actor where Actor.Surname ='" + TextBox1.Text + "' and Actor.Actor_ID=Movie.Main_Actor_ID"  , myConn);
            DataSet st = new DataSet();
            myConn.Open();
            select.Fill(st);
            myConn.Close();
            

            String Movie_ID;
            String Title;
            String Main_Actor_ID;
            String Publish_Studio_ID;
            String Date_Published;
            //TableCells 
            foreach (DataRow row in st.Tables[0].Rows)
            {
                TableRow trow = new TableRow();

                TableCell Movie_IDCell = new TableCell();
                Movie_ID = row.ItemArray.GetValue(0).ToString();
                Movie_IDCell.Text = Movie_ID;
                trow.Cells.Add(Movie_IDCell);

                TableCell TitleCell = new TableCell();
                Title = row.ItemArray.GetValue(1).ToString();
                TitleCell.Text = Title;
                trow.Cells.Add(TitleCell);

                TableCell Main_Actor_IDCell = new TableCell();
                Main_Actor_ID = row.ItemArray.GetValue(2).ToString();
                Main_Actor_IDCell.Text = Main_Actor_ID;
                trow.Cells.Add(Main_Actor_IDCell);

                TableCell Publish_Studio_IDCell = new TableCell();
                Publish_Studio_ID = row.ItemArray.GetValue(3).ToString();
                Publish_Studio_IDCell.Text = Publish_Studio_ID;
                trow.Cells.Add(Publish_Studio_IDCell);

                TableCell Date_PublishedCell = new TableCell();
                Date_Published = row.ItemArray.GetValue(3).ToString();
                Date_PublishedCell.Text = Date_Published;
                trow.Cells.Add(Date_PublishedCell);

                Table1.Rows.Add(trow);

            }
        }
        catch (Exception e1)
        {
            Console.WriteLine(e1.ToString());

        }

    }

}


