﻿namespace Cake.Docker
{
    /// <summary>
    /// Settings for docker swarm init.
    /// </summary>
    public sealed class DockerNetworkDisconnectSettings : AutoToolSettings
    {
        /// <summary>
        /// Force the container to disconnect from a network
        /// </summary>
        public bool Force { get; set; }
    }
}
