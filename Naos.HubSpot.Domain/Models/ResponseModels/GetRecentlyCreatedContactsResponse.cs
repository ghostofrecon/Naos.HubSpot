namespace Naos.HubSpot.Domain.Models.ResponseModels
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
