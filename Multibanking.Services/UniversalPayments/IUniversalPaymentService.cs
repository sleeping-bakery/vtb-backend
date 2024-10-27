using Multibanking.Contracts.UniversalPayment;

namespace Multibanking.Services.UniversalPayments;

public interface IUniversalPaymentService
{
    void CreatePaymentRequest(CreateUniversalPaymentDto createUniversalPaymentDto);
}