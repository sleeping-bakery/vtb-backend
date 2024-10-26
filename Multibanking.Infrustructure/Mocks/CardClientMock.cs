using System.Text;
using Moq;
using Multibanking.CardEmissionClient.Model;
using Multibanking.CardInformationClient.Model;
using Multibanking.Data.OpenAPIBankClients.CardClient;

namespace Multibanking.Infrustructure.Mocks;

public static class CardClientMock
{
    private static readonly Random Random = new Random();

    private static string GenerateRandomPan(int length)
    {
        var pan = new char[length];
        for (var i = 0; i < length; i++)
        {
            pan[i] = (char)('0' + Random.Next(0, 10)); // Генерация случайной цифры
        }

        return new string(pan);
    }

    private static string GenerateMaskedPan(int panLength = 16, int visibleDigits = 4)
    {
        if (panLength <= visibleDigits)
        {
            throw new ArgumentException("PAN length must be greater than the number of visible digits.");
        }

        var pan = GenerateRandomPan(panLength);
        var maskedLength = pan.Length - visibleDigits;

        return string.Concat(new string('*', maskedLength), pan.AsSpan(maskedLength));
    }
    
    private static string GenerateCvv(int length = 3)
    {
        
        var minValue = (int)Math.Pow(10, length - 1);
        var maxValue = (int)Math.Pow(10, length) - 1;

        var cvvNumber = Random.Next(minValue, maxValue + 1);
        
        return cvvNumber.ToString();
    }

    public static Mock<ICardEmissionClient> MockCardEmissionClient()
    {
        var mock = new Mock<ICardEmissionClient>();
        mock.Setup(cardEmissionClient =>
                cardEmissionClient.UpdateCreateCard(It.IsAny<string>(), It.IsAny<string>(), It.IsAny<string>(), It.IsAny<CardOpenRequest>(), It.IsAny<int>())
            )
            .Returns(() => new CardInfoResponse(GenerateMaskedPan(), "", "26.10.2099", Guid.NewGuid().ToString()));
        return mock;
    }

    public static Mock<ICardInformationClient> MockCardInformationClient()
    {
        var mock = new Mock<ICardInformationClient>();
        mock.Setup(cardInformationClient =>
                cardInformationClient.GetCredentials(It.IsAny<string>(), It.IsAny<string>(), It.IsAny<string>(), It.IsAny<string>(), It.IsAny<string>(), It.IsAny<int>())
            )
            .Returns(() => new CredentialsResponse(Convert.ToBase64String(Encoding.UTF8.GetBytes(GenerateRandomPan(16))), "12/29", "Мок Моковный"));

        mock.Setup(cardInformationClient =>
                cardInformationClient.GetCvv(It.IsAny<string>(), It.IsAny<string>(), It.IsAny<string>(), It.IsAny<string>(), It.IsAny<string>(), It.IsAny<int>())
            )
            .Returns(() => new CvvResponse(GenerateCvv()));
        return mock;
    }

    public static Mock<ICardOperationClient> MockCardOperationClient()
    {
        var mock = new Mock<ICardOperationClient>();

        return mock;
    }
}