using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Security;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;

public partial class donate_form : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        
    }
    protected void donate_form_btn_click(object sender, EventArgs e)
    {


        Session["x_amount"] = x_amount.Value;
        //Response.Redirect("form1.aspx");
        Response.Write("<script>window.open('form1.aspx','_blank','width=800,height=600')</script>"); 
        


    }
}