namespace Multibanking.Infrustructure.Models;

public class MockOpenApiBankClientsSettings
{
    public bool IsAccountClientMock { get; set; }
    
    public bool IsCardClientMock { get; set; }
    
    public bool IsUnidentifiedPaymentClientMock { get; set; }
}