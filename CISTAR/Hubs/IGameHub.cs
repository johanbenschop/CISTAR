namespace CISTAR.Hubs
{
    /// <summary>
    /// Interface for the IGB.
    /// TODO add documention for the parameters.
    /// </summary>
    public interface IGameHub
    {
        /// <summary>
        /// Opens the character's mail inbox.
        /// </summary>
        void OpenEveMail();

        /// <summary>
        /// Opens the show info window for typeId. If itemId is given, the show info window will open for that item.
        /// </summary>
        /// <param name="typeId"></param>
        void ShowInfo(int typeId);

        /// <summary>
        /// Opens the show info window for typeId. If itemId is given, the show info window will open for that item.
        /// </summary>
        /// <param name="typeId"></param>
        /// <param name="itemId"></param>
        void ShowInfo(int typeId, int itemId);

        /// <summary>
        /// Opens the preview window for typeId.
        /// </summary>
        /// <param name="typeId"></param>
        void ShowPreview(int typeId);

        /// <summary>
        /// Shows the route to the destinationId from the sourceId. If sourceId is not given, the source system is taken to be the system the user is currently in.
        /// </summary>
        /// <param name="destinationId"></param>
        void ShowRouteTo(int destinationId);

        /// <summary>
        /// Shows the route to the destinationId from the sourceId. If sourceId is not given, the source system is taken to be the system the user is currently in.
        /// </summary>
        /// <param name="destinationId"></param>
        /// <param name="sourceId"></param>
        void ShowRouteTo(int destinationId, int sourceId);

        /// <summary>
        /// Opens the map. If systemId is given, the map will focus on that system.
        /// </summary>
        /// <param name="systemId"></param>
        void ShowMap(int systemId);

        /// <summary>
        /// Opens the map. If systemId is given, the map will focus on that system.
        /// </summary>
        void ShowMap();

        /// <summary>
        /// Opens the fitting window and displays the fitting represented by fitting.
        /// </summary>
        /// <param name="fitting"></param>
        void ShowFitting(string fitting);

        /// <summary>
        /// Opens the contract window and displays the contract represented by the contractId argument. Contracts are, however, assigned per-solar-system, and so a solarSystemId must also be provIded.
        /// </summary>
        /// <param name="solarSystemId"></param>
        /// <param name="contractId"></param>
        void ShowContract(int solarSystemId, int contractId);

        /// <summary>
        /// Opens the market details window and displays the information about the item represented by typeId.
        /// </summary>
        /// <param name="typeId"></param>
        void ShowMarketDetails(int typeId);

        /// <summary>
        /// This method will pop-up a trust prompt in the client, allowing the user to either grant the trust request, ignore it, or always ignore trust requests from your site.
        /// </summary>
        /// <param name="trustableUrl"></param>
        void RequestTrust(string trustableUrl);

        /// <summary>
        /// Sets the client's autopilot destination to the specified solarsystem.
        /// </summary>
        /// <param name="solarSystemId"></param>
        void SetDestination(int solarSystemId);

        /// <summary>
        /// Adds the specified solar system to the end of the client's autopilot route. If the solar system is already in the route, no changes are made and the method fails silently.
        /// </summary>
        /// <param name="solarSystemId"></param>
        void AddWaypoint(int solarSystemId);

        /// <summary>
        /// Causes the user to attempt to join the named channel. Normal channel access control rules apply. If the user is unable to join the channel, the method fails silently.
        /// </summary>
        /// <param name="channelName"></param>
        void JoinChannel(string channelName);

        /// <summary>
        /// Causes the user to subscribe to the named mailing list.
        /// </summary>
        /// <param name="mailingListName"></param>
        void JoinMailingList(string mailingListName);

        /// <summary>
        /// Launches Create Contract wizard with contract type, and optional items pre selected.
        /// </summary>
        /// <param name="contractType"></param>
        void CreateContract(int contractType);

        /// <summary>
        /// Launches Create Contract wizard with contract type, and optional items pre selected.
        /// </summary>
        /// <param name="contractType"></param>
        /// <param name="station"></param>
        void CreateContract(int contractType, int station);

        /// <summary>
        /// Launches Create Contract wizard with contract type, and optional items pre selected.
        /// </summary>
        /// <param name="contractType"></param>
        /// <param name="station"></param>
        /// <param name="itemIds"></param>
        void CreateContract(int contractType, int station, int itemIds);

        /// <summary>
        /// Opens buy window, with sell offers of typeId selected.
        /// </summary>
        /// <param name="typeId"></param>
        void BuyType(int typeId);

        /// <summary>
        /// Opens the contract window, with contracts of typeId selected.
        /// </summary>
        /// <param name="typeId"></param>
        void FindInContracts(int typeId);

        /// <summary>
        /// Adds typeId to the market quickbar.
        /// </summary>
        /// <param name="typeId"></param>
        void AddToMarketQuickBar(int typeId);

        /// <summary>
        /// Adds characterId to address book, opens Edit Contact if he's already a contact.
        /// </summary>
        /// <param name="characterId"></param>
        void AddContact(int characterId);

        /// <summary>
        /// Removes characterId from address book.
        /// </summary>
        /// <param name="characterId"></param>
        void RemoveContact(int characterId);

        /// <summary>
        /// Adds corporation contact to address book.
        /// </summary>
        /// <param name="characterId"></param>
        void AddCorpContact(int characterId);

        /// <summary>
        /// Removes corporation contact.
        /// </summary>
        /// <param name="characterId"></param>
        void RemoveCorpContact(int characterId);

        /// <summary>
        /// Blocks contact.
        /// </summary>
        /// <param name="characterId"></param>
        void Block(int characterId);

        /// <summary>
        /// Adds bounty to contact.
        /// </summary>
        /// <param name="characterId"></param>
        void AddBounty(int characterId);

        /// <summary>
        /// Invites contact to fleet.
        /// </summary>
        /// <param name="characterId"></param>
        void InviteToFleet(int characterId);

        /// <summary>
        /// Starts a conversation with contact.
        /// </summary>
        /// <param name="characterId"></param>
        void StartConversation(int characterId);

        /// <summary>
        /// Shows the contracts of a given owner.
        /// </summary>
        /// <param name="ownerId"></param>
        void ShowContracts(int ownerId);

        /// <summary>
        /// Shows the location of a given corporation on map.
        /// </summary>
        /// <param name="corporationId"></param>
        void ShowOnMap(int corporationId);

        /// <summary>
        /// Opens contact editor with character characterId loaded.
        /// </summary>
        /// <param name="characterId"></param>
        void EditMember(int characterId);

        /// <summary>
        /// Opens award decoration dialog for character.
        /// </summary>
        /// <param name="characterId"></param>
        void AwardDecoration(int characterId);

        /// <summary>
        /// Opens mail editor with character, subject, and body pre filled out.
        /// </summary>
        /// <param name="characterId"></param>
        /// <param name="subject"></param>
        /// <param name="body"></param>
        void SendMail(int characterId, string subject, string body);

        /// <summary>
        /// Shows the contents of a given container item.
        /// </summary>
        /// <param name="stationId"></param>
        /// <param name="itemId"></param>
        void ShowContents(int stationId, int itemId);

        /// <summary>
        /// Opens bookmark editor for item.
        /// </summary>
        /// <param name="itemId"></param>
        void Bookmark(int itemId);
    }
}
