namespace Naos.HubSpot.Domain.Contracts.ContactsApi.QueryModels
{
    /// <summary>
    /// 
    /// </summary>
    public class CreateOrUpdateContactPayload
    {
        /// <summary>
        /// 
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Website { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Company { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Phone { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Address { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string City { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string State { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Zip { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateOrUpdateContactPayload"/> class.
        /// </summary>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <param name="website"></param>
        /// <param name="company"></param>
        /// <param name="phone"></param>
        /// <param name="address"></param>
        /// <param name="city"></param>
        /// <param name="state"></param>
        /// <param name="zip"></param>
        public CreateOrUpdateContactPayload(string firstName, string lastName, string website, string company,
            string phone, string address, string city, string state, string zip)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Website = website;
            this.Company = company;
            this.Phone = phone;
            this.Address = address;
            this.City = city;
            this.State = state;
            this.Zip = zip;
        }
    }
}