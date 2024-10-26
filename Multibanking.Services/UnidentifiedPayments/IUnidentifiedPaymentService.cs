using Multibanking.Contracts.UnidentifiedPayment;

namespace Multibanking.Services.UnidentifiedPayments;

public interface IUnidentifiedPaymentService
{
    Task CreatePayment(CreateUnidentifiedPaymentDto createUnidentifiedPaymentDto);
}