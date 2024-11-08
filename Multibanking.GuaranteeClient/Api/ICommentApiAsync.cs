using System.Threading;
using System.Threading.Tasks;
using Multibanking.GuaranteeClient.Client;
using Multibanking.GuaranteeClient.Model;

namespace Multibanking.GuaranteeClient.Api
{
    /// <summary>
    ///     Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ICommentApiAsync : IApiAccessor
    {
        #region Asynchronous Operations

        /// <summary>
        ///     Отправка комментария в рамках чата
        /// </summary>
        /// <remarks>
        ///     Отправка комментария в рамках чата
        /// </remarks>
        /// <exception cref="Multibanking.GuaranteeClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="orderId">Идентификатор заявки</param>
        /// <param name="xIBMClientID">Заголовок запроса, содержащий client_id партнера</param>
        /// <param name="clientCommentDto">Данные о комментарии и документе в рамках чата с клиентом</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of void</returns>
        Task CreateCommentAsync(string orderId, string xIBMClientID, ClientCommentDto clientCommentDto, int operationIndex = 0, CancellationToken cancellationToken = default);

        /// <summary>
        ///     Отправка комментария в рамках чата
        /// </summary>
        /// <remarks>
        ///     Отправка комментария в рамках чата
        /// </remarks>
        /// <exception cref="Multibanking.GuaranteeClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="orderId">Идентификатор заявки</param>
        /// <param name="xIBMClientID">Заголовок запроса, содержащий client_id партнера</param>
        /// <param name="clientCommentDto">Данные о комментарии и документе в рамках чата с клиентом</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse</returns>
        Task<ApiResponse<object>> CreateCommentWithHttpInfoAsync(string orderId, string xIBMClientID, ClientCommentDto clientCommentDto, int operationIndex = 0,
            CancellationToken cancellationToken = default);

        /// <summary>
        ///     Получение информации по комментариям сотрудника к заявке
        /// </summary>
        /// <remarks>
        ///     Получение информации по комментариям сотрудника к заявке
        /// </remarks>
        /// <exception cref="Multibanking.GuaranteeClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="orderId">Идентификатор заявки</param>
        /// <param name="xIBMClientID">Заголовок запроса, содержащий client_id партнера</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of OrderIdCommentDto</returns>
        Task<OrderIdCommentDto> GetCommentsAsync(string orderId, string xIBMClientID, int operationIndex = 0, CancellationToken cancellationToken = default);

        /// <summary>
        ///     Получение информации по комментариям сотрудника к заявке
        /// </summary>
        /// <remarks>
        ///     Получение информации по комментариям сотрудника к заявке
        /// </remarks>
        /// <exception cref="Multibanking.GuaranteeClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="orderId">Идентификатор заявки</param>
        /// <param name="xIBMClientID">Заголовок запроса, содержащий client_id партнера</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (OrderIdCommentDto)</returns>
        Task<ApiResponse<OrderIdCommentDto>> GetCommentsWithHttpInfoAsync(string orderId, string xIBMClientID, int operationIndex = 0,
            CancellationToken cancellationToken = default);

        /// <summary>
        ///     Получение информации по прочитанным комментариям
        /// </summary>
        /// <remarks>
        ///     Получение информации по прочитанным комментариям
        /// </remarks>
        /// <exception cref="Multibanking.GuaranteeClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="xIBMClientID">Заголовок запроса, содержащий client_id партнера</param>
        /// <param name="markReadCommentDto">Список идентификаторов комментариев</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of void</returns>
        Task MarkReadAsync(string xIBMClientID, MarkReadCommentDto markReadCommentDto, int operationIndex = 0, CancellationToken cancellationToken = default);

        /// <summary>
        ///     Получение информации по прочитанным комментариям
        /// </summary>
        /// <remarks>
        ///     Получение информации по прочитанным комментариям
        /// </remarks>
        /// <exception cref="Multibanking.GuaranteeClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="xIBMClientID">Заголовок запроса, содержащий client_id партнера</param>
        /// <param name="markReadCommentDto">Список идентификаторов комментариев</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse</returns>
        Task<ApiResponse<object>> MarkReadWithHttpInfoAsync(string xIBMClientID, MarkReadCommentDto markReadCommentDto, int operationIndex = 0,
            CancellationToken cancellationToken = default);

        #endregion Asynchronous Operations
    }
}