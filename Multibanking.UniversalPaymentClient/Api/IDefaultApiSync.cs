using System.Collections.Generic;
using Multibanking.UniversalPaymentClient.Client;
using Multibanking.UniversalPaymentClient.Model;

namespace Multibanking.UniversalPaymentClient.Api;

/// <summary>
///     Represents a collection of functions to interact with the API endpoints
/// </summary>
public interface IDefaultApiSync : IApiAccessor
{
    #region Synchronous Operations

    /// <summary>
    ///     Запрос на оплату универсального платежа
    /// </summary>
    /// <exception cref="Multibanking.UniversalPaymentClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="X_UNC">Идентификатор клиента УНК</param>
    /// <param name="X_MDM_ID">Идентификатор клиента mdm id</param>
    /// <param name="X_USER_SESSION_ID">Идентификатор сессии клиента</param>
    /// <param name="X_PARTNER_ID">Идентификатор партнера ВТБ</param>
    /// <param name="X_LOGIN_MODE">Режим входа в ВТБ</param>
    /// <param name="X_ROLES">Роли клиента</param>
    /// <param name="X_CHANNEL">Идентификатор канала клиента</param>
    /// <param name="confirmPaymentDtoRq"></param>
    /// <param name="X_TB_ID">Идентификатор клиента TB id (optional)</param>
    /// <param name="operationIndex">Index associated with the operation.</param>
    /// <returns>ConfirmPaymentDtoRs</returns>
    ConfirmPaymentDtoRs Confirm(string X_UNC, string X_MDM_ID, string X_USER_SESSION_ID, string X_PARTNER_ID, string X_LOGIN_MODE, List<string> X_ROLES, string X_CHANNEL,
        ConfirmPaymentDtoRq confirmPaymentDtoRq, string X_TB_ID = default, int operationIndex = 0);

    /// <summary>
    ///     Запрос на оплату универсального платежа
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <exception cref="Multibanking.UniversalPaymentClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="X_UNC">Идентификатор клиента УНК</param>
    /// <param name="X_MDM_ID">Идентификатор клиента mdm id</param>
    /// <param name="X_USER_SESSION_ID">Идентификатор сессии клиента</param>
    /// <param name="X_PARTNER_ID">Идентификатор партнера ВТБ</param>
    /// <param name="X_LOGIN_MODE">Режим входа в ВТБ</param>
    /// <param name="X_ROLES">Роли клиента</param>
    /// <param name="X_CHANNEL">Идентификатор канала клиента</param>
    /// <param name="confirmPaymentDtoRq"></param>
    /// <param name="X_TB_ID">Идентификатор клиента TB id (optional)</param>
    /// <param name="operationIndex">Index associated with the operation.</param>
    /// <returns>ApiResponse of ConfirmPaymentDtoRs</returns>
    ApiResponse<ConfirmPaymentDtoRs> ConfirmWithHttpInfo(string X_UNC, string X_MDM_ID, string X_USER_SESSION_ID, string X_PARTNER_ID, string X_LOGIN_MODE, List<string> X_ROLES,
        string X_CHANNEL, ConfirmPaymentDtoRq confirmPaymentDtoRq, string X_TB_ID = default, int operationIndex = 0);

    /// <summary>
    ///     Получение списка продуктов, доступных для оплаты универсальных платежей
    /// </summary>
    /// <exception cref="Multibanking.UniversalPaymentClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="X_UNC">Идентификатор клиента УНК</param>
    /// <param name="X_MDM_ID">Идентификатор клиента mdm id</param>
    /// <param name="X_PARTNER_ID">Идентификатор партнера ВТБ</param>
    /// <param name="X_LOGIN_MODE">Режим входа в ВТБ</param>
    /// <param name="X_ROLES">Роли клиента</param>
    /// <param name="X_CHANNEL">Идентификатор канала клиента</param>
    /// <param name="minBalance">Баланс который должен  быть в наличии у продуктов клиента (optional, default to 0M)</param>
    /// <param name="operationIndex">Index associated with the operation.</param>
    /// <returns>ClientProductsDtoRs</returns>
    ClientProductsDtoRs GetClientProducts(string X_UNC, string X_MDM_ID, string X_PARTNER_ID, string X_LOGIN_MODE, List<string> X_ROLES, string X_CHANNEL,
        decimal? minBalance = default, int operationIndex = 0);

