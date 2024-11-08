using Multibanking.PeriodPaymentClient.Client;
using Multibanking.PeriodPaymentClient.Model;

namespace Multibanking.PeriodPaymentClient.Api;

/// <summary>
///     Represents a collection of functions to interact with the API endpoints
/// </summary>
public interface IVRPConsentApiSync : IApiAccessor
{
    #region Synchronous Operations

    /// <summary>
    ///     Создание Согласия на инициирование
    /// </summary>
    /// <remarks>
    ///     Создание и установка Согласия на инициирование с требуемыми параметрами контроля и повторяющимися реквизитами платежного распоряжения
    /// </remarks>
    /// <exception cref="Multibanking.PeriodPaymentClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="vRPConsentRequest">Запрос создания ресурса Согласия на инициирование</param>
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
    /// <returns>VRPConsentResponse</returns>
    VRPConsentResponse CreateVRPConsent(VRPConsentRequest vRPConsentRequest, string xFapiAuthDate = default, string xFapiCustomerIpAddress = default,
        string xFapiInteractionId = default, string xIdempotencyKey = default, string xJwsSignature = default, string xCustomerUserAgent = default, int operationIndex = 0);

    /// <summary>
    ///     Создание Согласия на инициирование
    /// </summary>
    /// <remarks>
    ///     Создание и установка Согласия на инициирование с требуемыми параметрами контроля и повторяющимися реквизитами платежного распоряжения
    /// </remarks>
    /// <exception cref="Multibanking.PeriodPaymentClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="vRPConsentRequest">Запрос создания ресурса Согласия на инициирование</param>
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
    /// <returns>ApiResponse of VRPConsentResponse</returns>
    ApiResponse<VRPConsentResponse> CreateVRPConsentWithHttpInfo(VRPConsentRequest vRPConsentRequest, string xFapiAuthDate = default, string xFapiCustomerIpAddress = default,
        string xFapiInteractionId = default, string xIdempotencyKey = default, string xJwsSignature = default, string xCustomerUserAgent = default, int operationIndex = 0);

    /// <summary>
    ///     Отзыв Согласия на инициирование
    /// </summary>
    /// <remarks>
    ///     Конечная точка позволяет СППУ удалять ресурс Согласия на инициирование
    /// </remarks>
    /// <exception cref="Multibanking.PeriodPaymentClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="consentId">Идентификатор ресурса согласия</param>
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
    /// <returns></returns>
    void DeleteVRPConsentsConsentId(string consentId, string xFapiAuthDate = default, string xFapiCustomerIpAddress = default, string xFapiInteractionId = default,
        string xCustomerUserAgent = default, int operationIndex = 0);

    /// <summary>
    ///     Отзыв Согласия на инициирование
    /// </summary>
    /// <remarks>
    ///     Конечная точка позволяет СППУ удалять ресурс Согласия на инициирование
    /// </remarks>
    /// <exception cref="Multibanking.PeriodPaymentClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="consentId">Идентификатор ресурса согласия</param>
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
    /// <returns>ApiResponse of Object(void)</returns>
    ApiResponse<object> DeleteVRPConsentsConsentIdWithHttpInfo(string consentId, string xFapiAuthDate = default, string xFapiCustomerIpAddress = default,
        string xFapiInteractionId = default, string xCustomerUserAgent = default, int operationIndex = 0);

    /// <summary>
    ///     Получение ресурса Согласия на инициирование
    /// </summary>
    /// <remarks>
    ///     Получение информации о состоянии Согласия на инициирование по его идентификатору
    /// </remarks>
    /// <exception cref="Multibanking.PeriodPaymentClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="consentId">Идентификатор ресурса согласия</param>
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
    /// <returns>VRPConsentResponse</returns>
    VRPConsentResponse GetVRPConsentConsentId(string consentId, string xFapiAuthDate = default, string xFapiCustomerIpAddress = default, string xFapiInteractionId = default,
        string xCustomerUserAgent = default, int operationIndex = 0);

    /// <summary>
    ///     Получение ресурса Согласия на инициирование
    /// </summary>
    /// <remarks>
    ///     Получение информации о состоянии Согласия на инициирование по его идентификатору
    /// </remarks>
    /// <exception cref="Multibanking.PeriodPaymentClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="consentId">Идентификатор ресурса согласия</param>
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
    /// <returns>ApiResponse of VRPConsentResponse</returns>
    ApiResponse<VRPConsentResponse> GetVRPConsentConsentIdWithHttpInfo(string consentId, string xFapiAuthDate = default, string xFapiCustomerIpAddress = default,
        string xFapiInteractionId = default, string xCustomerUserAgent = default, int operationIndex = 0);

    #endregion Synchronous Operations
}