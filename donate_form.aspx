<%@ Page Title="" Language="C#" MasterPageFile="~/UserMasterPage.master" AutoEventWireup="true" CodeFile="donate_form.aspx.cs" Inherits="donate_form" %>

<asp:Content ID="Content1" runat="server" contentplaceholderid="ContentPlaceHolder1" ClientIDMode="Static">  


    <link href="css/Donate.css" rel="stylesheet" type="text/css" />
    <script>
        $(function() { 
        $("#ten").click(function () {
           
            $("#x_amount").val("10");
           
           
        });
        $("#thirty").click(function () {
            $("#x_amount").val("30");
           

        });
        $("#fifty").click(function () {
            $("#x_amount").val("50");

        });
        $("#hundred").click(function () {
            $("#x_amount").val("100");

        });
        $("#other").click(function () {
            $("#x_amount").val("");

        });

        });
    </script>


   
<div id="lower_middle_main">
    	<div id="lower_middle_cont">
            <div id="div_wrapper">
    	<div id="div_wrapper_inner">
    		<div id="div_form">
            <div id="div_heading_text"> 
            <h1> Donate to Hope In Tomorrow </h1>
            </div>
            <div id="div_regular_text">
            <p>Hope In Tomorrow Group helps the children those suffering from desease leukemia but it can be possible only when you people help us. </p>
            </div>
            <div id="div_head">
            <h1> Select Amount </h1>
             </div>
             <div class="div_btn1">
             <div class="btn" id="ten"> $10 </div>
             <div class="btn" id="thirty"> $30 </div>
             <div class="btn"id="fifty"> $50 </div>
             <div class="btn"id="hundred"> $100 </div>
             <div class="btn" id="other"> Other </div>
             </div>
             <div id="amount">
             <div id="div_donation">
             Your Donation</div>
             <div id="div_ammount"> 
           
 
            <input type="text" class="textfield" value="" size="12" placeholder="$" required="required" runat="server"  id='x_amount' style="border-radius:5px;"  />
            
            
             </div>
             <div id="div_radio" onload="sendForm()">
             <input type="radio" value="one-time" name="donation"checked="checked" style="padding:10px" /><span style="padding:5px">Monthly</span>
               <input type="radio" value="monthly"name="donation"  style="padding:10px" /><span style="padding:5px">One Time</span>
             </div>
             </div>
             <div id="div_user_info">
             <h2> Your Information </h2></div>
             <div id="info_container">
             
             <label> Name
               </label>
              <input type="text" placeholder="First Name" class="textfield1"  />
               <input type="text" placeholder="Last Name"  class="textfield1"   />
             </div>
           		
                 <div id="info_container1">
             
             <label> Email
               </label>
               <input type="text" placeholder="Email"  class="textfield1"   />
 
             </div>
             <div id="div_donate_button"> 
            <asp:Button id="donate_form_btn" runat="server"  CssClass="donate_asp_buttons" Width="100px"  Height="50px"  Text="Donate" Style="margin-top:20px;margin-left:15px"  OnClick="donate_form_btn_click"></asp:Button> 
                            
             </div>
                
            </div>
            <div id="div_right_container">
            <div id="div_image_container">
              <img src="img/Emma_April17_WEB.jpg" width="200" height="200" />
            </div>
            <div id="img_content"><p>Hope In Tomorrow is a non-profit organization that raises funds for children hospital of philadelphia so donate and join us.</p>
            </div>
            <div id="join_btn">
              <a href="join_us.aspx" class="btn_join"> Join Us </a>
            </div>
          </div>
            </div>
    	</div>

        </div>
</div>
</asp:content>


