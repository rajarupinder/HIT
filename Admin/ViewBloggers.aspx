<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ViewBloggers.aspx.cs" Inherits="Admin_ViewBloggers" MasterPageFile="~/Admin/AdminMaster.master" Title="Bloggers"%>


<asp:Content ContentPlaceHolderID="content_body" ID="ViewBloggers" runat="server" >


    <link href="css/ViewAllUsers.css" rel="stylesheet" />
    <script src="Scripts/jquery-1.10.2.js" type="text/javascript"></script>
    <script src="Scripts/ViewBloggers.js"></script>

    <div>
    
        <div id="div_main_contianer">            <!-- The main container--> 
           
            
            <div id="div_middle">                <!-- The Middle Body --> 
                
                
               
                
                
                <div id="div_menu_bar">          <!-- Admin Menu Bar --> 
                    
                    <ul> 
                        <li id="li_1"> <a href="AdminHome.aspx" class="a_menu" id="a_menu_Home"> Home </a> </li> 
                        <li id="li_2"> <a href="ViewAllUsers.aspx" class="a_menu" id="a_menu_allUsers"> All Users </a> </li>  
                        <li id="li_3"> <a href="ViewBloggers.aspx" class="a_menu" id="a_menu_bloggers"> Bloggers </a> </li>  
                        <li id="li_4"> <a href="ViewVolunteers.aspx" class="a_menu" id="a_menu_volunteers"> Volunteers </a> </li>  
                       
                    </ul> 
                    
                </div>                           <!-- End OF Admin Menu Bar --> 
                
                
                
                
                <div id="div_bloggerlist_container">           <!-- User list container -->
                    
                     

                    </div>                   <!-- End of user list container --> 
                


               </div>                               <!-- End OF The Middle Body --> 
            

    </div>
   </div>
 </asp:Content>
        