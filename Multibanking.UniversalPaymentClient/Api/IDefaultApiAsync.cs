using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Multibanking.UniversalPaymentClient.Client;
using Multibanking.UniversalPaymentClient.Model;

namespace Multibanking.UniversalPaymentClient.Api;

/// <summary>
///     Represents a collection of functions to interact with the API endpoints
/// </summary>
public interface IDefaultApiAsync : IApiAccessor
{
    #region Asynchronous Operations

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
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ConfirmPaymentDtoRs</returns>
    Task<ConfirmPaymentDtoRs> ConfirmAsync(string X_UNC, string X_MDM_ID, string X_USER_SESSION_ID, string X_PARTNER_ID, string X_LOGIN_MODE, List<string> X_ROLES,
        string X_CHANNEL, ConfirmPaymentDtoRq confirmPaymentDtoRq, string X_TB_ID = default, int operationIndex = 0, CancellationToken cancellationToken = default);

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
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ApiResponse (ConfirmPaymentDtoRs)</returns>
    Task<ApiResponse<ConfirmPaymentDtoRs>> ConfirmWithHttpInfoAsync(string X_UNC, string X_MDM_ID, string X_USER_SESSION_ID, string X_PARTNER_ID, string X_LOGIN_MODE,
        List<string> X_ROLES, string X_CHANNEL, ConfirmPaymentDtoRq confirmPaymentDtoRq, string X_TB_ID = default, int operationIndex = 0,
        CancellationToken cancellationToken = default);

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
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ClientProductsDtoRs</returns>
    Task<ClientProductsDtoRs> GetClientProductsAsync(string X_UNC, string X_MDM_ID, string X_PARTNER_ID, string X_LOGIN_MODE, List<string> X_ROLES, string X_CHANNEL,
        decimal? minBalance = default, int operationIndex = 0, CancellationToken cancellationToken = default);

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
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ApiResponse (ClientProductsDtoRs)</returns>
    Task<ApiResponse<ClientProductsDtoRs>> GetClientProductsWithHttpInfoAsync(string X_UNC, string X_MDM_ID, string X_PARTNER_ID, string X_LOGIN_MODE, List<string> X_ROLES,
        string X_CHANNEL, decimal? minBalance = default, int operationIndex = 0, CancellationToken cancellationToken = default);

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
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of PaymentDtoRs</returns>
    Task<PaymentDtoRs> GetPaymentAsync(string X_UNC, string X_MDM_ID, string X_PARTNER_ID, string X_LOGIN_MODE, List<string> X_ROLES, string X_CHANNEL, string paymentId,
        int operationIndex = 0, CancellationToken cancellationToken = default);

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
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ApiResponse (PaymentDtoRs)</returns>
    Task<ApiResponse<PaymentDtoRs>> GetPaymentWithHttpInfoAsync(string X_UNC, string X_MDM_ID, string X_PARTNER_ID, string X_LOGIN_MODE, List<string> X_ROLES, string X_CHANNEL,
        string paymentId, int operationIndex = 0, CancellationToken cancellationToken = default);

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
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of PaymentCheckDtoRs</returns>
    Task<PaymentCheckDtoRs> GetPaymentCheckAsync(string X_UNC, string X_MDM_ID, string X_PARTNER_ID, string X_LOGIN_MODE, List<string> X_ROLES, string X_CHANNEL, string paymentId,
        int operationIndex = 0, CancellationToken cancellationToken = default);

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
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ApiResponse (PaymentCheckDtoRs)</returns>
    Task<ApiResponse<PaymentCheckDtoRs>> GetPaymentCheckWithHttpInfoAsync(string X_UNC, string X_MDM_ID, string X_PARTNER_ID, string X_LOGIN_MODE, List<string> X_ROLES,
        string X_CHANNEL, string paymentId, int operationIndex = 0, CancellationToken cancellationToken = default);

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
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of RequestPaymentDtoRs</returns>
    Task<RequestPaymentDtoRs> RequestAsync(string X_UNC, string X_MDM_ID, string X_PARTNER_ID, string X_LOGIN_MODE, List<string> X_ROLES, string X_CHANNEL,
        RequestPaymentDtoRq requestPaymentDtoRq, string X_TB_ID = default, int operationIndex = 0, CancellationToken cancellationToken = default);

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
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ApiResponse (RequestPaymentDtoRs)</returns>
    Task<ApiResponse<RequestPaymentDtoRs>> RequestWithHttpInfoAsync(string X_UNC, string X_MDM_ID, string X_PARTNER_ID, string X_LOGIN_MODE, List<string> X_ROLES, string X_CHANNEL,
        RequestPaymentDtoRq requestPaymentDtoRq, string X_TB_ID = default, int operationIndex = 0, CancellationToken cancellationToken = default);

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
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of StartPaymentDtoRs</returns>
    Task<StartPaymentDtoRs> StartAsync(string X_UNC, string X_MDM_ID, string X_PARTNER_ID, string X_LOGIN_MODE, List<string> X_ROLES, string X_CHANNEL,
        StartPaymentDtoRq startPaymentDtoRq, int operationIndex = 0, CancellationToken cancellationToken = default);

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
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ApiResponse (StartPaymentDtoRs)</returns>
    Task<ApiResponse<StartPaymentDtoRs>> StartWithHttpInfoAsync(string X_UNC, string X_MDM_ID, string X_PARTNER_ID, string X_LOGIN_MODE, List<string> X_ROLES, string X_CHANNEL,
        StartPaymentDtoRq startPaymentDtoRq, int operationIndex = 0, CancellationToken cancellationToken = default);

    #endregion Asynchronous Operations
}