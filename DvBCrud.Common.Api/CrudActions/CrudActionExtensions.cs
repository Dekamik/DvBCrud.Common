#nullable enable
namespace DvBCrud.Common.Api.CrudActions;

public static class CrudActionExtensions
{
    public static bool IsActionAllowed(this IEnumerable<CrudAction>? allowedActions, CrudAction action)
    {
        var allowedActionsArr = allowedActions?.ToArray();
        return allowedActionsArr == null ||
               !allowedActionsArr.Any() ||
               allowedActionsArr.Contains(action);
    }
}