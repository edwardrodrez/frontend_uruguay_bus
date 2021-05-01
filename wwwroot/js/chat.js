
"use strict";

var connection = new signalR.HubConnectionBuilder().withUrl("/chatHub").build();

//Disable send button until connection is established
document.getElementById("sendButton").disabled = true;

connection.on("ReceiveMessage", function (message) {
    console.log(message);
    //with this way of iterating it

    message.forEach(function (entry) {
        var li = document.createElement("li");
        li.className = 'list-group-item list-group-item-info';
        li.style = 'margin-bottom:10px';
        li.innerHTML = '<div class="d-flex w-100 justify-content-between"><small>25/10/2020 12:45</small></div><p class="mb-1">' + entry + '</p><small>Con Destino a Montevideo</small>';
        document.getElementById("messagesList").appendChild(li);
    });
});

connection.start().then(function () {
    document.getElementById("sendButton").disabled = false;
}).catch(function (err) {
    return console.error(err.toString());
});

document.getElementById("sendButton").addEventListener("click", function (event) {
    connection.invoke("SendMessage", message).catch(function (err) {
        return console.error(err.toString());
    });
    event.preventDefault();
});
