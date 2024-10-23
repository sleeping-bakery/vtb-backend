using System;
using Multibanking.AccountClient.Client;
using Multibanking.AccountClient.Model;

namespace Multibanking.AccountClient.Api;

/// <summary>
///     Represents a collection of functions to interact with the API endpoints
/// </summary>
public interface ITransactionsApiSync : IApiAccessor
{
    #region Synchronous Operations

    /// <summary>
    ///     Ресурс транзакции с идентификатором accountId
    /// </summary>
    /// <remarks>
    ///     Конечная точка извлекает ресурс транзакции с идентификатором accountId, который получается с помощью вызова
    ///     конечной точки GET /accounts.
    /// </remarks>
    /// <exception cref="Multibanking.AccountClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="accountId">Идентификатор счета</param>
    /// <param name="page">Номер страницы (optional, default to 0)</param>
    /// <param name="fromBookingDateTime">Дата и время начала фильтрации списка транзакций. (optional)</param>
    /// <param name="toBookingDateTime">Дата и время окончания фильтрации списка транзакций. (optional)</param>
    /// <param name="xFapiAuthDate">
    ///     Время последнего входа Пользователя в систему с TPP. Значение предоставляется в виде
    ///     HTTP-date, как в разделе 7.1.1.1 [RFC7231]. Например, x-fapi-auth-date: Mon, 26 Aug 2019 12:23:11 GMT (optional)
    /// </param>
    /// <param name="xFapiCustomerIpAddress">
    ///     IP-адрес Пользователя, если Пользователь в данный момент подключен к Стороннему
    ///     Поставщику (залогинен в приложении Стороннего Поставщика). (optional)
    /// </param>
    /// <param name="xFapiInteractionId">
    ///     RFC4122 UID, используемый в качестве идентификатора корреляции. Если необходимо, то
    ///     ППУ передает обратно значение идентификатора корреляции в заголовке ответа x-fapi-interaction-id. (optional)
    /// </param>
    /// <param name="xCustomerUserAgent">
    ///     В заголовке указывается тип устройства (user-agent), который использует Пользователь.
    ///     Сторонний Поставщик может заполнить это поле значением типа устройства (user-agent), указанным Пользователем. Если
    ///     Пользователь использует мобильное приложение Стороннего Поставщика, Сторонний Поставщик проверяет, что строка типа
    ///     устройства (user-agent) отличается от строки типа устройства (user-agent) на основе браузера. (optional)
    /// </param>
    /// <param name="operationIndex">Index associated with the operation.</param>
    /// <returns>TransactionResponse</returns>
    TransactionResponse GetAccountsaccountIdTransactions(string accountId, int? page = default,
        DateTime? fromBookingDateTime = default, DateTime? toBookingDateTime = default, string xFapiAuthDate = default,
        string xFapiCustomerIpAddress = default, string xFapiInteractionId = default,
        string xCustomerUserAgent = default, int operationIndex = 0);

    /// <summary>
    ///     Ресурс транзакции с идентификатором accountId
    /// </summary>
    /// <remarks>
    ///     Конечная точка извлекает ресурс транзакции с идентификатором accountId, который получается с помощью вызова
    ///     конечной точки GET /accounts.
    /// </remarks>
    /// <exception cref="Multibanking.AccountClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="accountId">Идентификатор счета</param>
    /// <param name="page">Номер страницы (optional, default to 0)</param>
    /// <param name="fromBookingDateTime">Дата и время начала фильтрации списка транзакций. (optional)</param>
    /// <param name="toBookingDateTime">Дата и время окончания фильтрации списка транзакций. (optional)</param>
    /// <param name="xFapiAuthDate">
    ///     Время последнего входа Пользователя в систему с TPP. Значение предоставляется в виде
    ///     HTTP-date, как в разделе 7.1.1.1 [RFC7231]. Например, x-fapi-auth-date: Mon, 26 Aug 2019 12:23:11 GMT (optional)
    /// </param>
    /// <param name="xFapiCustomerIpAddress">
    ///     IP-адрес Пользователя, если Пользователь в данный момент подключен к Стороннему
    ///     Поставщику (залогинен в приложении Стороннего Поставщика). (optional)
    /// </param>
    /// <param name="xFapiInteractionId">
    ///     RFC4122 UID, используемый в качестве идентификатора корреляции. Если необходимо, то
    ///     ППУ передает обратно значение идентификатора корреляции в заголовке ответа x-fapi-interaction-id. (optional)
    /// </param>
    /// <param name="xCustomerUserAgent">
    ///     В заголовке указывается тип устройства (user-agent), который использует Пользователь.
    ///     Сторонний Поставщик может заполнить это поле значением типа устройства (user-agent), указанным Пользователем. Если
    ///     Пользователь использует мобильное приложение Стороннего Поставщика, Сторонний Поставщик проверяет, что строка типа
    ///     устройства (user-agent) отличается от строки типа устройства (user-agent) на основе браузера. (optional)
    /// </param>
    /// <param name="operationIndex">Index associated with the operation.</param>
    /// <returns>ApiResponse of TransactionResponse</returns>
    ApiResponse<TransactionResponse> GetAccountsaccountIdTransactionsWithHttpInfo(string accountId, int? page = default,
        DateTime? fromBookingDateTime = default, DateTime? toBookingDateTime = default, string xFapiAuthDate = default,
        string xFapiCustomerIpAddress = default, string xFapiInteractionId = default,
        string xCustomerUserAgent = default, int operationIndex = 0);

