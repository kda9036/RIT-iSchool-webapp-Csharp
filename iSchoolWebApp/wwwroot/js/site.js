// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

/*$(document).ready(function ()...*/
$(function () {
    /*people tabs*/
    $("#KellyTab").tabs();
    /*degrees accordion*/
    $("#KellyAcc").accordion({
        collapsible: true,
        //active: false,
        heightStyle: "content"
    });
    $("#KellyAcc2,#KellyAcc3").accordion({
        collapsible: true,
        active: false,
        heightStyle: "content"
    });
    /*employment tables*/
    $("#tableCoop,#tableEmp").DataTable();
    /*degree stats flip cards*/
    $(".card").flip();
    /*modally nested modal / popup*/
    $("#parent").on("click", ".modalOpen", function () {
        $(this).modally($(this).id, {
            // add any desired options here
        });
    })
});

/*dialog widget with animation*/
function dialog_btn_click(clicked_id) {
    let myid = clicked_id + "-dialog";
    $("#" + myid).dialog({
        autoOpen: true,
        /*act as modal and disable other items on page*/
        modal: true,
        show: {
            effect: "blind",
            duration: 1000
        },
        hide: {
            effect: "explode",
            duration: 1000
        }
    });
}

/*modally nested modal / popup - to get second popup for courses*/
function courses_btn_click(clicked_id) {
    let myid = clicked_id + "-courses";
    $("#" + myid).modally(myid, {
        // add any desire options here
    });
}