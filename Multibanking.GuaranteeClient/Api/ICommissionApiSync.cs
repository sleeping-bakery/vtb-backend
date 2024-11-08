using Multibanking.GuaranteeClient.Client;
using Multibanking.GuaranteeClient.Model;

namespace Multibanking.GuaranteeClient.Api
{
    /// <summary>
    ///     Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ICommissionApiSync : IApiAccessor
    {
        #region Synchronous Operations

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
        /// <returns>CommissionResponseDto</returns>
        CommissionResponseDto PrecalculateCommission(string xIBMClientID, CommissionRequest commissionRequest, int operationIndex = 0);

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
        /// <returns>ApiResponse of CommissionResponseDto</returns>
        ApiResponse<CommissionResponseDto> PrecalculateCommissionWithHttpInfo(string xIBMClientID, CommissionRequest commissionRequest, int operationIndex = 0);

        #endregion Synchronous Operations
    }
}