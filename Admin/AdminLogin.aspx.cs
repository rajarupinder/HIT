using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_AdminLogin : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }



    protected void btnLogin_Click(object sender, EventArgs e)
    {
        admin_infoBO admin_credentials = new admin_infoBO();
        AdminFunctionsBAL admin_login = new AdminFunctionsBAL();


        try
        {

            admin_credentials.email_id = txtadmin_email_id.Value.ToString();
            admin_credentials.password = txtpassword.Value.ToString();

            if (admin_login.AdminLoginAuthenticate(admin_credentials))
            {

                admin_infoBO admin_info = new admin_infoBO();

                admin_info = admin_login.AdminCompleteInfoFetch(admin_credentials);      //fetching the admin_id 
                Session["admin_id"] = admin_info.admin_id;
                Response.Redirect("~/Admin/AdminHome.aspx");
            }
            else
            {
                Response.Write("<script type='text/javascript'> $(function(){alert('Please enter correct email id or password')}); </script>"); ;
            }

        }

        catch (Exception ex)
        {
            Response.Write(ex.ToString());
        }
    }


}