﻿namespace AspNetCore.ApiGateway.Application
{
    public abstract class GatewayHubUserBase
    {
        public string Api { get; set; }
        public string Key { get; set; }
        public string ReceiveKey { get; set; }
    }

    public class GatewayHubUser : GatewayHubUserBase
    {
        public string UserId { get; set; }
    }

    public class GatewayHubGroupUser : GatewayHubUserBase
    {
        public string ReceiveGroup { get; set; }
    }

    internal class GatewayHubUserExtended : GatewayHubUser
    {
        public string ConnectionId { get; set; }
    }
}
