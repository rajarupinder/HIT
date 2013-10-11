using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

/// <summary>
/// Summary description for AdminLoginDAL
/// </summary>
public class AdminFunctionsDAL
{
	public AdminFunctionsDAL()
	{
		//
		// TODO: Add constructor logic here
		//
	}

    SqlConnection newcon = new SqlConnection(ConfigurationManager.ConnectionStrings["hit"].ConnectionString);
    String query;
    SqlCommand command;
    SqlDataReader reader ;
    SqlDataAdapter adapter; 
    

    public Boolean AdminLoginAuthenticate(admin_infoBO admin_credinatials)
    {
        try
        {
            newcon.Open();
            query = "Select admin_id from admin_info where email_id=@email and password=@pass";

            command = new SqlCommand(query, newcon);

            command.Parameters.AddWithValue("@email", admin_credinatials.email_id);
            command.Parameters.AddWithValue("@pass", admin_credinatials.password);

            reader = command.ExecuteReader();

            command.Dispose();

            if (reader.HasRows)  //username or password is correct
            {
                return true;
            }
            else
            {
                return false;              //Username or password not correct
            }


        }
        catch
        {
            throw;

        }

        finally
        {
            reader.Dispose();
            newcon.Close();
        }
    }                        //end of admin login authentication 



    public admin_infoBO AdminCompleteInfoFetch(admin_infoBO admin_credentials)     //fetching the admin general information
    {
        try
        {

            newcon.Open();

            query = "Select * from admin_info where email_id=@email";

            command = new SqlCommand(query, newcon);

            command.Parameters.AddWithValue("@email", admin_credentials.email_id);
            

            reader = command.ExecuteReader();

            command.Dispose();

            if (reader.HasRows)
            {
                admin_infoBO admin_info = new admin_infoBO();

                reader.Read();

                admin_info.admin_id = Convert.ToInt32(reader[0]);              //admin_id 
                admin_info.first_name = Convert.ToString(reader[3]);           //admin_firstname         
                admin_info.last_name = Convert.ToString(reader[4]);            //admin_lastname  
                return admin_info;
            }
            else
            {
                return null;
            }
        }

        catch
        {
            throw;
        }

        finally
        {
            reader.Dispose();
            newcon.Close();
        }
    }                                             //end of adming information fetch function 



    

    public Boolean AdminPasswordChange(admin_infoBO admin_info,String newpass)     //Admin passwrod change function 
    {
        try
        {

            if (AdminPasswordCheck(admin_info.admin_id, admin_info.password))
            {
                newcon.Open();
                query = "update admin_info set admin_password='@newpass' where admin_id=@admin_id";

                command = new SqlCommand(query, newcon);

                command.Parameters.AddWithValue("@admin_id", admin_info.admin_id);
                command.Parameters.AddWithValue("@newpass", newpass);
                command.ExecuteNonQuery();

                return true;

            }
            else
            {
                return false;
            }
        }
        catch
        {
            throw;
        }

        finally
        {
            command.Dispose();
            newcon.Close();
        }
    }

    private Boolean AdminPasswordCheck(int id,String pwd)
    {
        try
        {

            newcon.Open();
            query = "Select admin_pass from admin_info where admin_id=@admin_id";

            command = new SqlCommand(query, newcon);

            command.Parameters.AddWithValue("@admin_id", id);

            reader = command.ExecuteReader();

            command.Dispose();

            if (reader.HasRows)
            {
                reader.Read();
                if (reader[0].ToString() == pwd)
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }
            else
            {
                return false;
            }
        }

        catch
        {
            throw;
        }

        finally
        {
            reader.Dispose();
            newcon.Close();
        }
           
    }




                                                        //User profile viewing functions 

    public DataSet ListAllUsers()
    {

        try
        {
            if (newcon.State == ConnectionState.Closed)
            {
                newcon.Open();
            }

            DataSet ds = new DataSet();
            String query = "Select user_id,email_id,first_name,last_name,user_type,join_date from user_info";
            adapter = new SqlDataAdapter(query, newcon);
            adapter.Fill(ds);

            return ds;
        }
        catch
        {
            throw;
        }
        finally
        {
            if (newcon.State == ConnectionState.Open)
            {
                newcon.Close();
            }
        }
    }





