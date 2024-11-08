using System.Threading;
using System.Threading.Tasks;
using Multibanking.PeriodPaymentClient.Client;
using Multibanking.PeriodPaymentClient.Model;

namespace Multibanking.PeriodPaymentClient.Api;

/// <summary>
///     Represents a collection of functions to interact with the API endpoints
/// </summary>
public interface IVRPPaymentsApiAsync : IApiAccessor
{
    #region Asynchronous Operations

    /// <summary>
    ///     Инициирование платежа
    /// </summary>
    /// <remarks>
    ///     Конечная точка используется для подтверждения инициирования проведения платежа
    /// </remarks>
    /// <exception cref="Multibanking.PeriodPaymentClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="vRPRequest"></param>
    /// <param name="xFapiAuthDate">
    ///     Время последнего входа Пользователя в систему с TPP. Значение предоставляется в виде HTTP-date, как в разделе 7.1.1.1 [RFC7231]. Например,
    ///     x-fapi-auth-date: Mon, 26 Aug 2019 12:23:11 GMT (optional)
    /// </param>
    /// <param name="xFapiCustomerIpAddress">
    ///     IP-адрес Пользователя, если Пользователь в данный момент подключен к Стороннему Поставщику (залогинен в приложении Стороннего Поставщика).
    ///     (optional)
    /// </param>
    /// <param name="xFapiInteractionId">
    ///     RFC4122 UID, используемый в качестве идентификатора корреляции. Если необходимо, то ППИУ передает обратно значение идентификатора корреляции в
    ///     заголовке ответа x-fapi-interaction-id. (optional)
    /// </param>
    /// <param name="xIdempotencyKey">
    ///     Не стандартный HTTP заголовок. Уникальный идентификатор запроса для поддержки идемпотентности. Обязательно для запросов POST к конечным точкам
    ///     идемпотентного ресурса. Для других запросов не указывается. (optional)
    /// </param>
    /// <param name="xJwsSignature">Отделяемая подпись полезной нагрузки в формате JWS (optional)</param>
    /// <param name="xCustomerUserAgent">
    ///     В заголовке указывается тип устройства (user-agent), который использует Пользователь. Сторонний Поставщик может заполнить это поле значением типа
    ///     устройства (user-agent), указанным Пользователем. Если Пользователь использует мобильное приложение Стороннего Поставщика, Сторонний Поставщик проверяет, что строка типа
    ///     устройства (user-agent) отличается от строки типа устройства (user-agent) на основе браузера. (optional)
    /// </param>
    /// <param name="operationIndex">Index associated with the operation.</param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of VRPResponse</returns>
    Task<VRPResponse> CreateVRPAsync(VRPRequest vRPRequest, string xFapiAuthDate = default, string xFapiCustomerIpAddress = default, string xFapiInteractionId = default,
        string xIdempotencyKey = default, string xJwsSignature = default, string xCustomerUserAgent = default, int operationIndex = 0,
        CancellationToken cancellationToken = default);

    /// <summary>
    ///     Инициирование платежа
    /// </summary>
    /// <remarks>
    ///     Конечная точка используется для подтверждения инициирования проведения платежа
    /// </remarks>
    /// <exception cref="Multibanking.PeriodPaymentClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="vRPRequest"></param>
    /// <param name="xFapiAuthDate">
    ///     Время последнего входа Пользователя в систему с TPP. Значение предоставляется в виде HTTP-date, как в разделе 7.1.1.1 [RFC7231]. Например,
    ///     x-fapi-auth-date: Mon, 26 Aug 2019 12:23:11 GMT (optional)
    /// </param>
    /// <param name="xFapiCustomerIpAddress">
    ///     IP-адрес Пользователя, если Пользователь в данный момент подключен к Стороннему Поставщику (залогинен в приложении Стороннего Поставщика).
    ///     (optional)
    /// </param>
    /// <param name="xFapiInteractionId">
    ///     RFC4122 UID, используемый в качестве идентификатора корреляции. Если необходимо, то ППИУ передает обратно значение идентификатора корреляции в
    ///     заголовке ответа x-fapi-interaction-id. (optional)
    /// </param>
    /// <param name="xIdempotencyKey">
    ///     Не стандартный HTTP заголовок. Уникальный идентификатор запроса для поддержки идемпотентности. Обязательно для запросов POST к конечным точкам
    ///     идемпотентного ресурса. Для других запросов не указывается. (optional)
    /// </param>
    /// <param name="xJwsSignature">Отделяемая подпись полезной нагрузки в формате JWS (optional)</param>
    /// <param name="xCustomerUserAgent">
    ///     В заголовке указывается тип устройства (user-agent), который использует Пользователь. Сторонний Поставщик может заполнить это поле значением типа
    ///     устройства (user-agent), указанным Пользователем. Если Пользователь использует мобильное приложение Стороннего Поставщика, Сторонний Поставщик проверяет, что строка типа
    ///     устройства (user-agent) отличается от строки типа устройства (user-agent) на основе браузера. (optional)
    /// </param>
    /// <param name="operationIndex">Index associated with the operation.</param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ApiResponse (VRPResponse)</returns>
    Task<ApiResponse<VRPResponse>> CreateVRPWithHttpInfoAsync(VRPRequest vRPRequest, string xFapiAuthDate = default, string xFapiCustomerIpAddress = default,
        string xFapiInteractionId = default, string xIdempotencyKey = default, string xJwsSignature = default, string xCustomerUserAgent = default, int operationIndex = 0,
        CancellationToken cancellationToken = default);

