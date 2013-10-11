<%@ Page Language="C#" AutoEventWireup="true" CodeFile="contactUs.aspx.cs" Inherits="HopeInTomorrow_contactUs" MasterPageFile="~/UserMasterPage.master" %>

<asp:Content ID="Content1" runat="server" contentplaceholderid="ContentPlaceHolder1">  

    <div id="lower_middle_main">
    	<div id="lower_middle_cont">
            <div id="div_wrapper">
    	<div id="div_wrapper_inner">

    <div id="div_form">
    <div id="div_header">
    <h2> Contact us </h2>
        <br />
    </div>
    <div id="div_regular_content">
    we are here to answer any question you may have about our site that is Hope In Tomorrow. Reach out of us and we will respose as soon as we can.
     </div>
     <div id="div_info_conatiner">
     <div id="div_content_left">
     NAME <br/> 
     <input type="text" class="text" runat="server" id="sugName" required="required"/>
     </div>
     <div id="div_content_right">
     EMAIL <br/>
         
     <input  class="text" runat="server" id="txtemail" required="required" />
     </div>
     </div>
     <br />
     <br />
     <div id="div_container">
     MESSAGE <br />
	<textarea id="comments" cols="64" rows="8" placeholder="Enter your message here...." required="required" runat="server"></textarea>
	</div>
    <div id="div_button">
        <input type="reset" class="btn" runat="server" />
        <asp:Button runat ="server" CssClass="btn"  Text="Submit" OnClick="send_feedBack" />
        
    </div>
    </div>
    <div id="div_info">
    <div id="div_1">
    <h4 style="line-height:5px;">EMAIL</h4> <br />
    abc@gmail.com
    </div>
    <div id="div_2">
    <h4 style="line-height:5px;">TELEPHONE </h4> <br />
    1234567899
    </div>
    <div id="div_3">
    <h4 style="line-height:5px;">SKYPE</h4> <br />
    skype.com
    </div>

<div id="div_4">
    <h4 style="line-height:5px;">ADDRESS</h4> <br />
    USA,Philadelphia
    
    
    </div>
        

    </div>
            </div>
                </div>
            </div>
        </div>
   
</asp:Content>