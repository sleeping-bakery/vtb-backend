using Multibanking.BonusPointClient.Client;
using Multibanking.BonusPointClient.Model;

namespace Multibanking.BonusPointClient.Api;

/// <summary>
///     Represents a collection of functions to interact with the API endpoints
/// </summary>
public interface IDefaultApiSync : IApiAccessor
{
    #region Synchronous Operations

    /// <summary>
    ///     Получить текущий баланс наград для указанного аккаунта и атрибутов программы, настроенных для конкретного партнера
    /// </summary>
    /// <remarks>
    ///     Получить текущий баланс наград для данного аккаунта.
    /// </remarks>
    /// <exception cref="Multibanking.BonusPointClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="authorization">TIAA-US External token</param>
    /// <param name="externalAccountID">Уникальный идентификатор (аналог UUID), созданный для каждой учетной записи клиента.</param>
    /// <param name="correlationID">
    ///     Уникальный идентификатор для каждого входящего запроса. Вызывающий API должен передать это в заголовке, который будет каскадно передан через стек
    ///     вызовов API. Это необходимо для обеспечения соответствия текущим стандартам REST.
    /// </param>
    /// <param name="xCallerId">Идентификатор внешнего объекта, инициирующего вызов. Устанавливается внешним шлюзом API и передается через стек API. (optional)</param>
    /// <param name="operationIndex">Index associated with the operation.</param>
    /// <returns>RewardBalanceDataV2</returns>
    RewardBalanceDataV2 GetRewardsBalance(string authorization, string externalAccountID, string correlationID, string xCallerId = default, int operationIndex = 0);

    /// <summary>
    ///     Получить текущий баланс наград для указанного аккаунта и атрибутов программы, настроенных для конкретного партнера
    /// </summary>
    /// <remarks>
    ///     Получить текущий баланс наград для данного аккаунта.
    /// </remarks>
    /// <exception cref="Multibanking.BonusPointClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="authorization">TIAA-US External token</param>
    /// <param name="externalAccountID">Уникальный идентификатор (аналог UUID), созданный для каждой учетной записи клиента.</param>
    /// <param name="correlationID">
    ///     Уникальный идентификатор для каждого входящего запроса. Вызывающий API должен передать это в заголовке, который будет каскадно передан через стек
    ///     вызовов API. Это необходимо для обеспечения соответствия текущим стандартам REST.
    /// </param>
    /// <param name="xCallerId">Идентификатор внешнего объекта, инициирующего вызов. Устанавливается внешним шлюзом API и передается через стек API. (optional)</param>
    /// <param name="operationIndex">Index associated with the operation.</param>
    /// <returns>ApiResponse of RewardBalanceDataV2</returns>
    ApiResponse<RewardBalanceDataV2> GetRewardsBalanceWithHttpInfo(string authorization, string externalAccountID, string correlationID, string xCallerId = default,
        int operationIndex = 0);

    /// <summary>
    ///     Выполните выписку по кредиту для данного аккаунта и соответствующих атрибутов программы.
    /// </summary>
    /// <remarks>
    ///     Списывает вознаграждение с данного счета и публикует выписку по кредиту. Возвращает идентификатор погашения для отслеживания.
    /// </remarks>
    /// <exception cref="Multibanking.BonusPointClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="authorization">TIAA-US External token</param>
    /// <param name="contentType">Content-Type</param>
    /// <param name="externalAccountID">Уникальный идентификатор (аналог UUID), созданный для каждой учетной записи клиента.</param>
    /// <param name="correlationID">
    ///     Уникальный идентификатор для каждого входящего запроса. Вызывающий API должен передать это в заголовке, который будет каскадно передан через стек
    ///     вызовов API. Это необходимо для обеспечения соответствия текущим стандартам REST.
    /// </param>
    /// <param name="redemptionRequestDataV2">Содержит информацию, необходимую для операции погашения.</param>
    /// <param name="xCallerId">Идентификатор внешнего объекта, инициирующего вызов. Устанавливается внешним шлюзом API и передается через стек API. (optional)</param>
    /// <param name="operationIndex">Index associated with the operation.</param>
    /// <returns>RedemptionResponseDataV2</returns>
    RedemptionResponseDataV2 ProcessRedemption(string authorization, string contentType, string externalAccountID, string correlationID,
        RedemptionRequestDataV2 redemptionRequestDataV2, string xCallerId = default, int operationIndex = 0);

    /// <summary>
    ///     Выполните выписку по кредиту для данного аккаунта и соответствующих атрибутов программы.
    /// </summary>
    /// <remarks>
    ///     Списывает вознаграждение с данного счета и публикует выписку по кредиту. Возвращает идентификатор погашения для отслеживания.
    /// </remarks>
    /// <exception cref="Multibanking.BonusPointClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="authorization">TIAA-US External token</param>
    /// <param name="contentType">Content-Type</param>
    /// <param name="externalAccountID">Уникальный идентификатор (аналог UUID), созданный для каждой учетной записи клиента.</param>
    /// <param name="correlationID">
    ///     Уникальный идентификатор для каждого входящего запроса. Вызывающий API должен передать это в заголовке, который будет каскадно передан через стек
    ///     вызовов API. Это необходимо для обеспечения соответствия текущим стандартам REST.
    /// </param>
    /// <param name="redemptionRequestDataV2">Содержит информацию, необходимую для операции погашения.</param>
    /// <param name="xCallerId">Идентификатор внешнего объекта, инициирующего вызов. Устанавливается внешним шлюзом API и передается через стек API. (optional)</param>
    /// <param name="operationIndex">Index associated with the operation.</param>
    /// <returns>ApiResponse of RedemptionResponseDataV2</returns>
    ApiResponse<RedemptionResponseDataV2> ProcessRedemptionWithHttpInfo(string authorization, string contentType, string externalAccountID, string correlationID,
        RedemptionRequestDataV2 redemptionRequestDataV2, string xCallerId = default, int operationIndex = 0);

    #endregion Synchronous Operations
}