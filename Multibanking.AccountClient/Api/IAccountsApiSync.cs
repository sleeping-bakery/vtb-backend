using Multibanking.AccountClient.Client;
using Multibanking.AccountClient.Model;

namespace Multibanking.AccountClient.Api;

/// <summary>
///     Represents a collection of functions to interact with the API endpoints
/// </summary>
public interface IAccountsApiSync : IApiAccessor
{
    #region Synchronous Operations

    /// <summary>
    ///     Получение списка счетов
    /// </summary>
    /// <remarks>
    ///     СПИУ предоставляется полный список счетов (с идентификаторами accountId), которые были авторизованы пользователем
    ///     на стороне ППУ.
    /// </remarks>
    /// <exception cref="Multibanking.AccountClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="page">Номер страницы (optional, default to 0)</param>
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
    /// <returns>AccountResponse</returns>
    AccountResponse GetAccounts(int? page = default, string xFapiAuthDate = default,
        string xFapiCustomerIpAddress = default, string xFapiInteractionId = default,
        string xCustomerUserAgent = default, int operationIndex = 0);

    /// <summary>
    ///     Получение списка счетов
    /// </summary>
    /// <remarks>
    ///     СПИУ предоставляется полный список счетов (с идентификаторами accountId), которые были авторизованы пользователем
    ///     на стороне ППУ.
    /// </remarks>
    /// <exception cref="Multibanking.AccountClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="page">Номер страницы (optional, default to 0)</param>
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
    /// <returns>ApiResponse of AccountResponse</returns>
    ApiResponse<AccountResponse> GetAccountsWithHttpInfo(int? page = default, string xFapiAuthDate = default,
        string xFapiCustomerIpAddress = default, string xFapiInteractionId = default,
        string xCustomerUserAgent = default, int operationIndex = 0);

    /// <summary>
    ///     Получение детальной информации о счете
    /// </summary>
    /// <remarks>
    ///     СПИУ получает детальную информацию о счете по идентификатору accountId (который был получен при вызове конечной
    ///     точке списка счетов GET /accounts).
    /// </remarks>
    /// <exception cref="Multibanking.AccountClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="accountId">Идентификатор счета</param>
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
    /// <returns>AccountResponse</returns>
    AccountResponse GetAccountsaccountId(string accountId, string xFapiAuthDate = default,
        string xFapiCustomerIpAddress = default, string xFapiInteractionId = default,
        string xCustomerUserAgent = default, int operationIndex = 0);

    /// <summary>
    ///     Получение детальной информации о счете
    /// </summary>
    /// <remarks>
    ///     СПИУ получает детальную информацию о счете по идентификатору accountId (который был получен при вызове конечной
    ///     точке списка счетов GET /accounts).
    /// </remarks>
    /// <exception cref="Multibanking.AccountClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="accountId">Идентификатор счета</param>
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
    /// <returns>ApiResponse of AccountResponse</returns>
    ApiResponse<AccountResponse> GetAccountsaccountIdWithHttpInfo(string accountId, string xFapiAuthDate = default,
        string xFapiCustomerIpAddress = default, string xFapiInteractionId = default,
        string xCustomerUserAgent = default, int operationIndex = 0);

    #endregion Synchronous Operations
}