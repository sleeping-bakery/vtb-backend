using System.Threading;
using System.Threading.Tasks;
using Multibanking.AccountClient.Client;
using Multibanking.AccountClient.Model;

namespace Multibanking.AccountClient.Api;

/// <summary>
///     Represents a collection of functions to interact with the API endpoints
/// </summary>
public interface IAccountConsentsApiAsync : IApiAccessor
{
    #region Asynchronous Operations

    /// <summary>
    ///     Создание ресурса согласия на доступ к счету.
    /// </summary>
    /// <remarks>
    ///     Запрос создает ресурс согласия account-consent на доступ к счету и возвращает consentId, которая идентифицирует
    ///     созданный ресурс согласия.
    /// </remarks>
    /// <exception cref="Multibanking.AccountClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="consent">Запрос на создание ресурса согласия account-consent</param>
    /// <param name="xCustomerUserAgent">
    ///     В заголовке указывается тип устройства (user-agent), который использует Пользователь.
    ///     Сторонний Поставщик может заполнить это поле значением типа устройства (user-agent), указанным Пользователем. Если
    ///     Пользователь использует мобильное приложение Стороннего Поставщика, Сторонний Поставщик проверяет, что строка типа
    ///     устройства (user-agent) отличается от строки типа устройства (user-agent) на основе браузера. (optional)
    /// </param>
    /// <param name="xFapiAuthDate">
    ///     Время последнего входа Пользователя в систему с TPP. Значение предоставляется в виде
    ///     HTTP-date, как в разделе 7.1.1.1 [RFC7231]. Например, x-fapi-auth-date: Mon, 26 Aug 2019 12:23:11 GMT (optional)
    /// </param>
    /// <param name="xFapiInteractionId">
    ///     RFC4122 UID, используемый в качестве идентификатора корреляции. Если необходимо, то
    ///     ППУ передает обратно значение идентификатора корреляции в заголовке ответа x-fapi-interaction-id. (optional)
    /// </param>
    /// <param name="xFapiCustomerIpAddress">
    ///     IP-адрес Пользователя, если Пользователь в данный момент подключен к Стороннему
    ///     Поставщику (залогинен в приложении Стороннего Поставщика). (optional)
    /// </param>
    /// <param name="xIdempotencyKey">
    ///     Не стандартный HTTP заголовок. Уникальный идентификатор запроса для поддержки
    ///     идемпотентности. Обязательно для запросов POST к конечным точкам идемпотентного ресурса. Для других запросов не
    ///     указывается. (optional)
    /// </param>
    /// <param name="operationIndex">Index associated with the operation.</param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ConsentResponse</returns>
    Task<ConsentResponse> CreateAccountAccessConsentsAsync(Consent consent,
        string xCustomerUserAgent = default, string xFapiAuthDate = default, string xFapiInteractionId = default,
        string xFapiCustomerIpAddress = default, string xIdempotencyKey = default, int operationIndex = 0,
        CancellationToken cancellationToken = default);

    /// <summary>
    ///     Создание ресурса согласия на доступ к счету.
    /// </summary>
    /// <remarks>
    ///     Запрос создает ресурс согласия account-consent на доступ к счету и возвращает consentId, которая идентифицирует
    ///     созданный ресурс согласия.
    /// </remarks>
    /// <exception cref="Multibanking.AccountClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="consent">Запрос на создание ресурса согласия account-consent</param>
    /// <param name="xCustomerUserAgent">
    ///     В заголовке указывается тип устройства (user-agent), который использует Пользователь.
    ///     Сторонний Поставщик может заполнить это поле значением типа устройства (user-agent), указанным Пользователем. Если
    ///     Пользователь использует мобильное приложение Стороннего Поставщика, Сторонний Поставщик проверяет, что строка типа
    ///     устройства (user-agent) отличается от строки типа устройства (user-agent) на основе браузера. (optional)
    /// </param>
    /// <param name="xFapiAuthDate">
    ///     Время последнего входа Пользователя в систему с TPP. Значение предоставляется в виде
    ///     HTTP-date, как в разделе 7.1.1.1 [RFC7231]. Например, x-fapi-auth-date: Mon, 26 Aug 2019 12:23:11 GMT (optional)
    /// </param>
    /// <param name="xFapiInteractionId">
    ///     RFC4122 UID, используемый в качестве идентификатора корреляции. Если необходимо, то
    ///     ППУ передает обратно значение идентификатора корреляции в заголовке ответа x-fapi-interaction-id. (optional)
    /// </param>
    /// <param name="xFapiCustomerIpAddress">
    ///     IP-адрес Пользователя, если Пользователь в данный момент подключен к Стороннему
    ///     Поставщику (залогинен в приложении Стороннего Поставщика). (optional)
    /// </param>
    /// <param name="xIdempotencyKey">
    ///     Не стандартный HTTP заголовок. Уникальный идентификатор запроса для поддержки
    ///     идемпотентности. Обязательно для запросов POST к конечным точкам идемпотентного ресурса. Для других запросов не
    ///     указывается. (optional)
    /// </param>
    /// <param name="operationIndex">Index associated with the operation.</param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ApiResponse (ConsentResponse)</returns>
    Task<ApiResponse<ConsentResponse>> CreateAccountAccessConsentsWithHttpInfoAsync(
        Consent consent, string xCustomerUserAgent = default, string xFapiAuthDate = default,
        string xFapiInteractionId = default, string xFapiCustomerIpAddress = default, string xIdempotencyKey = default,
        int operationIndex = 0, CancellationToken cancellationToken = default);

