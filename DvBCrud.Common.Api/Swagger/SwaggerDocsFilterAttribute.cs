using System.Diagnostics.CodeAnalysis;
using DvBCrud.Common.Api.CrudActions;

namespace DvBCrud.Common.Api.Swagger;

[ExcludeFromCodeCoverage]
[AttributeUsage(AttributeTargets.Method)]
public class SwaggerDocsFilterAttribute : Attribute
{
    public CrudAction HideIfNotAllowed { get; }
    
    public SwaggerDocsFilterAttribute(CrudAction hideIfNotAllowed)
    {
        HideIfNotAllowed = hideIfNotAllowed;
    }
}