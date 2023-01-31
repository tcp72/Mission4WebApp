//this was just the JavaScript

//this is the jquery




$("#btnSend").click(function () { //assumes that click is an event listener
    let grade = 0.0;
    let dispay = " ";

    alert("the function was called");

    grade = 0.0;
    grade += $("pctAssignments");
    grade += $("pctProject");
    grade += $("pctQuiz");
    grade += $("pctMidterm");
    grade += $("pctFinal");
    grade += $("pctAssignments");
    grade += $("pctIntex");

    if (grade >= 94) display = "A"
    else if (grade >= 90) display = "A-"
    alert("The grade is " + display);

};



/*
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
        display = "C;
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

    alert("The grade is " + display);
    $("displayID").html('Final Letter Grade: ${display}'); //displayID is in the form; display is from the JS

    //document.getElementById("displayID").innerHTML = display;
    //return display;
    });

*/