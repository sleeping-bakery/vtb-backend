using Multibanking.CardInformationClient.Client;
using Multibanking.CardInformationClient.Model;

namespace Multibanking.CardInformationClient.Api;

/// <summary>
///     Represents a collection of functions to interact with the API endpoints
/// </summary>
public interface IAPIApiSync : IApiAccessor
{
    #region Synchronous Operations

    /// <summary>
    ///     Получение реквизитов карты
    /// </summary>
    /// <remarks>
    ///     Метод получения реквизитов карты
    /// </remarks>
    /// <exception cref="Multibanking.CardInformationClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="publicId">Публичный идентификатор продукта</param>
    /// <param name="xMdmId">Уникальный идентификатор клиента в MDM</param>
    /// <param name="clientOpenKey">Открытый ключ клиента</param>
    /// <param name="xClientChannel">Признак использования API партнером</param>
    /// <param name="X_PARTNER_ID">Мнемокод партнера</param>
    /// <param name="operationIndex">Index associated with the operation.</param>
    /// <returns>CredentialsResponse</returns>
    CredentialsResponse GetCredentials(string publicId, string xMdmId, string clientOpenKey, string xClientChannel, string X_PARTNER_ID, int operationIndex = 0);

    /// <summary>
    ///     Получение реквизитов карты
    /// </summary>
    /// <remarks>
    ///     Метод получения реквизитов карты
    /// </remarks>
    /// <exception cref="Multibanking.CardInformationClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="publicId">Публичный идентификатор продукта</param>
    /// <param name="xMdmId">Уникальный идентификатор клиента в MDM</param>
    /// <param name="clientOpenKey">Открытый ключ клиента</param>
    /// <param name="xClientChannel">Признак использования API партнером</param>
    /// <param name="X_PARTNER_ID">Мнемокод партнера</param>
    /// <param name="operationIndex">Index associated with the operation.</param>
    /// <returns>ApiResponse of CredentialsResponse</returns>
    ApiResponse<CredentialsResponse> GetCredentialsWithHttpInfo(string publicId, string xMdmId, string clientOpenKey, string xClientChannel, string X_PARTNER_ID,
        int operationIndex = 0);

    /// <summary>
    ///     Получение кода CVV карты
    /// </summary>
    /// <remarks>
    ///     Метод получения CVV кода карты
    /// </remarks>
    /// <exception cref="Multibanking.CardInformationClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="publicId">Публичный идентификатор продукта</param>
    /// <param name="xMdmId">Уникальный идентификатор клиента в MDM</param>
    /// <param name="clientOpenKey">Открытый ключ клиента</param>
    /// <param name="xClientChannel">Признак использования API партнером</param>
    /// <param name="X_PARTNER_ID">Мнемокод партнера</param>
    /// <param name="operationIndex">Index associated with the operation.</param>
    /// <returns>CvvResponse</returns>
    CvvResponse GetCvv(string publicId, string xMdmId, string clientOpenKey, string xClientChannel, string X_PARTNER_ID, int operationIndex = 0);

    /// <summary>
    ///     Получение кода CVV карты
    /// </summary>
    /// <remarks>
    ///     Метод получения CVV кода карты
    /// </remarks>
    /// <exception cref="Multibanking.CardInformationClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="publicId">Публичный идентификатор продукта</param>
    /// <param name="xMdmId">Уникальный идентификатор клиента в MDM</param>
    /// <param name="clientOpenKey">Открытый ключ клиента</param>
    /// <param name="xClientChannel">Признак использования API партнером</param>
    /// <param name="X_PARTNER_ID">Мнемокод партнера</param>
    /// <param name="operationIndex">Index associated with the operation.</param>
    /// <returns>ApiResponse of CvvResponse</returns>
    ApiResponse<CvvResponse> GetCvvWithHttpInfo(string publicId, string xMdmId, string clientOpenKey, string xClientChannel, string X_PARTNER_ID, int operationIndex = 0);

    /// <summary>
    ///     Получение токенов карты
    /// </summary>
    /// <remarks>
    ///     Метод получения токенов карты
    /// </remarks>
    /// <exception cref="Multibanking.CardInformationClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="publicId">Публичный идентификатор продукта</param>
    /// <param name="xMdmId">Уникальный идентификатор клиента в MDM</param>
    /// <param name="xClientChannel">Признак использования API партнером</param>
    /// <param name="X_PARTNER_ID">Мнемокод партнера</param>
    /// <param name="operationIndex">Index associated with the operation.</param>
    /// <returns>TokensDto</returns>
    TokensDto GetTokens(string publicId, string xMdmId, string xClientChannel, string X_PARTNER_ID, int operationIndex = 0);

    /// <summary>
    ///     Получение токенов карты
    /// </summary>
    /// <remarks>
    ///     Метод получения токенов карты
    /// </remarks>
    /// <exception cref="Multibanking.CardInformationClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="publicId">Публичный идентификатор продукта</param>
    /// <param name="xMdmId">Уникальный идентификатор клиента в MDM</param>
    /// <param name="xClientChannel">Признак использования API партнером</param>
    /// <param name="X_PARTNER_ID">Мнемокод партнера</param>
    /// <param name="operationIndex">Index associated with the operation.</param>
    /// <returns>ApiResponse of TokensDto</returns>
    ApiResponse<TokensDto> GetTokensWithHttpInfo(string publicId, string xMdmId, string xClientChannel, string X_PARTNER_ID, int operationIndex = 0);

    /// <summary>
    ///     Токенизация карты
    /// </summary>
    /// <remarks>
    ///     Операция токенизации карты
    /// </remarks>
    /// <exception cref="Multibanking.CardInformationClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="publicId">Публичный идентификатор продукта</param>
    /// <param name="xMdmId">Уникальный идентификатор клиента в MDM</param>
    /// <param name="xClientChannel">Признак использования API партнером</param>
    /// <param name="X_PARTNER_ID">Мнемокод партнера</param>
    /// <param name="generateWalletTokenRequest">Данные для формирования зашифрованных параметров</param>
    /// <param name="operationIndex">Index associated with the operation.</param>
    /// <returns>TokensDto</returns>
    TokensDto UpdateTokenize(string publicId, string xMdmId, string xClientChannel, string X_PARTNER_ID, GenerateWalletTokenRequest generateWalletTokenRequest,
        int operationIndex = 0);

    /// <summary>
    ///     Токенизация карты
    /// </summary>
    /// <remarks>
    ///     Операция токенизации карты
    /// </remarks>
    /// <exception cref="Multibanking.CardInformationClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="publicId">Публичный идентификатор продукта</param>
    /// <param name="xMdmId">Уникальный идентификатор клиента в MDM</param>
    /// <param name="xClientChannel">Признак использования API партнером</param>
    /// <param name="X_PARTNER_ID">Мнемокод партнера</param>
    /// <param name="generateWalletTokenRequest">Данные для формирования зашифрованных параметров</param>
    /// <param name="operationIndex">Index associated with the operation.</param>
    /// <returns>ApiResponse of TokensDto</returns>
    ApiResponse<TokensDto> UpdateTokenizeWithHttpInfo(string publicId, string xMdmId, string xClientChannel, string X_PARTNER_ID,
        GenerateWalletTokenRequest generateWalletTokenRequest, int operationIndex = 0);

    #endregion Synchronous Operations
}