using Multibanking.GuaranteeClient.Client;
using Multibanking.GuaranteeClient.Model;

namespace Multibanking.GuaranteeClient.Api
{
    /// <summary>
    ///     Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IDocumentApiSync : IApiAccessor
    {
        #region Synchronous Operations

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
        /// <returns></returns>
        void ConfirmDownload(string xIBMClientID, DownloadConfirmDto downloadConfirmDto, int operationIndex = 0);

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
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<object> ConfirmDownloadWithHttpInfo(string xIBMClientID, DownloadConfirmDto downloadConfirmDto, int operationIndex = 0);

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
        /// <returns></returns>
        void ExpectUpload(int requestId, string xIBMClientID, UploadExpect uploadExpect, int operationIndex = 0);

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
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<object> ExpectUploadWithHttpInfo(int requestId, string xIBMClientID, UploadExpect uploadExpect, int operationIndex = 0);

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
        /// <returns>ApplicationDetailsResponseDto</returns>
        ApplicationDetailsResponseDto GetApplicationDetails(string orderId, string xIBMClientID, int operationIndex = 0);

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
        /// <returns>ApiResponse of ApplicationDetailsResponseDto</returns>
        ApiResponse<ApplicationDetailsResponseDto> GetApplicationDetailsWithHttpInfo(string orderId, string xIBMClientID, int operationIndex = 0);

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
        /// <returns>DocumentDownloadDto</returns>
        DocumentDownloadDto RequestDownload(string xIBMClientID, DownloadRequestDto downloadRequestDto, int operationIndex = 0);

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
        /// <returns>ApiResponse of DocumentDownloadDto</returns>
        ApiResponse<DocumentDownloadDto> RequestDownloadWithHttpInfo(string xIBMClientID, DownloadRequestDto downloadRequestDto, int operationIndex = 0);

        #endregion Synchronous Operations
    }
}