﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_NewEvent : System.Web.UI.Page
{
    eventsBO new_event = new eventsBO();
    AdminFunctionsBAL postevent = new AdminFunctionsBAL();


    protected void Page_Load(object sender, EventArgs e)
    {

        if (Session["admin_id"] == null)
        {
            Response.Redirect("~/Admin/AdminLogin.aspx");
        }
    }


    protected void btnPostNewEvent_Click(object sender, EventArgs e)
    {
        try
        {

        new_event.admin_id = Convert.ToInt32(Session["admin_id"]);
        new_event.event_title = txtEventTitle.Text;
        new_event.event_time = Convert.ToDateTime(Calendar1.SelectedDate.ToShortDateString() + " " + txtEventTime.Value.ToString());
        new_event.event_place = txtEventPlace.Text;
        new_event.event_desc = txtEventDesc.Text;
        new_event.date_time_of_post = System.DateTime.Now;

        postevent.PostNewEvent(new_event);

        }
        catch(Exception ex)
        {
            Response.Write("Error Occurred : "+ex.ToString());
        }
    }
    protected void Calendar1_SelectionChanged(object sender, EventArgs e)
    {
        txtEventDate.Text = Calendar1.SelectedDate.ToLongDateString();
    }
}