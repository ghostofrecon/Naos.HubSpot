namespace Naos.HubSpot.Domain.Contracts.ContactsApi.ResponseContracts
{
    using System;
    using System.Collections.Generic;

    public partial class GetAllContactsResponse
    {
        public List<Contact> Contacts { get; set; }

        public bool HasMore { get; set; }

        public long VidOffset { get; set; }
    }

    public partial class Contact
    {
        public long AddedAt { get; set; }

        public long Vid { get; set; }

        public long CanonicalVid { get; set; }

        public List<object> MergedVids { get; set; }

        public long PortalId { get; set; }

        public bool IsContact { get; set; }

        public string ProfileToken { get; set; }

        public Uri ProfileUrl { get; set; }

        public Properties Properties { get; set; }

        public List<object> FormSubmissions { get; set; }

        public List<IdentityProfile> IdentityProfiles { get; set; }

        public List<object> MergeAudits { get; set; }
    }

    public partial class IdentityProfile
    {
        public long Vid { get; set; }

        public long SavedAtTimestamp { get; set; }

        public long DeletedChangedTimestamp { get; set; }

        public List<Identity> Identities { get; set; }
    }

    public partial class Identity
    {
        public string Type { get; set; }

        public string Value { get; set; }

        public long Timestamp { get; set; }
    }

    public partial class Properties
    {
        public Company Firstname { get; set; }

        public Company Lastmodifieddate { get; set; }

        public Company Company { get; set; }

        public Company Lastname { get; set; }
    }

    public partial class Company
    {
        public string Value { get; set; }
    }
}
