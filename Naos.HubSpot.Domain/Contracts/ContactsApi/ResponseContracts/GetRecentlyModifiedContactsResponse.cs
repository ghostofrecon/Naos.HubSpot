namespace Naos.HubSpot.Domain.Contracts.ContactsApi.ResponseContracts
{
    using System;

    public partial class GetRecentlyModifiedContactsResponse
    {
        public Contact[] Contacts { get; set; }

        public bool HasMore { get; set; }

        public long VidOffset { get; set; }

        public long TimeOffset { get; set; }
    }
}
