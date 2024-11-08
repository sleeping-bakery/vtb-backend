using Multibanking.Data.OpenAPIBankClients.ServiceClient;
using Multibanking.ServiceClient.Model;

namespace Multibanking.Services.Services;

public class ServiceSupplierService(IServiceClient serviceClient) : IServiceSupplierService
{
    public PageDtoRsServiceProviderSearchDtoRs GetServices()
    {
        return serviceClient.FindOperations();
    }
}