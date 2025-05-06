using System;

namespace NexusRpc.Handler
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Interface | AttributeTargets.Struct, Inherited = false)]
    public sealed class NexusServiceImplAttribute : Attribute
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NexusServiceImplAttribute"/> class with the
        /// given service type.
        /// </summary>
        /// <param name="serviceType">Nexus service type to use.</param>
        public NexusServiceImplAttribute(Type serviceType) => ServiceType = serviceType;

        /// <summary>
        /// Gets the Nexus service type.
        /// </summary>
        public Type ServiceType { get; }
    }
}
