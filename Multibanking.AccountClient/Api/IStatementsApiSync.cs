using System;
using Multibanking.AccountClient.Client;
using Multibanking.AccountClient.Model;

namespace Multibanking.AccountClient.Api;

/// <summary>
///     Represents a collection of functions to interact with the API endpoints
/// </summary>
public interface IStatementsApiSync : IApiAccessor
{
    #region Synchronous Operations

    /// <summary>
    ///     Получения выписки по идентификатору счета и идентификатору выписки
    /// </summary>
    /// <remarks>
    ///     ППУ предоставляет конечную точку СПИУ для получения выписки по идентификатору счета и идентификатору выписки.
    /// </remarks>
    /// <exception cref="Multibanking.AccountClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="accountId">Идентификатор счета</param>
    /// <param name="statementId">Идентификатор выписки</param>
    /// <param name="page">Номер страницы (optional, default to 0)</param>
    /// <param name="fromBookingDateTime">Дата и время начала фильтрации списка транзакций. (optional)</param>
    /// <param name="toBookingDateTime">Дата и время окончания фильтрации списка транзакций. (optional)</param>
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
    /// <returns>StatementResponse</returns>
    StatementResponse GetAccountsaccountIdStatementsStatementId(string accountId, string statementId, int? page = default, DateTime? fromBookingDateTime = default,
        DateTime? toBookingDateTime = default, string xFapiAuthDate = default, string xFapiCustomerIpAddress = default, string xFapiInteractionId = default,
        string xCustomerUserAgent = default, int operationIndex = 0);

    /// <summary>
    ///     Получения выписки по идентификатору счета и идентификатору выписки
    /// </summary>
    /// <remarks>
    ///     ППУ предоставляет конечную точку СПИУ для получения выписки по идентификатору счета и идентификатору выписки.
    /// </remarks>
    /// <exception cref="Multibanking.AccountClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="accountId">Идентификатор счета</param>
    /// <param name="statementId">Идентификатор выписки</param>
    /// <param name="page">Номер страницы (optional, default to 0)</param>
    /// <param name="fromBookingDateTime">Дата и время начала фильтрации списка транзакций. (optional)</param>
    /// <param name="toBookingDateTime">Дата и время окончания фильтрации списка транзакций. (optional)</param>
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
    /// <returns>ApiResponse of StatementResponse</returns>
    ApiResponse<StatementResponse> GetAccountsaccountIdStatementsStatementIdWithHttpInfo(string accountId, string statementId, int? page = default,
        DateTime? fromBookingDateTime = default, DateTime? toBookingDateTime = default, string xFapiAuthDate = default, string xFapiCustomerIpAddress = default,
        string xFapiInteractionId = default, string xCustomerUserAgent = default, int operationIndex = 0);

    /// <summary>
    ///     Выписки по всем авторизованным счетам
    /// </summary>
    /// <remarks>
    ///     ППУ предоставляет конечную точку СПИУ для получения выписок по всем авторизованным Пользователем счетам.
    /// </remarks>
    /// <exception cref="Multibanking.AccountClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="page">Номер страницы (optional, default to 0)</param>
    /// <param name="fromBookingDateTime">Дата и время начала фильтрации списка транзакций. (optional)</param>
    /// <param name="toBookingDateTime">Дата и время окончания фильтрации списка транзакций. (optional)</param>
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
    /// <returns>StatementResponse</returns>
    StatementResponse GetStatements(int? page = default, DateTime? fromBookingDateTime = default, DateTime? toBookingDateTime = default, string xFapiAuthDate = default,
        string xFapiCustomerIpAddress = default, string xFapiInteractionId = default, string xCustomerUserAgent = default, int operationIndex = 0);

    /// <summary>
    ///     Выписки по всем авторизованным счетам
    /// </summary>
    /// <remarks>
    ///     ППУ предоставляет конечную точку СПИУ для получения выписок по всем авторизованным Пользователем счетам.
    /// </remarks>
    /// <exception cref="Multibanking.AccountClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="page">Номер страницы (optional, default to 0)</param>
    /// <param name="fromBookingDateTime">Дата и время начала фильтрации списка транзакций. (optional)</param>
    /// <param name="toBookingDateTime">Дата и время окончания фильтрации списка транзакций. (optional)</param>
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
    /// <returns>ApiResponse of StatementResponse</returns>
    ApiResponse<StatementResponse> GetStatementsWithHttpInfo(int? page = default, DateTime? fromBookingDateTime = default, DateTime? toBookingDateTime = default,
        string xFapiAuthDate = default, string xFapiCustomerIpAddress = default, string xFapiInteractionId = default, string xCustomerUserAgent = default, int operationIndex = 0);

