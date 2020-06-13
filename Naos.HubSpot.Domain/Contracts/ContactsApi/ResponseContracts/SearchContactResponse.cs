namespace Naos.HubSpot.Domain.Contracts.ContactsApi.ResponseContracts
{
    public class SearchContactResponse
    {
        public string Query { get; set; }

        public long Offset { get; set; }

        public bool HasMore { get; set; }

        public long Total { get; set; }

        public Contact[] Contacts { get; set; }
    }
}
