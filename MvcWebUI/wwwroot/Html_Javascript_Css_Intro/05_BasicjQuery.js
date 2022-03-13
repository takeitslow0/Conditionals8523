$(document).ready(function () {
    console.log("script loaded");
    var inputText;

    $("#bSetText").click(function () {
        inputText = $("#tbInput1").val(); // textbox ddl ve listbox için multiple değerler okunur.
        $("#sOutput1").text(inputText); // span, label, p gibi şeyleri kullanıcıya göstermek için .text kullanılır.
    });
    $("#bsetHtml").click(function () {
        inputText = $("#tbInput1").val();
        $("#sOutput2").html('<label style="color:blue;font-size:24px;"><b>' + inputText + '</b></label>');
    });

    $("#bSetValue").click(function () {
        inputText = $("#tbInput1").val();
        $("#tbOutput1").val(inputText);
    });