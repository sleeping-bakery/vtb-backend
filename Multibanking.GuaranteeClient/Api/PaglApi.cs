/*
 * Система рассмотрения заявок на экспресс-гарантии, полученных от партнеров банка
 *
 * Функционал выдачи экспресс гарантий позволяет реализовать след. сервисы:  - Создание клиентом заявки в личном кабинете на выдачу экспресс-гарантии - Отображение информации о закупке по минимальному набору введенных атрибутов - Загрузка и прикрепление документов к заявке - Формирование заявления на выдачу экспресс-гарантии для подписания клиентом - Подписание клиентом заявления с использованием УНЭП - Отображение в Интернет банке статусов заявки - Получение и передача заявок от партнеров - Создание сотрудником банка заявки на гарантию - Формирование проекта решения по заявке на гарантию 
 *
 * The version of the OpenAPI document: 1.4.1
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net;
using System.Net.Mime;
using Multibanking.GuaranteeClient.Client;
using Multibanking.GuaranteeClient.Model;

namespace Multibanking.GuaranteeClient.Api
{

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IPaglApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Создать запросы от клиента для расчета предодобренного предложения
        /// </summary>
        /// <remarks>
        /// Создать запрос клиента
        /// </remarks>
        /// <exception cref="Multibanking.GuaranteeClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="xIBMClientID">Заголовок запроса, содержащий client_id партнера</param>
        /// <param name="paglRequest">Данные ПАГЛ</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>CreateRequestResponseDto</returns>
        CreateRequestResponseDto CreateRequestClient(string xIBMClientID, PaglRequest paglRequest, int operationIndex = 0);

        /// <summary>
        /// Создать запросы от клиента для расчета предодобренного предложения
        /// </summary>
        /// <remarks>
        /// Создать запрос клиента
        /// </remarks>
        /// <exception cref="Multibanking.GuaranteeClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="xIBMClientID">Заголовок запроса, содержащий client_id партнера</param>
        /// <param name="paglRequest">Данные ПАГЛ</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of CreateRequestResponseDto</returns>
        ApiResponse<CreateRequestResponseDto> CreateRequestClientWithHttpInfo(string xIBMClientID, PaglRequest paglRequest, int operationIndex = 0);
        /// <summary>
        /// Получить ссылку на документ результатов предодобренных лимитов по гарантиям
        /// </summary>
        /// <remarks>
        /// Запрос документа результатов расчета
        /// </remarks>
        /// <exception cref="Multibanking.GuaranteeClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="internalId">Идентификатор запроса партнера</param>
        /// <param name="xIBMClientID">Заголовок запроса, содержащий client_id партнера</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>DocumentDownloadDto</returns>
        DocumentDownloadDto GetPaglResult(string internalId, string xIBMClientID, int operationIndex = 0);

        /// <summary>
        /// Получить ссылку на документ результатов предодобренных лимитов по гарантиям
        /// </summary>
        /// <remarks>
        /// Запрос документа результатов расчета
        /// </remarks>
        /// <exception cref="Multibanking.GuaranteeClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="internalId">Идентификатор запроса партнера</param>
        /// <param name="xIBMClientID">Заголовок запроса, содержащий client_id партнера</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of DocumentDownloadDto</returns>
        ApiResponse<DocumentDownloadDto> GetPaglResultWithHttpInfo(string internalId, string xIBMClientID, int operationIndex = 0);
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IPaglApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// Создать запросы от клиента для расчета предодобренного предложения
        /// </summary>
        /// <remarks>
        /// Создать запрос клиента
        /// </remarks>
        /// <exception cref="Multibanking.GuaranteeClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="xIBMClientID">Заголовок запроса, содержащий client_id партнера</param>
        /// <param name="paglRequest">Данные ПАГЛ</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of CreateRequestResponseDto</returns>
        System.Threading.Tasks.Task<CreateRequestResponseDto> CreateRequestClientAsync(string xIBMClientID, PaglRequest paglRequest, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Создать запросы от клиента для расчета предодобренного предложения
        /// </summary>
        /// <remarks>
        /// Создать запрос клиента
        /// </remarks>
        /// <exception cref="Multibanking.GuaranteeClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="xIBMClientID">Заголовок запроса, содержащий client_id партнера</param>
        /// <param name="paglRequest">Данные ПАГЛ</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (CreateRequestResponseDto)</returns>
        System.Threading.Tasks.Task<ApiResponse<CreateRequestResponseDto>> CreateRequestClientWithHttpInfoAsync(string xIBMClientID, PaglRequest paglRequest, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Получить ссылку на документ результатов предодобренных лимитов по гарантиям
        /// </summary>
        /// <remarks>
        /// Запрос документа результатов расчета
        /// </remarks>
        /// <exception cref="Multibanking.GuaranteeClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="internalId">Идентификатор запроса партнера</param>
        /// <param name="xIBMClientID">Заголовок запроса, содержащий client_id партнера</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of DocumentDownloadDto</returns>
        System.Threading.Tasks.Task<DocumentDownloadDto> GetPaglResultAsync(string internalId, string xIBMClientID, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Получить ссылку на документ результатов предодобренных лимитов по гарантиям
        /// </summary>
        /// <remarks>
        /// Запрос документа результатов расчета
        /// </remarks>
        /// <exception cref="Multibanking.GuaranteeClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="internalId">Идентификатор запроса партнера</param>
        /// <param name="xIBMClientID">Заголовок запроса, содержащий client_id партнера</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (DocumentDownloadDto)</returns>
        System.Threading.Tasks.Task<ApiResponse<DocumentDownloadDto>> GetPaglResultWithHttpInfoAsync(string internalId, string xIBMClientID, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IGuaranteePaglApi : IPaglApiSync, IPaglApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class GuaranteePaglApi : IGuaranteePaglApi
    {
        private Multibanking.GuaranteeClient.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="GuaranteePaglApi"/> class.
        /// </summary>
        /// <returns></returns>
        public GuaranteePaglApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GuaranteePaglApi"/> class.
        /// </summary>
        /// <returns></returns>
        public GuaranteePaglApi(string basePath)
        {
            this.Configuration = Multibanking.GuaranteeClient.Client.Configuration.MergeConfigurations(
                Multibanking.GuaranteeClient.Client.GlobalConfiguration.Instance,
                new Multibanking.GuaranteeClient.Client.Configuration { BasePath = basePath }
            );
            this.Client = new Multibanking.GuaranteeClient.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new Multibanking.GuaranteeClient.Client.ApiClient(this.Configuration.BasePath);
            this.ExceptionFactory = Multibanking.GuaranteeClient.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GuaranteePaglApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public GuaranteePaglApi(Multibanking.GuaranteeClient.Client.Configuration configuration)
        {
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Configuration = Multibanking.GuaranteeClient.Client.Configuration.MergeConfigurations(
                Multibanking.GuaranteeClient.Client.GlobalConfiguration.Instance,
                configuration
            );
            this.Client = new Multibanking.GuaranteeClient.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new Multibanking.GuaranteeClient.Client.ApiClient(this.Configuration.BasePath);
            ExceptionFactory = Multibanking.GuaranteeClient.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GuaranteePaglApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public GuaranteePaglApi(Multibanking.GuaranteeClient.Client.ISynchronousClient client, Multibanking.GuaranteeClient.Client.IAsynchronousClient asyncClient, Multibanking.GuaranteeClient.Client.IReadableConfiguration configuration)
        {
            if (client == null) throw new ArgumentNullException("client");
            if (asyncClient == null) throw new ArgumentNullException("asyncClient");
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Client = client;
            this.AsynchronousClient = asyncClient;
            this.Configuration = configuration;
            this.ExceptionFactory = Multibanking.GuaranteeClient.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// The client for accessing this underlying API asynchronously.
        /// </summary>
        public Multibanking.GuaranteeClient.Client.IAsynchronousClient AsynchronousClient { get; set; }

        /// <summary>
        /// The client for accessing this underlying API synchronously.
        /// </summary>
        public Multibanking.GuaranteeClient.Client.ISynchronousClient Client { get; set; }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public string GetBasePath()
        {
            return this.Configuration.BasePath;
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public Multibanking.GuaranteeClient.Client.IReadableConfiguration Configuration { get; set; }

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public Multibanking.GuaranteeClient.Client.ExceptionFactory ExceptionFactory
        {
            get
            {
                if (_exceptionFactory != null && _exceptionFactory.GetInvocationList().Length > 1)
                {
                    throw new InvalidOperationException("Multicast delegate for ExceptionFactory is unsupported.");
                }
                return _exceptionFactory;
            }
            set { _exceptionFactory = value; }
        }

        /// <summary>
        /// Создать запросы от клиента для расчета предодобренного предложения Создать запрос клиента
        /// </summary>
        /// <exception cref="Multibanking.GuaranteeClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="xIBMClientID">Заголовок запроса, содержащий client_id партнера</param>
        /// <param name="paglRequest">Данные ПАГЛ</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>CreateRequestResponseDto</returns>
        public CreateRequestResponseDto CreateRequestClient(string xIBMClientID, PaglRequest paglRequest, int operationIndex = 0)
        {
            Multibanking.GuaranteeClient.Client.ApiResponse<CreateRequestResponseDto> localVarResponse = CreateRequestClientWithHttpInfo(xIBMClientID, paglRequest);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Создать запросы от клиента для расчета предодобренного предложения Создать запрос клиента
        /// </summary>
        /// <exception cref="Multibanking.GuaranteeClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="xIBMClientID">Заголовок запроса, содержащий client_id партнера</param>
        /// <param name="paglRequest">Данные ПАГЛ</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of CreateRequestResponseDto</returns>
        public Multibanking.GuaranteeClient.Client.ApiResponse<CreateRequestResponseDto> CreateRequestClientWithHttpInfo(string xIBMClientID, PaglRequest paglRequest, int operationIndex = 0)
        {
            // verify the required parameter 'xIBMClientID' is set
            if (xIBMClientID == null)
            {
                throw new Multibanking.GuaranteeClient.Client.ApiException(400, "Missing required parameter 'xIBMClientID' when calling GuaranteePaglApi->CreateRequestClient");
            }

            // verify the required parameter 'paglRequest' is set
            if (paglRequest == null)
            {
                throw new Multibanking.GuaranteeClient.Client.ApiException(400, "Missing required parameter 'paglRequest' when calling GuaranteePaglApi->CreateRequestClient");
            }

            Multibanking.GuaranteeClient.Client.RequestOptions localVarRequestOptions = new Multibanking.GuaranteeClient.Client.RequestOptions();

            string[] _contentTypes = new string[] {
                "application/json"
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = Multibanking.GuaranteeClient.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-FileUploadType", localVarContentType);
            }

            var localVarAccept = Multibanking.GuaranteeClient.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.HeaderParameters.Add("X-IBM-Client-ID", Multibanking.GuaranteeClient.Client.ClientUtils.ParameterToString(xIBMClientID)); // header parameter
            localVarRequestOptions.Data = paglRequest;

            localVarRequestOptions.Operation = "GuaranteePaglApi.CreateRequestClient";
            localVarRequestOptions.OperationIndex = operationIndex;


            // make the HTTP request
            var localVarResponse = this.Client.Post<CreateRequestResponseDto>("/pagl", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("CreateRequestClient", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Создать запросы от клиента для расчета предодобренного предложения Создать запрос клиента
        /// </summary>
        /// <exception cref="Multibanking.GuaranteeClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="xIBMClientID">Заголовок запроса, содержащий client_id партнера</param>
        /// <param name="paglRequest">Данные ПАГЛ</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of CreateRequestResponseDto</returns>
        public async System.Threading.Tasks.Task<CreateRequestResponseDto> CreateRequestClientAsync(string xIBMClientID, PaglRequest paglRequest, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Multibanking.GuaranteeClient.Client.ApiResponse<CreateRequestResponseDto> localVarResponse = await CreateRequestClientWithHttpInfoAsync(xIBMClientID, paglRequest, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Создать запросы от клиента для расчета предодобренного предложения Создать запрос клиента
        /// </summary>
        /// <exception cref="Multibanking.GuaranteeClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="xIBMClientID">Заголовок запроса, содержащий client_id партнера</param>
        /// <param name="paglRequest">Данные ПАГЛ</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (CreateRequestResponseDto)</returns>
        public async System.Threading.Tasks.Task<Multibanking.GuaranteeClient.Client.ApiResponse<CreateRequestResponseDto>> CreateRequestClientWithHttpInfoAsync(string xIBMClientID, PaglRequest paglRequest, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'xIBMClientID' is set
            if (xIBMClientID == null)
            {
                throw new Multibanking.GuaranteeClient.Client.ApiException(400, "Missing required parameter 'xIBMClientID' when calling GuaranteePaglApi->CreateRequestClient");
            }

            // verify the required parameter 'paglRequest' is set
            if (paglRequest == null)
            {
                throw new Multibanking.GuaranteeClient.Client.ApiException(400, "Missing required parameter 'paglRequest' when calling GuaranteePaglApi->CreateRequestClient");
            }


            Multibanking.GuaranteeClient.Client.RequestOptions localVarRequestOptions = new Multibanking.GuaranteeClient.Client.RequestOptions();

            string[] _contentTypes = new string[] {
                "application/json"
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = Multibanking.GuaranteeClient.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-FileUploadType", localVarContentType);
            }

            var localVarAccept = Multibanking.GuaranteeClient.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.HeaderParameters.Add("X-IBM-Client-ID", Multibanking.GuaranteeClient.Client.ClientUtils.ParameterToString(xIBMClientID)); // header parameter
            localVarRequestOptions.Data = paglRequest;

            localVarRequestOptions.Operation = "GuaranteePaglApi.CreateRequestClient";
            localVarRequestOptions.OperationIndex = operationIndex;


            // make the HTTP request
            var localVarResponse = await this.AsynchronousClient.PostAsync<CreateRequestResponseDto>("/pagl", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("CreateRequestClient", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Получить ссылку на документ результатов предодобренных лимитов по гарантиям Запрос документа результатов расчета
        /// </summary>
        /// <exception cref="Multibanking.GuaranteeClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="internalId">Идентификатор запроса партнера</param>
        /// <param name="xIBMClientID">Заголовок запроса, содержащий client_id партнера</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>DocumentDownloadDto</returns>
        public DocumentDownloadDto GetPaglResult(string internalId, string xIBMClientID, int operationIndex = 0)
        {
            Multibanking.GuaranteeClient.Client.ApiResponse<DocumentDownloadDto> localVarResponse = GetPaglResultWithHttpInfo(internalId, xIBMClientID);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Получить ссылку на документ результатов предодобренных лимитов по гарантиям Запрос документа результатов расчета
        /// </summary>
        /// <exception cref="Multibanking.GuaranteeClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="internalId">Идентификатор запроса партнера</param>
        /// <param name="xIBMClientID">Заголовок запроса, содержащий client_id партнера</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of DocumentDownloadDto</returns>
        public Multibanking.GuaranteeClient.Client.ApiResponse<DocumentDownloadDto> GetPaglResultWithHttpInfo(string internalId, string xIBMClientID, int operationIndex = 0)
        {
            // verify the required parameter 'internalId' is set
            if (internalId == null)
            {
                throw new Multibanking.GuaranteeClient.Client.ApiException(400, "Missing required parameter 'internalId' when calling GuaranteePaglApi->GetPaglResult");
            }

            // verify the required parameter 'xIBMClientID' is set
            if (xIBMClientID == null)
            {
                throw new Multibanking.GuaranteeClient.Client.ApiException(400, "Missing required parameter 'xIBMClientID' when calling GuaranteePaglApi->GetPaglResult");
            }

            Multibanking.GuaranteeClient.Client.RequestOptions localVarRequestOptions = new Multibanking.GuaranteeClient.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = Multibanking.GuaranteeClient.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-FileUploadType", localVarContentType);
            }

            var localVarAccept = Multibanking.GuaranteeClient.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.PathParameters.Add("internalId", Multibanking.GuaranteeClient.Client.ClientUtils.ParameterToString(internalId)); // path parameter
            localVarRequestOptions.HeaderParameters.Add("X-IBM-Client-ID", Multibanking.GuaranteeClient.Client.ClientUtils.ParameterToString(xIBMClientID)); // header parameter

            localVarRequestOptions.Operation = "GuaranteePaglApi.GetPaglResult";
            localVarRequestOptions.OperationIndex = operationIndex;


            // make the HTTP request
            var localVarResponse = this.Client.Get<DocumentDownloadDto>("/pagl/result/{internalId}", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetPaglResult", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Получить ссылку на документ результатов предодобренных лимитов по гарантиям Запрос документа результатов расчета
        /// </summary>
        /// <exception cref="Multibanking.GuaranteeClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="internalId">Идентификатор запроса партнера</param>
        /// <param name="xIBMClientID">Заголовок запроса, содержащий client_id партнера</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of DocumentDownloadDto</returns>
        public async System.Threading.Tasks.Task<DocumentDownloadDto> GetPaglResultAsync(string internalId, string xIBMClientID, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Multibanking.GuaranteeClient.Client.ApiResponse<DocumentDownloadDto> localVarResponse = await GetPaglResultWithHttpInfoAsync(internalId, xIBMClientID, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Получить ссылку на документ результатов предодобренных лимитов по гарантиям Запрос документа результатов расчета
        /// </summary>
        /// <exception cref="Multibanking.GuaranteeClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="internalId">Идентификатор запроса партнера</param>
        /// <param name="xIBMClientID">Заголовок запроса, содержащий client_id партнера</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (DocumentDownloadDto)</returns>
        public async System.Threading.Tasks.Task<Multibanking.GuaranteeClient.Client.ApiResponse<DocumentDownloadDto>> GetPaglResultWithHttpInfoAsync(string internalId, string xIBMClientID, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'internalId' is set
            if (internalId == null)
            {
                throw new Multibanking.GuaranteeClient.Client.ApiException(400, "Missing required parameter 'internalId' when calling GuaranteePaglApi->GetPaglResult");
            }

            // verify the required parameter 'xIBMClientID' is set
            if (xIBMClientID == null)
            {
                throw new Multibanking.GuaranteeClient.Client.ApiException(400, "Missing required parameter 'xIBMClientID' when calling GuaranteePaglApi->GetPaglResult");
            }


            Multibanking.GuaranteeClient.Client.RequestOptions localVarRequestOptions = new Multibanking.GuaranteeClient.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = Multibanking.GuaranteeClient.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-FileUploadType", localVarContentType);
            }

            var localVarAccept = Multibanking.GuaranteeClient.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.PathParameters.Add("internalId", Multibanking.GuaranteeClient.Client.ClientUtils.ParameterToString(internalId)); // path parameter
            localVarRequestOptions.HeaderParameters.Add("X-IBM-Client-ID", Multibanking.GuaranteeClient.Client.ClientUtils.ParameterToString(xIBMClientID)); // header parameter

            localVarRequestOptions.Operation = "GuaranteePaglApi.GetPaglResult";
            localVarRequestOptions.OperationIndex = operationIndex;


            // make the HTTP request
            var localVarResponse = await this.AsynchronousClient.GetAsync<DocumentDownloadDto>("/pagl/result/{internalId}", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetPaglResult", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

    }
}
