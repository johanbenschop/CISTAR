// Type definitions for CCPEVE
// Project: CISTAR
// Definitions by: Johan Benschop <https://github.com/johanbenschop/>
// Definitions: https://github.com/johanbenschop/CISTAR


/**
 * The IGB javascript methods
 */
interface CCPEVE {

    // Opens the character's mail inbox.
    openEveMail(): void;

    // Opens the show info window for typeID. If itemID is given, the show info window will open for that item.
    showInfo(typeID: number): void;
    showInfo(typeID: number, itemID: number): void;

    // Opens the preview window for typeID.
    showPreview(typeID : number): void;

    // Shows the route to the destinationID from the sourceID. If sourceID is not given, the source system is taken to be the system the user is currently in.
    showRouteTo(destinationID: number): void;
    showRouteTo(destinationID: number, sourceID: number): void;

    // Opens the map. If systemID is given, the map will focus on that system.
    showMap(systemID: number): void;
    showMap(): void;

    // Opens the fitting window and displays the fitting represented by fitting.
    showFitting(fitting : string): void;

    // Opens the contract window and displays the contract represented by the contractID argument. Contracts are, however, assigned per-solar-system, and so a solarSystemID must also be provided.
    showContract(solarSystemID: number, contractID : number): void;

    // Opens the market details window and displays the information about the item represented by typeID.
    showMarketDetails(typeID: number): void;

    // This method will pop-up a trust prompt in the client, allowing the user to either grant the trust request, ignore it, or always ignore trust requests from your site.
    requestTrust(trustableUrl: string): void;

    // Sets the client's autopilot destination to the specified solarsystem.
    setDestination(solarSystemID : number): void;

    // Adds the specified solar system to the end of the client's autopilot route. If the solar system is already in the route, no changes are made and the method fails silently.
    addWaypoint(solarSystemID : number): void;

    // Causes the user to attempt to join the named channel. Normal channel access control rules apply. If the user is unable to join the channel, the method fails silently.
    joinChannel(channelName : string): void;

    // Causes the user to subscribe to the named mailing list.
    joinMailingList(mailingListName : string): void;

    // Launches Create Contract wizard with contract type, and optional items pre selected.
    createContract(contractType: number): void;
    createContract(contractType: number, station: number): void;
    createContract(contractType: number, station: number, itemIDs : number): void;

    // Opens buy window, with sell offers of typeID selected.
    buyType(typeID : number): void;

    // Opens the contract window, with contracts of typeID selected.
    findInContracts(typeID: number): void;

    // Adds typeID to the market quickbar.
    addToMarketQuickBar(typeID: number): void;

    // Adds characterID to address book, opens Edit Contact if he's already a contact.
    addContact(characterID : number): void;

    // Removes characterID from address book.
    removeContact(characterID : number): void;

    // Adds corporation contact to address book.
    addCorpContact(characterID: number): void;

    // Removes corporation contact.
    removeCorpContact(characterID: number): void;

    // Blocks contact.
    block(characterID: number): void;

    // Adds bounty to contact.
    addBounty(characterID: number): void;

    // Invites contact to fleet.
    inviteToFleet(characterID: number): void;

    // Starts a conversation with contact.
    startConversation(characterID: number): void;

    // Shows the contracts of a given owner.
    showContracts(ownerID : number): void;

    // Shows the location of a given corporation on map.
    showOnMap(corporationID : number): void;

    // Opens contact editor with character characterID loaded.
    editMember(characterID : number): void;

    // Opens award decoration dialog for character.
    awardDecoration(characterID : number): void;

    // Opens mail editor with character, subject, and body pre filled out.
    sendMail(characterID: number, subject: string, body: string): void;

    // Shows the contents of a given container item.
    showContents(stationID : number, itemID : number): void;

    // Opens bookmark editor for item.
    bookmark(itemID : number): void;
}

declare var CCPEVE: CCPEVE;
