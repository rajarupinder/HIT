using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Net.Mail;
using System.Configuration;

/// <summary>
/// Summary description for UserFunctionsBAL
/// </summary>
public class UserFunctionsBAL
{

    UserFunctionsDAL userFunctions = new UserFunctionsDAL();

    public UserFunctionsBAL()
    {
        //
        // TODO: Add constructor logic here
        //
    }




    public bool UserSigIn(user_infoBO user_credentials)
    {
        try
        {
            return userFunctions.UserSignIn(user_credentials);
        }
        catch
        {
            throw;
        }
    }

    public int UserIdFetch(String email_id)
    {
        try
        {
            return userFunctions.UserIDFetch(email_id);
        }
        catch
        {
            throw;
        }
    }

    public String UserNameFetch(int user_id)
    {
        try
        {
            return userFunctions.UserNameFetch(user_id);
        }
        catch
        {
            throw;
        }
    }

    public String AdminNameFetch(int admin_id)
    {
        try
        {
            return userFunctions.AdminNameFetch(admin_id);
        }
        catch
        {
            throw;
        }
    }

    public int NewUserRegister(user_infoBO user_info)
    {
        try
        {
            
            return userFunctions.NewUserRegister(user_info);
        }

        catch
        {
            throw;
        }
    }

    public int ForgotPassword(String email)
    {
        try
        {
            if (userFunctions.check_emailId(email))
            {
                String message = " <h1>Hope In Tomorrow </h1> <br/> <br/> Your Password is : " + userFunctions.GetPass(email).ToString() + "<br/><br/>This is a self generated email , please do not reply";
                String subject = "Hope In Tomorrow : Password Recovery";
                MailMessage mail = new MailMessage(ConfigurationManager.AppSettings["FromEmail"], email, subject, message);
                mail.IsBodyHtml = true;

                SmtpClient client = new SmtpClient();

                client.Host = ConfigurationManager.AppSettings["SMTP"];
                client.EnableSsl = true;
                client.Credentials = new System.Net.NetworkCredential(ConfigurationManager.AppSettings["FromEmail"].ToString(), ConfigurationManager.AppSettings["Pass"].ToString());

                client.Send(mail);

                return 1;
            }

            else
            {
                return 0;
            }
        }
        catch
        {
            throw;
        }
    }

    public void JoinUsMail(String email_id)
    {

        try
        {
          
                String message = " <h1>Hope In Tomorrow </h1> <br/> <br/> <h4> Thank You for joining Hope In Tomorrow </h4><br/><br/>This is a self generated email , please do not reply";
                String subject = "Hope In Tomorrow";
                MailMessage mail = new MailMessage(ConfigurationManager.AppSettings["FromEmail"], email_id, subject, message);
                mail.IsBodyHtml = true;

                SmtpClient client = new SmtpClient();

                client.Host = ConfigurationManager.AppSettings["SMTP"];
                client.EnableSsl = true;
                client.Credentials = new System.Net.NetworkCredential(ConfigurationManager.AppSettings["FromEmail"].ToString(), ConfigurationManager.AppSettings["Pass"].ToString());

                client.Send(mail);

        }
        catch
        {
            throw;
        }

    }

    public DataSet ListBlog()
    {
        try
        {
            return userFunctions.ListBlog();
        }
        catch
        {
            throw;
        }
    }

    public blog_postBO UserBlogViewer(int blog_id)
    {
        try
        {
            return userFunctions.UserBlogViewer(blog_id);
        }
        catch
        {
            throw;
        }
    }

    public void BlogPostComments(blog_commentsBO blogComment)
    {
        try
        {
            userFunctions.BlogPostComments(blogComment);
        }
        catch
        {
            throw;
        }
    }

    public DataSet LoadBlogPostComments(int blog_id)
    {
        try
        {
            return userFunctions.LoadBlogPostComments(blog_id);
        }
        catch
        {
            throw;
        }
    }
}