                                                        //admin blog management functions 


                                                        //blog loader 

    public DataSet AdminBlogLister()
    {
        try
        {
            if (newcon.State == ConnectionState.Closed)
            {
                newcon.Open();
            }

            DataSet ds = new DataSet();
            String query = "Select blog_id,blog_title,date_time_of_post from blog_post ORDER BY (date_time_of_post) DESC";
            adapter = new SqlDataAdapter(query, newcon);
            adapter.Fill(ds);

            return ds;
        }
        catch
        {
            throw;
        }
        finally
        {
            if (newcon.State == ConnectionState.Open)
            {
                newcon.Close();
            }
        }
    }


    public DataSet MyBlogLister(int admin_id)
    {
        try
        {
            if (newcon.State == ConnectionState.Closed)
            {
                newcon.Open();
            }

            DataSet ds = new DataSet();
            String query = "Select blog_id,blog_title,date_time_of_post from blog_post where poster_id="+admin_id+" ORDER BY (date_time_of_post) DESC";
            adapter = new SqlDataAdapter(query, newcon);
            adapter.Fill(ds);

            return ds;
        }
        catch
        {
            throw;
        }
        finally
        {
            if (newcon.State == ConnectionState.Open)
            {
                newcon.Close();
            }
        }
    }


    public void AdminBlogDelete(blog_postBO blogInfo)
    {
        try
        {
            if (newcon.State == ConnectionState.Closed)
            {
                newcon.Open();
            }

            
            String query = "Delete from blog_post where blog_id = @bid";
            command = new SqlCommand(query, newcon);
            command.Parameters.AddWithValue("@bid", blogInfo.blog_id);
            command.ExecuteNonQuery();            
        }
        catch
        {
            throw;
        }
        finally
        {
            if (newcon.State == ConnectionState.Open)
            {
                newcon.Close();
            }
        }
    }


    public blog_postBO AdminBlogViewer(int blog_id)
    {
        blog_postBO blog = new blog_postBO();
        try
        {
            if (newcon.State == ConnectionState.Closed)
            {
                newcon.Open();
            }


            String query = "Select * from blog_post where blog_id = @bid";
            command = new SqlCommand(query, newcon);
            command.Parameters.AddWithValue("@bid", blog_id);

            reader = command.ExecuteReader();

            if (reader.HasRows)
            {
                reader.Read();
                {
                    blog.blog_id = Convert.ToInt32(reader[0]);
                    blog.blog_title = reader[1].ToString();
                    blog.blog_content = reader[2].ToString();
                    blog.poster_id = Convert.ToInt32(reader[3]);
                    blog.is_admin = (Convert.ToInt16(reader[4]) == 1) ? true : false;
                    blog.date_time_of_post = Convert.ToDateTime(reader[5]);
                }
            }
            else
            {
                blog = null;
            }

            command.Dispose();
            reader.Dispose();
                
            return blog;
        }
        catch
        {
            throw;
        }
        finally
        {
            if (newcon.State == ConnectionState.Open)
            {
                newcon.Close();
            }
        }
    }


    public void AdminBlogEdit(blog_postBO nBlog)
    {
        try
        {
            if (newcon.State == ConnectionState.Closed)
            {
                newcon.Open();
            }


            String query = "Update blog_post set blog_title=@title,blog_content=@content where blog_id = @bid";
            command = new SqlCommand(query, newcon);

            command.Parameters.AddWithValue("@title", nBlog.blog_title.ToString());
            command.Parameters.AddWithValue("@content", nBlog.blog_content.ToString());
            command.Parameters.AddWithValue("@bid", nBlog.blog_id);


            command.ExecuteNonQuery();
            command.Dispose();
            newcon.Close();
            
        }
        catch
        {
            throw;
        }

        finally
        {
            if (newcon.State == ConnectionState.Open)
            {
                newcon.Close();
            }
        }
    }


