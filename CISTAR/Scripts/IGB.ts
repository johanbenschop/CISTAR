/// <reference path="typings/jquery/jquery.d.ts" />
/// <reference path="typings/ccpeve/ccpeve.d.ts" />
/// <reference path="typings/signalr/signalr.d.ts" />
/// <reference path="typings/signalr/hubs.d.ts" />

$(document).ready(() => {
    // request trust from the IGB.
    // the IGB will not refresh when trust is given.
    var pathname = "http://localhost:52288/";
    CCPEVE.requestTrust(pathname);


    var hubProxy = $.connection.gameHub;

    hubProxy.client.addWaypoint = (solarSystemId) => {
        CCPEVE.addWaypoint(solarSystemId);
    };

    $.connection.hub.start().done(() => {
        
        // set interval in milliseconds
        var tid = setInterval(ping, 1000);
        function ping() {
            // simple ping to the server so the headers get pushed out
            hubProxy.server.ping();
        }
        function abortTimer() {
            clearInterval(tid);
        }

    });
});