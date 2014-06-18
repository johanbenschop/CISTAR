/// <reference path="../ccpeve/ccpeve.d.ts" />

interface SignalR {
    gameHub: GameHubProxy;
}

interface GameHubProxy {
    client: CCPEVE;
    server: any;
}