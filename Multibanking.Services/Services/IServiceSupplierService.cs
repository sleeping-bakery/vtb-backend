using Multibanking.ServiceClient.Model;

namespace Multibanking.Services.Services;

public interface IServiceSupplierService
{
    PageDtoRsServiceProviderSearchDtoRs GetServices();
};