//let doSomething = () => {
//    let _fullName = $("#name").val();
//    $("#welcomeMessage").html(_fullName);
//}

let addToList = (marble) => {
    $("#marbleList")
        .append($("<li>").html(marble.Color));
}

let printRandomToScreen = (marble) => {
    $("#randomMarble")
        .append($("<li>").html(marble.Color));
}

let talkToServer = () => {

    let newMarble = {
        color: $("#newMarbleColor").val()
    };

    $.ajax({
        url: '/api/marble',
        dataType: "json",
        contentType: "application/json",
        data: JSON.stringify(newMarble),
        type: "POST",
        success: (marbleFromServer) => {
            addToList(marbleFromServer);
        },
        error: (data) => {
            console.log("oops", data)
        },
        complete: (data) => {
            console.log("done", data);
        }
    });
}

let loadMarbles = () => {
    $.ajax({
        url: "/api/marble",
        //because there is no type, we know it is a get
        //think of the controller as entry point to apps
        dataType: "json",
        success: (allMarbles) => {
            allMarbles.map((m) => { addToList(m); });
        }
    })
}

loadMarbles();


let findRandomMarble = () => {
    let allMarbles = $("#allMarbles").children();
    var rand = Math.floor(Math.random(0 * allMarbles.length));
    $("#random")
}



