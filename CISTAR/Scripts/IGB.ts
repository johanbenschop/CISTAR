/// <reference path="typings/jquery/jquery.d.ts" />
/// <reference path="typings/ccpeve/ccpeve.d.ts" />
/// <reference path="typings/signalr/signalr.d.ts" />
/// <reference path="typings/signalr/hubs.d.ts" />


$(document).ready(() => {
    // Request trust from the IGB.
    // The IGB will not refresh when trust is given.
    var pathname = "http://localhost:52288/";
    CCPEVE.requestTrust(pathname);


    var hubProxy = $.connection.GameHub;
    hubProxy.client.addContosoChatMessageToPage = (name, message) => {
        console.log(name + ' ' + message);
    };

    $.connection.hub.start().done(() => {
        
    });
});