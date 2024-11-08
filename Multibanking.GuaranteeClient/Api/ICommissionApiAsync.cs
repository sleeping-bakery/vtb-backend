using System.Threading;
using System.Threading.Tasks;
using Multibanking.GuaranteeClient.Client;
using Multibanking.GuaranteeClient.Model;

namespace Multibanking.GuaranteeClient.Api
{
    /// <summary>
    ///     Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ICommissionApiAsync : IApiAccessor
    {
        #region Asynchronous Operations

        /// <summary>
        ///     Получить предварительный расчет комиссии
        /// </summary>
        /// <remarks>
        ///     Получить предварительный расчет комиссии
        /// </remarks>
        /// <exception cref="Multibanking.GuaranteeClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="xIBMClientID">Заголовок запроса, содержащий client_id партнера</param>
        /// <param name="commissionRequest">Информация о комиссии</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of CommissionResponseDto</returns>
        Task<CommissionResponseDto> PrecalculateCommissionAsync(string xIBMClientID, CommissionRequest commissionRequest, int operationIndex = 0,
            CancellationToken cancellationToken = default);

        /// <summary>
        ///     Получить предварительный расчет комиссии
        /// </summary>
        /// <remarks>
        ///     Получить предварительный расчет комиссии
        /// </remarks>
        /// <exception cref="Multibanking.GuaranteeClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="xIBMClientID">Заголовок запроса, содержащий client_id партнера</param>
        /// <param name="commissionRequest">Информация о комиссии</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (CommissionResponseDto)</returns>
        Task<ApiResponse<CommissionResponseDto>> PrecalculateCommissionWithHttpInfoAsync(string xIBMClientID, CommissionRequest commissionRequest, int operationIndex = 0,
            CancellationToken cancellationToken = default);

        #endregion Asynchronous Operations
    }
}