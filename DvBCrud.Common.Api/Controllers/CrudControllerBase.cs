using Microsoft.AspNetCore.Mvc;

namespace DvBCrud.Common.Api.Controllers;

public abstract class CrudControllerBase<TModel> : ControllerBase
{
    protected ObjectResult Forbidden() => StatusCode(403, $"Action forbidden on {nameof(TModel)}");
}