    /// <summary>
    ///     Получения идентификатора выписки statementId по идентификатору счета accountId
    /// </summary>
    /// <remarks>
    ///     ППУ предоставляет конечную точку СПИУ для получения идентификатора выписки statementId по идентификатору счета accountId, который предоставляется при вызове конечной точки GET
    ///     /accounts
    /// </remarks>
    /// <exception cref="Multibanking.AccountClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="accountId">Идентификатор счета</param>
    /// <param name="xIdempotencyKey">
    ///     Не стандартный HTTP заголовок. Уникальный идентификатор запроса для поддержки идемпотентности. Обязательно для запросов POST к конечным точкам
    ///     идемпотентного ресурса. Для других запросов не указывается.
    /// </param>
    /// <param name="statementInitRequest"></param>
    /// <param name="xCustomerUserAgent">
    ///     В заголовке указывается тип устройства (user-agent), который использует Пользователь. Сторонний Поставщик может заполнить это поле значением типа
    ///     устройства (user-agent), указанным Пользователем. Если Пользователь использует мобильное приложение Стороннего Поставщика, Сторонний Поставщик проверяет, что строка типа
    ///     устройства (user-agent) отличается от строки типа устройства (user-agent) на основе браузера. (optional)
    /// </param>
    /// <param name="xFapiAuthDate">
    ///     Время последнего входа Пользователя в систему с TPP. Значение предоставляется в виде HTTP-date, как в разделе 7.1.1.1 [RFC7231]. Например,
    ///     x-fapi-auth-date: Mon, 26 Aug 2019 12:23:11 GMT (optional)
    /// </param>
    /// <param name="xFapiInteractionId">
    ///     RFC4122 UID, используемый в качестве идентификатора корреляции. Если необходимо, то ППУ передает обратно значение идентификатора корреляции в
    ///     заголовке ответа x-fapi-interaction-id. (optional)
    /// </param>
    /// <param name="xFapiCustomerIpAddress">
    ///     IP-адрес Пользователя, если Пользователь в данный момент подключен к Стороннему Поставщику (залогинен в приложении Стороннего Поставщика).
    ///     (optional)
    /// </param>
    /// <param name="operationIndex">Index associated with the operation.</param>
    /// <returns>StatementInitResponse</returns>
    StatementInitResponse GetStatementsaccountId(string accountId, string xIdempotencyKey, StatementInitRequest statementInitRequest, string xCustomerUserAgent = default,
        string xFapiAuthDate = default, string xFapiInteractionId = default, string xFapiCustomerIpAddress = default, int operationIndex = 0);

    /// <summary>
    ///     Получения идентификатора выписки statementId по идентификатору счета accountId
    /// </summary>
    /// <remarks>
    ///     ППУ предоставляет конечную точку СПИУ для получения идентификатора выписки statementId по идентификатору счета accountId, который предоставляется при вызове конечной точки GET
    ///     /accounts
    /// </remarks>
    /// <exception cref="Multibanking.AccountClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="accountId">Идентификатор счета</param>
    /// <param name="xIdempotencyKey">
    ///     Не стандартный HTTP заголовок. Уникальный идентификатор запроса для поддержки идемпотентности. Обязательно для запросов POST к конечным точкам
    ///     идемпотентного ресурса. Для других запросов не указывается.
    /// </param>
    /// <param name="statementInitRequest"></param>
    /// <param name="xCustomerUserAgent">
    ///     В заголовке указывается тип устройства (user-agent), который использует Пользователь. Сторонний Поставщик может заполнить это поле значением типа
    ///     устройства (user-agent), указанным Пользователем. Если Пользователь использует мобильное приложение Стороннего Поставщика, Сторонний Поставщик проверяет, что строка типа
    ///     устройства (user-agent) отличается от строки типа устройства (user-agent) на основе браузера. (optional)
    /// </param>
    /// <param name="xFapiAuthDate">
    ///     Время последнего входа Пользователя в систему с TPP. Значение предоставляется в виде HTTP-date, как в разделе 7.1.1.1 [RFC7231]. Например,
    ///     x-fapi-auth-date: Mon, 26 Aug 2019 12:23:11 GMT (optional)
    /// </param>
    /// <param name="xFapiInteractionId">
    ///     RFC4122 UID, используемый в качестве идентификатора корреляции. Если необходимо, то ППУ передает обратно значение идентификатора корреляции в
    ///     заголовке ответа x-fapi-interaction-id. (optional)
    /// </param>
    /// <param name="xFapiCustomerIpAddress">
    ///     IP-адрес Пользователя, если Пользователь в данный момент подключен к Стороннему Поставщику (залогинен в приложении Стороннего Поставщика).
    ///     (optional)
    /// </param>
    /// <param name="operationIndex">Index associated with the operation.</param>
    /// <returns>ApiResponse of StatementInitResponse</returns>
    ApiResponse<StatementInitResponse> GetStatementsaccountIdWithHttpInfo(string accountId, string xIdempotencyKey, StatementInitRequest statementInitRequest,
        string xCustomerUserAgent = default, string xFapiAuthDate = default, string xFapiInteractionId = default, string xFapiCustomerIpAddress = default, int operationIndex = 0);

    #endregion Synchronous Operations
}