$(document).ready(function () {
    var queue = $.connection.queueHub;
    queue.client.choose = function (ticketno) {
        $("#ticketno").text(ticketno);
        //console.log(ticketno);
        //if (ticketno != null) {
        //    $("#ticketno").text(ticketno);
        //$("#waiting").addClass("d-none");
        //console.log(ticketno);

        //}
        //else {
        //    $("#waiting").text("wait please");
        //    $("#waiting").removeClass("d-none");

        //}
        console.log("bszhbsh");

    };
    $.connection.hub.start().done(function () {
        $("#company").click(function () {
            queue.server.chooseCompany();
           
        });
    });
});