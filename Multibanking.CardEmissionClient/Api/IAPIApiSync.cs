using Multibanking.CardEmissionClient.Client;
using Multibanking.CardEmissionClient.Model;

namespace Multibanking.CardEmissionClient.Api;

/// <summary>
///     Represents a collection of functions to interact with the API endpoints
/// </summary>
public interface IAPIApiSync : IApiAccessor
{
    #region Synchronous Operations

    /// <summary>
    ///     Открытие карты
    /// </summary>
    /// <remarks>
    ///     Метод открытия карты
    /// </remarks>
    /// <exception cref="Multibanking.CardEmissionClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="xMdmId">Уникальный идентификатор клиента в MDM</param>
    /// <param name="xClientChannel">Признак использования API партнером</param>
    /// <param name="X_PARTNER_ID">Мнемокод партнера</param>
    /// <param name="cardOpenRequest">Параметры открываемой карты</param>
    /// <param name="operationIndex">Index associated with the operation.</param>
    /// <returns>CardInfoResponse</returns>
    CardInfoResponse UpdateCreateCard(string xMdmId, string xClientChannel, string X_PARTNER_ID, CardOpenRequest cardOpenRequest, int operationIndex = 0);

    /// <summary>
    ///     Открытие карты
    /// </summary>
    /// <remarks>
    ///     Метод открытия карты
    /// </remarks>
    /// <exception cref="Multibanking.CardEmissionClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="xMdmId">Уникальный идентификатор клиента в MDM</param>
    /// <param name="xClientChannel">Признак использования API партнером</param>
    /// <param name="X_PARTNER_ID">Мнемокод партнера</param>
    /// <param name="cardOpenRequest">Параметры открываемой карты</param>
    /// <param name="operationIndex">Index associated with the operation.</param>
    /// <returns>ApiResponse of CardInfoResponse</returns>
    ApiResponse<CardInfoResponse> UpdateCreateCardWithHttpInfo(string xMdmId, string xClientChannel, string X_PARTNER_ID, CardOpenRequest cardOpenRequest, int operationIndex = 0);

    #endregion Synchronous Operations
}