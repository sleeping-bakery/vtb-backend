using Multibanking.CardOperationClient.Client;
using Multibanking.CardOperationClient.Model;

namespace Multibanking.CardOperationClient.Api;

/// <summary>
///     Represents a collection of functions to interact with the API endpoints
/// </summary>
public interface IAPIApiSync : IApiAccessor
{
    #region Synchronous Operations

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
    /// <returns>CardInfoResponse</returns>
    CardInfoResponse UpdateCardOption(string publicId, string xMdmId, string xClientChannel, string X_PARTNER_ID, CardStatusRequest cardStatusRequest, int operationIndex = 0);

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
    /// <returns>ApiResponse of CardInfoResponse</returns>
    ApiResponse<CardInfoResponse> UpdateCardOptionWithHttpInfo(string publicId, string xMdmId, string xClientChannel, string X_PARTNER_ID, CardStatusRequest cardStatusRequest,
        int operationIndex = 0);

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
    /// <returns>CardInfoResponse</returns>
    CardInfoResponse UpdateCardPin(string publicId, string xMdmId, string xClientChannel, string X_PARTNER_ID, PinCardRequest pinCardRequest, int operationIndex = 0);

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
    /// <returns>ApiResponse of CardInfoResponse</returns>
    ApiResponse<CardInfoResponse> UpdateCardPinWithHttpInfo(string publicId, string xMdmId, string xClientChannel, string X_PARTNER_ID, PinCardRequest pinCardRequest,
        int operationIndex = 0);

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
    /// <returns></returns>
    void UpdateCloseCard(string publicId, string xMdmId, string xClientChannel, string X_PARTNER_ID, int operationIndex = 0);

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
    /// <returns>ApiResponse of Object(void)</returns>
    ApiResponse<object> UpdateCloseCardWithHttpInfo(string publicId, string xMdmId, string xClientChannel, string X_PARTNER_ID, int operationIndex = 0);

    #endregion Synchronous Operations
}