    /// <summary>
    ///     Список транзакций по всем счетам
    /// </summary>
    /// <remarks>
    ///     Конечная точка позволяет получить список транзакций по всем счетам, которые авторизованы пользователем с помощью
    ///     согласия.
    /// </remarks>
    /// <exception cref="Multibanking.AccountClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="page">Номер страницы (optional, default to 0)</param>
    /// <param name="fromBookingDateTime">Дата и время начала фильтрации списка транзакций. (optional)</param>
    /// <param name="toBookingDateTime">Дата и время окончания фильтрации списка транзакций. (optional)</param>
    /// <param name="xFapiAuthDate">
    ///     Время последнего входа Пользователя в систему с TPP. Значение предоставляется в виде
    ///     HTTP-date, как в разделе 7.1.1.1 [RFC7231]. Например, x-fapi-auth-date: Mon, 26 Aug 2019 12:23:11 GMT (optional)
    /// </param>
    /// <param name="xFapiCustomerIpAddress">
    ///     IP-адрес Пользователя, если Пользователь в данный момент подключен к Стороннему
    ///     Поставщику (залогинен в приложении Стороннего Поставщика). (optional)
    /// </param>
    /// <param name="xFapiInteractionId">
    ///     RFC4122 UID, используемый в качестве идентификатора корреляции. Если необходимо, то
    ///     ППУ передает обратно значение идентификатора корреляции в заголовке ответа x-fapi-interaction-id. (optional)
    /// </param>
    /// <param name="xCustomerUserAgent">
    ///     В заголовке указывается тип устройства (user-agent), который использует Пользователь.
    ///     Сторонний Поставщик может заполнить это поле значением типа устройства (user-agent), указанным Пользователем. Если
    ///     Пользователь использует мобильное приложение Стороннего Поставщика, Сторонний Поставщик проверяет, что строка типа
    ///     устройства (user-agent) отличается от строки типа устройства (user-agent) на основе браузера. (optional)
    /// </param>
    /// <param name="operationIndex">Index associated with the operation.</param>
    /// <returns>TransactionResponse</returns>
    TransactionResponse GetTransactions(int? page = default, DateTime? fromBookingDateTime = default,
        DateTime? toBookingDateTime = default, string xFapiAuthDate = default, string xFapiCustomerIpAddress = default,
        string xFapiInteractionId = default, string xCustomerUserAgent = default, int operationIndex = 0);

    /// <summary>
    ///     Список транзакций по всем счетам
    /// </summary>
    /// <remarks>
    ///     Конечная точка позволяет получить список транзакций по всем счетам, которые авторизованы пользователем с помощью
    ///     согласия.
    /// </remarks>
    /// <exception cref="Multibanking.AccountClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="page">Номер страницы (optional, default to 0)</param>
    /// <param name="fromBookingDateTime">Дата и время начала фильтрации списка транзакций. (optional)</param>
    /// <param name="toBookingDateTime">Дата и время окончания фильтрации списка транзакций. (optional)</param>
    /// <param name="xFapiAuthDate">
    ///     Время последнего входа Пользователя в систему с TPP. Значение предоставляется в виде
    ///     HTTP-date, как в разделе 7.1.1.1 [RFC7231]. Например, x-fapi-auth-date: Mon, 26 Aug 2019 12:23:11 GMT (optional)
    /// </param>
    /// <param name="xFapiCustomerIpAddress">
    ///     IP-адрес Пользователя, если Пользователь в данный момент подключен к Стороннему
    ///     Поставщику (залогинен в приложении Стороннего Поставщика). (optional)
    /// </param>
    /// <param name="xFapiInteractionId">
    ///     RFC4122 UID, используемый в качестве идентификатора корреляции. Если необходимо, то
    ///     ППУ передает обратно значение идентификатора корреляции в заголовке ответа x-fapi-interaction-id. (optional)
    /// </param>
    /// <param name="xCustomerUserAgent">
    ///     В заголовке указывается тип устройства (user-agent), который использует Пользователь.
    ///     Сторонний Поставщик может заполнить это поле значением типа устройства (user-agent), указанным Пользователем. Если
    ///     Пользователь использует мобильное приложение Стороннего Поставщика, Сторонний Поставщик проверяет, что строка типа
    ///     устройства (user-agent) отличается от строки типа устройства (user-agent) на основе браузера. (optional)
    /// </param>
    /// <param name="operationIndex">Index associated with the operation.</param>
    /// <returns>ApiResponse of TransactionResponse</returns>
    ApiResponse<TransactionResponse> GetTransactionsWithHttpInfo(int? page = default,
        DateTime? fromBookingDateTime = default, DateTime? toBookingDateTime = default, string xFapiAuthDate = default,
        string xFapiCustomerIpAddress = default, string xFapiInteractionId = default,
        string xCustomerUserAgent = default, int operationIndex = 0);

    #endregion Synchronous Operations
}