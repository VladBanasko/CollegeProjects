using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HockeyVladyslavBanasko
{
    public partial class EditStats : System.Web.UI.Page
    {

        MyDatabaseTableAdapters.PlayerTableAdapter adpPl = new MyDatabaseTableAdapters.PlayerTableAdapter();
        MyDatabaseTableAdapters.StatisticTableAdapter adpSt = new MyDatabaseTableAdapters.StatisticTableAdapter();
        MyDatabase.PlayerDataTable tblPl = new MyDatabase.PlayerDataTable();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            String name = rblistNames.SelectedValue;

            int? id = adpPl.GetId(name);

            int newID = id.GetValueOrDefault();

            int? stat = adpSt.GetStatIdFromPlayerID(newID);

            int StatId = stat.GetValueOrDefault();

            int newMatchPlayed = int.Parse(txtboxMathesPlayed.Text);
            int newMatchWon = int.Parse(txtboxMathesWon.Text);
            int newAssists = int.Parse(txtboxAssists.Text);
            int newGoals = int.Parse(txtboxGoals.Text);


            int? points = newAssists * newGoals;

            adpSt.Update(newID, newMatchPlayed, newMatchWon, newAssists, newGoals, points, StatId);
            Label1.Text = "Updated";
        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            string name = txtboxName.Text;

            tblPl = adpPl.GetPlayerName(name);

            rblistNames.DataSource = tblPl;
            rblistNames.DataValueField = tblPl.PlayerNameColumn.ToString();
            rblistNames.DataBind();
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            String name = rblistNames.SelectedValue;

            
            int? id = adpPl.GetId(name);

            int newID = id.GetValueOrDefault();

            int? stat = adpSt.GetStatIdFromPlayerID(newID);

            int StatId = stat.GetValueOrDefault();

            adpSt.Delete(StatId);
            Label1.Text = "deleted";
        }

      
    }
}