using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;

/// <summary>
/// Summary description for AdminLogin
/// </summary>
public class AdminFunctionsBAL
{
    AdminFunctionsDAL adminfunction = new AdminFunctionsDAL();


    public Boolean AdminLoginAuthenticate(admin_infoBO admin_credentials)
    {
        try
        {

            return adminfunction.AdminLoginAuthenticate(admin_credentials);
        }
        catch
        {
            throw;
        }

    }


    public admin_infoBO AdminCompleteInfoFetch(admin_infoBO admin_info)
    {
        try
        {
            return adminfunction.AdminCompleteInfoFetch(admin_info);
        }

        catch
        {
            throw;
        }
    }

    public String AdminPasswordChange(admin_infoBO admin_info,String newpass)
    {

        if (adminfunction.AdminPasswordChange(admin_info, newpass))
        {
            return "Password Changed successfully";
        }

        else
        {
            return "Something went wrong and password didn't change";
        }
    }


    public DataSet ListAllUsers()
    {
        try
        {

            return adminfunction.ListAllUsers();
        }
        catch
        {
            throw;
        }
    }


    public DataSet AdminBlogLister()
    {
        try
        {

            return adminfunction.AdminBlogLister();
        }
        catch 
        {
            throw;
        }
    }

    public DataSet MyBlogLister(int admin_id)
    {
        try
        {
            return adminfunction.MyBlogLister(admin_id);
        }

        catch
        {
            throw;
        }
    }

    public void AdminBlogDelete(blog_postBO blogInfo)
    {
        try
        {
            adminfunction.AdminBlogDelete(blogInfo);
        }
        catch
        {
            throw; 
        }
    }


    public blog_postBO AdminBlogViewer(int blog_id)
    {
        try
        {
            return adminfunction.AdminBlogViewer(blog_id);
        }
        catch
        {
            throw;
        }

    }


   public void AdminBlogEdit(blog_postBO nBlog)
   {
       try
       {
           adminfunction.AdminBlogEdit(nBlog);
       }

       catch
       {
           throw;
       }
   }


   public void AdminPostBlog(blog_postBO nblog)
   {
       try
       {
           adminfunction.AdminPostBlog(nblog);

       }
       catch
       {
           throw;
       }
   }

   public String AdminName(int admin_id)
   {
       try
       {
           return adminfunction.AdminName(admin_id);
       }
       catch
       {
           throw;
       }
   }

   public DataSet AdminEventLister()
   {
       try
       {
           return adminfunction.AdminEventLister();
       }
       catch
       {
           throw;
       }
   }

   public void PostNewEvent(eventsBO new_event)
   {
       try
       {
           adminfunction.PostNewEvent(new_event);
       }

       catch
       {
           throw;
       }
   }
}