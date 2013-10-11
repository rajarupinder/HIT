$(function () {

    var i = 0;


    $("#img_calender").click(function () {

        $("#div_calendar_event_date").slideDown('fast');

    });

});


function postval()
{
    if (document.getElementById('txtEventTitle').value.trim() != "" && document.getElementById('txtEventDate').value.trim() != "" && document.getElementById('txtEventPlace').value.trim() != "" && document.getElementById('txtEventTime').value.trim() != "" && document.getElementById('txtEventDesc').value.trim() != "")
    {
        return true;
    }
    {
        alert("Please do not leave any field blank ");
        return false;
    }
}
