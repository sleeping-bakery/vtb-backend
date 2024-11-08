using Multibanking.GuaranteeClient.Client;
using Multibanking.GuaranteeClient.Model;

namespace Multibanking.GuaranteeClient.Api
{
    /// <summary>
    ///     Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IOrderApiSync : IApiAccessor
    {
        #region Synchronous Operations

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
        /// <returns></returns>
        void AppendDocuments(string orderId, string xIBMClientID, DocumentsAppendRequestDto documentsAppendRequestDto, int operationIndex = 0);

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
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<object> AppendDocumentsWithHttpInfo(string orderId, string xIBMClientID, DocumentsAppendRequestDto documentsAppendRequestDto, int operationIndex = 0);

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
        /// <returns>OrderResponse</returns>
        OrderResponse CreateOrder(string xIBMClientID, Order order, int operationIndex = 0);

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
        /// <returns>ApiResponse of OrderResponse</returns>
        ApiResponse<OrderResponse> CreateOrderWithHttpInfo(string xIBMClientID, Order order, int operationIndex = 0);

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
        /// <returns></returns>
        void DeclineByClient(string orderId, string xIBMClientID, DeclineOrderDto declineOrderDto, int operationIndex = 0);

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
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<object> DeclineByClientWithHttpInfo(string orderId, string xIBMClientID, DeclineOrderDto declineOrderDto, int operationIndex = 0);

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
        /// <returns>OrderStatus</returns>
        OrderStatus GetOrder(string orderId, string xIBMClientID, int operationIndex = 0);

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
        /// <returns>ApiResponse of OrderStatus</returns>
        ApiResponse<OrderStatus> GetOrderWithHttpInfo(string orderId, string xIBMClientID, int operationIndex = 0);

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
        /// <returns>DiscountResponse</returns>
        DiscountResponse RequestDiscount(string orderId, string xIBMClientID, DiscountRequestDto discountRequestDto, int operationIndex = 0);

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
        /// <returns>ApiResponse of DiscountResponse</returns>
        ApiResponse<DiscountResponse> RequestDiscountWithHttpInfo(string orderId, string xIBMClientID, DiscountRequestDto discountRequestDto, int operationIndex = 0);

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
        /// <returns></returns>
        void SendComment(string orderId, string xIBMClientID, CommentDto commentDto, int operationIndex = 0);

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
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<object> SendCommentWithHttpInfo(string orderId, string xIBMClientID, CommentDto commentDto, int operationIndex = 0);

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
        /// <returns></returns>
        void SignOffer(string orderId, string xIBMClientID, OfferDto offerDto, int operationIndex = 0);

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
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<object> SignOfferWithHttpInfo(string orderId, string xIBMClientID, OfferDto offerDto, int operationIndex = 0);

        #endregion Synchronous Operations
    }
}