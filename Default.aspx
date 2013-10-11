<%@ Page Title="Hope In Tomorrow" Language="C#" MasterPageFile="~/UserMasterPage.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>


<asp:Content ID="Content1" runat="server" ContentPlaceHolderID="ContentPlaceHolder1">

    <div id="middle_main">
        <div id="middle_cont">
            <div class="middle_slider">

                <div class="im" id="slider_1">
                    <img src="img/slider_images/1.jpg" />

                </div>
                <div class="im" id="slider_2">
                    <img src="img/slider_images/2.jpg" />
                </div>
                <div class="im" id="slider_3">
                    <img src="img/slider_images/3.jpg" />
                </div>
                <div class="im" id="slider_4">
                    <img src="img/slider_images/4.jpg" />
                </div>

            </div>
        </div>

    </div>
    <div id="lower_middle_main">
        <div id="lower_middle_cont">

            <div class="lower_middle_icon" id="lower_middle_icon_joinus">
                <a href="join_us.aspx">
                    <h3>Join us</h3>
                    &nbsp;
            	<div class="icon_style">
                    <img src="img/Pensils@2x.png" />
                </div>
                </a>

            </div>
            <div class="lower_middle_icon " id="lower_middle_icon_donate">
                <h3>Donate</h3>
                &nbsp;
                <a href="donate.aspx">
                    <div class="icon_style">
                        <img class="donate_radius" src="img/Infinity-Loop@2x.png" />
                    </div>
                </a>
            </div>
            <div class="lower_middle_icon" id="lower_middle_icon_event">
                <a href="#">
                    <h3>Event</h3>
                    &nbsp;
            	 <div class="icon_style">
                     <img src="img/Calendar@2x.png" />
                 </div>
                </a>
            </div>
            <div class="lower_middle_icon" id="lower_middle_icon_news">
                <a href="#">
                    <h3>News</h3>
                    &nbsp;
                     
                  <div class="icon_style">
                      <img src="img/Watches@2x.png" />
                  </div>
                </a>

            </div>



        </div>


    </div>



</asp:Content>






