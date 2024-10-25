using AutoMapper;
using Moq;
using Multibanking.AccountClient.Model;
using Multibanking.Data.OpenAPIBankClients.AccountClient;

namespace Multibanking.Infrustructure.Mocks;

public static class AccountClientMock
{
    private static readonly List<string> AccountIds = [Guid.NewGuid().ToString(), Guid.NewGuid().ToString(), Guid.NewGuid().ToString(), Guid.NewGuid().ToString()];

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
            new TransactionComplex(AccountIds[0], Guid.NewGuid().ToString(), "", CreditDebitIndicatorStaticType.Debit, TransactionStatusStaticType.Booked, DateTime.Now,
                DateTime.Now, "Пополнение счета", "г. Калуга", new TransactionComplexTypeAmount("70000", "RUB"), new TransactionComplexChargeAmount("0", "RUB"),
                new TransactionComplexCurrencyExchange("RUB", "RUB", "RUB", BaseOneRate.TmpVal2, Guid.NewGuid().ToString(), DateTime.Now,
                    new CurrencyExchangeComplexTypeInstructedAmount("70000", "RUB"))),
            new TransactionComplex(AccountIds[0], Guid.NewGuid().ToString(), "", CreditDebitIndicatorStaticType.Credit, TransactionStatusStaticType.Booked, DateTime.Now,
                DateTime.Now, "Пополнение счета", "г. Калуга", new TransactionComplexTypeAmount("985", "RUB"), new TransactionComplexChargeAmount("0", "RUB"),
                new TransactionComplexCurrencyExchange("RUB", "RUB", "RUB", BaseOneRate.TmpVal2, Guid.NewGuid().ToString(), DateTime.Now,
                    new CurrencyExchangeComplexTypeInstructedAmount("985", "RUB"))),
            // Кредитка
            new TransactionComplex(AccountIds[1], Guid.NewGuid().ToString(), "", CreditDebitIndicatorStaticType.Debit, TransactionStatusStaticType.Booked, DateTime.Now,
                DateTime.Now, "Кредитованные средства", "г. Калуга", new TransactionComplexTypeAmount("150000", "RUB"), new TransactionComplexChargeAmount("0", "RUB"),
                new TransactionComplexCurrencyExchange("RUB", "RUB", "RUB", BaseOneRate.TmpVal2, Guid.NewGuid().ToString(), DateTime.Now,
                    new CurrencyExchangeComplexTypeInstructedAmount("150000", "RUB"))),
            new TransactionComplex(AccountIds[1], Guid.NewGuid().ToString(), "", CreditDebitIndicatorStaticType.Credit, TransactionStatusStaticType.Booked, DateTime.Now,
                DateTime.Now, "Покупка телефона", "г. Калуга", new TransactionComplexTypeAmount("10000", "RUB"), new TransactionComplexChargeAmount("0", "RUB"),
                new TransactionComplexCurrencyExchange("RUB", "RUB", "RUB", BaseOneRate.TmpVal2, Guid.NewGuid().ToString(), DateTime.Now,
                    new CurrencyExchangeComplexTypeInstructedAmount("10000", "RUB"))),
            new TransactionComplex(AccountIds[1], Guid.NewGuid().ToString(), "", CreditDebitIndicatorStaticType.Debit, TransactionStatusStaticType.Booked, DateTime.Now,
                DateTime.Now, "Погашение телефона", "г. Калуга", new TransactionComplexTypeAmount("5000", "RUB"), new TransactionComplexChargeAmount("0", "RUB"),
                new TransactionComplexCurrencyExchange("RUB", "RUB", "RUB", BaseOneRate.TmpVal2, Guid.NewGuid().ToString(), DateTime.Now,
                    new CurrencyExchangeComplexTypeInstructedAmount("5000", "RUB"))),
            new TransactionComplex(AccountIds[1], Guid.NewGuid().ToString(), "", CreditDebitIndicatorStaticType.Debit, TransactionStatusStaticType.Booked, DateTime.Now,
                DateTime.Now, "Погашение делефона", "г. Калуга", new TransactionComplexTypeAmount("5000", "RUB"), new TransactionComplexChargeAmount("0", "RUB"),
                new TransactionComplexCurrencyExchange("RUB", "RUB", "RUB", BaseOneRate.TmpVal2, Guid.NewGuid().ToString(), DateTime.Now,
                    new CurrencyExchangeComplexTypeInstructedAmount("5000", "RUB"))),
            new TransactionComplex(AccountIds[1], Guid.NewGuid().ToString(), "", CreditDebitIndicatorStaticType.Credit, TransactionStatusStaticType.Booked, DateTime.Now,
                DateTime.Now, "Покупка скутера", "г. Калуга", new TransactionComplexTypeAmount("20000", "RUB"), new TransactionComplexChargeAmount("0", "RUB"),
                new TransactionComplexCurrencyExchange("RUB", "RUB", "RUB", BaseOneRate.TmpVal2, Guid.NewGuid().ToString(), DateTime.Now,
                    new CurrencyExchangeComplexTypeInstructedAmount("20000", "RUB"))),
            // Ипотека
            new TransactionComplex(AccountIds[3], Guid.NewGuid().ToString(), "", CreditDebitIndicatorStaticType.Debit, TransactionStatusStaticType.Booked, DateTime.Now,
                DateTime.Now, "Пополнение счета", "г. Калуга", new TransactionComplexTypeAmount("100000", "RUB"), new TransactionComplexChargeAmount("0", "RUB"),
                new TransactionComplexCurrencyExchange("RUB", "RUB", "RUB", BaseOneRate.TmpVal2, Guid.NewGuid().ToString(), DateTime.Now,
                    new CurrencyExchangeComplexTypeInstructedAmount("100000", "RUB"))),
            new TransactionComplex(AccountIds[3], Guid.NewGuid().ToString(), "", CreditDebitIndicatorStaticType.Debit, TransactionStatusStaticType.Booked, DateTime.Now,
                DateTime.Now, "Пополнение счета", "г. Калуга", new TransactionComplexTypeAmount("564000", "RUB"), new TransactionComplexChargeAmount("0", "RUB"),
                new TransactionComplexCurrencyExchange("RUB", "RUB", "RUB", BaseOneRate.TmpVal2, Guid.NewGuid().ToString(), DateTime.Now,
                    new CurrencyExchangeComplexTypeInstructedAmount("564000", "RUB"))),
            new TransactionComplex(AccountIds[3], Guid.NewGuid().ToString(), "", CreditDebitIndicatorStaticType.Debit, TransactionStatusStaticType.Booked, DateTime.Now,
                DateTime.Now, "Пополнение счета", "г. Калуга", new TransactionComplexTypeAmount("169000", "RUB"), new TransactionComplexChargeAmount("0", "RUB"),
                new TransactionComplexCurrencyExchange("RUB", "RUB", "RUB", BaseOneRate.TmpVal2, Guid.NewGuid().ToString(), DateTime.Now,
                    new CurrencyExchangeComplexTypeInstructedAmount("169000", "RUB"))),
            new TransactionComplex(AccountIds[3], Guid.NewGuid().ToString(), "", CreditDebitIndicatorStaticType.Debit, TransactionStatusStaticType.Booked, DateTime.Now,
                DateTime.Now, "Пополнение счета", "г. Калуга", new TransactionComplexTypeAmount("203470", "RUB"), new TransactionComplexChargeAmount("0", "RUB"),
                new TransactionComplexCurrencyExchange("RUB", "RUB", "RUB", BaseOneRate.TmpVal2, Guid.NewGuid().ToString(), DateTime.Now,
                    new CurrencyExchangeComplexTypeInstructedAmount("203470", "RUB"))),
            new TransactionComplex(AccountIds[3], Guid.NewGuid().ToString(), "", CreditDebitIndicatorStaticType.Debit, TransactionStatusStaticType.Booked, DateTime.Now,
                DateTime.Now, "Пополнение счета", "г. Калуга", new TransactionComplexTypeAmount("10020", "RUB"), new TransactionComplexChargeAmount("0", "RUB"),
                new TransactionComplexCurrencyExchange("RUB", "RUB", "RUB", BaseOneRate.TmpVal2, Guid.NewGuid().ToString(), DateTime.Now,
                    new CurrencyExchangeComplexTypeInstructedAmount("10020", "RUB"))),
            
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
        return mock;
    }
}