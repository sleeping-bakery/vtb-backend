using System.Threading;
using System.Threading.Tasks;
using Multibanking.GuaranteeClient.Client;
using Multibanking.GuaranteeClient.Model;

namespace Multibanking.GuaranteeClient.Api
{
    /// <summary>
    ///     Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IDocumentApiAsync : IApiAccessor
    {
        #region Asynchronous Operations

        /// <summary>
        ///     Подтвердить загрузку документа из банка
        /// </summary>
        /// <remarks>
        ///     Подтвердить загрузку документа из банка
        /// </remarks>
        /// <exception cref="Multibanking.GuaranteeClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="xIBMClientID">Заголовок запроса, содержащий client_id партнера</param>
        /// <param name="downloadConfirmDto">Запрос на подтверждение загрузки документа из банка</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of void</returns>
        Task ConfirmDownloadAsync(string xIBMClientID, DownloadConfirmDto downloadConfirmDto, int operationIndex = 0, CancellationToken cancellationToken = default);

        /// <summary>
        ///     Подтвердить загрузку документа из банка
        /// </summary>
        /// <remarks>
        ///     Подтвердить загрузку документа из банка
        /// </remarks>
        /// <exception cref="Multibanking.GuaranteeClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="xIBMClientID">Заголовок запроса, содержащий client_id партнера</param>
        /// <param name="downloadConfirmDto">Запрос на подтверждение загрузки документа из банка</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse</returns>
        Task<ApiResponse<object>> ConfirmDownloadWithHttpInfoAsync(string xIBMClientID, DownloadConfirmDto downloadConfirmDto, int operationIndex = 0,
            CancellationToken cancellationToken = default);

        /// <summary>
        ///     Ожидать загрузку документа в банк (для систем партнеров)
        /// </summary>
        /// <remarks>
        ///     Ожидать загрузку документа в банк (для систем партнеров)
        /// </remarks>
        /// <exception cref="Multibanking.GuaranteeClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestId">Идентификатор запроса</param>
        /// <param name="xIBMClientID">Заголовок запроса, содержащий client_id партнера</param>
        /// <param name="uploadExpect">Запрос на подтверждение загрузки документа из банка</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of void</returns>
        Task ExpectUploadAsync(int requestId, string xIBMClientID, UploadExpect uploadExpect, int operationIndex = 0, CancellationToken cancellationToken = default);

        /// <summary>
        ///     Ожидать загрузку документа в банк (для систем партнеров)
        /// </summary>
        /// <remarks>
        ///     Ожидать загрузку документа в банк (для систем партнеров)
        /// </remarks>
        /// <exception cref="Multibanking.GuaranteeClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestId">Идентификатор запроса</param>
        /// <param name="xIBMClientID">Заголовок запроса, содержащий client_id партнера</param>
        /// <param name="uploadExpect">Запрос на подтверждение загрузки документа из банка</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse</returns>
        Task<ApiResponse<object>> ExpectUploadWithHttpInfoAsync(int requestId, string xIBMClientID, UploadExpect uploadExpect, int operationIndex = 0,
            CancellationToken cancellationToken = default);

        /// <summary>
        ///     Получение информации по загрузке документов заявки
        /// </summary>
        /// <remarks>
        ///     Получение информации по загрузке документов заявки
        /// </remarks>
        /// <exception cref="Multibanking.GuaranteeClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="orderId">Идентификатор заявки</param>
        /// <param name="xIBMClientID">Заголовок запроса, содержащий client_id партнера</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApplicationDetailsResponseDto</returns>
        Task<ApplicationDetailsResponseDto> GetApplicationDetailsAsync(string orderId, string xIBMClientID, int operationIndex = 0, CancellationToken cancellationToken = default);

        /// <summary>
        ///     Получение информации по загрузке документов заявки
        /// </summary>
        /// <remarks>
        ///     Получение информации по загрузке документов заявки
        /// </remarks>
        /// <exception cref="Multibanking.GuaranteeClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="orderId">Идентификатор заявки</param>
        /// <param name="xIBMClientID">Заголовок запроса, содержащий client_id партнера</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (ApplicationDetailsResponseDto)</returns>
        Task<ApiResponse<ApplicationDetailsResponseDto>> GetApplicationDetailsWithHttpInfoAsync(string orderId, string xIBMClientID, int operationIndex = 0,
            CancellationToken cancellationToken = default);

        /// <summary>
        ///     Запросить загрузку документа из банка
        /// </summary>
        /// <remarks>
        ///     Запросить загрузку документа из банка
        /// </remarks>
        /// <exception cref="Multibanking.GuaranteeClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="xIBMClientID">Заголовок запроса, содержащий client_id партнера</param>
        /// <param name="downloadRequestDto">Запрос на передачу документа</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of DocumentDownloadDto</returns>
        Task<DocumentDownloadDto> RequestDownloadAsync(string xIBMClientID, DownloadRequestDto downloadRequestDto, int operationIndex = 0,
            CancellationToken cancellationToken = default);

        /// <summary>
        ///     Запросить загрузку документа из банка
        /// </summary>
        /// <remarks>
        ///     Запросить загрузку документа из банка
        /// </remarks>
        /// <exception cref="Multibanking.GuaranteeClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="xIBMClientID">Заголовок запроса, содержащий client_id партнера</param>
        /// <param name="downloadRequestDto">Запрос на передачу документа</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (DocumentDownloadDto)</returns>
        Task<ApiResponse<DocumentDownloadDto>> RequestDownloadWithHttpInfoAsync(string xIBMClientID, DownloadRequestDto downloadRequestDto, int operationIndex = 0,
            CancellationToken cancellationToken = default);

        #endregion Asynchronous Operations
    }
}