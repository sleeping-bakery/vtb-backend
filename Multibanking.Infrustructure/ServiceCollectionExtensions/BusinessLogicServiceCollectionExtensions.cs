using Microsoft.Extensions.DependencyInjection;
using Multibanking.Services.Account;
using Multibanking.Services.Account.Implementations;
using Multibanking.Services.Account.MappingProfiles;
using Multibanking.Services.Cards;
using Multibanking.Services.Cards.MappingProfiles;
using Multibanking.Services.PeriodPayments;
using Multibanking.Services.PeriodPayments.Implementations;
using Multibanking.Services.PeriodPayments.MappingProfiles;
using Multibanking.Services.Services;
using Multibanking.Services.UnidentifiedPayments;
using Multibanking.Services.UnidentifiedPayments.MappingProfiles;
using Multibanking.Services.UniversalPayments;
using Multibanking.Services.User;
using Multibanking.Services.User.Implementations;
using Multibanking.Services.User.MappingProfiles;
using Multibanking.Services.User.Middlewares;

namespace Multibanking.Infrustructure.ServiceCollectionExtensions;

public static class BusinessLogicServiceCollectionExtensions
{
    public static IServiceCollection AddBusinessLogic(this IServiceCollection serviceCollection)
    {
        return serviceCollection
            .AddMapping()
            .AddServices()
            .AddMiddlewares();
    }

    private static IServiceCollection AddMapping(this IServiceCollection serviceCollection)
    {
        return serviceCollection.AddAutoMapper(
            [typeof(UserMapperProfile), typeof(AccountConsentMapperProfile), typeof(CardMapperProfile), typeof(UnidentifiedPaymentMapperProfile), typeof(PeriodPaymentMapperProfile)]);
    }

    private static IServiceCollection AddServices(this IServiceCollection serviceCollection)
    {
        return serviceCollection
            .AddScoped<IUserService, UserService>()
            .AddScoped<IUserContextService, UserContextService>()
            .AddScoped<IAccountConsentsService, AccountConsentsService>()
            .AddScoped<IAccountService, AccountService>()
            .AddScoped<IBalanceService, BalanceService>()
            .AddScoped<ITransactionService, TransactionService>()
            .AddScoped<IStatementService, StatementService>()
            .AddScoped<ICardService, CardService>()
            .AddScoped<IUnidentifiedPaymentService, UnidentifiedPaymentService>()
            .AddScoped<IServiceSupplierService, ServiceSupplierService>()
            .AddScoped<IUniversalPaymentService, UniversalPaymentService>()
            .AddScoped<IPeriodPaymentConsentService, PeriodPaymentConsentService>()
            .AddScoped<IPeriodPaymentService, PeriodPaymentService>();
    }

    private static IServiceCollection AddMiddlewares(this IServiceCollection serviceCollection)
    {
        return serviceCollection.AddTransient<CreateUserMiddleware>();
    }
}