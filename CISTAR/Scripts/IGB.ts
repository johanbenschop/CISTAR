/// <reference path="typings/jquery/jquery.d.ts" />
/// <reference path="typings/ccpeve/ccpeve.d.ts" />

$(document).ready(() => {
    // Request trust from the IGB.
    // The IGB will not refresh when trust is given.
    var pathname = "http://localhost:52288/";
    CCPEVE.requestTrust(pathname);


	var hubProxy = $.connection.contosoChatHub;
	hubProxy.client.addContosoChatMessageToPage = function (name, message) {
		console.log(name + ' ' + message);
	};

	$.connection.hub.start().done(function () {
		
	});
});