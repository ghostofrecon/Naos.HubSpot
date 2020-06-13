namespace Naos.HubSpot.Domain.Models.QueryModels
{
    public class UpdateContactByIdPayload
    {
        /// <summary>
        /// Gets or sets the Email of the contact to update.
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// Gets or sets the first name of the record to update.
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// Gets or sets the last name of the record to update.
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// Gets or sets the website of the record to update.
        /// </summary>
        public string Website { get; set; }

        /// <summary>
        /// Gets or sets the life cycle stage of the record to update.
        /// </summary>
        public string LifeCycleStage { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateContactByIdPayload"/> class.
        /// Constructs the object that represents the body of the update contact transaction.
        /// </summary>
        /// <param name="email">The Email of the contact to update.</param>
        /// <param name="firstName">The first name of the record to update.</param>
        /// <param name="lastName">The last name of the record to update.</param>
        /// <param name="website">The website of the record to update.</param>
        /// <param name="lifeCycleStage">The life cycle stage of the record to update.</param>
        public UpdateContactByIdPayload(string email, string firstName, string lastName, string website, string lifeCycleStage)
        {
            this.Email = email;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Website = website;
            this.LifeCycleStage = lifeCycleStage;
        }
    }
}