    public void AdminPostBlog(blog_postBO nBlog)
    {
        try
        {
            Next_ID nid = new Next_ID();
            nBlog.blog_id = nid.incrementer("blog_id", "blog_post");

            if (newcon.State == ConnectionState.Closed)
            {
                newcon.Open();
            }


            
            int isadmin = 0;
            
            nBlog.date_time_of_post = System.DateTime.Now;


            if (nBlog.is_admin)
            {
                isadmin = 1;
            }
            else
            {
                isadmin = 0;
            }

            String query = "insert into blog_post values(@bid,@title,@content,@posterid,@isadmin,@datetime)";
            command = new SqlCommand(query, newcon);

            command.Parameters.AddWithValue("@bid",nBlog.blog_id);
            command.Parameters.AddWithValue("@title", nBlog.blog_title.ToString());
            command.Parameters.AddWithValue("@content", nBlog.blog_content.ToString());
            command.Parameters.AddWithValue("@posterid",nBlog.poster_id);
            command.Parameters.AddWithValue("@isadmin",isadmin);
            command.Parameters.AddWithValue("@datetime", nBlog.date_time_of_post.ToString());

            command.ExecuteNonQuery();
            command.Dispose();
            newcon.Close();
        }

        catch
        {
            throw;
        }
        finally
        {
            if (newcon.State == ConnectionState.Open)
            {
                newcon.Close();
            }
        }
    }

    public String AdminName(int admin_id)
    {
        String AdminName = "";

        try
        {
            if (newcon.State == ConnectionState.Closed)
            {
                newcon.Open();
            }


            String query = "Select first_name,last_name from admin_info where admin_id = @aid";
            command = new SqlCommand(query, newcon);
            command.Parameters.AddWithValue("@aid", admin_id);

            reader = command.ExecuteReader();

            if (reader.HasRows)
            {
                reader.Read();
                {
                    AdminName = reader[0].ToString() + " " + reader[1].ToString();
                }
            }
            else
            {
                AdminName = "";
            }

            command.Dispose();
            reader.Dispose();


            return AdminName;
        }

        catch
        {
            throw;
        }
        finally
        {
            if (newcon.State == ConnectionState.Open)
            {
                newcon.Close();
            }
        }
    }



                                                                 // Admin Events functions 

    public void PostNewEvent(eventsBO new_event)                 //post new event 
    {

        try
        {
            Next_ID nid = new Next_ID();
            new_event.event_id = nid.incrementer("event_id", "events");

            if (newcon.State == ConnectionState.Closed)
            {
                newcon.Open();
            }


            String query = "insert into events(event_id,admin_id,event_title,event_desc,event_time,event_place,date_time_of_post) values(@eid,@aid,@title,@desc,@etime,@eplace,@datetime)";
            command = new SqlCommand(query, newcon);

            command.Parameters.AddWithValue("@eid", new_event.event_id);
            command.Parameters.AddWithValue("@aid",new_event.admin_id);
            command.Parameters.AddWithValue("@title", new_event.event_title.ToString());
            command.Parameters.AddWithValue("@desc",new_event.event_desc.ToString());
            command.Parameters.AddWithValue("@etime",new_event.event_time);
            command.Parameters.AddWithValue("@eplace",new_event.event_place.ToString());
            command.Parameters.AddWithValue("@datetime", new_event.date_time_of_post);

            command.ExecuteNonQuery();
            command.Dispose();
            newcon.Close();
        }

        catch
        {
            throw;
        }
        finally
        {
            if (newcon.State == ConnectionState.Open)
            {
                newcon.Close();
            }
        }
    }


    public DataSet AdminEventLister()
    {
        try
        {
            if (newcon.State == ConnectionState.Closed)
            {
                newcon.Open();
            }

            DataSet ds = new DataSet();
            String query = "Select event_id,event_title,event_time,event_place,date_time_of_post from events ORDER BY (date_time_of_post) DESC";
            adapter = new SqlDataAdapter(query, newcon);
            adapter.Fill(ds);

            return ds;
        }
        catch
        {
            throw;
        }
        finally
        {
            if (newcon.State == ConnectionState.Open)
            {
                newcon.Close();
            }
        }
    }
}