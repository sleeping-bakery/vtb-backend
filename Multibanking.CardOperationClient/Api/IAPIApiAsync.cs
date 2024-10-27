using System.Threading;
using System.Threading.Tasks;
using Multibanking.CardOperationClient.Client;
using Multibanking.CardOperationClient.Model;

namespace Multibanking.CardOperationClient.Api;

/// <summary>
///     Represents a collection of functions to interact with the API endpoints
/// </summary>
public interface IAPIApiAsync : IApiAccessor
{
    #region Asynchronous Operations

    /// <summary>
    ///     Установка/смена статуса карты
    /// </summary>
    /// <remarks>
    ///     Метод установки статуса карты
    /// </remarks>
    /// <exception cref="Multibanking.CardOperationClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="publicId">Публичный идентификатор продукта</param>
    /// <param name="xMdmId">Уникальный идентификатор клиента в MDM</param>
    /// <param name="xClientChannel">Признак использования API партнером</param>
    /// <param name="X_PARTNER_ID">Мнемокод партнера</param>
    /// <param name="cardStatusRequest">Данные для блокировки/разблокировки карты</param>
    /// <param name="operationIndex">Index associated with the operation.</param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of CardInfoResponse</returns>
    Task<CardInfoResponse> UpdateCardOptionAsync(string publicId, string xMdmId, string xClientChannel, string X_PARTNER_ID, CardStatusRequest cardStatusRequest,
        int operationIndex = 0, CancellationToken cancellationToken = default);

    /// <summary>
    ///     Установка/смена статуса карты
    /// </summary>
    /// <remarks>
    ///     Метод установки статуса карты
    /// </remarks>
    /// <exception cref="Multibanking.CardOperationClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="publicId">Публичный идентификатор продукта</param>
    /// <param name="xMdmId">Уникальный идентификатор клиента в MDM</param>
    /// <param name="xClientChannel">Признак использования API партнером</param>
    /// <param name="X_PARTNER_ID">Мнемокод партнера</param>
    /// <param name="cardStatusRequest">Данные для блокировки/разблокировки карты</param>
    /// <param name="operationIndex">Index associated with the operation.</param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ApiResponse (CardInfoResponse)</returns>
    Task<ApiResponse<CardInfoResponse>> UpdateCardOptionWithHttpInfoAsync(string publicId, string xMdmId, string xClientChannel, string X_PARTNER_ID,
        CardStatusRequest cardStatusRequest, int operationIndex = 0, CancellationToken cancellationToken = default);

    /// <summary>
    ///     Установка/смена пин-кода для карты
    /// </summary>
    /// <remarks>
    ///     Метод смены PIN-кода карты
    /// </remarks>
    /// <exception cref="Multibanking.CardOperationClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="publicId">Публичный идентификатор продукта</param>
    /// <param name="xMdmId">Уникальный идентификатор клиента в MDM</param>
    /// <param name="xClientChannel">Признак использования API партнером</param>
    /// <param name="X_PARTNER_ID">Мнемокод партнера</param>
    /// <param name="pinCardRequest">Данные для смены пин-кода карты</param>
    /// <param name="operationIndex">Index associated with the operation.</param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of CardInfoResponse</returns>
    Task<CardInfoResponse> UpdateCardPinAsync(string publicId, string xMdmId, string xClientChannel, string X_PARTNER_ID, PinCardRequest pinCardRequest, int operationIndex = 0,
        CancellationToken cancellationToken = default);

    /// <summary>
    ///     Установка/смена пин-кода для карты
    /// </summary>
    /// <remarks>
    ///     Метод смены PIN-кода карты
    /// </remarks>
    /// <exception cref="Multibanking.CardOperationClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="publicId">Публичный идентификатор продукта</param>
    /// <param name="xMdmId">Уникальный идентификатор клиента в MDM</param>
    /// <param name="xClientChannel">Признак использования API партнером</param>
    /// <param name="X_PARTNER_ID">Мнемокод партнера</param>
    /// <param name="pinCardRequest">Данные для смены пин-кода карты</param>
    /// <param name="operationIndex">Index associated with the operation.</param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ApiResponse (CardInfoResponse)</returns>
    Task<ApiResponse<CardInfoResponse>> UpdateCardPinWithHttpInfoAsync(string publicId, string xMdmId, string xClientChannel, string X_PARTNER_ID, PinCardRequest pinCardRequest,
        int operationIndex = 0, CancellationToken cancellationToken = default);

    /// <summary>
    ///     Закрытие карты при нулевом балансе
    /// </summary>
    /// <remarks>
    ///     Метод закрытия карты
    /// </remarks>
    /// <exception cref="Multibanking.CardOperationClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="publicId">Публичный идентификатор продукта</param>
    /// <param name="xMdmId">Уникальный идентификатор клиента в MDM</param>
    /// <param name="xClientChannel">Признак использования API партнером</param>
    /// <param name="X_PARTNER_ID">Мнемокод партнера</param>
    /// <param name="operationIndex">Index associated with the operation.</param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of void</returns>
    Task UpdateCloseCardAsync(string publicId, string xMdmId, string xClientChannel, string X_PARTNER_ID, int operationIndex = 0, CancellationToken cancellationToken = default);

    /// <summary>
    ///     Закрытие карты при нулевом балансе
    /// </summary>
    /// <remarks>
    ///     Метод закрытия карты
    /// </remarks>
    /// <exception cref="Multibanking.CardOperationClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="publicId">Публичный идентификатор продукта</param>
    /// <param name="xMdmId">Уникальный идентификатор клиента в MDM</param>
    /// <param name="xClientChannel">Признак использования API партнером</param>
    /// <param name="X_PARTNER_ID">Мнемокод партнера</param>
    /// <param name="operationIndex">Index associated with the operation.</param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ApiResponse</returns>
    Task<ApiResponse<object>> UpdateCloseCardWithHttpInfoAsync(string publicId, string xMdmId, string xClientChannel, string X_PARTNER_ID, int operationIndex = 0,
        CancellationToken cancellationToken = default);

    #endregion Asynchronous Operations
}