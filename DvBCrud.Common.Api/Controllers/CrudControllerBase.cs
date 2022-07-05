using Microsoft.AspNetCore.Mvc;

namespace DvBCrud.Common.Api.Controllers;

public abstract class CrudControllerBase<TModel> : ControllerBase
{
    protected ObjectResult NotAllowed(string method) => StatusCode(405, $"{method} not allowed on {typeof(TModel).Name}");
}