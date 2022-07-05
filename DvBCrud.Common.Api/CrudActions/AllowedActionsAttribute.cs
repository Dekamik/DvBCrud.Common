using System.Diagnostics.CodeAnalysis;

namespace DvBCrud.Common.Api.CrudActions
{
    [ExcludeFromCodeCoverage]
    [AttributeUsage(AttributeTargets.Class)]
    public class AllowedActionsAttribute : Attribute
    {
        public CrudAction[] AllowedActions { get; }

        public AllowedActionsAttribute(params CrudAction[] allowedActions)
        {
            AllowedActions = allowedActions;
        }
    }
}


