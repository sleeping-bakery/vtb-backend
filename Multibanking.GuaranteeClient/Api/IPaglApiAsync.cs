using System.Threading;
using System.Threading.Tasks;
using Multibanking.GuaranteeClient.Client;
using Multibanking.GuaranteeClient.Model;

namespace Multibanking.GuaranteeClient.Api
{
    /// <summary>
    ///     Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IPaglApiAsync : IApiAccessor
    {
        #region Asynchronous Operations

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
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of CreateRequestResponseDto</returns>
        Task<CreateRequestResponseDto> CreateRequestClientAsync(string xIBMClientID, PaglRequest paglRequest, int operationIndex = 0,
            CancellationToken cancellationToken = default);

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
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (CreateRequestResponseDto)</returns>
        Task<ApiResponse<CreateRequestResponseDto>> CreateRequestClientWithHttpInfoAsync(string xIBMClientID, PaglRequest paglRequest, int operationIndex = 0,
            CancellationToken cancellationToken = default);

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
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of DocumentDownloadDto</returns>
        Task<DocumentDownloadDto> GetPaglResultAsync(string internalId, string xIBMClientID, int operationIndex = 0, CancellationToken cancellationToken = default);

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
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (DocumentDownloadDto)</returns>
        Task<ApiResponse<DocumentDownloadDto>> GetPaglResultWithHttpInfoAsync(string internalId, string xIBMClientID, int operationIndex = 0,
            CancellationToken cancellationToken = default);

        #endregion Asynchronous Operations
    }
}