    /// <summary>
    ///     Получение списка продуктов, доступных для оплаты универсальных платежей
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <exception cref="Multibanking.UniversalPaymentClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="X_UNC">Идентификатор клиента УНК</param>
    /// <param name="X_MDM_ID">Идентификатор клиента mdm id</param>
    /// <param name="X_PARTNER_ID">Идентификатор партнера ВТБ</param>
    /// <param name="X_LOGIN_MODE">Режим входа в ВТБ</param>
    /// <param name="X_ROLES">Роли клиента</param>
    /// <param name="X_CHANNEL">Идентификатор канала клиента</param>
    /// <param name="minBalance">Баланс который должен  быть в наличии у продуктов клиента (optional, default to 0M)</param>
    /// <param name="operationIndex">Index associated with the operation.</param>
    /// <returns>ApiResponse of ClientProductsDtoRs</returns>
    ApiResponse<ClientProductsDtoRs> GetClientProductsWithHttpInfo(string X_UNC, string X_MDM_ID, string X_PARTNER_ID, string X_LOGIN_MODE, List<string> X_ROLES, string X_CHANNEL,
        decimal? minBalance = default, int operationIndex = 0);

    /// <summary>
    ///     Запрос детальной информации по универсальному платежу
    /// </summary>
    /// <exception cref="Multibanking.UniversalPaymentClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="X_UNC">Идентификатор клиента УНК</param>
    /// <param name="X_MDM_ID">Идентификатор клиента mdm id</param>
    /// <param name="X_PARTNER_ID">Идентификатор партнера ВТБ</param>
    /// <param name="X_LOGIN_MODE">Режим входа в ВТБ</param>
    /// <param name="X_ROLES">Роли клиента</param>
    /// <param name="X_CHANNEL">Идентификатор канала клиента</param>
    /// <param name="paymentId">Идентификатор платежа</param>
    /// <param name="operationIndex">Index associated with the operation.</param>
    /// <returns>PaymentDtoRs</returns>
    PaymentDtoRs GetPayment(string X_UNC, string X_MDM_ID, string X_PARTNER_ID, string X_LOGIN_MODE, List<string> X_ROLES, string X_CHANNEL, string paymentId,
        int operationIndex = 0);

    /// <summary>
    ///     Запрос детальной информации по универсальному платежу
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <exception cref="Multibanking.UniversalPaymentClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="X_UNC">Идентификатор клиента УНК</param>
    /// <param name="X_MDM_ID">Идентификатор клиента mdm id</param>
    /// <param name="X_PARTNER_ID">Идентификатор партнера ВТБ</param>
    /// <param name="X_LOGIN_MODE">Режим входа в ВТБ</param>
    /// <param name="X_ROLES">Роли клиента</param>
    /// <param name="X_CHANNEL">Идентификатор канала клиента</param>
    /// <param name="paymentId">Идентификатор платежа</param>
    /// <param name="operationIndex">Index associated with the operation.</param>
    /// <returns>ApiResponse of PaymentDtoRs</returns>
    ApiResponse<PaymentDtoRs> GetPaymentWithHttpInfo(string X_UNC, string X_MDM_ID, string X_PARTNER_ID, string X_LOGIN_MODE, List<string> X_ROLES, string X_CHANNEL,
        string paymentId, int operationIndex = 0);

    /// <summary>
    ///     Запрос чека по универсальному платежу
    /// </summary>
    /// <exception cref="Multibanking.UniversalPaymentClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="X_UNC">Идентификатор клиента УНК</param>
    /// <param name="X_MDM_ID">Идентификатор клиента mdm id</param>
    /// <param name="X_PARTNER_ID">Идентификатор партнера ВТБ</param>
    /// <param name="X_LOGIN_MODE">Режим входа в ВТБ</param>
    /// <param name="X_ROLES">Роли клиента</param>
    /// <param name="X_CHANNEL">Идентификатор канала клиента</param>
    /// <param name="paymentId">Идентификатор платежа</param>
    /// <param name="operationIndex">Index associated with the operation.</param>
    /// <returns>PaymentCheckDtoRs</returns>
    PaymentCheckDtoRs GetPaymentCheck(string X_UNC, string X_MDM_ID, string X_PARTNER_ID, string X_LOGIN_MODE, List<string> X_ROLES, string X_CHANNEL, string paymentId,
        int operationIndex = 0);

    /// <summary>
    ///     Запрос чека по универсальному платежу
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <exception cref="Multibanking.UniversalPaymentClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="X_UNC">Идентификатор клиента УНК</param>
    /// <param name="X_MDM_ID">Идентификатор клиента mdm id</param>
    /// <param name="X_PARTNER_ID">Идентификатор партнера ВТБ</param>
    /// <param name="X_LOGIN_MODE">Режим входа в ВТБ</param>
    /// <param name="X_ROLES">Роли клиента</param>
    /// <param name="X_CHANNEL">Идентификатор канала клиента</param>
    /// <param name="paymentId">Идентификатор платежа</param>
    /// <param name="operationIndex">Index associated with the operation.</param>
    /// <returns>ApiResponse of PaymentCheckDtoRs</returns>
    ApiResponse<PaymentCheckDtoRs> GetPaymentCheckWithHttpInfo(string X_UNC, string X_MDM_ID, string X_PARTNER_ID, string X_LOGIN_MODE, List<string> X_ROLES, string X_CHANNEL,
        string paymentId, int operationIndex = 0);

