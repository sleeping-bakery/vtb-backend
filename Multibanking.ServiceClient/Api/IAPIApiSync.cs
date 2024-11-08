using Multibanking.ServiceClient.Client;
using Multibanking.ServiceClient.Model;

namespace Multibanking.ServiceClient.Api;

/// <summary>
///     Represents a collection of functions to interact with the API endpoints
/// </summary>
public interface IAPIApiSync : IApiAccessor
{
    #region Synchronous Operations

    /// <summary>
    ///     Поиск услуг ПУ
    /// </summary>
    /// <remarks>
    ///     Поиск услуг по фильтрам
    /// </remarks>
    /// <exception cref="Multibanking.ServiceClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="X_UNC">УНК (optional)</param>
    /// <param name="clientUnc">УНК (optional)</param>
    /// <param name="X_CLIENT_CHANNEL">Идентификатор канала клиента (optional)</param>
    /// <param name="X_LOGIN_MODE">Режим входа клиента (optional)</param>
    /// <param name="X_ROLES">Роли клиента (optional)</param>
    /// <param name="X_PARTNER_ID">Идентификатор партнера (optional)</param>
    /// <param name="categoryId">Фильтр по категории (optional)</param>
    /// <param name="regionId">Фильтр по региону (optional)</param>
    /// <param name="filter">Фильтр по наименованию или ИНН (optional)</param>
    /// <param name="subTypes">Фильтр по подтипам (optional)</param>
    /// <param name="actions">
    ///     Фильтр по поддерживаемым действиям услуги, возможные действия - PAYMENT, TEMPLATE, AUTOPAYMENT_BY_DATE, AUTOPAYMENT_BY_BALANCE, INVOICE, REPEAT, REMIND,
    ///     SUBSCRIPTION (optional)
    /// </param>
    /// <param name="pageNumber">Номер страницы результата (страницы нумеруются с 0) (optional)</param>
    /// <param name="pageSize">Размер страницы результата (optional)</param>
    /// <param name="operationIndex">Index associated with the operation.</param>
    /// <returns>PageDtoRsServiceProviderSearchDtoRs</returns>
    PageDtoRsServiceProviderSearchDtoRs FindOperations(string X_UNC = default, string clientUnc = default, string X_CLIENT_CHANNEL = default, string X_LOGIN_MODE = default,
        string X_ROLES = default, string X_PARTNER_ID = default, string categoryId = default, string regionId = default, string filter = default, string subTypes = default,
        string actions = default, string pageNumber = default, string pageSize = default, int operationIndex = 0);

    /// <summary>
    ///     Поиск услуг ПУ
    /// </summary>
    /// <remarks>
    ///     Поиск услуг по фильтрам
    /// </remarks>
    /// <exception cref="Multibanking.ServiceClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="X_UNC">УНК (optional)</param>
    /// <param name="clientUnc">УНК (optional)</param>
    /// <param name="X_CLIENT_CHANNEL">Идентификатор канала клиента (optional)</param>
    /// <param name="X_LOGIN_MODE">Режим входа клиента (optional)</param>
    /// <param name="X_ROLES">Роли клиента (optional)</param>
    /// <param name="X_PARTNER_ID">Идентификатор партнера (optional)</param>
    /// <param name="categoryId">Фильтр по категории (optional)</param>
    /// <param name="regionId">Фильтр по региону (optional)</param>
    /// <param name="filter">Фильтр по наименованию или ИНН (optional)</param>
    /// <param name="subTypes">Фильтр по подтипам (optional)</param>
    /// <param name="actions">
    ///     Фильтр по поддерживаемым действиям услуги, возможные действия - PAYMENT, TEMPLATE, AUTOPAYMENT_BY_DATE, AUTOPAYMENT_BY_BALANCE, INVOICE, REPEAT, REMIND,
    ///     SUBSCRIPTION (optional)
    /// </param>
    /// <param name="pageNumber">Номер страницы результата (страницы нумеруются с 0) (optional)</param>
    /// <param name="pageSize">Размер страницы результата (optional)</param>
    /// <param name="operationIndex">Index associated with the operation.</param>
    /// <returns>ApiResponse of PageDtoRsServiceProviderSearchDtoRs</returns>
    ApiResponse<PageDtoRsServiceProviderSearchDtoRs> FindOperationsWithHttpInfo(string X_UNC = default, string clientUnc = default, string X_CLIENT_CHANNEL = default,
        string X_LOGIN_MODE = default, string X_ROLES = default, string X_PARTNER_ID = default, string categoryId = default, string regionId = default, string filter = default,
        string subTypes = default, string actions = default, string pageNumber = default, string pageSize = default, int operationIndex = 0);

    /// <summary>
    ///     Получение услуг ПУ по списку ID
    /// </summary>
    /// <remarks>
    ///     Получение договорных (serviceType &#x3D; CONTRACT) услуг ПУ по списку идентфикаторов
    /// </remarks>
    /// <exception cref="Multibanking.ServiceClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="ids">Список идентификаторов услуг (через \&quot;,\&quot;)</param>
    /// <param name="operationIndex">Index associated with the operation.</param>
    /// <returns>PageDtoRsServiceProviderDetailDtoRs</returns>
    PageDtoRsServiceProviderDetailDtoRs FindOperations1(string ids, int operationIndex = 0);