    /// <summary>
    ///     Создание Подтверждения наличия необходимого количества средств
    /// </summary>
    /// <remarks>
    ///     Запрос наличия необходимого количества средств на счете Плательщика, который связан с Согласием на инициирование
    /// </remarks>
    /// <exception cref="Multibanking.PeriodPaymentClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="consentId">Идентификатор ресурса согласия</param>
    /// <param name="vRPFundsConfirmationRequest">Запрос создания ресурса подтверждения наличия средств</param>
    /// <param name="xFapiAuthDate">
    ///     Время последнего входа Пользователя в систему с TPP. Значение предоставляется в виде HTTP-date, как в разделе 7.1.1.1 [RFC7231]. Например,
    ///     x-fapi-auth-date: Mon, 26 Aug 2019 12:23:11 GMT (optional)
    /// </param>
    /// <param name="xFapiCustomerIpAddress">
    ///     IP-адрес Пользователя, если Пользователь в данный момент подключен к Стороннему Поставщику (залогинен в приложении Стороннего Поставщика).
    ///     (optional)
    /// </param>
    /// <param name="xFapiInteractionId">
    ///     RFC4122 UID, используемый в качестве идентификатора корреляции. Если необходимо, то ППИУ передает обратно значение идентификатора корреляции в
    ///     заголовке ответа x-fapi-interaction-id. (optional)
    /// </param>
    /// <param name="xJwsSignature">Отделяемая подпись полезной нагрузки в формате JWS (optional)</param>
    /// <param name="xCustomerUserAgent">
    ///     В заголовке указывается тип устройства (user-agent), который использует Пользователь. Сторонний Поставщик может заполнить это поле значением типа
    ///     устройства (user-agent), указанным Пользователем. Если Пользователь использует мобильное приложение Стороннего Поставщика, Сторонний Поставщик проверяет, что строка типа
    ///     устройства (user-agent) отличается от строки типа устройства (user-agent) на основе браузера. (optional)
    /// </param>
    /// <param name="operationIndex">Index associated with the operation.</param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of VRPFundsConfirmationResponse</returns>
    Task<VRPFundsConfirmationResponse> CreateVRPConsentConsentIdFundsConfirmationsAsync(string consentId, VRPFundsConfirmationRequest vRPFundsConfirmationRequest,
        string xFapiAuthDate = default, string xFapiCustomerIpAddress = default, string xFapiInteractionId = default, string xJwsSignature = default,
        string xCustomerUserAgent = default, int operationIndex = 0, CancellationToken cancellationToken = default);

    /// <summary>
    ///     Создание Подтверждения наличия необходимого количества средств
    /// </summary>
    /// <remarks>
    ///     Запрос наличия необходимого количества средств на счете Плательщика, который связан с Согласием на инициирование
    /// </remarks>
    /// <exception cref="Multibanking.PeriodPaymentClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="consentId">Идентификатор ресурса согласия</param>
    /// <param name="vRPFundsConfirmationRequest">Запрос создания ресурса подтверждения наличия средств</param>
    /// <param name="xFapiAuthDate">
    ///     Время последнего входа Пользователя в систему с TPP. Значение предоставляется в виде HTTP-date, как в разделе 7.1.1.1 [RFC7231]. Например,
    ///     x-fapi-auth-date: Mon, 26 Aug 2019 12:23:11 GMT (optional)
    /// </param>
    /// <param name="xFapiCustomerIpAddress">
    ///     IP-адрес Пользователя, если Пользователь в данный момент подключен к Стороннему Поставщику (залогинен в приложении Стороннего Поставщика).
    ///     (optional)
    /// </param>
    /// <param name="xFapiInteractionId">
    ///     RFC4122 UID, используемый в качестве идентификатора корреляции. Если необходимо, то ППИУ передает обратно значение идентификатора корреляции в
    ///     заголовке ответа x-fapi-interaction-id. (optional)
    /// </param>
    /// <param name="xJwsSignature">Отделяемая подпись полезной нагрузки в формате JWS (optional)</param>
    /// <param name="xCustomerUserAgent">
    ///     В заголовке указывается тип устройства (user-agent), который использует Пользователь. Сторонний Поставщик может заполнить это поле значением типа
    ///     устройства (user-agent), указанным Пользователем. Если Пользователь использует мобильное приложение Стороннего Поставщика, Сторонний Поставщик проверяет, что строка типа
    ///     устройства (user-agent) отличается от строки типа устройства (user-agent) на основе браузера. (optional)
    /// </param>
    /// <param name="operationIndex">Index associated with the operation.</param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ApiResponse (VRPFundsConfirmationResponse)</returns>
    Task<ApiResponse<VRPFundsConfirmationResponse>> CreateVRPConsentConsentIdFundsConfirmationsWithHttpInfoAsync(string consentId,
        VRPFundsConfirmationRequest vRPFundsConfirmationRequest, string xFapiAuthDate = default, string xFapiCustomerIpAddress = default, string xFapiInteractionId = default,
        string xJwsSignature = default, string xCustomerUserAgent = default, int operationIndex = 0, CancellationToken cancellationToken = default);

