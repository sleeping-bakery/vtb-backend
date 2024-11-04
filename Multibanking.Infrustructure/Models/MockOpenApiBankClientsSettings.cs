namespace Multibanking.Infrustructure.Models;

public class MockOpenApiBankClientsSettings
{
    public bool IsAccountClientMock { get; set; }

    public bool IsCardClientMock { get; set; }

    public bool IsUnidentifiedPaymentClientMock { get; set; }
    
    public bool IsServiceClientMock { get; set; }
    
    public bool IsUniversalPaymentClientMock { get; set; }
    
    public bool IsPeriodPaymentClientMock { get; set; }
    
    public bool IsBonusPointClientMock { get; set; }
    
    public bool IsGuaranteeClientMock { get; set; }
}