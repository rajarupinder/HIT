using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
/// <summary>
/// Summary description for UserFunctionsDAL
/// </summary>
public class UserFunctionsDAL
{
	public UserFunctionsDAL()
	{
		//
		// TODO: Add constructor logic here
		//
	}


    SqlConnection newcon = new SqlConnection(ConfigurationManager.ConnectionStrings["hit"].ConnectionString);
    String query;
    SqlCommand command;
    SqlDataReader reader;
    SqlDataAdapter adapter;


    public bool UserSignIn(user_infoBO user_credentials )
    {

        try
        {
            newcon.Open();
            query = "Select user_id from user_info where email_id=@email and password=@pass";

            command = new SqlCommand(query, newcon);

            command.Parameters.AddWithValue("@email", user_credentials.email_id.ToString());
            command.Parameters.AddWithValue("@pass", user_credentials.password.ToString());

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
    }

    public int UserIDFetch(String user_emial)
    {
        try
        {
            user_infoBO user_info = new user_infoBO();
            if (newcon.State == ConnectionState.Closed)
            {

                newcon.Open();
            }
            query = "Select user_id from user_info where email_id=@email";

            command = new SqlCommand(query, newcon);

            command.Parameters.AddWithValue("@email", user_emial.ToString());


            reader = command.ExecuteReader();

            command.Dispose();

            if (reader.HasRows)
            {
                

                reader.Read();

                user_info.user_id = Convert.ToInt32(reader[0]);

                
            }

            return user_info.user_id;

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

    public String UserNameFetch(int user_id)
    {
        String UserName = "";

        try
        {
            if (newcon.State == ConnectionState.Closed)
            {
                newcon.Open();
            }


            String query = "Select first_name,last_name from user_info where user_id = @uid";
            command = new SqlCommand(query, newcon);
            command.Parameters.AddWithValue("@uid", user_id);

            reader = command.ExecuteReader();

            if (reader.HasRows)
            {
                reader.Read();
                {
                    UserName = reader[0].ToString() + " " + reader[1].ToString();
                }
            }
            else
            {
                UserName = "";
            }

            command.Dispose();
            reader.Dispose();


            return UserName;
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

    public String AdminNameFetch(int admin_id)
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



    public int NewUserRegister(user_infoBO user_info)
    {
        try
        {

            if (!(check_emailId(user_info.email_id)))
            {


                if (newcon.State == ConnectionState.Closed)
                {
                    newcon.Open();
                }

                Next_ID newid = new Next_ID();

                user_info.user_id = newid.incrementer("user_id", "user_info");

                user_info.join_date = System.DateTime.Now;

                int x = 0;

                if (user_info.user_type == true)
                {
                    x = 1;
                }


                String query = "Insert into user_info(user_id,email_id,first_name,last_name,password,user_type,country,city,join_date) values(@user_id,@email_id,@first_name,@last_name,@password,@user_type,@country,@city,@join_date)";

                command = new SqlCommand(query, newcon);
                command.Parameters.AddWithValue("@user_id", user_info.user_id);
                command.Parameters.AddWithValue("@email_id", user_info.email_id);
                command.Parameters.AddWithValue("@first_name", user_info.first_name);
                command.Parameters.AddWithValue("@last_name", user_info.last_name);
                command.Parameters.AddWithValue("@password", user_info.password);
                command.Parameters.AddWithValue("@user_type", x);
                command.Parameters.AddWithValue("@country", user_info.country);
                command.Parameters.AddWithValue("@city", user_info.city);
                command.Parameters.AddWithValue("@join_date", user_info.join_date.ToString());

                command.ExecuteNonQuery();
                command.Dispose();

                return 2;
            }
            else
            {
               return 1;
            }
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


    public bool check_emailId(String email)
    {
        try
        {
            if (newcon.State == ConnectionState.Closed)
            {
                newcon.Open();
            }

            String query = "select * from user_info where email_id=@email_id";

            command = new SqlCommand(query, newcon);
            command.Parameters.AddWithValue("@email_id", email.ToString());
            reader = command.ExecuteReader();

            if (reader.HasRows)
            {
                return true;     //email present 
            }
            else
            {
                return false;     //not present 
            }
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

    public String GetPass(String emailid)
    {
        String pass = "";

        try
        {
            if (newcon.State == ConnectionState.Closed)
            {
                newcon.Open();
            }


            String query = "Select password from user_info where email_id = @eid";
            command = new SqlCommand(query, newcon);
            command.Parameters.AddWithValue("@eid", emailid);

            reader = command.ExecuteReader();

            if (reader.HasRows)
            {
                reader.Read();
                {
                    pass = reader[0].ToString();
                }
            }
            else
            {
                pass = "";
            }

            command.Dispose();
            reader.Dispose();


            return pass;
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

    public DataSet ListBlog()
    {
        try
        {
            if (newcon.State == ConnectionState.Closed)
            {
                newcon.Open();
            }

            DataSet ds = new DataSet();
            String query = "Select TOP 5 * from blog_post ORDER BY (date_time_of_post) DESC";
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

    public blog_postBO UserBlogViewer(int blog_id)
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

    public void BlogPostComments(blog_commentsBO blogComment)
    {
        try
        {
            if (newcon.State == ConnectionState.Closed)
            {
                newcon.Open();
            }

            Next_ID id = new Next_ID();

            blogComment.comment_id = id.incrementer("comment_id","blog_comments");
            blogComment.date_time_of_comment = System.DateTime.Now;

            String query = "insert into blog_comments values(@comment_id,@blog_id,@poster_id,@is_admin,@comment,@date_time_of_post)";
            command = new SqlCommand(query, newcon);

            command.Parameters.AddWithValue("@comment_id", blogComment.comment_id);
            command.Parameters.AddWithValue("@blog_id",blogComment.blog_id);
            command.Parameters.AddWithValue("@poster_id",blogComment.poster_id);
            command.Parameters.AddWithValue("@is_admin", Convert.ToInt32((blogComment.is_admin ? 1 : 0)));
            command.Parameters.AddWithValue("@comment",blogComment.comment.ToString());
            command.Parameters.AddWithValue("@date_time_of_post", blogComment.date_time_of_comment.ToString());

            command.ExecuteNonQuery();

            command.Dispose();

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

    public DataSet LoadBlogPostComments(int blog_id)
    {
        try
        {
            if (newcon.State == ConnectionState.Closed)
            {
                newcon.Open();
            }

            DataSet ds = new DataSet();
            String query = "Select TOP 5 * from blog_comments where blog_id="+ blog_id +" ORDER BY (date_time_of_comment) DESC";
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