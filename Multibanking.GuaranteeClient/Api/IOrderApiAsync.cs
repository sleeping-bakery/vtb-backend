using System.Threading;
using System.Threading.Tasks;
using Multibanking.GuaranteeClient.Client;
using Multibanking.GuaranteeClient.Model;

namespace Multibanking.GuaranteeClient.Api
{
    /// <summary>
    ///     Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IOrderApiAsync : IApiAccessor
    {
        #region Asynchronous Operations

        /// <summary>
        ///     Загрузка документов и перевод заявки на предыдущий статус
        /// </summary>
        /// <remarks>
        ///     Загрузка документов и перевод заявки на предыдущий статус
        /// </remarks>
        /// <exception cref="Multibanking.GuaranteeClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="orderId">Идентификатор заявки</param>
        /// <param name="xIBMClientID">Заголовок запроса, содержащий client_id партнера</param>
        /// <param name="documentsAppendRequestDto">ДТО для прикрепления списка документов по заявке</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of void</returns>
        Task AppendDocumentsAsync(string orderId, string xIBMClientID, DocumentsAppendRequestDto documentsAppendRequestDto, int operationIndex = 0,
            CancellationToken cancellationToken = default);

        /// <summary>
        ///     Загрузка документов и перевод заявки на предыдущий статус
        /// </summary>
        /// <remarks>
        ///     Загрузка документов и перевод заявки на предыдущий статус
        /// </remarks>
        /// <exception cref="Multibanking.GuaranteeClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="orderId">Идентификатор заявки</param>
        /// <param name="xIBMClientID">Заголовок запроса, содержащий client_id партнера</param>
        /// <param name="documentsAppendRequestDto">ДТО для прикрепления списка документов по заявке</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse</returns>
        Task<ApiResponse<object>> AppendDocumentsWithHttpInfoAsync(string orderId, string xIBMClientID, DocumentsAppendRequestDto documentsAppendRequestDto, int operationIndex = 0,
            CancellationToken cancellationToken = default);

        /// <summary>
        ///     Создать заявку
        /// </summary>
        /// <remarks>
        ///     Создать заявку
        /// </remarks>
        /// <exception cref="Multibanking.GuaranteeClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="xIBMClientID">Заголовок запроса, содержащий client_id партнера</param>
        /// <param name="order">Заявка</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of OrderResponse</returns>
        Task<OrderResponse> CreateOrderAsync(string xIBMClientID, Order order, int operationIndex = 0, CancellationToken cancellationToken = default);

        /// <summary>
        ///     Создать заявку
        /// </summary>
        /// <remarks>
        ///     Создать заявку
        /// </remarks>
        /// <exception cref="Multibanking.GuaranteeClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="xIBMClientID">Заголовок запроса, содержащий client_id партнера</param>
        /// <param name="order">Заявка</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (OrderResponse)</returns>
        Task<ApiResponse<OrderResponse>> CreateOrderWithHttpInfoAsync(string xIBMClientID, Order order, int operationIndex = 0, CancellationToken cancellationToken = default);

        /// <summary>
        ///     Отказ клиента от заявки
        /// </summary>
        /// <remarks>
        ///     Отказ клиента от заявки
        /// </remarks>
        /// <exception cref="Multibanking.GuaranteeClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="orderId">Идентификатор заявки</param>
        /// <param name="xIBMClientID">Заголовок запроса, содержащий client_id партнера</param>
        /// <param name="declineOrderDto">DTO с данными на отказ клиента от заявки</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of void</returns>
        Task DeclineByClientAsync(string orderId, string xIBMClientID, DeclineOrderDto declineOrderDto, int operationIndex = 0, CancellationToken cancellationToken = default);

        /// <summary>
        ///     Отказ клиента от заявки
        /// </summary>
        /// <remarks>
        ///     Отказ клиента от заявки
        /// </remarks>
        /// <exception cref="Multibanking.GuaranteeClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="orderId">Идентификатор заявки</param>
        /// <param name="xIBMClientID">Заголовок запроса, содержащий client_id партнера</param>
        /// <param name="declineOrderDto">DTO с данными на отказ клиента от заявки</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse</returns>
        Task<ApiResponse<object>> DeclineByClientWithHttpInfoAsync(string orderId, string xIBMClientID, DeclineOrderDto declineOrderDto, int operationIndex = 0,
            CancellationToken cancellationToken = default);

        /// <summary>
        ///     Получить статус заявки
        /// </summary>
        /// <remarks>
        ///     Получить статус заявки
        /// </remarks>
        /// <exception cref="Multibanking.GuaranteeClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="orderId">Идентификатор заявки</param>
        /// <param name="xIBMClientID">Заголовок запроса, содержащий client_id партнера</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of OrderStatus</returns>
        Task<OrderStatus> GetOrderAsync(string orderId, string xIBMClientID, int operationIndex = 0, CancellationToken cancellationToken = default);

        /// <summary>
        ///     Получить статус заявки
        /// </summary>
        /// <remarks>
        ///     Получить статус заявки
        /// </remarks>
        /// <exception cref="Multibanking.GuaranteeClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="orderId">Идентификатор заявки</param>
        /// <param name="xIBMClientID">Заголовок запроса, содержащий client_id партнера</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (OrderStatus)</returns>
        Task<ApiResponse<OrderStatus>> GetOrderWithHttpInfoAsync(string orderId, string xIBMClientID, int operationIndex = 0, CancellationToken cancellationToken = default);

        /// <summary>
        ///     Запрос скидки к ранее одобренной заявке на банковскую гарантию
        /// </summary>
        /// <remarks>
        ///     Запрос скидки к ранее одобренной заявке на банковскую гарантию
        /// </remarks>
        /// <exception cref="Multibanking.GuaranteeClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="orderId">Идентификатор заявки</param>
        /// <param name="xIBMClientID">Заголовок запроса, содержащий client_id партнера</param>
        /// <param name="discountRequestDto">ДТО для запроса скидки</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of DiscountResponse</returns>
        Task<DiscountResponse> RequestDiscountAsync(string orderId, string xIBMClientID, DiscountRequestDto discountRequestDto, int operationIndex = 0,
            CancellationToken cancellationToken = default);

        /// <summary>
        ///     Запрос скидки к ранее одобренной заявке на банковскую гарантию
        /// </summary>
        /// <remarks>
        ///     Запрос скидки к ранее одобренной заявке на банковскую гарантию
        /// </remarks>
        /// <exception cref="Multibanking.GuaranteeClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="orderId">Идентификатор заявки</param>
        /// <param name="xIBMClientID">Заголовок запроса, содержащий client_id партнера</param>
        /// <param name="discountRequestDto">ДТО для запроса скидки</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (DiscountResponse)</returns>
        Task<ApiResponse<DiscountResponse>> RequestDiscountWithHttpInfoAsync(string orderId, string xIBMClientID, DiscountRequestDto discountRequestDto, int operationIndex = 0,
            CancellationToken cancellationToken = default);

        /// <summary>
        ///     Отправка комментария
        /// </summary>
        /// <remarks>
        ///     Отправка комментария
        /// </remarks>
        /// <exception cref="Multibanking.GuaranteeClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="orderId">Идентификатор заявки</param>
        /// <param name="xIBMClientID">Заголовок запроса, содержащий client_id партнера</param>
        /// <param name="commentDto">DTO с текстовым комментарием, с сылкой на документ от клиента с правками/замечаниями</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of void</returns>
        Task SendCommentAsync(string orderId, string xIBMClientID, CommentDto commentDto, int operationIndex = 0, CancellationToken cancellationToken = default);

        /// <summary>
        ///     Отправка комментария
        /// </summary>
        /// <remarks>
        ///     Отправка комментария
        /// </remarks>
        /// <exception cref="Multibanking.GuaranteeClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="orderId">Идентификатор заявки</param>
        /// <param name="xIBMClientID">Заголовок запроса, содержащий client_id партнера</param>
        /// <param name="commentDto">DTO с текстовым комментарием, с сылкой на документ от клиента с правками/замечаниями</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse</returns>
        Task<ApiResponse<object>> SendCommentWithHttpInfoAsync(string orderId, string xIBMClientID, CommentDto commentDto, int operationIndex = 0,
            CancellationToken cancellationToken = default);

        /// <summary>
        ///     Передача подписанной клиентом оферты
        /// </summary>
        /// <remarks>
        ///     Передача подписанной клиентом оферты
        /// </remarks>
        /// <exception cref="Multibanking.GuaranteeClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="orderId">Идентификатор заявки</param>
        /// <param name="xIBMClientID">Заголовок запроса, содержащий client_id партнера</param>
        /// <param name="offerDto">Данные оферты</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of void</returns>
        Task SignOfferAsync(string orderId, string xIBMClientID, OfferDto offerDto, int operationIndex = 0, CancellationToken cancellationToken = default);

        /// <summary>
        ///     Передача подписанной клиентом оферты
        /// </summary>
        /// <remarks>
        ///     Передача подписанной клиентом оферты
        /// </remarks>
        /// <exception cref="Multibanking.GuaranteeClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="orderId">Идентификатор заявки</param>
        /// <param name="xIBMClientID">Заголовок запроса, содержащий client_id партнера</param>
        /// <param name="offerDto">Данные оферты</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse</returns>
        Task<ApiResponse<object>> SignOfferWithHttpInfoAsync(string orderId, string xIBMClientID, OfferDto offerDto, int operationIndex = 0,
            CancellationToken cancellationToken = default);

        #endregion Asynchronous Operations
    }
}