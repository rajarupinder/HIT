using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class UserProfile : System.Web.UI.Page
{
    //GLOBAL DECLARATION OF MAIN MODULE FUNCTIONS

    UserFunctionsBAL getusername = new UserFunctionsBAL();
    UserFunctionsBAL blog = new UserFunctionsBAL();

    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["user_id"] == null)
        {
            Response.Redirect("~/HopeInTomorrow/sign_in.aspx");
        }

        UserName.Text = getusername.UserNameFetch(Convert.ToInt32(Session["user_id"]));

        //------------------------loading last blog entry-------------------------
       

    }


   
}



