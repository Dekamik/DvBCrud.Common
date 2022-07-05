using DvBCrud.Common.Api.Controllers;
using Microsoft.AspNetCore.Mvc;

namespace DvBCrud.Common.Api.Tests.Controllers.Mocks;

public class AnyCrudControllerBase : CrudControllerBase<string>
{
    public IActionResult AnyNotAllowedMethod()
    {
        return NotAllowed("GET");
    }
}