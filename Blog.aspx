<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Blog.aspx.cs" Inherits="HopeInTomorrow_Blog" MasterPageFile="~/UserMasterPage.master" Title="Blog"%>

<asp:Content ContentPlaceHolderID="ContentPlaceHolder1" ID="BlogBody" runat="server">
    <link href="css/BlogListView.css" rel="stylesheet" type="text/css"/>

     <div id="div_main_contianer">            <!-- The main container--> 
           
            <div id="div_middle" class="div_middle">               <!-- The Middle Body --> 
                
            
                
                <asp:DataList ID="dlBlog" runat="server" CssClass="datalistblog">
                    <ItemTemplate>

                        <div id="div_blog_container" class="div_blog_container">           <!-- Blog container -->

                                <div id="div_blog_title" runat="server" contenteditable ="false" class="div_blog_title">
                                    <%# DataBinder.Eval(Container.DataItem,"blog_title").ToString() %>
                                </div> 

                                <div id="div_blog_date_time" runat="server" contenteditable ="false" class="div_blog_date_time">
                                    <%# GetLongDateFormat((DateTime)DataBinder.Eval(Container.DataItem,"date_time_of_post")) %>
                                </div> 

                                <div id="div_blog_body" contenteditable ="false" runat="server" class="div_blog_body">
                                    <%# Server.HtmlDecode(DataBinder.Eval(Container.DataItem,"blog_content").ToString()) %>
                                </div>   
                            
                            <div id="div_blog_options" runat="server" class="div_blog_options">
                                <asp:LinkButton ID="lnkbtnReadMore" runat="server" CssClass="lnkbtn_blog_readmore"  OnCommand="lnkbtnReadMore_Command" CommandArgument='<%# DataBinder.Eval(Container.DataItem,"blog_id") %>' > Read More</asp:LinkButton>
                            </div>
                        </div> 

                        

                    </ItemTemplate>

                 </asp:DataList> 
                
            </div>                               <!-- End OF The Middle Body --> 

            
        </div>                                  <!-- End Of The main container-->


</asp:Content>