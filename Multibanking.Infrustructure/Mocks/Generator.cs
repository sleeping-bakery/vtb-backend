using Multibanking.GuaranteeClient.Model;

namespace Multibanking.Infrustructure.Mocks;

public static class Generator
{
    private static readonly Random Random = new();

    private static readonly List<string> Descriptions =
    [
        "Status description 1",
        "Status description 2",
        "Status description 3",
        "Status description 4"
    ];

    public static string GenerateAccount(int length = 20)
    {
        var accountNumber = new char[length];
        for (var i = 0; i < length; i++) accountNumber[i] = (char)('0' + Random.Next(0, 10));

        return new string(accountNumber);
    }

    public static string GenerateInn()
    {
        var random = new Random();
        var inn = new int[12];

        for (var i = 0; i < 10; i++) inn[i] = random.Next(0, 10);

        inn[10] =
            (7 * inn[0] + 2 * inn[1] + 4 * inn[2] + 10 * inn[3] +
             3 * inn[4] + 5 * inn[5] + 9 * inn[6] + 4 * inn[7] +
             6 * inn[8] + 8 * inn[9]) % 11 % 10;

        inn[11] =
            (3 * inn[0] + 7 * inn[1] + 2 * inn[2] + 4 * inn[3] +
             10 * inn[4] + 3 * inn[5] + 5 * inn[6] + 9 * inn[7] +
             4 * inn[8] + 6 * inn[9] + 8 * inn[10]) % 11 % 10;

        return string.Concat(inn);
    }

    public static string GenerateKpp()
    {
        var random = new Random();
        var kpp = new char[9];

        kpp[0] = '7';
        kpp[1] = '7';
        kpp[2] = (char)('0' + random.Next(0, 10)); // случайная третья цифра
        kpp[3] = (char)('0' + random.Next(0, 10)); // случайная четвертая цифра

        kpp[4] = '0';
        kpp[5] = '1';

        kpp[6] = (char)('0' + random.Next(0, 10));
        kpp[7] = (char)('0' + random.Next(0, 10));
        kpp[8] = (char)('0' + random.Next(0, 10));

        return new string(kpp);
    }

    public static OrderStatus GenerateRandomOrderStatus()
    {
        // Генерируем случайные значения
        var commission = (decimal)(Random.NextDouble() * 100); // Случайная комиссия от 0 до 100
        var orderId = Guid.NewGuid().ToString();
        var orderNumber = GenerateRandomOrderNumber();
        var legalNumber = GenerateRandomLegalNumber();
        var label = GenerateRandomLabel();
        var orderStatus = (OrderStatus.OrderStatusEnum)Random.Next(1, 9); // Значения от 1 до 8
        var statusDescription = GenerateRandomStatusDescription();
        var countComments = new CommentCountResponseDto(Random.Next(0, 100), Random.Next(0, 50)); // Случайное количество комментариев
        var parentId = Guid.NewGuid().ToString(); // Случайный parentId
        var startDate = DateTime.Now.AddDays(-Random.Next(1, 30)); // Случайная дата начала в пределах последнего месяца
        var endDate = startDate.AddDays(Random.Next(1, 30)); // Дата окончания позже даты начала
        var bankGuaranteeSum = (decimal)(Random.NextDouble() * 10000); // Сумма банковской гарантии от 0 до 10000
        var annualInterestRate = (decimal)(Random.NextDouble() * 15); // Годовая процентная ставка от 0 до 15%

        return new OrderStatus(
            commission,
            [],
            orderId,
            orderNumber,
            legalNumber,
            label,
            orderStatus,
            statusDescription,
            countComments,
            parentId,
            startDate,
            endDate,
            bankGuaranteeSum,
            annualInterestRate
        );
    }


    private static string GenerateRandomOrderNumber()
    {
        return $"Order-{Random.Next(10000, 99999)}";
    }


    private static string GenerateRandomLegalNumber()
    {
        return $"Legal-{Random.Next(10000, 99999)}";
    }

    private static string GenerateRandomLabel()
    {
        return $"Label_{Guid.NewGuid().ToString().Substring(0, 8)}";
    }

    private static string GenerateRandomStatusDescription()
    {
        return Descriptions[Random.Next(Descriptions.Count)];
    }

    public static decimal GenerateRandomCommission(decimal min = 0m, decimal max = 1000000000m, int decimalPlaces = 2)
    {
        return Math.Round((decimal)(new Random().NextDouble() * (double)(max - min) + (double)min), decimalPlaces);
    }
}