<%@ Page Language="C#" AutoEventWireup="true" CodeFile="UserProfile.aspx.cs" Inherits="UserProfile" MasterPageFile="~/UserMasterPage.master" title="User Profile"%>


<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server" ClientIDMode="Static">

    <link href="css/UserProfile.css" rel="stylesheet" type="text/css" />
     <div id="lower_middle_main">
  	    <div id="lower_middle_cont">
                            <div class="Usr_details">
                                <div class="user_name">
                                    <h2 style="color:white;">Welcome</h2>
                                    <h3><asp:Label ID="UserName" runat="server">------------</asp:Label></h3>
                                    <br />
                                    <p>Basic information about the user </p>
                                </div>
                                <div class="user_pic"> 
                                   picture
                                </div>
                                <hr/>
                            <div class="Latest_news_Events">
                                  Latest news   
                              </div> 
                                <hr />
                                <div class="Latest_news_Events">
                                  Latest Events   
                              </div>
                                <div class="msgFromAdmin asp_buttons">
                                    <h4 style="font-family:Raleway;font-style: normal;font:bold; font-size:25px;">Message from Admin</h4>

                                </div> 
                                 <div class="write_blog asp_buttons">
                                    <h4 style="font-family:Raleway;font-style: normal;font:bold; font-size:25px;">Write Blog</h4>
                                     

                                </div> 
                                <div class="Events asp_buttons">
                                  <h4 style="font-family:Raleway;font-style: normal;font:bold; font-size:25px;">Orgainse Event</h4>
                                </div> 
                                <div class="Email_entry asp_buttons">
                                    <h4 style="font-family:Raleway;font-style: normal;font:bold; font-size:25px;">Email To Admin</h4>
                                </div> 
                                
                            </div>
                              

              </div>
         </div>

</asp:Content>


