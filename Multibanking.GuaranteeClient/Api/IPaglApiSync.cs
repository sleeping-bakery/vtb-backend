using Multibanking.GuaranteeClient.Client;
using Multibanking.GuaranteeClient.Model;

namespace Multibanking.GuaranteeClient.Api
{
    /// <summary>
    ///     Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IPaglApiSync : IApiAccessor
    {
        #region Synchronous Operations

        /// <summary>
        ///     Создать запросы от клиента для расчета предодобренного предложения
        /// </summary>
        /// <remarks>
        ///     Создать запрос клиента
        /// </remarks>
        /// <exception cref="Multibanking.GuaranteeClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="xIBMClientID">Заголовок запроса, содержащий client_id партнера</param>
        /// <param name="paglRequest">Данные ПАГЛ</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>CreateRequestResponseDto</returns>
        CreateRequestResponseDto CreateRequestClient(string xIBMClientID, PaglRequest paglRequest, int operationIndex = 0);

        /// <summary>
        ///     Создать запросы от клиента для расчета предодобренного предложения
        /// </summary>
        /// <remarks>
        ///     Создать запрос клиента
        /// </remarks>
        /// <exception cref="Multibanking.GuaranteeClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="xIBMClientID">Заголовок запроса, содержащий client_id партнера</param>
        /// <param name="paglRequest">Данные ПАГЛ</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of CreateRequestResponseDto</returns>
        ApiResponse<CreateRequestResponseDto> CreateRequestClientWithHttpInfo(string xIBMClientID, PaglRequest paglRequest, int operationIndex = 0);

        /// <summary>
        ///     Получить ссылку на документ результатов предодобренных лимитов по гарантиям
        /// </summary>
        /// <remarks>
        ///     Запрос документа результатов расчета
        /// </remarks>
        /// <exception cref="Multibanking.GuaranteeClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="internalId">Идентификатор запроса партнера</param>
        /// <param name="xIBMClientID">Заголовок запроса, содержащий client_id партнера</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>DocumentDownloadDto</returns>
        DocumentDownloadDto GetPaglResult(string internalId, string xIBMClientID, int operationIndex = 0);

        /// <summary>
        ///     Получить ссылку на документ результатов предодобренных лимитов по гарантиям
        /// </summary>
        /// <remarks>
        ///     Запрос документа результатов расчета
        /// </remarks>
        /// <exception cref="Multibanking.GuaranteeClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="internalId">Идентификатор запроса партнера</param>
        /// <param name="xIBMClientID">Заголовок запроса, содержащий client_id партнера</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of DocumentDownloadDto</returns>
        ApiResponse<DocumentDownloadDto> GetPaglResultWithHttpInfo(string internalId, string xIBMClientID, int operationIndex = 0);

        #endregion Synchronous Operations
    }
}