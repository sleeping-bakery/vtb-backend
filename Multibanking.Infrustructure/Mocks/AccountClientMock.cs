using Moq;
using Multibanking.AccountClient.Model;
using Multibanking.Data.OpenAPIBankClients.AccountClient;

namespace Multibanking.Infrustructure.Mocks;

public static class AccountClientMock
{
    private static readonly string StatementId = Guid.NewGuid().ToString();

    private static string GenerateInn()
    {
        var random = new Random();
        var inn = new int[12];

        for (var i = 0; i < 10; i++)
        {
            inn[i] = random.Next(0, 10);
        }

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

    private static string GenerateKpp()
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

    private static readonly string[] Adjectives =
    [
        "Global", "Innovative", "Dynamic", "NextGen", "Smart", "Unified",
        "Advanced", "Modern", "Green", "Prime", "Vanguard", "Elite"
    ];

    private static readonly string[] Nouns =
    [
        "Solutions", "Technologies", "Systems", "Networks", "Group",
        "Holdings", "Ventures", "Dynamics", "Industries", "Concepts", "Partners"
    ];

    private static readonly string[] Endings =
    [
        "Ltd", "LLC", "Corp", "Inc", "AG", "SA", "PLC", "Group", "Enterprises"
    ];

    public static string GenerateCompanyName()
    {
        var random = new Random();

        var adjective = Adjectives[random.Next(Adjectives.Length)];
        var noun = Nouns[random.Next(Nouns.Length)];
        var ending = Endings[random.Next(Endings.Length)];

        return $"{adjective} {noun} {ending}";
    }

    private static readonly List<string> AccountIds =
    [
        "978232c6-dc4d-471c-880f-a7177422d9a8",
        "cceac821-32e1-4682-907e-3c8602b5fc24",
        "0293af91-b687-4e9a-8346-24693bd79bc6",
        "40b68082-b078-4725-b3f5-a20d822da926"
    ];

    private static readonly List<string> TransactionIds =
    [
        // Дебитовая
        Guid.NewGuid().ToString(), Guid.NewGuid().ToString(),
        // Кредитка
        Guid.NewGuid().ToString(), Guid.NewGuid().ToString(), Guid.NewGuid().ToString(), Guid.NewGuid().ToString(), Guid.NewGuid().ToString(),
        // Ипотека
        Guid.NewGuid().ToString(), Guid.NewGuid().ToString(), Guid.NewGuid().ToString(), Guid.NewGuid().ToString(), Guid.NewGuid().ToString(),
    ];

    private static AccountResponse MockedAccounts()
    {
        return new AccountResponse(new DataAccountResponseComplexType(
        [
            new AccountComplexType(AccountIds[0], AccountStatusStaticType.Enabled, DateTime.Now, "RUB", AccountTypeStaticType.Personal,
                AccountSubTypeStaticType.CurrentAccount, "Мой любимый счет!", [],
                new Party("Мокнутый Мок Мокович", "+79995556677", "RUS", "RUS", "Калужская область", "Калуга", DateTime.Now, [], [])),
            new AccountComplexType(AccountIds[1], AccountStatusStaticType.Disabled, DateTime.Now, "RUB", AccountTypeStaticType.Personal,
                AccountSubTypeStaticType.CreditCard, "Заблокирована от греха подальше", [],
                new Party("Мокнутый Мок Мокович", "+79995556677", "RUS", "RUS", "Калужская область", "Калуга", DateTime.Now, [], [])),
            new AccountComplexType(AccountIds[2], AccountStatusStaticType.Deleted, DateTime.Now, "RUB", AccountTypeStaticType.Personal,
                AccountSubTypeStaticType.CurrentAccount, "Счет от института", [],
                new Party("Мокнутый Мок Мокович", "+79995556677", "RUS", "RUS", "Калужская область", "Калуга", DateTime.Now, [], [])),
            new AccountComplexType(AccountIds[3], AccountStatusStaticType.Enabled, DateTime.Now, "RUB", AccountTypeStaticType.Personal,
                AccountSubTypeStaticType.Savings, "На ипотеку", [],
                new Party("Мокнутый Мок Мокович", "+79995556677", "RUS", "RUS", "Калужская область", "Калуга", DateTime.Now, [], []))
        ]), new object(), new LinksType(""), new MetaType());
    }

    private static BalanceResponse MockedBalances()
    {
        return new BalanceResponse(new DataBalanceResponseComplexType
        ([
            new BalanceComplexType(AccountIds[0], CreditDebitIndicatorStaticType.Debit, BalanceTypeStaticType.Expected, DateTime.Now,
                new TransactionCashBalanceComplexTypeAmount("69015", "RUB"), []),
            new BalanceComplexType(AccountIds[1], CreditDebitIndicatorStaticType.Credit, BalanceTypeStaticType.Expected, DateTime.Now,
                new TransactionCashBalanceComplexTypeAmount("130000", "RUB"),
                [
                    new CreditLineComplexType(false, CreditLineStaticType.TmpVal1, new AmountComplexType("10000", "RUB")),
                    new CreditLineComplexType(true, CreditLineStaticType.TmpVal1, new AmountComplexType("20000", "RUB"))
                ]),
            new BalanceComplexType(AccountIds[2], CreditDebitIndicatorStaticType.Debit, BalanceTypeStaticType.OpeningCleared, DateTime.Now,
                new TransactionCashBalanceComplexTypeAmount("0", "RUB"), []),
            new BalanceComplexType(AccountIds[3], CreditDebitIndicatorStaticType.Debit, BalanceTypeStaticType.Expected, DateTime.Now,
                new TransactionCashBalanceComplexTypeAmount("1046490", "RUB"), []),
        ]), new object(), new LinksType(""), new MetaType());
    }

    private static TransactionResponse MockedTransactions()
    {
        return new TransactionResponse(new DataTransactionResponseComplexType
        ([
            // Дебитовая карта
            new TransactionComplex(AccountIds[0], TransactionIds[0], "", CreditDebitIndicatorStaticType.Debit, TransactionStatusStaticType.Booked, DateTime.Now,
                DateTime.Now, "Пополнение счета", "г. Калуга", new TransactionComplexTypeAmount("70000", "RUB"), new TransactionComplexChargeAmount("0", "RUB"),
                new TransactionComplexCurrencyExchange("RUB", "RUB", "RUB", BaseOneRate.TmpVal2, Guid.NewGuid().ToString(), DateTime.Now,
                    new CurrencyExchangeComplexTypeInstructedAmount("70000", "RUB"))),
            new TransactionComplex(AccountIds[0], TransactionIds[1], "", CreditDebitIndicatorStaticType.Credit, TransactionStatusStaticType.Booked, DateTime.Now,
                DateTime.Now, "Покупки в магазине", "г. Калуга", new TransactionComplexTypeAmount("985", "RUB"), new TransactionComplexChargeAmount("0", "RUB"),
                new TransactionComplexCurrencyExchange("RUB", "RUB", "RUB", BaseOneRate.TmpVal2, Guid.NewGuid().ToString(), DateTime.Now,
                    new CurrencyExchangeComplexTypeInstructedAmount("985", "RUB"))),
            // Кредитка
            new TransactionComplex(AccountIds[1], TransactionIds[2], "", CreditDebitIndicatorStaticType.Debit, TransactionStatusStaticType.Booked, DateTime.Now,
                DateTime.Now, "Кредитованные средства", "г. Калуга", new TransactionComplexTypeAmount("150000", "RUB"), new TransactionComplexChargeAmount("0", "RUB"),
                new TransactionComplexCurrencyExchange("RUB", "RUB", "RUB", BaseOneRate.TmpVal2, Guid.NewGuid().ToString(), DateTime.Now,
                    new CurrencyExchangeComplexTypeInstructedAmount("150000", "RUB"))),
            new TransactionComplex(AccountIds[1], TransactionIds[3], "", CreditDebitIndicatorStaticType.Credit, TransactionStatusStaticType.Booked, DateTime.Now,
                DateTime.Now, "Покупка телефона", "г. Калуга", new TransactionComplexTypeAmount("10000", "RUB"), new TransactionComplexChargeAmount("0", "RUB"),
                new TransactionComplexCurrencyExchange("RUB", "RUB", "RUB", BaseOneRate.TmpVal2, Guid.NewGuid().ToString(), DateTime.Now,
                    new CurrencyExchangeComplexTypeInstructedAmount("10000", "RUB"))),
            new TransactionComplex(AccountIds[1], TransactionIds[4], "", CreditDebitIndicatorStaticType.Debit, TransactionStatusStaticType.Booked, DateTime.Now,
                DateTime.Now, "Погашение телефона", "г. Калуга", new TransactionComplexTypeAmount("5000", "RUB"), new TransactionComplexChargeAmount("0", "RUB"),
                new TransactionComplexCurrencyExchange("RUB", "RUB", "RUB", BaseOneRate.TmpVal2, Guid.NewGuid().ToString(), DateTime.Now,
                    new CurrencyExchangeComplexTypeInstructedAmount("5000", "RUB"))),
            new TransactionComplex(AccountIds[1], TransactionIds[5], "", CreditDebitIndicatorStaticType.Debit, TransactionStatusStaticType.Booked, DateTime.Now,
                DateTime.Now, "Погашение телефона", "г. Калуга", new TransactionComplexTypeAmount("5000", "RUB"), new TransactionComplexChargeAmount("0", "RUB"),
                new TransactionComplexCurrencyExchange("RUB", "RUB", "RUB", BaseOneRate.TmpVal2, Guid.NewGuid().ToString(), DateTime.Now,
                    new CurrencyExchangeComplexTypeInstructedAmount("5000", "RUB"))),
            new TransactionComplex(AccountIds[1], TransactionIds[6], "", CreditDebitIndicatorStaticType.Credit, TransactionStatusStaticType.Booked, DateTime.Now,
                DateTime.Now, "Покупка скутера", "г. Калуга", new TransactionComplexTypeAmount("20000", "RUB"), new TransactionComplexChargeAmount("0", "RUB"),
                new TransactionComplexCurrencyExchange("RUB", "RUB", "RUB", BaseOneRate.TmpVal2, Guid.NewGuid().ToString(), DateTime.Now,
                    new CurrencyExchangeComplexTypeInstructedAmount("20000", "RUB"))),
            // Ипотека
            new TransactionComplex(AccountIds[3], TransactionIds[7], "", CreditDebitIndicatorStaticType.Debit, TransactionStatusStaticType.Booked, DateTime.Now,
                DateTime.Now, "Пополнение счета", "г. Калуга", new TransactionComplexTypeAmount("100000", "RUB"), new TransactionComplexChargeAmount("0", "RUB"),
                new TransactionComplexCurrencyExchange("RUB", "RUB", "RUB", BaseOneRate.TmpVal2, Guid.NewGuid().ToString(), DateTime.Now,
                    new CurrencyExchangeComplexTypeInstructedAmount("100000", "RUB"))),
            new TransactionComplex(AccountIds[3], TransactionIds[8], "", CreditDebitIndicatorStaticType.Debit, TransactionStatusStaticType.Booked, DateTime.Now,
                DateTime.Now, "Пополнение счета", "г. Калуга", new TransactionComplexTypeAmount("564000", "RUB"), new TransactionComplexChargeAmount("0", "RUB"),
                new TransactionComplexCurrencyExchange("RUB", "RUB", "RUB", BaseOneRate.TmpVal2, Guid.NewGuid().ToString(), DateTime.Now,
                    new CurrencyExchangeComplexTypeInstructedAmount("564000", "RUB"))),
            new TransactionComplex(AccountIds[3], TransactionIds[9], "", CreditDebitIndicatorStaticType.Debit, TransactionStatusStaticType.Booked, DateTime.Now,
                DateTime.Now, "Пополнение счета", "г. Калуга", new TransactionComplexTypeAmount("169000", "RUB"), new TransactionComplexChargeAmount("0", "RUB"),
                new TransactionComplexCurrencyExchange("RUB", "RUB", "RUB", BaseOneRate.TmpVal2, Guid.NewGuid().ToString(), DateTime.Now,
                    new CurrencyExchangeComplexTypeInstructedAmount("169000", "RUB"))),
            new TransactionComplex(AccountIds[3], TransactionIds[10], "", CreditDebitIndicatorStaticType.Debit, TransactionStatusStaticType.Booked, DateTime.Now,
                DateTime.Now, "Пополнение счета", "г. Калуга", new TransactionComplexTypeAmount("203470", "RUB"), new TransactionComplexChargeAmount("0", "RUB"),
                new TransactionComplexCurrencyExchange("RUB", "RUB", "RUB", BaseOneRate.TmpVal2, Guid.NewGuid().ToString(), DateTime.Now,
                    new CurrencyExchangeComplexTypeInstructedAmount("203470", "RUB"))),
            new TransactionComplex(AccountIds[3], TransactionIds[11], "", CreditDebitIndicatorStaticType.Debit, TransactionStatusStaticType.Booked, DateTime.Now,
                DateTime.Now, "Пополнение счета", "г. Калуга", new TransactionComplexTypeAmount("10020", "RUB"), new TransactionComplexChargeAmount("0", "RUB"),
                new TransactionComplexCurrencyExchange("RUB", "RUB", "RUB", BaseOneRate.TmpVal2, Guid.NewGuid().ToString(), DateTime.Now,
                    new CurrencyExchangeComplexTypeInstructedAmount("10020", "RUB"))),
        ]), new object(), new LinksType(""), new MetaType());
    }

    private static StatementResponse MockedStatements()
    {
        return new StatementResponse(new DataStatementResponseComplexType
        ([
            // Дебитовая карта
            new StatementComplexType(AccountIds[0], Guid.NewGuid().ToString(), DateTime.Now, DateTime.Now, DateTime.Now,
            [
                new TransactionComplexType(TransactionIds[0], CreditDebitIndicatorStaticType.Debit, TransactionStatusStaticType.Booked, Guid.NewGuid().ToString(), DateTime.Now,
                    DateTime.Now, "Пополнение счета", new TransactionComplexTypeAmount("70000", "RUB"),
                    new TransactionComplexTypeDebtorParty(GenerateInn(), GenerateCompanyName(), GenerateKpp()),
                    new TransactionComplexTypeDebtorAccount(AccountIdentificationDynamicType.CellphoneNumber, "+79995556677")),
                new TransactionComplexType(TransactionIds[1], CreditDebitIndicatorStaticType.Credit, TransactionStatusStaticType.Booked, Guid.NewGuid().ToString(), DateTime.Now,
                    DateTime.Now, "Покупки в магазине", new TransactionComplexTypeAmount("985", "RUB"),
                    new TransactionComplexTypeDebtorParty(GenerateInn(), GenerateCompanyName(), GenerateKpp()),
                    new TransactionComplexTypeDebtorAccount(AccountIdentificationDynamicType.CellphoneNumber, "+79995556677")),
            ]),
            // Кредитка
            new StatementComplexType(AccountIds[1], Guid.NewGuid().ToString(), DateTime.Now, DateTime.Now, DateTime.Now,
            [
                new TransactionComplexType(TransactionIds[2], CreditDebitIndicatorStaticType.Debit, TransactionStatusStaticType.Booked, Guid.NewGuid().ToString(), DateTime.Now,
                    DateTime.Now, "Кредитованные средства", new TransactionComplexTypeAmount("150000", "RUB"),
                    new TransactionComplexTypeDebtorParty(GenerateInn(), GenerateCompanyName(), GenerateKpp()),
                    new TransactionComplexTypeDebtorAccount(AccountIdentificationDynamicType.CellphoneNumber, "+79995556677")),
                new TransactionComplexType(TransactionIds[3], CreditDebitIndicatorStaticType.Credit, TransactionStatusStaticType.Booked, Guid.NewGuid().ToString(), DateTime.Now,
                    DateTime.Now, "Покупка телефона", new TransactionComplexTypeAmount("10000", "RUB"),
                    new TransactionComplexTypeDebtorParty(GenerateInn(), GenerateCompanyName(), GenerateKpp()),
                    new TransactionComplexTypeDebtorAccount(AccountIdentificationDynamicType.CellphoneNumber, "+79995556677")),
                new TransactionComplexType(TransactionIds[4], CreditDebitIndicatorStaticType.Debit, TransactionStatusStaticType.Booked, Guid.NewGuid().ToString(), DateTime.Now,
                    DateTime.Now, "Погашение телефона", new TransactionComplexTypeAmount("5000", "RUB"),
                    new TransactionComplexTypeDebtorParty(GenerateInn(), GenerateCompanyName(), GenerateKpp()),
                    new TransactionComplexTypeDebtorAccount(AccountIdentificationDynamicType.CellphoneNumber, "+79995556677")),
                new TransactionComplexType(TransactionIds[5], CreditDebitIndicatorStaticType.Debit, TransactionStatusStaticType.Booked, Guid.NewGuid().ToString(), DateTime.Now,
                    DateTime.Now, "Погашение телефона", new TransactionComplexTypeAmount("5000", "RUB"),
                    new TransactionComplexTypeDebtorParty(GenerateInn(), GenerateCompanyName(), GenerateKpp()),
                    new TransactionComplexTypeDebtorAccount(AccountIdentificationDynamicType.CellphoneNumber, "+79995556677")),
                new TransactionComplexType(TransactionIds[6], CreditDebitIndicatorStaticType.Credit, TransactionStatusStaticType.Booked, Guid.NewGuid().ToString(), DateTime.Now,
                    DateTime.Now, "Покупка скутера", new TransactionComplexTypeAmount("20000", "RUB"),
                    new TransactionComplexTypeDebtorParty(GenerateInn(), GenerateCompanyName(), GenerateKpp()),
                    new TransactionComplexTypeDebtorAccount(AccountIdentificationDynamicType.CellphoneNumber, "+79995556677"))
            ]),
            // Ипотека
            new StatementComplexType(AccountIds[3], Guid.NewGuid().ToString(), DateTime.Now, DateTime.Now, DateTime.Now,
            [
                new TransactionComplexType(TransactionIds[7], CreditDebitIndicatorStaticType.Debit, TransactionStatusStaticType.Booked, Guid.NewGuid().ToString(), DateTime.Now,
                    DateTime.Now, "Пополнение счета", new TransactionComplexTypeAmount("100000", "RUB"),
                    new TransactionComplexTypeDebtorParty(GenerateInn(), GenerateCompanyName(), GenerateKpp()),
                    new TransactionComplexTypeDebtorAccount(AccountIdentificationDynamicType.CellphoneNumber, "+79995556677")),
                new TransactionComplexType(TransactionIds[8], CreditDebitIndicatorStaticType.Debit, TransactionStatusStaticType.Booked, Guid.NewGuid().ToString(), DateTime.Now,
                    DateTime.Now, "Пополнение счета", new TransactionComplexTypeAmount("564000", "RUB"),
                    new TransactionComplexTypeDebtorParty(GenerateInn(), GenerateCompanyName(), GenerateKpp()),
                    new TransactionComplexTypeDebtorAccount(AccountIdentificationDynamicType.CellphoneNumber, "+79995556677")),
                new TransactionComplexType(TransactionIds[9], CreditDebitIndicatorStaticType.Debit, TransactionStatusStaticType.Booked, Guid.NewGuid().ToString(), DateTime.Now,
                    DateTime.Now, "Пополнение счета", new TransactionComplexTypeAmount("169000", "RUB"),
                    new TransactionComplexTypeDebtorParty(GenerateInn(), GenerateCompanyName(), GenerateKpp()),
                    new TransactionComplexTypeDebtorAccount(AccountIdentificationDynamicType.CellphoneNumber, "+79995556677")),
                new TransactionComplexType(TransactionIds[10], CreditDebitIndicatorStaticType.Debit, TransactionStatusStaticType.Booked, Guid.NewGuid().ToString(), DateTime.Now,
                    DateTime.Now, "Пополнение счета", new TransactionComplexTypeAmount("203470", "RUB"),
                    new TransactionComplexTypeDebtorParty(GenerateInn(), GenerateCompanyName(), GenerateKpp()),
                    new TransactionComplexTypeDebtorAccount(AccountIdentificationDynamicType.CellphoneNumber, "+79995556677")),
                new TransactionComplexType(TransactionIds[11], CreditDebitIndicatorStaticType.Debit, TransactionStatusStaticType.Booked, Guid.NewGuid().ToString(), DateTime.Now,
                    DateTime.Now, "Пополнение счета", new TransactionComplexTypeAmount("10020", "RUB"),
                    new TransactionComplexTypeDebtorParty(GenerateInn(), GenerateCompanyName(), GenerateKpp()),
                    new TransactionComplexTypeDebtorAccount(AccountIdentificationDynamicType.CellphoneNumber, "+79995556677")),
            ])
        ]), new object(), new LinksType(""), new MetaType());
    }

    public static Mock<IAccountConsentsClient> MockAccountConsentsClient()
    {
        var mock = new Mock<IAccountConsentsClient>();
        mock.Setup(accountConsentsClient => accountConsentsClient.CreateAccountAccessConsents(It.IsAny<Consent>(), It.IsAny<string>(),
                It.IsAny<string>(), It.IsAny<string>(), It.IsAny<string>(), It.IsAny<string>(), It.IsAny<int>()))
            .Returns(() =>
            {
                var id = Guid.NewGuid().ToString();
                return new ConsentResponse(new DataConsentResponseType(id, DateTime.Now,
                    ConsentStatusType.Authorised, DateTime.Now, []), new object(), new LinksType(id), new MetaType());
            });

        return mock;
    }

    public static Mock<IAccountsClient> MockAccountsClient()
    {
        var mock = new Mock<IAccountsClient>();
        mock.Setup(accountsClient =>
                accountsClient.GetAccounts(It.IsAny<int?>(), It.IsAny<string>(), It.IsAny<string>(), It.IsAny<string>(), It.IsAny<string>(), It.IsAny<int>())
            )
            .Returns(MockedAccounts);

        mock.Setup(accountsClient =>
                accountsClient.GetAccountsaccountId(It.IsAny<string>(), It.IsAny<string>(), It.IsAny<string>(), It.IsAny<string>(), It.IsAny<string>(), It.IsAny<int>())
            )
            .Returns((string accountId, string _, string _, string _, string _, int _) =>
            {
                var accountsWithOneAccount = MockedAccounts();
                accountsWithOneAccount.Data.Account = accountsWithOneAccount.Data.Account.Where(account => account.AccountId == accountId).ToList();
                return accountsWithOneAccount;
            });
        return mock;
    }

    public static Mock<IBalancesClient> MockBalancesClient()
    {
        var mock = new Mock<IBalancesClient>();

        mock.Setup(balancesClient =>
                balancesClient.GetBalances(It.IsAny<int?>(), It.IsAny<string>(), It.IsAny<string>(), It.IsAny<string>(), It.IsAny<string>(), It.IsAny<int>())
            )
            .Returns(MockedBalances);

        mock.Setup(balancesClient =>
                balancesClient.GetAccountsaccountIdBalances(It.IsAny<string>(), It.IsAny<string>(), It.IsAny<string>(), It.IsAny<string>(), It.IsAny<string>(), It.IsAny<int>())
            )
            .Returns((string accountId, string _, string _, string _, string _, int _) =>
            {
                var balancesWithOneBalance = MockedBalances();
                balancesWithOneBalance.Data.Balance = balancesWithOneBalance.Data.Balance.Where(balance => balance.AccountId == accountId).ToList();
                return balancesWithOneBalance;
            });

        return mock;
    }


    public static Mock<ITransactionsClient> MockTransactionsClient()
    {
        var mock = new Mock<ITransactionsClient>();

        mock.Setup(transactionClient => transactionClient.GetTransactions(It.IsAny<int?>(), It.IsAny<DateTime?>(), It.IsAny<DateTime?>(), It.IsAny<string>(), It.IsAny<string>(),
                It.IsAny<string>(), It.IsAny<string>(), It.IsAny<int>())
            )
            .Returns(MockedTransactions);

        mock.Setup(transactionClient => transactionClient.GetAccountsaccountIdTransactions(It.IsAny<string>(), It.IsAny<int?>(), It.IsAny<DateTime?>(), It.IsAny<DateTime?>(),
                It.IsAny<string>(), It.IsAny<string>(),
                It.IsAny<string>(), It.IsAny<string>(), It.IsAny<int>())
            )
            .Returns((string accountId, int? _, DateTime? _, DateTime? _, string _, string _, string _, string _, int _) =>
            {
                var transactionsWithOneTransaction = MockedTransactions();
                transactionsWithOneTransaction.Data.Transaction = transactionsWithOneTransaction.Data.Transaction.Where(transaction => transaction.AccountId == accountId).ToList();
                return transactionsWithOneTransaction;
            });
        return mock;
    }

    public static Mock<IStatementsClient> MockStatementsClient()
    {
        var mock = new Mock<IStatementsClient>();

        mock.Setup(statementClient => statementClient.GetStatementsaccountId(It.IsAny<string>(), It.IsAny<string>(), It.IsAny<StatementInitRequest>(), It.IsAny<string>(),
                It.IsAny<string>(), It.IsAny<string>(), It.IsAny<string>(), It.IsAny<int>())
            )
            .Returns(() => new StatementInitResponse(new DataStatementInitResponseComplexType(new StatementInitRespComplex(statementId: StatementId)), new object(),
                new LinksType(""), new MetaType())
            );

        mock.Setup(statementClient => statementClient.GetStatements(It.IsAny<int?>(), It.IsAny<DateTime?>(), It.IsAny<DateTime?>(),
                It.IsAny<string>(), It.IsAny<string>(),
                It.IsAny<string>(), It.IsAny<string>(), It.IsAny<int>())
            )
            .Returns(MockedStatements);

        mock.Setup(statementClient => statementClient.GetAccountsaccountIdStatementsStatementId(It.IsAny<string>(), It.IsAny<string>(), It.IsAny<int?>(), It.IsAny<DateTime?>(),
                It.IsAny<DateTime?>(), It.IsAny<string>(), It.IsAny<string>(), It.IsAny<string>(), It.IsAny<string>(), It.IsAny<int>())
            )
            .Returns((string accountId, string _, int? _, DateTime? _, DateTime? _, string _, string _, string _, string _, int _) =>
            {
                var statementForAccount = MockedStatements();
                statementForAccount.Data.Statement = statementForAccount.Data.Statement.Where(statement => statement.AccountId == accountId).ToList();
                return statementForAccount;
            });
        return mock;
    }
}