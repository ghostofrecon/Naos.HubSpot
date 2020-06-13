namespace Naos.HubSpot.Domain.Models.QueryModels
{
    /// <summary>
    /// The class representing the query parameters for the update contact operation.
    /// </summary>
    public class UpdateContactByIdQuery
    {
        /// <summary>
        /// Gets or sets the VID of the contact to update.
        /// </summary>
        public string Vid { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateContactByIdQuery"/> class.
        /// Constructs the object representing the query parameters for the update contact operation.
        /// </summary>
        /// <param name="vid">the VID of the contact to update.</param>
        public UpdateContactByIdQuery(string vid)
        {
            this.Vid = vid;
        }
    }
}
