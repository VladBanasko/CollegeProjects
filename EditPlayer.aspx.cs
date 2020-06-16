using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HockeyVladyslavBanasko
{

    public partial class EditPlayer : System.Web.UI.Page
    {

        MyDatabaseTableAdapters.PlayerTableAdapter adpPl = new MyDatabaseTableAdapters.PlayerTableAdapter();
        MyDatabaseTableAdapters.StatisticTableAdapter adpSt = new MyDatabaseTableAdapters.StatisticTableAdapter(); 
        MyDatabase.PlayerDataTable tblPl = new MyDatabase.PlayerDataTable();


        protected void Page_Load(object sender, EventArgs e)
        {
        }



        protected void btn1_Click(object sender, EventArgs e)
        {
            string name = txtboxName.Text;

            tblPl = adpPl.GetPlayerName(name);

            rblistNames.DataSource = tblPl;
            rblistNames.DataValueField = "PlayerName";
            rblistNames.DataBind();
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            String name = rblistNames.SelectedValue;

            int? id = adpPl.GetId(name);

            int newID = id.GetValueOrDefault();

            string newName = txtboxNewName.Text;
            int newNumber = int.Parse(txtboxNewNumber.Text);

            adpPl.Update(newName, newNumber, newID);
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            String name = rblistNames.SelectedValue;

            int? id = adpPl.GetId(name);

            int ID = id.GetValueOrDefault();

            int? StatId = adpSt.GetStatIdFromPlayerID(ID);

            int Stat = StatId.GetValueOrDefault();

            adpPl.Delete(ID);
            adpSt.Delete(Stat);
        }

        
    }
}