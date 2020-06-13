namespace Naos.HubSpot.Domain.Models.ResponseModels
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
