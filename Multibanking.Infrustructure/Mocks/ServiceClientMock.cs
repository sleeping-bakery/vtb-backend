using Moq;
using Multibanking.Data.OpenAPIBankClients.ServiceClient;
using Multibanking.ServiceClient.Model;

namespace Multibanking.Infrustructure.Mocks;

public static class ServiceClientMock
{
    public static Mock<IServiceClient> MockServiceClient()
    {
        var mock = new Mock<IServiceClient>();
        mock.Setup(serviceClient => serviceClient.FindOperations(It.IsAny<string>(), It.IsAny<string>(), It.IsAny<string>(), It.IsAny<string>(), It.IsAny<string>(),
                It.IsAny<string>(), It.IsAny<string>(), It.IsAny<string>(), It.IsAny<string>(), It.IsAny<string>(), It.IsAny<string>(), It.IsAny<string>(), It.IsAny<string>(),
                It.IsAny<int>()))
            .Returns(() => new PageDtoRsServiceProviderSearchDtoRs([
                new ServiceProviderSearchDtoRs(Guid.NewGuid().ToString(), Guid.NewGuid().ToString(), Guid.NewGuid().ToString(), ServiceProviderSearchDtoRs.ServiceTypeEnum.CONTRACT,
                    ServiceProviderSearchDtoRs.SubTypeEnum.MOBILEBYPHONE, [], "Оплата мобильных услуг с автоматическим определением номера клиента", "Мобильные услуги",
                    "Услуга \"Оплата мобильных услуг с автоматическим определением номера клиента\" представляет собой сервис, который позволяет пользователям легко и быстро оплачивать счета за мобильную связь, используя автоматическое распознавание их телефонного номера. Это решение упрощает процесс оплаты и экономит время, исключая необходимость ручного ввода номера, тем самым снижая вероятность ошибок.",
                    new PaymentReceiverDtoRs(Generator.GenerateKpp(), Generator.GenerateKpp(), Generator.GenerateAccount(), new BankDtoRs()), [], [], [],
                    new PaymentSettingsSearchDtoRs()),
                new ServiceProviderSearchDtoRs(Guid.NewGuid().ToString(), Guid.NewGuid().ToString(), Guid.NewGuid().ToString(), ServiceProviderSearchDtoRs.ServiceTypeEnum.CONTRACT,
                    ServiceProviderSearchDtoRs.SubTypeEnum.FEDERAL, [], "Оплата федеральных услуг", "Государственные услуги",
                    "Услуга для оплаты федеральных государственных сборов и налогов.",
                    new PaymentReceiverDtoRs(Generator.GenerateKpp(), Generator.GenerateKpp(), Generator.GenerateAccount(), new BankDtoRs()), [], [], [],
                    new PaymentSettingsSearchDtoRs()),

                new ServiceProviderSearchDtoRs(Guid.NewGuid().ToString(), Guid.NewGuid().ToString(), Guid.NewGuid().ToString(), ServiceProviderSearchDtoRs.ServiceTypeEnum.CONTRACT,
                    ServiceProviderSearchDtoRs.SubTypeEnum.BYACCOUNTTOANOTHERBANK, [], "Перевод по счету в другой банк", "Банковские переводы",
                    "Сервис для переводов по банковскому счету в другой банк.",
                    new PaymentReceiverDtoRs(Generator.GenerateKpp(), Generator.GenerateKpp(), Generator.GenerateAccount(), new BankDtoRs()), [], [], [],
                    new PaymentSettingsSearchDtoRs()),

                new ServiceProviderSearchDtoRs(Guid.NewGuid().ToString(), Guid.NewGuid().ToString(), Guid.NewGuid().ToString(), ServiceProviderSearchDtoRs.ServiceTypeEnum.CONTRACT,
                    ServiceProviderSearchDtoRs.SubTypeEnum.BYACCOUNTTOINTERNAL, [], "Внутренний перевод по счету", "Банковские переводы",
                    "Перевод между счетами внутри одного банка для физических и юридических лиц.",
                    new PaymentReceiverDtoRs(Generator.GenerateKpp(), Generator.GenerateKpp(), Generator.GenerateAccount(), new BankDtoRs()), [], [], [],
                    new PaymentSettingsSearchDtoRs()),

                new ServiceProviderSearchDtoRs(Guid.NewGuid().ToString(), Guid.NewGuid().ToString(), Guid.NewGuid().ToString(), ServiceProviderSearchDtoRs.ServiceTypeEnum.GISHCS,
                    ServiceProviderSearchDtoRs.SubTypeEnum.TOANOTHERBANK, [], "Оплата ЖКХ услуг в другой банк", "Коммунальные услуги",
                    "Оплата услуг ЖКХ через банк с возможностью перевода в другие банки.",
                    new PaymentReceiverDtoRs(Generator.GenerateKpp(), Generator.GenerateKpp(), Generator.GenerateAccount(), new BankDtoRs()), [], [], [],
                    new PaymentSettingsSearchDtoRs()),

                new ServiceProviderSearchDtoRs(Guid.NewGuid().ToString(), Guid.NewGuid().ToString(), Guid.NewGuid().ToString(), ServiceProviderSearchDtoRs.ServiceTypeEnum.GISHCS,
                    ServiceProviderSearchDtoRs.SubTypeEnum.TOINTERNAL, [], "Оплата ЖКХ услуг внутри банка", "Коммунальные услуги",
                    "Услуга для оплаты коммунальных услуг с использованием внутренних банковских переводов.",
                    new PaymentReceiverDtoRs(Generator.GenerateKpp(), Generator.GenerateKpp(), Generator.GenerateAccount(), new BankDtoRs()), [], [], [],
                    new PaymentSettingsSearchDtoRs()),

                new ServiceProviderSearchDtoRs(Guid.NewGuid().ToString(), Guid.NewGuid().ToString(), Guid.NewGuid().ToString(), ServiceProviderSearchDtoRs.ServiceTypeEnum.CONTRACT,
                    ServiceProviderSearchDtoRs.SubTypeEnum.TOINTERNAL, [], "Оплата мобильного интернета", "Мобильные услуги",
                    "Сервис для оплаты мобильного интернета с автоматическим определением тарифа.",
                    new PaymentReceiverDtoRs(Generator.GenerateKpp(), Generator.GenerateKpp(), Generator.GenerateAccount(), new BankDtoRs()), [], [], [],
                    new PaymentSettingsSearchDtoRs()),

                new ServiceProviderSearchDtoRs(Guid.NewGuid().ToString(), Guid.NewGuid().ToString(), Guid.NewGuid().ToString(), ServiceProviderSearchDtoRs.ServiceTypeEnum.CONTRACT,
                    ServiceProviderSearchDtoRs.SubTypeEnum.MOBILEBYPHONE, [], "Оплата услуг роуминга", "Мобильные услуги",
                    "Услуга позволяет оплачивать мобильные услуги в международном роуминге.",
                    new PaymentReceiverDtoRs(Generator.GenerateKpp(), Generator.GenerateKpp(), Generator.GenerateAccount(), new BankDtoRs()), [], [], [],
                    new PaymentSettingsSearchDtoRs()),

                new ServiceProviderSearchDtoRs(Guid.NewGuid().ToString(), Guid.NewGuid().ToString(), Guid.NewGuid().ToString(), ServiceProviderSearchDtoRs.ServiceTypeEnum.GISHCS,
                    ServiceProviderSearchDtoRs.SubTypeEnum.FEDERAL, [], "Оплата государственных пошлин", "Государственные услуги",
                    "Услуга для оплаты государственных пошлин, штрафов и сборов.",
                    new PaymentReceiverDtoRs(Generator.GenerateKpp(), Generator.GenerateKpp(), Generator.GenerateAccount(), new BankDtoRs()), [], [], [],
                    new PaymentSettingsSearchDtoRs()),

                new ServiceProviderSearchDtoRs(Guid.NewGuid().ToString(), Guid.NewGuid().ToString(), Guid.NewGuid().ToString(), ServiceProviderSearchDtoRs.ServiceTypeEnum.GISHCS,
                    ServiceProviderSearchDtoRs.SubTypeEnum.BYACCOUNTTOINTERNAL, [], "Перевод ЖКХ внутри банка", "Коммунальные услуги",
                    "Сервис для внутренних переводов на оплату ЖКХ в рамках одного банка.",
                    new PaymentReceiverDtoRs(Generator.GenerateKpp(), Generator.GenerateKpp(), Generator.GenerateAccount(), new BankDtoRs()), [], [], [],
                    new PaymentSettingsSearchDtoRs()),

                new ServiceProviderSearchDtoRs(Guid.NewGuid().ToString(), Guid.NewGuid().ToString(), Guid.NewGuid().ToString(), ServiceProviderSearchDtoRs.ServiceTypeEnum.CONTRACT,
                    ServiceProviderSearchDtoRs.SubTypeEnum.BYACCOUNTTOANOTHERBANK, [], "Перевод по реквизитам в другой банк", "Банковские переводы",
                    "Сервис позволяет перевести деньги на счет в другом банке по реквизитам.",
                    new PaymentReceiverDtoRs(Generator.GenerateKpp(), Generator.GenerateKpp(), Generator.GenerateAccount(), new BankDtoRs()), [], [], [],
                    new PaymentSettingsSearchDtoRs()),

                new ServiceProviderSearchDtoRs(Guid.NewGuid().ToString(), Guid.NewGuid().ToString(), Guid.NewGuid().ToString(), ServiceProviderSearchDtoRs.ServiceTypeEnum.GISHCS,
                    ServiceProviderSearchDtoRs.SubTypeEnum.BYACCOUNTTOANOTHERBANK, [], "Оплата ЖКХ с переводом в другой банк", "Коммунальные услуги",
                    "Оплата коммунальных услуг с возможностью перевода на счет в другом банке.",
                    new PaymentReceiverDtoRs(Generator.GenerateKpp(), Generator.GenerateKpp(), Generator.GenerateAccount(), new BankDtoRs()), [], [], [],
                    new PaymentSettingsSearchDtoRs()),

                new ServiceProviderSearchDtoRs(Guid.NewGuid().ToString(), Guid.NewGuid().ToString(), Guid.NewGuid().ToString(), ServiceProviderSearchDtoRs.ServiceTypeEnum.CONTRACT,
                    ServiceProviderSearchDtoRs.SubTypeEnum.FEDERAL, [], "Оплата налогов", "Налоговые услуги", "Сервис для оплаты налогов и сборов по федеральной системе.",
                    new PaymentReceiverDtoRs(Generator.GenerateKpp(), Generator.GenerateKpp(), Generator.GenerateAccount(), new BankDtoRs()), [], [], [],
                    new PaymentSettingsSearchDtoRs()),

                new ServiceProviderSearchDtoRs(Guid.NewGuid().ToString(), Guid.NewGuid().ToString(), Guid.NewGuid().ToString(), ServiceProviderSearchDtoRs.ServiceTypeEnum.GISHCS,
                    ServiceProviderSearchDtoRs.SubTypeEnum.TOINTERNAL, [], "Оплата ЖКХ внутри банка", "Коммунальные услуги",
                    "Оплата коммунальных услуг без перевода средств на другой банк.",
                    new PaymentReceiverDtoRs(Generator.GenerateKpp(), Generator.GenerateKpp(), Generator.GenerateAccount(), new BankDtoRs()), [], [], [],
                    new PaymentSettingsSearchDtoRs()),

                new ServiceProviderSearchDtoRs(Guid.NewGuid().ToString(), Guid.NewGuid().ToString(), Guid.NewGuid().ToString(), ServiceProviderSearchDtoRs.ServiceTypeEnum.CONTRACT,
                    ServiceProviderSearchDtoRs.SubTypeEnum.TOANOTHERBANK, [], "Перевод на карту другого банка", "Банковские переводы",
                    "Сервис для переводов на карту стороннего банка.",
                    new PaymentReceiverDtoRs(Generator.GenerateKpp(), Generator.GenerateKpp(), Generator.GenerateAccount(), new BankDtoRs()), [], [], [],
                    new PaymentSettingsSearchDtoRs())
            ]));
        return mock;
    }
}