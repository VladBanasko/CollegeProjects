using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HockeyVladyslavBanasko
{
    public partial class AddPlayer : System.Web.UI.Page
    {
        MyDatabaseTableAdapters.PlayerTableAdapter adpPl = new MyDatabaseTableAdapters.PlayerTableAdapter();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public void Add_Click(object sender, EventArgs e)
        {

            string name = TextBoxName.Text;
            string num1 = TextBoxNum.Text;
            int num = int.Parse(num1);


            

           int result =  adpPl.Insert(name, num);


            if (result == 1)
            {
                lblMessage.Text = "New player inserted";
                lblMessage.ForeColor = System.Drawing.Color.Green;
            }
            else
            {
                lblMessage.Text = "New player not inserted";
                lblMessage.ForeColor = System.Drawing.Color.Red;
            }
        }

    }
}