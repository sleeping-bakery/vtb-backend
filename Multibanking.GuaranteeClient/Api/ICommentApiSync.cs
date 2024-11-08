using Multibanking.GuaranteeClient.Client;
using Multibanking.GuaranteeClient.Model;

namespace Multibanking.GuaranteeClient.Api
{
    /// <summary>
    ///     Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ICommentApiSync : IApiAccessor
    {
        #region Synchronous Operations

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
        /// <returns></returns>
        void CreateComment(string orderId, string xIBMClientID, ClientCommentDto clientCommentDto, int operationIndex = 0);

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
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<object> CreateCommentWithHttpInfo(string orderId, string xIBMClientID, ClientCommentDto clientCommentDto, int operationIndex = 0);

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
        /// <returns>OrderIdCommentDto</returns>
        OrderIdCommentDto GetComments(string orderId, string xIBMClientID, int operationIndex = 0);

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
        /// <returns>ApiResponse of OrderIdCommentDto</returns>
        ApiResponse<OrderIdCommentDto> GetCommentsWithHttpInfo(string orderId, string xIBMClientID, int operationIndex = 0);

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
        /// <returns></returns>
        void MarkRead(string xIBMClientID, MarkReadCommentDto markReadCommentDto, int operationIndex = 0);

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
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<object> MarkReadWithHttpInfo(string xIBMClientID, MarkReadCommentDto markReadCommentDto, int operationIndex = 0);

        #endregion Synchronous Operations
    }
}