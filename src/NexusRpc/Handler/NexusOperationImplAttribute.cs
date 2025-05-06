using System;

namespace NexusRpc
{
    [AttributeUsage(AttributeTargets.Method, Inherited = false)]
    public sealed class NexusOperationImplAttribute : Attribute
    {
    }
}
