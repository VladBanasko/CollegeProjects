using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HockeyVladyslavBanasko
{
    public partial class AddStats : System.Web.UI.Page
    {
        MyDatabaseTableAdapters.PlayerTableAdapter adpPl = new MyDatabaseTableAdapters.PlayerTableAdapter();
        MyDatabaseTableAdapters.StatisticTableAdapter adpSt = new MyDatabaseTableAdapters.StatisticTableAdapter(); MyDatabase.PlayerDataTable tblPl = new MyDatabase.PlayerDataTable();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                tblPl = adpPl.GetPlayer();

                // populate the Categories ListBox
                ddlPlayers.DataSource = tblPl;
                ddlPlayers.DataTextField = tblPl.PlayerNameColumn.ToString();
                ddlPlayers.DataValueField = tblPl.PlayerIDColumn.ToString();

                ddlPlayers.DataBind();
            }


        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            int ID = int.Parse(ddlPlayers.SelectedValue);

            Label1.Text = ID.ToString();


            int mathesPlayed = int.Parse(txtboxMathesPlayed.Text);
            int mathesWon = int.Parse(txtboxMathesWon.Text);
            int assists = int.Parse(txtboxAssists.Text);
            int goals = int.Parse(txtboxGoals.Text);
            int? points = assists * goals;

            int ? test = adpSt.GetStatIdFromPlayerID(ID);


            if (test == null)
            {
                adpSt.Insert(ID, mathesPlayed, mathesWon, assists, goals, points);
                Label1.Text = "Insert";
            } else
            {
                Label1.Text = "Player already has statistics.Go to Edit Statistic page";
            }

         

        }

       
    }
}