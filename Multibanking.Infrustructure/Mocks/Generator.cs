namespace Multibanking.Infrustructure.Mocks;

public static class Generator
{
    
    private static readonly Random Random = new Random();

    public static string GenerateAccount(int length = 20)
    {
        var accountNumber = new char[length];
        for (var i = 0; i < length; i++)
        {
            accountNumber[i] = (char)('0' + Random.Next(0, 10));
        }
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
}