using System.Threading;
using System.Threading.Tasks;
using Multibanking.AccountClient.Client;
using Multibanking.AccountClient.Model;

namespace Multibanking.AccountClient.Api;

/// <summary>
///     Represents a collection of functions to interact with the API endpoints
/// </summary>
public interface IBalancesApiAsync : IApiAccessor
{
    #region Asynchronous Operations

    /// <summary>
    ///     Баланс банковского счета
    /// </summary>
    /// <remarks>
    ///     Конечная точка используется для получения информации о балансе банковского счета с идентификатором accountId.
    /// </remarks>
    /// <exception cref="Multibanking.AccountClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="accountId">Идентификатор счета</param>
    /// <param name="xFapiAuthDate">
    ///     Время последнего входа Пользователя в систему с TPP. Значение предоставляется в виде HTTP-date, как в разделе 7.1.1.1 [RFC7231]. Например,
    ///     x-fapi-auth-date: Mon, 26 Aug 2019 12:23:11 GMT (optional)
    /// </param>
    /// <param name="xFapiCustomerIpAddress">
    ///     IP-адрес Пользователя, если Пользователь в данный момент подключен к Стороннему Поставщику (залогинен в приложении Стороннего Поставщика).
    ///     (optional)
    /// </param>
    /// <param name="xFapiInteractionId">
    ///     RFC4122 UID, используемый в качестве идентификатора корреляции. Если необходимо, то ППУ передает обратно значение идентификатора корреляции в
    ///     заголовке ответа x-fapi-interaction-id. (optional)
    /// </param>
    /// <param name="xCustomerUserAgent">
    ///     В заголовке указывается тип устройства (user-agent), который использует Пользователь. Сторонний Поставщик может заполнить это поле значением типа
    ///     устройства (user-agent), указанным Пользователем. Если Пользователь использует мобильное приложение Стороннего Поставщика, Сторонний Поставщик проверяет, что строка типа
    ///     устройства (user-agent) отличается от строки типа устройства (user-agent) на основе браузера. (optional)
    /// </param>
    /// <param name="operationIndex">Index associated with the operation.</param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of BalanceResponse</returns>
    Task<BalanceResponse> GetAccountsaccountIdBalancesAsync(string accountId, string xFapiAuthDate = default, string xFapiCustomerIpAddress = default,
        string xFapiInteractionId = default, string xCustomerUserAgent = default, int operationIndex = 0, CancellationToken cancellationToken = default);

    /// <summary>
    ///     Баланс банковского счета
    /// </summary>
    /// <remarks>
    ///     Конечная точка используется для получения информации о балансе банковского счета с идентификатором accountId.
    /// </remarks>
    /// <exception cref="Multibanking.AccountClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="accountId">Идентификатор счета</param>
    /// <param name="xFapiAuthDate">
    ///     Время последнего входа Пользователя в систему с TPP. Значение предоставляется в виде HTTP-date, как в разделе 7.1.1.1 [RFC7231]. Например,
    ///     x-fapi-auth-date: Mon, 26 Aug 2019 12:23:11 GMT (optional)
    /// </param>
    /// <param name="xFapiCustomerIpAddress">
    ///     IP-адрес Пользователя, если Пользователь в данный момент подключен к Стороннему Поставщику (залогинен в приложении Стороннего Поставщика).
    ///     (optional)
    /// </param>
    /// <param name="xFapiInteractionId">
    ///     RFC4122 UID, используемый в качестве идентификатора корреляции. Если необходимо, то ППУ передает обратно значение идентификатора корреляции в
    ///     заголовке ответа x-fapi-interaction-id. (optional)
    /// </param>
    /// <param name="xCustomerUserAgent">
    ///     В заголовке указывается тип устройства (user-agent), который использует Пользователь. Сторонний Поставщик может заполнить это поле значением типа
    ///     устройства (user-agent), указанным Пользователем. Если Пользователь использует мобильное приложение Стороннего Поставщика, Сторонний Поставщик проверяет, что строка типа
    ///     устройства (user-agent) отличается от строки типа устройства (user-agent) на основе браузера. (optional)
    /// </param>
    /// <param name="operationIndex">Index associated with the operation.</param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ApiResponse (BalanceResponse)</returns>
    Task<ApiResponse<BalanceResponse>> GetAccountsaccountIdBalancesWithHttpInfoAsync(string accountId, string xFapiAuthDate = default, string xFapiCustomerIpAddress = default,
        string xFapiInteractionId = default, string xCustomerUserAgent = default, int operationIndex = 0, CancellationToken cancellationToken = default);

