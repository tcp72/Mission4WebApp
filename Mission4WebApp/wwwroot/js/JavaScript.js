//this was just the JavaScript

//this is the jquery

$("#btnSend").click(function () { //assumes that click is an event listener

    let grade = 0.0;
    let display = " ";

    var assign = ($("#pctAssignments").val() * .5);
    var project = ($("#pctProject").val() * .1);
    var quiz = ($("#pctQuiz").val() * .1);
    var midterm = ($("#pctMidterm").val() * .1);
    var final = ($("#pctFinal").val() * .1);
    var intex = ($("#pctIntex").val() * .1);

    grade = assign + project + quiz + midterm + final + intex;

    if (grade >= 94) {
        display = "A";
    }
    else if (grade >= 90) {
        display = "A-";
    }
    else if (grade >= 87) {
        display = "B+";
    }
    else if (grade >= 84) {
        display = "B";
    }
    else if (grade >= 80) {
        display = "B-";
    }
    else if (grade >= 77) {
        display = "C+";
    }
    else if (grade >= 74) {
        display = "C";
    }
    else if (grade >= 70) {
        display = "C-";
    }
    else if (grade >= 67) {
        display = "D+";
    }
    else if (grade >= 64) {
        display = "D";
    }
    else if (grade >= 60) {
        display = "D-";
    }
    else if (grade < 60) {
        display = "E";}

    //output

    alert("The number grade is " + grade);
    alert("The letter grade is " + display);

    $("#displayID").html(`Final Letter Grade: ${display}`); //displayID is in the form; display is from the JS

});