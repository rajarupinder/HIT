using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for news
/// </summary>
public class newsBO
{
	public newsBO()
	{
		//
		// TODO: Add constructor logic here
		//
	}

    private int news_id
    {
        set;
        get;
    }

    private int admin_id
    {
        set;
        get;
    }



    private String news_title
    {
        get;
        set;
    }

    private String news_desc
    {
        set;
        get;
    }

    private DateTime date_time_of_post
    {
        set;
        get;
    }



}