    /// <summary>
    ///     Баланс банковского счета
    /// </summary>
    /// <remarks>
    ///     Баланс передается по всем банковским счетам, которые пользователь авторизовал с помощью согласия с балансовыми разрешениями (permissions).
    /// </remarks>
    /// <exception cref="Multibanking.AccountClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="page">Номер страницы (optional, default to 0)</param>
    /// <param name="xFapiAuthDate">
    ///     Время последнего входа Пользователя в систему с TPP. Значение предоставляется в виде HTTP-date, как в разделе 7.1.1.1 [RFC7231]. Например,
    ///     x-fapi-auth-date: Mon, 26 Aug 2019 12:23:11 GMT (optional)
    /// </param>
    /// <param name="xFapiCustomerIpAddress">
    ///     IP-адрес Пользователя, если Пользователь в данный момент подключен к Стороннему Поставщику (залогинен в приложении Стороннего Поставщика).
    ///     (optional)
    /// </param>
    /// <param name="xFapiInteractionId">
    ///     RFC4122 UID, используемый в качестве идентификатора корреляции. Если необходимо, то ППУ передает обратно значение идентификатора корреляции в
    ///     заголовке ответа x-fapi-interaction-id. (optional)
    /// </param>
    /// <param name="xCustomerUserAgent">
    ///     В заголовке указывается тип устройства (user-agent), который использует Пользователь. Сторонний Поставщик может заполнить это поле значением типа
    ///     устройства (user-agent), указанным Пользователем. Если Пользователь использует мобильное приложение Стороннего Поставщика, Сторонний Поставщик проверяет, что строка типа
    ///     устройства (user-agent) отличается от строки типа устройства (user-agent) на основе браузера. (optional)
    /// </param>
    /// <param name="operationIndex">Index associated with the operation.</param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of BalanceResponse</returns>
    Task<BalanceResponse> GetBalancesAsync(int? page = default, string xFapiAuthDate = default, string xFapiCustomerIpAddress = default, string xFapiInteractionId = default,
        string xCustomerUserAgent = default, int operationIndex = 0, CancellationToken cancellationToken = default);

    /// <summary>
    ///     Баланс банковского счета
    /// </summary>
    /// <remarks>
    ///     Баланс передается по всем банковским счетам, которые пользователь авторизовал с помощью согласия с балансовыми разрешениями (permissions).
    /// </remarks>
    /// <exception cref="Multibanking.AccountClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="page">Номер страницы (optional, default to 0)</param>
    /// <param name="xFapiAuthDate">
    ///     Время последнего входа Пользователя в систему с TPP. Значение предоставляется в виде HTTP-date, как в разделе 7.1.1.1 [RFC7231]. Например,
    ///     x-fapi-auth-date: Mon, 26 Aug 2019 12:23:11 GMT (optional)
    /// </param>
    /// <param name="xFapiCustomerIpAddress">
    ///     IP-адрес Пользователя, если Пользователь в данный момент подключен к Стороннему Поставщику (залогинен в приложении Стороннего Поставщика).
    ///     (optional)
    /// </param>
    /// <param name="xFapiInteractionId">
    ///     RFC4122 UID, используемый в качестве идентификатора корреляции. Если необходимо, то ППУ передает обратно значение идентификатора корреляции в
    ///     заголовке ответа x-fapi-interaction-id. (optional)
    /// </param>
    /// <param name="xCustomerUserAgent">
    ///     В заголовке указывается тип устройства (user-agent), который использует Пользователь. Сторонний Поставщик может заполнить это поле значением типа
    ///     устройства (user-agent), указанным Пользователем. Если Пользователь использует мобильное приложение Стороннего Поставщика, Сторонний Поставщик проверяет, что строка типа
    ///     устройства (user-agent) отличается от строки типа устройства (user-agent) на основе браузера. (optional)
    /// </param>
    /// <param name="operationIndex">Index associated with the operation.</param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ApiResponse (BalanceResponse)</returns>
    Task<ApiResponse<BalanceResponse>> GetBalancesWithHttpInfoAsync(int? page = default, string xFapiAuthDate = default, string xFapiCustomerIpAddress = default,
        string xFapiInteractionId = default, string xCustomerUserAgent = default, int operationIndex = 0, CancellationToken cancellationToken = default);

    #endregion Asynchronous Operations
}