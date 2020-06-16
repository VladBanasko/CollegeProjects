using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HockeyVladyslavBanasko
{
    public partial class Home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // object of table adapter

            MyDatabaseTableAdapters.DataTable1TableAdapter adpAll = new MyDatabaseTableAdapters.DataTable1TableAdapter();

            // object of data table 
            MyDatabase.DataTable1DataTable tblAll = new MyDatabase.DataTable1DataTable();

            adpAll.Fill(tblAll);

            grvStats.DataSource = tblAll;
            grvStats.DataBind();


           // MyDatabaseTableAdapters.QueriesTableAdapter max = new MyDatabaseTableAdapters.QueriesTableAdapter();

       

           // lblHighPoint.Text = max.ToString();

        }
    }
}