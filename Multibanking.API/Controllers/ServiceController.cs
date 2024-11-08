using Microsoft.AspNetCore.Mvc;
using Multibanking.ServiceClient.Model;
using Multibanking.Services.Services;

namespace Multibanking.API.Controllers;

[ApiController]
[Route("[controller]")]
public class ServiceController(IServiceSupplierService serviceSupplierService) : ControllerBase
{
    /// <summary>
    ///     Получить список услуг
    /// </summary>
    /// <returns></returns>
    [HttpGet]
    public ActionResult<PageDtoRsServiceProviderSearchDtoRs> Get()
    {
        return serviceSupplierService.GetServices();
    }
}