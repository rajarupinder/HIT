using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_BlogViewer : System.Web.UI.Page
{
    AdminFunctionsBAL blogviewer = new AdminFunctionsBAL();
    blog_postBO blog = new blog_postBO();
    protected void Page_Load(object sender, EventArgs e)
    {


        if (Session["admin_id"] == null)
        {
            Response.Redirect("AdminLogin.aspx");
        }
        else
        {
            if (!(Page.IsPostBack))
            {

                if (Request.QueryString["id"] == null)
                {
                    Response.Redirect("~/Admin/AdminBlog.aspx");
                }

                else
                {

                    try
                    {
                        blog = blogviewer.AdminBlogViewer(Convert.ToInt32(Request.QueryString["id"]));

                        if (blog == null)
                        {
                            Response.Write("Sorry, But the blog is not present");
                        }
                        else
                        {

                            div_blog_title.InnerText = Server.HtmlDecode(blog.blog_title.ToString());
                            div_blog_date_time.InnerText = Server.HtmlDecode((blog.date_time_of_post).ToLongDateString());
                            div_blog_body.InnerHtml = Server.HtmlDecode(blog.blog_content.ToString());
                            spn_posterName.InnerText = Server.HtmlDecode((blogviewer.AdminName(blog.poster_id)).ToString());   //getting the admin name from admin_id
                            spn_timeOfPost.InnerText = Server.HtmlDecode(blog.date_time_of_post.ToShortTimeString());
                           
                        }
                    }
                    catch (Exception ex)
                    {
                        Response.Write("Error Ocured : " + ex.ToString());
                    }

                }
            }
        }
    }
    protected void btnEdit_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/Admin/BlogEditor.aspx?id="+Request.QueryString["id"]);
    }
    protected void btnClose_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/Admin/AdminBlog.aspx");
    }



  


}