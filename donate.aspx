<%@ Page Title="Donate" Language="C#" MasterPageFile="~/UserMasterPage.master" AutoEventWireup="true" CodeFile="donate.aspx.cs" Inherits="donate" %>

<asp:Content ID="Content1" runat="server" contentplaceholderid="ContentPlaceHolder1">  
    <script>

        $(function () {

            $("body").css("background-image", "url('img/s3.jpg')");
            $("body").css("background-attachment", "fixed");
            $("body").css("background-repeat", "no-repeat");
            $("body").css("background-repeat", "no-repeat");
            $("#header_main").css("background", "rgba(255,255,255,0.9)");
            

        });
    </script>
    <div id="lower_middle_main">
    	    <div id="lower_middle_cont">
                 <div id="slide">
         <div id="slide_inner">
          <div id="slide_inner1">
                  <div id="slide_content" align="justify">
                  <h1 style="color:#262466; font-size:40px;">Donate for children</h1>
                  Support the urgent needs of the children, whether it is responding to a disaster and their families during emergencies.
                  hether it is responding to a disaster and their families during em
                    <a href="donate_form.aspx" class="btn_donate_join" style="margin-top:10px;" > Donate now </a>
 
            </div>
         </div>
        
        
        <div id="buttons">
           <div id="button_outer">
             <div class="buttons_inner">
                  
                  <div class="btn_image">
                      <div class="icon_image_inner">
                       <img src="img/img1.png"  />
                       </div>
                     
                   </div>
                          <div class="buttons_content">
                            <center> 
                               DONATE NOW
                                  <h5>
                                        Take action by making a
                                        tax-deductible donation to suffering 
                                        Children
                                  </h5>
                            </center>
                           </div>
                                    
                                       <div class="buttons_btn">
                                           <center>
                                               <a href="donate_form.aspx" class="button white" > Donate now </a>
                                           </center>
                           </div>
                   </div>
              
               <div class="buttons_inner">
                    <div class="btn_image">
                        <div class="icon_image_inner">
                       <img src="img/img2.png"  />
                       </div>
                    </div>
                     <div class="buttons_content">
                         <center>
                             DONATE MONTHLY
                                 <h5>
                                        Donate to suffering Children on 
                                        a monthly basis and become a Fourth Estate Member
                                  </h5>
                         </center>
                    </div>
       
                        <div class="buttons_btn">
                            <center>
                                    <a href="donate_form.aspx" class="button white" > Donate monthly </a>
                            </center>
                       </div>
                </div>
       
       
       
        <div class="buttons_inner">
                    <div class="btn_image">
                         <div class="icon_image_inner">
                       <img src="img/img3.png"  />
                       </div>
                    </div>
                          <div class="buttons_content">
                             <center>
                                  OTHER HELP
                              <h5>
                                 Take action by making a
                                 tax-deductible donation to suffering 
                                 Children
                              </h5>
                            </center>
                          </div>
       
                        <div class="buttons_btn">
                            <center>
                                   <a href="donate_form.aspx" class="button white" > other help </a>
                            </center>
                       </div>
                </div>
          </div>
        
        <div id="team">
        </div>
   </div>     
         </div>
    </div>


            </div>
    </div>
</asp:Content>