    /// <summary>
    ///     Запрос на оплату универсального платежа
    /// </summary>
    /// <exception cref="Multibanking.UniversalPaymentClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="X_UNC">Идентификатор клиента УНК</param>
    /// <param name="X_MDM_ID">Идентификатор клиента mdm id</param>
    /// <param name="X_PARTNER_ID">Идентификатор партнера ВТБ</param>
    /// <param name="X_LOGIN_MODE">Режим входа в ВТБ</param>
    /// <param name="X_ROLES">Роли клиента</param>
    /// <param name="X_CHANNEL">Идентификатор канала клиента</param>
    /// <param name="requestPaymentDtoRq"></param>
    /// <param name="X_TB_ID">Идентификатор клиента TB id (optional)</param>
    /// <param name="operationIndex">Index associated with the operation.</param>
    /// <returns>RequestPaymentDtoRs</returns>
    RequestPaymentDtoRs Request(string X_UNC, string X_MDM_ID, string X_PARTNER_ID, string X_LOGIN_MODE, List<string> X_ROLES, string X_CHANNEL,
        RequestPaymentDtoRq requestPaymentDtoRq, string X_TB_ID = default, int operationIndex = 0);

    /// <summary>
    ///     Запрос на оплату универсального платежа
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <exception cref="Multibanking.UniversalPaymentClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="X_UNC">Идентификатор клиента УНК</param>
    /// <param name="X_MDM_ID">Идентификатор клиента mdm id</param>
    /// <param name="X_PARTNER_ID">Идентификатор партнера ВТБ</param>
    /// <param name="X_LOGIN_MODE">Режим входа в ВТБ</param>
    /// <param name="X_ROLES">Роли клиента</param>
    /// <param name="X_CHANNEL">Идентификатор канала клиента</param>
    /// <param name="requestPaymentDtoRq"></param>
    /// <param name="X_TB_ID">Идентификатор клиента TB id (optional)</param>
    /// <param name="operationIndex">Index associated with the operation.</param>
    /// <returns>ApiResponse of RequestPaymentDtoRs</returns>
    ApiResponse<RequestPaymentDtoRs> RequestWithHttpInfo(string X_UNC, string X_MDM_ID, string X_PARTNER_ID, string X_LOGIN_MODE, List<string> X_ROLES, string X_CHANNEL,
        RequestPaymentDtoRq requestPaymentDtoRq, string X_TB_ID = default, int operationIndex = 0);

    /// <summary>
    ///     Запрос на старт оплаты универсального платежа
    /// </summary>
    /// <exception cref="Multibanking.UniversalPaymentClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="X_UNC">Идентификатор клиента УНК</param>
    /// <param name="X_MDM_ID">Идентификатор клиента mdm id</param>
    /// <param name="X_PARTNER_ID">Идентификатор партнера ВТБ</param>
    /// <param name="X_LOGIN_MODE">Режим входа в ВТБ</param>
    /// <param name="X_ROLES">Роли клиента</param>
    /// <param name="X_CHANNEL">Идентификатор канала клиента</param>
    /// <param name="startPaymentDtoRq"></param>
    /// <param name="operationIndex">Index associated with the operation.</param>
    /// <returns>StartPaymentDtoRs</returns>
    StartPaymentDtoRs Start(string X_UNC, string X_MDM_ID, string X_PARTNER_ID, string X_LOGIN_MODE, List<string> X_ROLES, string X_CHANNEL, StartPaymentDtoRq startPaymentDtoRq,
        int operationIndex = 0);

    /// <summary>
    ///     Запрос на старт оплаты универсального платежа
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <exception cref="Multibanking.UniversalPaymentClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="X_UNC">Идентификатор клиента УНК</param>
    /// <param name="X_MDM_ID">Идентификатор клиента mdm id</param>
    /// <param name="X_PARTNER_ID">Идентификатор партнера ВТБ</param>
    /// <param name="X_LOGIN_MODE">Режим входа в ВТБ</param>
    /// <param name="X_ROLES">Роли клиента</param>
    /// <param name="X_CHANNEL">Идентификатор канала клиента</param>
    /// <param name="startPaymentDtoRq"></param>
    /// <param name="operationIndex">Index associated with the operation.</param>
    /// <returns>ApiResponse of StartPaymentDtoRs</returns>
    ApiResponse<StartPaymentDtoRs> StartWithHttpInfo(string X_UNC, string X_MDM_ID, string X_PARTNER_ID, string X_LOGIN_MODE, List<string> X_ROLES, string X_CHANNEL,
        StartPaymentDtoRq startPaymentDtoRq, int operationIndex = 0);

    #endregion Synchronous Operations
}