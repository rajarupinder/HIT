using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class HopeInTomorrow_ViewPost : System.Web.UI.Page
{
    blog_postBO blog = new blog_postBO();
    UserFunctionsBAL blogviewer = new UserFunctionsBAL();
    int id;


    protected void Page_Load(object sender, EventArgs e)
    {

        if (Request.QueryString["id"] == null)
        {
            Response.Redirect("~/HopeInTomorrow/Blog.aspx");
        }

        else
        {

            try
            {
                id = Convert.ToInt32(Request.QueryString["id"]);
                blog = blogviewer.UserBlogViewer(id);

                if (blog == null)
                {
                    div_blog_title.InnerText ="Sorry, But the blog is not present";
                }
                else
                {

                    div_blog_title.InnerText = Server.HtmlDecode(blog.blog_title.ToString());
                    div_blog_date_time.InnerText = Server.HtmlDecode((blog.date_time_of_post).ToLongDateString());
                    div_blog_body.InnerHtml = Server.HtmlDecode(blog.blog_content.ToString());
                    spn_posterName.InnerText = Server.HtmlDecode((blogviewer.UserNameFetch(blog.poster_id)).ToString());   //getting the admin name from admin_id
                    spn_timeOfPost.InnerText = Server.HtmlDecode(blog.date_time_of_post.ToShortTimeString());


                    //lading the comments 
                    Listcomments();
                    
                }
            }
            catch (Exception ex)
            {
                Response.Write("Error Ocured : " + ex.ToString());
            }

        }
    }
    protected void btnPostComment_Click(object sender, EventArgs e)
    {
        try
        {
            if (Session["user_id"] != null)
            {
                blog_commentsBO usercomment = new blog_commentsBO();

                //First : Post the comment 

                usercomment.blog_id = id;
                usercomment.is_admin = false;
                usercomment.poster_id = Convert.ToInt32(Session["user_id"]);
                usercomment.comment = txtcomment.Value.ToString();

                blogviewer.BlogPostComments(usercomment);

                txtcomment.Value = "";

                // Second : Load the comments 

                Listcomments();
            }
            else
            {
                Response.Write("<script type='text/javascript'> alert('Sign In First To Post Any Comments'); </script>");
            }
        }
        catch(Exception ex)
        {
            Response.Write(ex.ToString());
        }
    }


    protected String commenter_name(int id, int is_admin)
    {

            String name = "";
            if (is_admin == 0)
            {
                name = blogviewer.UserNameFetch(id);
            }
            else if (is_admin == 1)
            {
                name = blogviewer.AdminNameFetch(id);
            }

            return name;

    }

    protected void Listcomments()
    {

        dlBlogComments.DataSource = blogviewer.LoadBlogPostComments(id);
        dlBlogComments.DataBind();
    }


    protected String LnToBr(String s)
    {
        String replaced_string = s.Replace("\n", "<br/>");
        return replaced_string;
    }


    protected bool checkForCommentOptions(int comment_id,int poster_id, int is_admin)
    {
        if (Session["user_id"] != null)          // means users has already been logged in 
        {
            if ((Convert.ToInt32(Session["user_id"])) == poster_id && is_admin == 0)     //It's the curre logged in user's post , so its ok to load the options "Edit" & "Delete"
            {
               //// LinkButton lnkbtnEdit = new LinkButton();
               // LinkButton lnkbtnDelete = new LinkButton();
                
               //// lnkbtnEdit.CommandArgument = comment_id.ToString();
               // lnkbtnDelete.CommandArgument = comment_id.ToString();


               //// lnkbtnEdit.Command += lnkbtnEdit_Command;
               // lnkbtnDelete.Command += lnkbtnDelete_Command;

               // lnkbtnDelete.Text = "Delete";
               // //lnkbtnEdit.Text = "Edit";

                
               

            }

        }

            return true;
    }



    //protected void lnkbtnEdit_Command(object sender, CommandEventArgs e)
    //{
    //}

    protected void lnkbtnDelete_Command(object sender, CommandEventArgs e)
    {
    }


}