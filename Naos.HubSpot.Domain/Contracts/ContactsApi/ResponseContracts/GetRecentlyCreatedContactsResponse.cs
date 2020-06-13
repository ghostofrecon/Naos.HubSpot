namespace Naos.HubSpot.Domain.Contracts.ContactsApi.ResponseContracts
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;

    public partial class GetRecentlyCreatedContactsResponse
    {
        public Contact[] Contacts { get; set; }

        public bool HasMore { get; set; }

        public long VidOffset { get; set; }

        public long TimeOffset { get; set; }
    }
}
