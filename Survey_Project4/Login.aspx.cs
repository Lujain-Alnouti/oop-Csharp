using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services.Description;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Survey_Project4
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void login_Click(object sender, EventArgs e)
        {
            string[] userN = { "Lujain", "Lubna", "Malek", "Raghad", "Sohaib", "Mohammad", "Ahmad", "Sara", "Alaa", "Hala" };
            string[] userID = { "1324", "1224", "1424", "2724", "3324", "1624", "1524", "1124", "2324", "2424" };
            for(int i = 0; i < userN.Length; i++)
            {
                if((User_input.Text == "Sara" && Id_input.Text == "1124")|| (User_input.Text == "Ahmad" && Id_input.Text == "1524")) {
                    //Response.Redirect("?&username="+User_input.Text+"&empID="+Id_input.Text);
                    mess.Text = "Welcome Admin";
                    break;
                }
                else if (User_input.Text == userN[i]&& Id_input.Text == userID[i])
                {
                    //Response.Redirect("?&username="+User_input.Text+"&empID="+Id_input.Text);

                    mess.Text ="";

                    break;
                }
                else if(User_input.Text ==String.Empty || Id_input.Text == String.Empty)
                {
                    //Response.Redirect("Login.aspx");

                    mess.Text = "Please Fill All Feilds";
                }
                else if(User_input.Text != userN[i] || Id_input.Text != userID[i])
                {
                    
                    mess.Text = "Wronge UserName Or ID";
                    //Response.Redirect("Login.aspx");
                }
            }
        }

        protected void home_Click(object sender, EventArgs e)
        {
            //Response.Redirect("Login.aspx");
        }

        protected void about_Click(object sender, EventArgs e)
        {
            //Response.Redirect("Login.aspx");
        }
    }
}