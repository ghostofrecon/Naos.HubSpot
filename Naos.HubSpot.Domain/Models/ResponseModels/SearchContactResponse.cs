namespace Naos.HubSpot.Domain.Models.ResponseModels
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
