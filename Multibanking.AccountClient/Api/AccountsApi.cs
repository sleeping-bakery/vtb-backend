/*
 * Получение информации о счете клиента третьей стороной
 *
 * Содержит описываются API для Открытых банковских интерфейсов по счетам и транзакциям.
 *
 * The version of the OpenAPI document: 1.2.1
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Threading;
using System.Threading.Tasks;
using Multibanking.AccountClient.Client;
using Multibanking.AccountClient.Model;

namespace Multibanking.AccountClient.Api;

/// <summary>
///     Represents a collection of functions to interact with the API endpoints
/// </summary>
public class AccountsApi : IAccountsApi
{
    private ExceptionFactory _exceptionFactory = (name, response) => null;

    /// <summary>
    ///     Initializes a new instance of the <see cref="AccountsApi" /> class.
    /// </summary>
    /// <returns></returns>
    public AccountsApi() : this((string)null)
    {
    }

    /// <summary>
    ///     Initializes a new instance of the <see cref="AccountsApi" /> class.
    /// </summary>
    /// <returns></returns>
    public AccountsApi(string basePath)
    {
        Configuration = AccountClient.Client.Configuration.MergeConfigurations(
            GlobalConfiguration.Instance,
            new Configuration { BasePath = basePath }
        );
        Client = new ApiClient(Configuration.BasePath);
        AsynchronousClient = new ApiClient(Configuration.BasePath);
        ExceptionFactory = AccountClient.Client.Configuration.DefaultExceptionFactory;
    }

    /// <summary>
    ///     Initializes a new instance of the <see cref="AccountsApi" /> class
    ///     using Configuration object
    /// </summary>
    /// <param name="configuration">An instance of Configuration</param>
    /// <returns></returns>
    public AccountsApi(Configuration configuration)
    {
        if (configuration == null) throw new ArgumentNullException("configuration");

        Configuration = AccountClient.Client.Configuration.MergeConfigurations(
            GlobalConfiguration.Instance,
            configuration
        );
        Client = new ApiClient(Configuration.BasePath);
        AsynchronousClient = new ApiClient(Configuration.BasePath);
        ExceptionFactory = AccountClient.Client.Configuration.DefaultExceptionFactory;
    }

    /// <summary>
    ///     Initializes a new instance of the <see cref="AccountsApi" /> class
    ///     using a Configuration object and client instance.
    /// </summary>
    /// <param name="client">The client interface for synchronous API access.</param>
    /// <param name="asyncClient">The client interface for asynchronous API access.</param>
    /// <param name="configuration">The configuration object.</param>
    public AccountsApi(ISynchronousClient client, IAsynchronousClient asyncClient, IReadableConfiguration configuration)
    {
        if (client == null) throw new ArgumentNullException("client");
        if (asyncClient == null) throw new ArgumentNullException("asyncClient");
        if (configuration == null) throw new ArgumentNullException("configuration");

        Client = client;
        AsynchronousClient = asyncClient;
        Configuration = configuration;
        ExceptionFactory = AccountClient.Client.Configuration.DefaultExceptionFactory;
    }

    /// <summary>
    ///     The client for accessing this underlying API asynchronously.
    /// </summary>
    public IAsynchronousClient AsynchronousClient { get; set; }

    /// <summary>
    ///     The client for accessing this underlying API synchronously.
    /// </summary>
    public ISynchronousClient Client { get; set; }

    /// <summary>
    ///     Gets the base path of the API client.
    /// </summary>
    /// <value>The base path</value>
    public string GetBasePath()
    {
        return Configuration.BasePath;
    }

    /// <summary>
    ///     Gets or sets the configuration object
    /// </summary>
    /// <value>An instance of the Configuration</value>
    public IReadableConfiguration Configuration { get; set; }

    /// <summary>
    ///     Provides a factory method hook for the creation of exceptions.
    /// </summary>
    public ExceptionFactory ExceptionFactory
    {
        get
        {
            if (_exceptionFactory != null && _exceptionFactory.GetInvocationList().Length > 1)
                throw new InvalidOperationException("Multicast delegate for ExceptionFactory is unsupported.");
            return _exceptionFactory;
        }
        set => _exceptionFactory = value;
    }

    /// <summary>
    ///     Получение списка счетов СПИУ предоставляется полный список счетов (с идентификаторами accountId), которые были
    ///     авторизованы пользователем на стороне ППУ.
    /// </summary>
    /// <exception cref="Multibanking.AccountClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="page">Номер страницы (optional, default to 0)</param>
    /// <param name="xFapiAuthDate">
    ///     Время последнего входа Пользователя в систему с TPP. Значение предоставляется в виде
    ///     HTTP-date, как в разделе 7.1.1.1 [RFC7231]. Например, x-fapi-auth-date: Mon, 26 Aug 2019 12:23:11 GMT (optional)
    /// </param>
    /// <param name="xFapiCustomerIpAddress">
    ///     IP-адрес Пользователя, если Пользователь в данный момент подключен к Стороннему
    ///     Поставщику (залогинен в приложении Стороннего Поставщика). (optional)
    /// </param>
    /// <param name="xFapiInteractionId">
    ///     RFC4122 UID, используемый в качестве идентификатора корреляции. Если необходимо, то
    ///     ППУ передает обратно значение идентификатора корреляции в заголовке ответа x-fapi-interaction-id. (optional)
    /// </param>
    /// <param name="xCustomerUserAgent">
    ///     В заголовке указывается тип устройства (user-agent), который использует Пользователь.
    ///     Сторонний Поставщик может заполнить это поле значением типа устройства (user-agent), указанным Пользователем. Если
    ///     Пользователь использует мобильное приложение Стороннего Поставщика, Сторонний Поставщик проверяет, что строка типа
    ///     устройства (user-agent) отличается от строки типа устройства (user-agent) на основе браузера. (optional)
    /// </param>
    /// <param name="operationIndex">Index associated with the operation.</param>
    /// <returns>AccountResponse</returns>
    public AccountResponse GetAccounts(int? page = default, string xFapiAuthDate = default,
        string xFapiCustomerIpAddress = default, string xFapiInteractionId = default,
        string xCustomerUserAgent = default, int operationIndex = 0)
    {
        var localVarResponse = GetAccountsWithHttpInfo(page, xFapiAuthDate, xFapiCustomerIpAddress, xFapiInteractionId,
            xCustomerUserAgent);
        return localVarResponse.Data;
    }

    /// <summary>
    ///     Получение списка счетов СПИУ предоставляется полный список счетов (с идентификаторами accountId), которые были
    ///     авторизованы пользователем на стороне ППУ.
    /// </summary>
    /// <exception cref="Multibanking.AccountClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="page">Номер страницы (optional, default to 0)</param>
    /// <param name="xFapiAuthDate">
    ///     Время последнего входа Пользователя в систему с TPP. Значение предоставляется в виде
    ///     HTTP-date, как в разделе 7.1.1.1 [RFC7231]. Например, x-fapi-auth-date: Mon, 26 Aug 2019 12:23:11 GMT (optional)
    /// </param>
    /// <param name="xFapiCustomerIpAddress">
    ///     IP-адрес Пользователя, если Пользователь в данный момент подключен к Стороннему
    ///     Поставщику (залогинен в приложении Стороннего Поставщика). (optional)
    /// </param>
    /// <param name="xFapiInteractionId">
    ///     RFC4122 UID, используемый в качестве идентификатора корреляции. Если необходимо, то
    ///     ППУ передает обратно значение идентификатора корреляции в заголовке ответа x-fapi-interaction-id. (optional)
    /// </param>
    /// <param name="xCustomerUserAgent">
    ///     В заголовке указывается тип устройства (user-agent), который использует Пользователь.
    ///     Сторонний Поставщик может заполнить это поле значением типа устройства (user-agent), указанным Пользователем. Если
    ///     Пользователь использует мобильное приложение Стороннего Поставщика, Сторонний Поставщик проверяет, что строка типа
    ///     устройства (user-agent) отличается от строки типа устройства (user-agent) на основе браузера. (optional)
    /// </param>
    /// <param name="operationIndex">Index associated with the operation.</param>
    /// <returns>ApiResponse of AccountResponse</returns>
    public ApiResponse<AccountResponse> GetAccountsWithHttpInfo(int? page = default, string xFapiAuthDate = default,
        string xFapiCustomerIpAddress = default, string xFapiInteractionId = default,
        string xCustomerUserAgent = default, int operationIndex = 0)
    {
        var localVarRequestOptions = new RequestOptions();

        var _contentTypes = new string[]
        {
        };

        // to determine the Accept header
        var _accepts = new[]
        {
            "application/json"
        };

        var localVarContentType = ClientUtils.SelectHeaderContentType(_contentTypes);
        if (localVarContentType != null)
            localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

        var localVarAccept = ClientUtils.SelectHeaderAccept(_accepts);
        if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

        if (page != null) localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "page", page));
        if (xFapiAuthDate != null)
            localVarRequestOptions.HeaderParameters.Add("x-fapi-auth-date",
                ClientUtils.ParameterToString(xFapiAuthDate)); // header parameter
        if (xFapiCustomerIpAddress != null)
            localVarRequestOptions.HeaderParameters.Add("x-fapi-customer-ip-address",
                ClientUtils.ParameterToString(xFapiCustomerIpAddress)); // header parameter
        if (xFapiInteractionId != null)
            localVarRequestOptions.HeaderParameters.Add("x-fapi-interaction-id",
                ClientUtils.ParameterToString(xFapiInteractionId)); // header parameter
        if (xCustomerUserAgent != null)
            localVarRequestOptions.HeaderParameters.Add("x-customer-user-agent",
                ClientUtils.ParameterToString(xCustomerUserAgent)); // header parameter

        localVarRequestOptions.Operation = "AccountsApi.GetAccounts";
        localVarRequestOptions.OperationIndex = operationIndex;

        // authentication (Authorization) required
        // oauth required
        if (!localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
        {
            if (!string.IsNullOrEmpty(Configuration.AccessToken))
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + Configuration.AccessToken);
            else if (!string.IsNullOrEmpty(Configuration.OAuthTokenUrl) &&
                     !string.IsNullOrEmpty(Configuration.OAuthClientId) &&
                     !string.IsNullOrEmpty(Configuration.OAuthClientSecret) &&
                     Configuration.OAuthFlow != null)
                localVarRequestOptions.OAuth = true;
        }

        // make the HTTP request
        var localVarResponse = Client.Get<AccountResponse>("/accounts", localVarRequestOptions, Configuration);
        if (ExceptionFactory != null)
        {
            var _exception = ExceptionFactory("GetAccounts", localVarResponse);
            if (_exception != null) throw _exception;
        }

        return localVarResponse;
    }

    /// <summary>
    ///     Получение списка счетов СПИУ предоставляется полный список счетов (с идентификаторами accountId), которые были
    ///     авторизованы пользователем на стороне ППУ.
    /// </summary>
    /// <exception cref="Multibanking.AccountClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="page">Номер страницы (optional, default to 0)</param>
    /// <param name="xFapiAuthDate">
    ///     Время последнего входа Пользователя в систему с TPP. Значение предоставляется в виде
    ///     HTTP-date, как в разделе 7.1.1.1 [RFC7231]. Например, x-fapi-auth-date: Mon, 26 Aug 2019 12:23:11 GMT (optional)
    /// </param>
    /// <param name="xFapiCustomerIpAddress">
    ///     IP-адрес Пользователя, если Пользователь в данный момент подключен к Стороннему
    ///     Поставщику (залогинен в приложении Стороннего Поставщика). (optional)
    /// </param>
    /// <param name="xFapiInteractionId">
    ///     RFC4122 UID, используемый в качестве идентификатора корреляции. Если необходимо, то
    ///     ППУ передает обратно значение идентификатора корреляции в заголовке ответа x-fapi-interaction-id. (optional)
    /// </param>
    /// <param name="xCustomerUserAgent">
    ///     В заголовке указывается тип устройства (user-agent), который использует Пользователь.
    ///     Сторонний Поставщик может заполнить это поле значением типа устройства (user-agent), указанным Пользователем. Если
    ///     Пользователь использует мобильное приложение Стороннего Поставщика, Сторонний Поставщик проверяет, что строка типа
    ///     устройства (user-agent) отличается от строки типа устройства (user-agent) на основе браузера. (optional)
    /// </param>
    /// <param name="operationIndex">Index associated with the operation.</param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of AccountResponse</returns>
    public async Task<AccountResponse> GetAccountsAsync(int? page = default,
        string xFapiAuthDate = default, string xFapiCustomerIpAddress = default, string xFapiInteractionId = default,
        string xCustomerUserAgent = default, int operationIndex = 0,
        CancellationToken cancellationToken = default)
    {
        var localVarResponse = await GetAccountsWithHttpInfoAsync(page, xFapiAuthDate, xFapiCustomerIpAddress,
            xFapiInteractionId, xCustomerUserAgent, operationIndex, cancellationToken).ConfigureAwait(false);
        return localVarResponse.Data;
    }

    /// <summary>
    ///     Получение списка счетов СПИУ предоставляется полный список счетов (с идентификаторами accountId), которые были
    ///     авторизованы пользователем на стороне ППУ.
    /// </summary>
    /// <exception cref="Multibanking.AccountClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="page">Номер страницы (optional, default to 0)</param>
    /// <param name="xFapiAuthDate">
    ///     Время последнего входа Пользователя в систему с TPP. Значение предоставляется в виде
    ///     HTTP-date, как в разделе 7.1.1.1 [RFC7231]. Например, x-fapi-auth-date: Mon, 26 Aug 2019 12:23:11 GMT (optional)
    /// </param>
    /// <param name="xFapiCustomerIpAddress">
    ///     IP-адрес Пользователя, если Пользователь в данный момент подключен к Стороннему
    ///     Поставщику (залогинен в приложении Стороннего Поставщика). (optional)
    /// </param>
    /// <param name="xFapiInteractionId">
    ///     RFC4122 UID, используемый в качестве идентификатора корреляции. Если необходимо, то
    ///     ППУ передает обратно значение идентификатора корреляции в заголовке ответа x-fapi-interaction-id. (optional)
    /// </param>
    /// <param name="xCustomerUserAgent">
    ///     В заголовке указывается тип устройства (user-agent), который использует Пользователь.
    ///     Сторонний Поставщик может заполнить это поле значением типа устройства (user-agent), указанным Пользователем. Если
    ///     Пользователь использует мобильное приложение Стороннего Поставщика, Сторонний Поставщик проверяет, что строка типа
    ///     устройства (user-agent) отличается от строки типа устройства (user-agent) на основе браузера. (optional)
    /// </param>
    /// <param name="operationIndex">Index associated with the operation.</param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ApiResponse (AccountResponse)</returns>
    public async Task<ApiResponse<AccountResponse>> GetAccountsWithHttpInfoAsync(
        int? page = default, string xFapiAuthDate = default, string xFapiCustomerIpAddress = default,
        string xFapiInteractionId = default, string xCustomerUserAgent = default, int operationIndex = 0,
        CancellationToken cancellationToken = default)
    {
        var localVarRequestOptions = new RequestOptions();

        var _contentTypes = new string[]
        {
        };

        // to determine the Accept header
        var _accepts = new[]
        {
            "application/json"
        };

        var localVarContentType = ClientUtils.SelectHeaderContentType(_contentTypes);
        if (localVarContentType != null)
            localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

        var localVarAccept = ClientUtils.SelectHeaderAccept(_accepts);
        if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

        if (page != null) localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "page", page));
        if (xFapiAuthDate != null)
            localVarRequestOptions.HeaderParameters.Add("x-fapi-auth-date",
                ClientUtils.ParameterToString(xFapiAuthDate)); // header parameter
        if (xFapiCustomerIpAddress != null)
            localVarRequestOptions.HeaderParameters.Add("x-fapi-customer-ip-address",
                ClientUtils.ParameterToString(xFapiCustomerIpAddress)); // header parameter
        if (xFapiInteractionId != null)
            localVarRequestOptions.HeaderParameters.Add("x-fapi-interaction-id",
                ClientUtils.ParameterToString(xFapiInteractionId)); // header parameter
        if (xCustomerUserAgent != null)
            localVarRequestOptions.HeaderParameters.Add("x-customer-user-agent",
                ClientUtils.ParameterToString(xCustomerUserAgent)); // header parameter

        localVarRequestOptions.Operation = "AccountsApi.GetAccounts";
        localVarRequestOptions.OperationIndex = operationIndex;

        // authentication (Authorization) required
        // oauth required
        if (!localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
        {
            if (!string.IsNullOrEmpty(Configuration.AccessToken))
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + Configuration.AccessToken);
            else if (!string.IsNullOrEmpty(Configuration.OAuthTokenUrl) &&
                     !string.IsNullOrEmpty(Configuration.OAuthClientId) &&
                     !string.IsNullOrEmpty(Configuration.OAuthClientSecret) &&
                     Configuration.OAuthFlow != null)
                localVarRequestOptions.OAuth = true;
        }

        // make the HTTP request
        var localVarResponse = await AsynchronousClient
            .GetAsync<AccountResponse>("/accounts", localVarRequestOptions, Configuration, cancellationToken)
            .ConfigureAwait(false);

        if (ExceptionFactory != null)
        {
            var _exception = ExceptionFactory("GetAccounts", localVarResponse);
            if (_exception != null) throw _exception;
        }

        return localVarResponse;
    }

    /// <summary>
    ///     Получение детальной информации о счете СПИУ получает детальную информацию о счете по идентификатору accountId
    ///     (который был получен при вызове конечной точке списка счетов GET /accounts).
    /// </summary>
    /// <exception cref="Multibanking.AccountClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="accountId">Идентификатор счета</param>
    /// <param name="xFapiAuthDate">
    ///     Время последнего входа Пользователя в систему с TPP. Значение предоставляется в виде
    ///     HTTP-date, как в разделе 7.1.1.1 [RFC7231]. Например, x-fapi-auth-date: Mon, 26 Aug 2019 12:23:11 GMT (optional)
    /// </param>
    /// <param name="xFapiCustomerIpAddress">
    ///     IP-адрес Пользователя, если Пользователь в данный момент подключен к Стороннему
    ///     Поставщику (залогинен в приложении Стороннего Поставщика). (optional)
    /// </param>
    /// <param name="xFapiInteractionId">
    ///     RFC4122 UID, используемый в качестве идентификатора корреляции. Если необходимо, то
    ///     ППУ передает обратно значение идентификатора корреляции в заголовке ответа x-fapi-interaction-id. (optional)
    /// </param>
    /// <param name="xCustomerUserAgent">
    ///     В заголовке указывается тип устройства (user-agent), который использует Пользователь.
    ///     Сторонний Поставщик может заполнить это поле значением типа устройства (user-agent), указанным Пользователем. Если
    ///     Пользователь использует мобильное приложение Стороннего Поставщика, Сторонний Поставщик проверяет, что строка типа
    ///     устройства (user-agent) отличается от строки типа устройства (user-agent) на основе браузера. (optional)
    /// </param>
    /// <param name="operationIndex">Index associated with the operation.</param>
    /// <returns>AccountResponse</returns>
    public AccountResponse GetAccountsaccountId(string accountId, string xFapiAuthDate = default,
        string xFapiCustomerIpAddress = default, string xFapiInteractionId = default,
        string xCustomerUserAgent = default, int operationIndex = 0)
    {
        var localVarResponse = GetAccountsaccountIdWithHttpInfo(accountId, xFapiAuthDate, xFapiCustomerIpAddress,
            xFapiInteractionId, xCustomerUserAgent);
        return localVarResponse.Data;
    }

    /// <summary>
    ///     Получение детальной информации о счете СПИУ получает детальную информацию о счете по идентификатору accountId
    ///     (который был получен при вызове конечной точке списка счетов GET /accounts).
    /// </summary>
    /// <exception cref="Multibanking.AccountClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="accountId">Идентификатор счета</param>
    /// <param name="xFapiAuthDate">
    ///     Время последнего входа Пользователя в систему с TPP. Значение предоставляется в виде
    ///     HTTP-date, как в разделе 7.1.1.1 [RFC7231]. Например, x-fapi-auth-date: Mon, 26 Aug 2019 12:23:11 GMT (optional)
    /// </param>
    /// <param name="xFapiCustomerIpAddress">
    ///     IP-адрес Пользователя, если Пользователь в данный момент подключен к Стороннему
    ///     Поставщику (залогинен в приложении Стороннего Поставщика). (optional)
    /// </param>
    /// <param name="xFapiInteractionId">
    ///     RFC4122 UID, используемый в качестве идентификатора корреляции. Если необходимо, то
    ///     ППУ передает обратно значение идентификатора корреляции в заголовке ответа x-fapi-interaction-id. (optional)
    /// </param>
    /// <param name="xCustomerUserAgent">
    ///     В заголовке указывается тип устройства (user-agent), который использует Пользователь.
    ///     Сторонний Поставщик может заполнить это поле значением типа устройства (user-agent), указанным Пользователем. Если
    ///     Пользователь использует мобильное приложение Стороннего Поставщика, Сторонний Поставщик проверяет, что строка типа
    ///     устройства (user-agent) отличается от строки типа устройства (user-agent) на основе браузера. (optional)
    /// </param>
    /// <param name="operationIndex">Index associated with the operation.</param>
    /// <returns>ApiResponse of AccountResponse</returns>
    public ApiResponse<AccountResponse> GetAccountsaccountIdWithHttpInfo(string accountId,
        string xFapiAuthDate = default, string xFapiCustomerIpAddress = default, string xFapiInteractionId = default,
        string xCustomerUserAgent = default, int operationIndex = 0)
    {
        // verify the required parameter 'accountId' is set
        if (accountId == null)
            throw new ApiException(400,
                "Missing required parameter 'accountId' when calling AccountsApi->GetAccountsaccountId");

        var localVarRequestOptions = new RequestOptions();

        var _contentTypes = new string[]
        {
        };

        // to determine the Accept header
        var _accepts = new[]
        {
            "application/json"
        };

        var localVarContentType = ClientUtils.SelectHeaderContentType(_contentTypes);
        if (localVarContentType != null)
            localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

        var localVarAccept = ClientUtils.SelectHeaderAccept(_accepts);
        if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

        localVarRequestOptions.PathParameters.Add("accountId",
            ClientUtils.ParameterToString(accountId)); // path parameter
        if (xFapiAuthDate != null)
            localVarRequestOptions.HeaderParameters.Add("x-fapi-auth-date",
                ClientUtils.ParameterToString(xFapiAuthDate)); // header parameter
        if (xFapiCustomerIpAddress != null)
            localVarRequestOptions.HeaderParameters.Add("x-fapi-customer-ip-address",
                ClientUtils.ParameterToString(xFapiCustomerIpAddress)); // header parameter
        if (xFapiInteractionId != null)
            localVarRequestOptions.HeaderParameters.Add("x-fapi-interaction-id",
                ClientUtils.ParameterToString(xFapiInteractionId)); // header parameter
        if (xCustomerUserAgent != null)
            localVarRequestOptions.HeaderParameters.Add("x-customer-user-agent",
                ClientUtils.ParameterToString(xCustomerUserAgent)); // header parameter

        localVarRequestOptions.Operation = "AccountsApi.GetAccountsaccountId";
        localVarRequestOptions.OperationIndex = operationIndex;

        // authentication (Authorization) required
        // oauth required
        if (!localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
        {
            if (!string.IsNullOrEmpty(Configuration.AccessToken))
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + Configuration.AccessToken);
            else if (!string.IsNullOrEmpty(Configuration.OAuthTokenUrl) &&
                     !string.IsNullOrEmpty(Configuration.OAuthClientId) &&
                     !string.IsNullOrEmpty(Configuration.OAuthClientSecret) &&
                     Configuration.OAuthFlow != null)
                localVarRequestOptions.OAuth = true;
        }

        // make the HTTP request
        var localVarResponse =
            Client.Get<AccountResponse>("/accounts/{accountId}", localVarRequestOptions, Configuration);
        if (ExceptionFactory != null)
        {
            var _exception = ExceptionFactory("GetAccountsaccountId", localVarResponse);
            if (_exception != null) throw _exception;
        }

        return localVarResponse;
    }

    /// <summary>
    ///     Получение детальной информации о счете СПИУ получает детальную информацию о счете по идентификатору accountId
    ///     (который был получен при вызове конечной точке списка счетов GET /accounts).
    /// </summary>
    /// <exception cref="Multibanking.AccountClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="accountId">Идентификатор счета</param>
    /// <param name="xFapiAuthDate">
    ///     Время последнего входа Пользователя в систему с TPP. Значение предоставляется в виде
    ///     HTTP-date, как в разделе 7.1.1.1 [RFC7231]. Например, x-fapi-auth-date: Mon, 26 Aug 2019 12:23:11 GMT (optional)
    /// </param>
    /// <param name="xFapiCustomerIpAddress">
    ///     IP-адрес Пользователя, если Пользователь в данный момент подключен к Стороннему
    ///     Поставщику (залогинен в приложении Стороннего Поставщика). (optional)
    /// </param>
    /// <param name="xFapiInteractionId">
    ///     RFC4122 UID, используемый в качестве идентификатора корреляции. Если необходимо, то
    ///     ППУ передает обратно значение идентификатора корреляции в заголовке ответа x-fapi-interaction-id. (optional)
    /// </param>
    /// <param name="xCustomerUserAgent">
    ///     В заголовке указывается тип устройства (user-agent), который использует Пользователь.
    ///     Сторонний Поставщик может заполнить это поле значением типа устройства (user-agent), указанным Пользователем. Если
    ///     Пользователь использует мобильное приложение Стороннего Поставщика, Сторонний Поставщик проверяет, что строка типа
    ///     устройства (user-agent) отличается от строки типа устройства (user-agent) на основе браузера. (optional)
    /// </param>
    /// <param name="operationIndex">Index associated with the operation.</param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of AccountResponse</returns>
    public async Task<AccountResponse> GetAccountsaccountIdAsync(string accountId,
        string xFapiAuthDate = default, string xFapiCustomerIpAddress = default, string xFapiInteractionId = default,
        string xCustomerUserAgent = default, int operationIndex = 0,
        CancellationToken cancellationToken = default)
    {
        var localVarResponse = await GetAccountsaccountIdWithHttpInfoAsync(accountId, xFapiAuthDate,
                xFapiCustomerIpAddress, xFapiInteractionId, xCustomerUserAgent, operationIndex, cancellationToken)
            .ConfigureAwait(false);
        return localVarResponse.Data;
    }

    /// <summary>
    ///     Получение детальной информации о счете СПИУ получает детальную информацию о счете по идентификатору accountId
    ///     (который был получен при вызове конечной точке списка счетов GET /accounts).
    /// </summary>
    /// <exception cref="Multibanking.AccountClient.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="accountId">Идентификатор счета</param>
    /// <param name="xFapiAuthDate">
    ///     Время последнего входа Пользователя в систему с TPP. Значение предоставляется в виде
    ///     HTTP-date, как в разделе 7.1.1.1 [RFC7231]. Например, x-fapi-auth-date: Mon, 26 Aug 2019 12:23:11 GMT (optional)
    /// </param>
    /// <param name="xFapiCustomerIpAddress">
    ///     IP-адрес Пользователя, если Пользователь в данный момент подключен к Стороннему
    ///     Поставщику (залогинен в приложении Стороннего Поставщика). (optional)
    /// </param>
    /// <param name="xFapiInteractionId">
    ///     RFC4122 UID, используемый в качестве идентификатора корреляции. Если необходимо, то
    ///     ППУ передает обратно значение идентификатора корреляции в заголовке ответа x-fapi-interaction-id. (optional)
    /// </param>
    /// <param name="xCustomerUserAgent">
    ///     В заголовке указывается тип устройства (user-agent), который использует Пользователь.
    ///     Сторонний Поставщик может заполнить это поле значением типа устройства (user-agent), указанным Пользователем. Если
    ///     Пользователь использует мобильное приложение Стороннего Поставщика, Сторонний Поставщик проверяет, что строка типа
    ///     устройства (user-agent) отличается от строки типа устройства (user-agent) на основе браузера. (optional)
    /// </param>
    /// <param name="operationIndex">Index associated with the operation.</param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ApiResponse (AccountResponse)</returns>
    public async Task<ApiResponse<AccountResponse>> GetAccountsaccountIdWithHttpInfoAsync(
        string accountId, string xFapiAuthDate = default, string xFapiCustomerIpAddress = default,
        string xFapiInteractionId = default, string xCustomerUserAgent = default, int operationIndex = 0,
        CancellationToken cancellationToken = default)
    {
        // verify the required parameter 'accountId' is set
        if (accountId == null)
            throw new ApiException(400,
                "Missing required parameter 'accountId' when calling AccountsApi->GetAccountsaccountId");


        var localVarRequestOptions = new RequestOptions();

        var _contentTypes = new string[]
        {
        };

        // to determine the Accept header
        var _accepts = new[]
        {
            "application/json"
        };

        var localVarContentType = ClientUtils.SelectHeaderContentType(_contentTypes);
        if (localVarContentType != null)
            localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

        var localVarAccept = ClientUtils.SelectHeaderAccept(_accepts);
        if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

        localVarRequestOptions.PathParameters.Add("accountId",
            ClientUtils.ParameterToString(accountId)); // path parameter
        if (xFapiAuthDate != null)
            localVarRequestOptions.HeaderParameters.Add("x-fapi-auth-date",
                ClientUtils.ParameterToString(xFapiAuthDate)); // header parameter
        if (xFapiCustomerIpAddress != null)
            localVarRequestOptions.HeaderParameters.Add("x-fapi-customer-ip-address",
                ClientUtils.ParameterToString(xFapiCustomerIpAddress)); // header parameter
        if (xFapiInteractionId != null)
            localVarRequestOptions.HeaderParameters.Add("x-fapi-interaction-id",
                ClientUtils.ParameterToString(xFapiInteractionId)); // header parameter
        if (xCustomerUserAgent != null)
            localVarRequestOptions.HeaderParameters.Add("x-customer-user-agent",
                ClientUtils.ParameterToString(xCustomerUserAgent)); // header parameter

        localVarRequestOptions.Operation = "AccountsApi.GetAccountsaccountId";
        localVarRequestOptions.OperationIndex = operationIndex;

        // authentication (Authorization) required
        // oauth required
        if (!localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
        {
            if (!string.IsNullOrEmpty(Configuration.AccessToken))
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + Configuration.AccessToken);
            else if (!string.IsNullOrEmpty(Configuration.OAuthTokenUrl) &&
                     !string.IsNullOrEmpty(Configuration.OAuthClientId) &&
                     !string.IsNullOrEmpty(Configuration.OAuthClientSecret) &&
                     Configuration.OAuthFlow != null)
                localVarRequestOptions.OAuth = true;
        }

        // make the HTTP request
        var localVarResponse = await AsynchronousClient
            .GetAsync<AccountResponse>("/accounts/{accountId}", localVarRequestOptions, Configuration,
                cancellationToken).ConfigureAwait(false);

        if (ExceptionFactory != null)
        {
            var _exception = ExceptionFactory("GetAccountsaccountId", localVarResponse);
            if (_exception != null) throw _exception;
        }

        return localVarResponse;
    }
}