    /// <summary>
    ///     Отзыв согласия на доступ к счету
    /// </summary>
    /// <remarks>
    ///     Если Пользователь отзывает согласие на доступ к данным для СПИУ, СПИУ удаляет ресурс account-consents на стороне
    ///     ППУ.
    /// </remarks>
    /// <exception cref="Multibanking.AccountClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="consentId">Идентификатор ресурса согласия account-consent</param>
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
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of void</returns>
    Task DeleteAccountAccessConsentsConsentIdAsync(string consentId,
        string xFapiAuthDate = default, string xFapiCustomerIpAddress = default, string xFapiInteractionId = default,
        string xCustomerUserAgent = default, int operationIndex = 0,
        CancellationToken cancellationToken = default);

    /// <summary>
    ///     Отзыв согласия на доступ к счету
    /// </summary>
    /// <remarks>
    ///     Если Пользователь отзывает согласие на доступ к данным для СПИУ, СПИУ удаляет ресурс account-consents на стороне
    ///     ППУ.
    /// </remarks>
    /// <exception cref="Multibanking.AccountClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="consentId">Идентификатор ресурса согласия account-consent</param>
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
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ApiResponse</returns>
    Task<ApiResponse<object>> DeleteAccountAccessConsentsConsentIdWithHttpInfoAsync(
        string consentId, string xFapiAuthDate = default, string xFapiCustomerIpAddress = default,
        string xFapiInteractionId = default, string xCustomerUserAgent = default, int operationIndex = 0,
        CancellationToken cancellationToken = default);

    /// <summary>
    ///     Получение ресурса согласия
    /// </summary>
    /// <remarks>
    ///     Получение созданного ресурса согласия на доступ к счету по идентификатору consentId
    /// </remarks>
    /// <exception cref="Multibanking.AccountClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="consentId">Идентификатор ресурса согласия account-consent</param>
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
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ConsentResponse</returns>
    Task<ConsentResponse> GetAccountAccessConsentsConsentIdAsync(string consentId,
        string xFapiAuthDate = default, string xFapiCustomerIpAddress = default, string xFapiInteractionId = default,
        string xCustomerUserAgent = default, int operationIndex = 0,
        CancellationToken cancellationToken = default);

    /// <summary>
    ///     Получение ресурса согласия
    /// </summary>
    /// <remarks>
    ///     Получение созданного ресурса согласия на доступ к счету по идентификатору consentId
    /// </remarks>
    /// <exception cref="Multibanking.AccountClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="consentId">Идентификатор ресурса согласия account-consent</param>
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
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ApiResponse (ConsentResponse)</returns>
    Task<ApiResponse<ConsentResponse>> GetAccountAccessConsentsConsentIdWithHttpInfoAsync(
        string consentId, string xFapiAuthDate = default, string xFapiCustomerIpAddress = default,
        string xFapiInteractionId = default, string xCustomerUserAgent = default, int operationIndex = 0,
        CancellationToken cancellationToken = default);

    /// <summary>
    ///     Поручение на извлечение ресурса согласия
    /// </summary>
    /// <remarks>
    ///     Данный ресурс создается на ресурсном сервере ППУ после авторизации согласия на получение информации о счете
    ///     Пользователем (после авторизации ресурса account-consents). Период действия поручения на извлечение (ресурса
    ///     retrieval-grant) совпадает с периодом действия согласия на получение информации о счете (ресурс account-consents).
    /// </remarks>
    /// <exception cref="Multibanking.AccountClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="consentId">Идентификатор ресурса согласия account-consent</param>
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
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of RetrievalGrantResponse</returns>
    Task<RetrievalGrantResponse> GetAccountAccessRetrievalGrantAsync(string consentId,
        string xFapiAuthDate = default, string xFapiCustomerIpAddress = default, string xFapiInteractionId = default,
        string xCustomerUserAgent = default, int operationIndex = 0,
        CancellationToken cancellationToken = default);

    /// <summary>
    ///     Поручение на извлечение ресурса согласия
    /// </summary>
    /// <remarks>
    ///     Данный ресурс создается на ресурсном сервере ППУ после авторизации согласия на получение информации о счете
    ///     Пользователем (после авторизации ресурса account-consents). Период действия поручения на извлечение (ресурса
    ///     retrieval-grant) совпадает с периодом действия согласия на получение информации о счете (ресурс account-consents).
    /// </remarks>
    /// <exception cref="Multibanking.AccountClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="consentId">Идентификатор ресурса согласия account-consent</param>
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
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ApiResponse (RetrievalGrantResponse)</returns>
    Task<ApiResponse<RetrievalGrantResponse>> GetAccountAccessRetrievalGrantWithHttpInfoAsync(
        string consentId, string xFapiAuthDate = default, string xFapiCustomerIpAddress = default,
        string xFapiInteractionId = default, string xCustomerUserAgent = default, int operationIndex = 0,
        CancellationToken cancellationToken = default);

    #endregion Asynchronous Operations
}