    /// <summary>
    ///     Получение ресурса  перевода денежных средств с указанием его состояния
    /// </summary>
    /// <remarks>
    ///     Получение информацию о состоянии исполнения  перевода денежных средств по его идентификатору
    /// </remarks>
    /// <exception cref="Multibanking.PeriodPaymentClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="vRPId"></param>
    /// <param name="xFapiAuthDate">
    ///     Время последнего входа Пользователя в систему с TPP. Значение предоставляется в виде HTTP-date, как в разделе 7.1.1.1 [RFC7231]. Например,
    ///     x-fapi-auth-date: Mon, 26 Aug 2019 12:23:11 GMT (optional)
    /// </param>
    /// <param name="xFapiCustomerIpAddress">
    ///     IP-адрес Пользователя, если Пользователь в данный момент подключен к Стороннему Поставщику (залогинен в приложении Стороннего Поставщика).
    ///     (optional)
    /// </param>
    /// <param name="xFapiInteractionId">
    ///     RFC4122 UID, используемый в качестве идентификатора корреляции. Если необходимо, то ППИУ передает обратно значение идентификатора корреляции в
    ///     заголовке ответа x-fapi-interaction-id. (optional)
    /// </param>
    /// <param name="xCustomerUserAgent">
    ///     В заголовке указывается тип устройства (user-agent), который использует Пользователь. Сторонний Поставщик может заполнить это поле значением типа
    ///     устройства (user-agent), указанным Пользователем. Если Пользователь использует мобильное приложение Стороннего Поставщика, Сторонний Поставщик проверяет, что строка типа
    ///     устройства (user-agent) отличается от строки типа устройства (user-agent) на основе браузера. (optional)
    /// </param>
    /// <param name="operationIndex">Index associated with the operation.</param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of VRPResponse</returns>
    Task<VRPResponse> GetVRPVRPIdAsync(string vRPId, string xFapiAuthDate = default, string xFapiCustomerIpAddress = default, string xFapiInteractionId = default,
        string xCustomerUserAgent = default, int operationIndex = 0, CancellationToken cancellationToken = default);

    /// <summary>
    ///     Получение ресурса  перевода денежных средств с указанием его состояния
    /// </summary>
    /// <remarks>
    ///     Получение информацию о состоянии исполнения  перевода денежных средств по его идентификатору
    /// </remarks>
    /// <exception cref="Multibanking.PeriodPaymentClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="vRPId"></param>
    /// <param name="xFapiAuthDate">
    ///     Время последнего входа Пользователя в систему с TPP. Значение предоставляется в виде HTTP-date, как в разделе 7.1.1.1 [RFC7231]. Например,
    ///     x-fapi-auth-date: Mon, 26 Aug 2019 12:23:11 GMT (optional)
    /// </param>
    /// <param name="xFapiCustomerIpAddress">
    ///     IP-адрес Пользователя, если Пользователь в данный момент подключен к Стороннему Поставщику (залогинен в приложении Стороннего Поставщика).
    ///     (optional)
    /// </param>
    /// <param name="xFapiInteractionId">
    ///     RFC4122 UID, используемый в качестве идентификатора корреляции. Если необходимо, то ППИУ передает обратно значение идентификатора корреляции в
    ///     заголовке ответа x-fapi-interaction-id. (optional)
    /// </param>
    /// <param name="xCustomerUserAgent">
    ///     В заголовке указывается тип устройства (user-agent), который использует Пользователь. Сторонний Поставщик может заполнить это поле значением типа
    ///     устройства (user-agent), указанным Пользователем. Если Пользователь использует мобильное приложение Стороннего Поставщика, Сторонний Поставщик проверяет, что строка типа
    ///     устройства (user-agent) отличается от строки типа устройства (user-agent) на основе браузера. (optional)
    /// </param>
    /// <param name="operationIndex">Index associated with the operation.</param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ApiResponse (VRPResponse)</returns>
    Task<ApiResponse<VRPResponse>> GetVRPVRPIdWithHttpInfoAsync(string vRPId, string xFapiAuthDate = default, string xFapiCustomerIpAddress = default,
        string xFapiInteractionId = default, string xCustomerUserAgent = default, int operationIndex = 0, CancellationToken cancellationToken = default);

    #endregion Asynchronous Operations
}