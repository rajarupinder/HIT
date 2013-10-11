using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class join_us : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["user_id"] != null)
        {
            Response.Redirect("~/HopeInTomorrow/login_user.aspx");
        }

        rdoVolunteer.Checked = true;
    }



    protected void bntJoinMe_Click(object sender, EventArgs e)
    {
        try
        {

            UserFunctionsBAL registeruser = new UserFunctionsBAL();

            user_infoBO user_info = new user_infoBO();

            String email_id = user_info.email_id = txtEmail.Value.ToString();
            user_info.first_name = txtFname.Value.ToString();
            user_info.last_name = txtLname.Value.ToString();
            user_info.country = sltCountry.Value.ToString();
            user_info.city = sltCity.Value.ToString();
            user_info.password = txtPassword.Value.ToString();
            if (rdoBlogger.Checked == true)
            {
                user_info.user_type = true;
            }
            else
            {
                user_info.user_type = false;
            }

            int check = registeruser.NewUserRegister(user_info);

            if ( check == 1)
            {
                Response.Write("<script type='text/javascript'> alert('Email ID Already Registered ... !') </script>");
            }
            else if (check == 2)
            {
                //Response.Write("<script>alert('Thanks For Joining Us ... !'); </script>");
                registeruser.JoinUsMail(email_id);

               
                
                Response.Redirect("~/HopeInTomorrow/sign_in.aspx");
            }

            txtEmail.Value = "";
            txtFname.Value = "";
            txtLname.Value = "";
            rdoBlogger.Checked = false;
            rdoVolunteer.Checked = false;
        }
        catch (Exception ex)
        {
            Response.Write(ex.ToString());
        }

    }
}