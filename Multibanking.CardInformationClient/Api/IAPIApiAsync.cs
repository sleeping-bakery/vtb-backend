using System.Threading;
using System.Threading.Tasks;
using Multibanking.CardInformationClient.Client;
using Multibanking.CardInformationClient.Model;

namespace Multibanking.CardInformationClient.Api;

/// <summary>
///     Represents a collection of functions to interact with the API endpoints
/// </summary>
public interface IAPIApiAsync : IApiAccessor
{
    #region Asynchronous Operations

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
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of CredentialsResponse</returns>
    Task<CredentialsResponse> GetCredentialsAsync(string publicId, string xMdmId, string clientOpenKey, string xClientChannel, string X_PARTNER_ID, int operationIndex = 0,
        CancellationToken cancellationToken = default);

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
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ApiResponse (CredentialsResponse)</returns>
    Task<ApiResponse<CredentialsResponse>> GetCredentialsWithHttpInfoAsync(string publicId, string xMdmId, string clientOpenKey, string xClientChannel, string X_PARTNER_ID,
        int operationIndex = 0, CancellationToken cancellationToken = default);

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
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of CvvResponse</returns>
    Task<CvvResponse> GetCvvAsync(string publicId, string xMdmId, string clientOpenKey, string xClientChannel, string X_PARTNER_ID, int operationIndex = 0,
        CancellationToken cancellationToken = default);

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
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ApiResponse (CvvResponse)</returns>
    Task<ApiResponse<CvvResponse>> GetCvvWithHttpInfoAsync(string publicId, string xMdmId, string clientOpenKey, string xClientChannel, string X_PARTNER_ID, int operationIndex = 0,
        CancellationToken cancellationToken = default);

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
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of TokensDto</returns>
    Task<TokensDto> GetTokensAsync(string publicId, string xMdmId, string xClientChannel, string X_PARTNER_ID, int operationIndex = 0,
        CancellationToken cancellationToken = default);

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
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ApiResponse (TokensDto)</returns>
    Task<ApiResponse<TokensDto>> GetTokensWithHttpInfoAsync(string publicId, string xMdmId, string xClientChannel, string X_PARTNER_ID, int operationIndex = 0,
        CancellationToken cancellationToken = default);

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
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of TokensDto</returns>
    Task<TokensDto> UpdateTokenizeAsync(string publicId, string xMdmId, string xClientChannel, string X_PARTNER_ID, GenerateWalletTokenRequest generateWalletTokenRequest,
        int operationIndex = 0, CancellationToken cancellationToken = default);

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
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ApiResponse (TokensDto)</returns>
    Task<ApiResponse<TokensDto>> UpdateTokenizeWithHttpInfoAsync(string publicId, string xMdmId, string xClientChannel, string X_PARTNER_ID,
        GenerateWalletTokenRequest generateWalletTokenRequest, int operationIndex = 0, CancellationToken cancellationToken = default);

    #endregion Asynchronous Operations
}