    /// <summary>
    ///     Получение услуг ПУ по списку ID
    /// </summary>
    /// <remarks>
    ///     Получение договорных (serviceType &#x3D; CONTRACT) услуг ПУ по списку идентфикаторов
    /// </remarks>
    /// <exception cref="Multibanking.ServiceClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="ids">Список идентификаторов услуг (через \&quot;,\&quot;)</param>
    /// <param name="operationIndex">Index associated with the operation.</param>
    /// <returns>ApiResponse of PageDtoRsServiceProviderDetailDtoRs</returns>
    ApiResponse<PageDtoRsServiceProviderDetailDtoRs> FindOperations1WithHttpInfo(string ids, int operationIndex = 0);

    /// <summary>
    ///     Получение доступных категорий услуг ПУ
    /// </summary>
    /// <remarks>
    ///     Получение доступных категорий услуг ПУ
    /// </remarks>
    /// <exception cref="Multibanking.ServiceClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="X_UNC">УНК (optional)</param>
    /// <param name="clientUnc">УНК (optional)</param>
    /// <param name="X_CLIENT_CHANNEL">Идентификатор канала клиента (optional)</param>
    /// <param name="X_LOGIN_MODE">Режим входа клиента (optional)</param>
    /// <param name="X_ROLES">Роли клиента (optional)</param>
    /// <param name="X_PARTNER_ID">Идентификатор партнера (optional)</param>
    /// <param name="operationPageSize">Количество услуг для каждой категории (optional, default to 0)</param>
    /// <param name="regionId">Регион пользователя для формирования услуг ПУ в категориях (optional)</param>
    /// <param name="operationIndex">Index associated with the operation.</param>
    /// <returns>PageDtoRsCategoryDtoRs</returns>
    PageDtoRsCategoryDtoRs GetCategories(string X_UNC = default, string clientUnc = default, string X_CLIENT_CHANNEL = default, string X_LOGIN_MODE = default,
        string X_ROLES = default, string X_PARTNER_ID = default, int? operationPageSize = default, string regionId = default, int operationIndex = 0);

    /// <summary>
    ///     Получение доступных категорий услуг ПУ
    /// </summary>
    /// <remarks>
    ///     Получение доступных категорий услуг ПУ
    /// </remarks>
    /// <exception cref="Multibanking.ServiceClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="X_UNC">УНК (optional)</param>
    /// <param name="clientUnc">УНК (optional)</param>
    /// <param name="X_CLIENT_CHANNEL">Идентификатор канала клиента (optional)</param>
    /// <param name="X_LOGIN_MODE">Режим входа клиента (optional)</param>
    /// <param name="X_ROLES">Роли клиента (optional)</param>
    /// <param name="X_PARTNER_ID">Идентификатор партнера (optional)</param>
    /// <param name="operationPageSize">Количество услуг для каждой категории (optional, default to 0)</param>
    /// <param name="regionId">Регион пользователя для формирования услуг ПУ в категориях (optional)</param>
    /// <param name="operationIndex">Index associated with the operation.</param>
    /// <returns>ApiResponse of PageDtoRsCategoryDtoRs</returns>
    ApiResponse<PageDtoRsCategoryDtoRs> GetCategoriesWithHttpInfo(string X_UNC = default, string clientUnc = default, string X_CLIENT_CHANNEL = default,
        string X_LOGIN_MODE = default, string X_ROLES = default, string X_PARTNER_ID = default, int? operationPageSize = default, string regionId = default,
        int operationIndex = 0);

    /// <summary>
    ///     Получение услуги ПУ по ID
    /// </summary>
    /// <remarks>
    ///     Получение договорной (serviceType &#x3D; CONTRACT) услуги ПУ по идентификатору
    /// </remarks>
    /// <exception cref="Multibanking.ServiceClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="id">Идентификатор услуги</param>
    /// <param name="operationIndex">Index associated with the operation.</param>
    /// <returns>ServiceProviderDetailDtoRs</returns>
    ServiceProviderDetailDtoRs GetOperation(string id, int operationIndex = 0);

    /// <summary>
    ///     Получение услуги ПУ по ID
    /// </summary>
    /// <remarks>
    ///     Получение договорной (serviceType &#x3D; CONTRACT) услуги ПУ по идентификатору
    /// </remarks>
    /// <exception cref="Multibanking.ServiceClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="id">Идентификатор услуги</param>
    /// <param name="operationIndex">Index associated with the operation.</param>
    /// <returns>ApiResponse of ServiceProviderDetailDtoRs</returns>
    ApiResponse<ServiceProviderDetailDtoRs> GetOperationWithHttpInfo(string id, int operationIndex = 0);

    #endregion Synchronous Operations
}