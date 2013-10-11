using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class HopeInTomorrow_Blog : System.Web.UI.Page
{
    UserFunctionsBAL blog = new UserFunctionsBAL();

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!(Page.IsPostBack))
        {
            try
            {

                dlBlog.DataSource = blog.ListBlog();
                dlBlog.DataBind();

            }
            catch (Exception ex)
            {
                Response.Write("Error Ocured : " + ex.ToString());
            }

        }
    }


    protected String GetLongDateFormat(DateTime d)
    {
        return d.ToLongDateString();
    }

    protected void lnkbtnReadMore_Command(object sender, CommandEventArgs e)
    {
        Response.Redirect("~/HopeInTomorrow/ViewPost.aspx?id="+ e.CommandArgument.ToString());
    }
}