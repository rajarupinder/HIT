<%@ Page Language="C#" AutoEventWireup="true" CodeFile="NewEvent.aspx.cs" Inherits="Admin_NewEvent" MasterPageFile="~/Admin/EventMaster.master" Title="NewEvent"%>

<asp:Content ContentPlaceHolderID="contentChildBody" ID="NewEvent" runat="server" ClientIDMode="Static">

    <link href="css/ViewAllEvents.css" rel="stylesheet" />
    <script src="Scripts/jquery-1.10.2.js" type="text/javascript"></script>
    <script src="Scripts/NewEvent.js"></script>
    

  
                
                
                <div id="div_newevent_container">           <!-- User list container -->
                    
                     <div style="margin-left:40px; float:left;"> 

                         <br/>
                        <br/>
                        <br/>


                       


                        <table style="height: 131px; width: 631px"> 
                            <tr>
                                <td colspan="2" style="text-align:center">
                                    New Event
                                </td>

                            </tr>

                             <tr>
                                <td style="width: 143px" >
                                    <asp:Label ID="lblEventTitle" runat="server" > Event Title </asp:Label>
                                </td>
                                 <td style="width: 404px">
                                     <asp:TextBox ID="txtEventTitle" runat="server" placeholder="Event Title" style="margin-left: 0px" Width="391px"></asp:TextBox> 
                                 </td>
                            </tr>

                            <tr>
                                <td style="width: 143px" >
                                    <asp:Label ID="Label1" runat="server"> Date </asp:Label>
                                </td>
                                 <td style="width: 404px">
                                    

                                     

                                     <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
                                     <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                                         <ContentTemplate>
                                             <div id="div_txt_event_datetime">
                                                <asp:TextBox ID="txtEventDate" runat="server" ReadOnly="true" Width="190px" ></asp:TextBox> &emsp; &emsp;
                                               
                                             </div> 

                                             <div id="div_calendar_event_date" style="display:none">
                                                 <asp:Calendar ID="Calendar1" runat="server" OnSelectionChanged="Calendar1_SelectionChanged"></asp:Calendar>
                                             </div>
                                              
                                         </ContentTemplate>


                                         
                                     </asp:UpdatePanel>
                                     <img src="Resources/Images/webpage_images/calender.png" style="height:23px;width:22px" id="img_calender"/>
                                 </td>
                            </tr>


                            <tr>
                                <td style="width: 143px" >
                                    <asp:Label ID="Label2" runat="server" > Place </asp:Label>
                                </td>
                                 <td style="width: 404px">                                   
                                     <asp:TextBox ID="txtEventPlace" runat="server" placeholder="Place" style="margin-left: 0px" Width="190px"></asp:TextBox> 
                                 </td>
                            </tr>



                             <tr>
                                <td style="width: 143px" >
                                    <asp:Label ID="Label4" runat="server"> Time </asp:Label>
                                </td>
                                 <td style="width: 404px">                                   
                                     <input id="txtEventTime" required="required" runat="server" style="width: 97px" />
                                 </td>
                            </tr>


                             <tr>
                                <td style="width: 143px" >
                                    <asp:Label ID="Label3" runat="server"> Description </asp:Label>
                                </td>
                                 <td style="width: 404px">                                   
                                     <asp:TextBox ID="txtEventDesc" runat="server" TextMode="MultiLine" Rows="15" Columns="50"></asp:TextBox>
                                 </td>
                            </tr>

                             <tr>
                                <td style="width: 143px" >
                                    
                                </td>
                                 <td style="width: 404px"> 
                                     &emsp; &emsp;   
                                     <asp:Button ID="btnPostNewEvent" runat="server" OnClientClick="return postval();" OnClick="btnPostNewEvent_Click" Text="Post Event" Height="30px" />  &emsp; &emsp;   &emsp; &emsp;                                  
                                     <input type="reset" value="Reset" style="height: 30px" />
                                  </td>
                            </tr>
                            

                        </table>


                    </div>
             </div> 


</asp:Content>