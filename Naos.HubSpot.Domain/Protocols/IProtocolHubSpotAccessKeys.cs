namespace Naos.HubSpot.Domain.Protocols
{
    using Naos.HubSpot.Domain.Operations;
    using Naos.Protocol.Domain;

    /// <summary>
    /// The protocol interface for getting initial the access key or the continue access key from HubSpot.
    /// </summary>
    public interface IProtocolHubSpotAccessKeys : IAsyncReturningProtocol<GetHubSpotAccessTokenOp, string>, ISyncAndAsyncVoidProtocol<ContinueAccessTokenOp>
    {
    }
}
