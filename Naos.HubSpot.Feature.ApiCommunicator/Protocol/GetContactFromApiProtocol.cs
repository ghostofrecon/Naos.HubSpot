namespace Naos.HubSpot.Feature.ApiCommunicator.Protocol
{
    using System.Threading.Tasks;
    using Naos.HubSpot.Domain.Models;
    using Naos.HubSpot.Domain.Operations;
    using Naos.HubSpot.Domain.Protocols;
    using Naos.HubSpot.Feature.ApiCommunicator.UriStrategies;
    using Naos.Protocol.Domain;

    /// <summary>
    /// The GetContactFromApiProtocol.
    /// </summary>
    public class GetContactFromApiProtocol : ISyncAndAsyncReturningProtocol<GetHubSpotContactOp, Contact>
    {
        private readonly IProtocolHubSpotAccessKeys hubspotAccessKeysProtocol;

        /// <summary>
        /// Initializes a new instance of the <see cref="GetContactFromApiProtocol"/> class.
        /// </summary>
        /// <param name="hubspotAccessKeysProtocol">The protocol for obtaining a new or continue HubSpot oAuth Access Token.</param>
        public GetContactFromApiProtocol(IProtocolHubSpotAccessKeys hubspotAccessKeysProtocol)
        {
            this.hubspotAccessKeysProtocol = hubspotAccessKeysProtocol;
        }

        /// <summary>
        /// Executes the op.
        /// </summary>
        /// <param name="operation">The Operation.</param>
        /// <returns>The contact.</returns>
        public Contact Execute(GetHubSpotContactOp operation)
        {
            // check to see if the continue token exists, if not, use GetHubSpotAccessTokenOp
            var accessKey = this.hubspotAccessKeysProtocol.Execute(new GetHubSpotAccessTokenOp());
            // do logic to get the contact
            // update continue key using GetHubSpotAccessToken.
            this.hubspotAccessKeysProtocol.Execute(new ContinueAccessTokenOp
                {ContinueAccessToken = "Continuing access token from the HubSpot transaction"});
            // return contact.
            throw new System.NotImplementedException();
        }

        /// <summary>
        /// Executes the operation asynchronously.
        /// </summary>
        /// <param name="operation">The Operation.</param>
        /// <returns>Task returning the contact.</returns>
        public Task<Contact> ExecuteAsync(GetHubSpotContactOp operation)
        {
            throw new System.NotImplementedException();
        }
    }
}
