using System.Diagnostics.CodeAnalysis;

namespace DvBCrud.Common.Api.CrudActions;

/// <summary>
/// Defines which actions are allowed on a CrudController
/// </summary>
[ExcludeFromCodeCoverage]
[AttributeUsage(AttributeTargets.Class)]
public sealed class AllowedActionsAttribute : Attribute
{
    public CrudAction[] AllowedActions { get; }

    public AllowedActionsAttribute(params CrudAction[] allowedActions)
    {
        AllowedActions = allowedActions;
    }
}