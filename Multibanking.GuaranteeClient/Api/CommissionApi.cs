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
    public interface ICommissionApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Получить предварительный расчет комиссии
        /// </summary>
        /// <remarks>
        /// Получить предварительный расчет комиссии
        /// </remarks>
        /// <exception cref="Multibanking.GuaranteeClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="xIBMClientID">Заголовок запроса, содержащий client_id партнера</param>
        /// <param name="commissionRequest">Информация о комиссии</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>CommissionResponseDto</returns>
        CommissionResponseDto PrecalculateCommission(string xIBMClientID, CommissionRequest commissionRequest, int operationIndex = 0);

        /// <summary>
        /// Получить предварительный расчет комиссии
        /// </summary>
        /// <remarks>
        /// Получить предварительный расчет комиссии
        /// </remarks>
        /// <exception cref="Multibanking.GuaranteeClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="xIBMClientID">Заголовок запроса, содержащий client_id партнера</param>
        /// <param name="commissionRequest">Информация о комиссии</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of CommissionResponseDto</returns>
        ApiResponse<CommissionResponseDto> PrecalculateCommissionWithHttpInfo(string xIBMClientID, CommissionRequest commissionRequest, int operationIndex = 0);
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ICommissionApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// Получить предварительный расчет комиссии
        /// </summary>
        /// <remarks>
        /// Получить предварительный расчет комиссии
        /// </remarks>
        /// <exception cref="Multibanking.GuaranteeClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="xIBMClientID">Заголовок запроса, содержащий client_id партнера</param>
        /// <param name="commissionRequest">Информация о комиссии</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of CommissionResponseDto</returns>
        System.Threading.Tasks.Task<CommissionResponseDto> PrecalculateCommissionAsync(string xIBMClientID, CommissionRequest commissionRequest, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Получить предварительный расчет комиссии
        /// </summary>
        /// <remarks>
        /// Получить предварительный расчет комиссии
        /// </remarks>
        /// <exception cref="Multibanking.GuaranteeClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="xIBMClientID">Заголовок запроса, содержащий client_id партнера</param>
        /// <param name="commissionRequest">Информация о комиссии</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (CommissionResponseDto)</returns>
        System.Threading.Tasks.Task<ApiResponse<CommissionResponseDto>> PrecalculateCommissionWithHttpInfoAsync(string xIBMClientID, CommissionRequest commissionRequest, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IGuaranteeCommissionApi : ICommissionApiSync, ICommissionApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class GuaranteeCommissionApi : IGuaranteeCommissionApi
    {
        private Multibanking.GuaranteeClient.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="GuaranteeCommissionApi"/> class.
        /// </summary>
        /// <returns></returns>
        public GuaranteeCommissionApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GuaranteeCommissionApi"/> class.
        /// </summary>
        /// <returns></returns>
        public GuaranteeCommissionApi(string basePath)
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
        /// Initializes a new instance of the <see cref="GuaranteeCommissionApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public GuaranteeCommissionApi(Multibanking.GuaranteeClient.Client.Configuration configuration)
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
        /// Initializes a new instance of the <see cref="GuaranteeCommissionApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public GuaranteeCommissionApi(Multibanking.GuaranteeClient.Client.ISynchronousClient client, Multibanking.GuaranteeClient.Client.IAsynchronousClient asyncClient, Multibanking.GuaranteeClient.Client.IReadableConfiguration configuration)
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
        /// Получить предварительный расчет комиссии Получить предварительный расчет комиссии
        /// </summary>
        /// <exception cref="Multibanking.GuaranteeClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="xIBMClientID">Заголовок запроса, содержащий client_id партнера</param>
        /// <param name="commissionRequest">Информация о комиссии</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>CommissionResponseDto</returns>
        public CommissionResponseDto PrecalculateCommission(string xIBMClientID, CommissionRequest commissionRequest, int operationIndex = 0)
        {
            Multibanking.GuaranteeClient.Client.ApiResponse<CommissionResponseDto> localVarResponse = PrecalculateCommissionWithHttpInfo(xIBMClientID, commissionRequest);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Получить предварительный расчет комиссии Получить предварительный расчет комиссии
        /// </summary>
        /// <exception cref="Multibanking.GuaranteeClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="xIBMClientID">Заголовок запроса, содержащий client_id партнера</param>
        /// <param name="commissionRequest">Информация о комиссии</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of CommissionResponseDto</returns>
        public Multibanking.GuaranteeClient.Client.ApiResponse<CommissionResponseDto> PrecalculateCommissionWithHttpInfo(string xIBMClientID, CommissionRequest commissionRequest, int operationIndex = 0)
        {
            // verify the required parameter 'xIBMClientID' is set
            if (xIBMClientID == null)
            {
                throw new Multibanking.GuaranteeClient.Client.ApiException(400, "Missing required parameter 'xIBMClientID' when calling GuaranteeCommissionApi->PrecalculateCommission");
            }

            // verify the required parameter 'commissionRequest' is set
            if (commissionRequest == null)
            {
                throw new Multibanking.GuaranteeClient.Client.ApiException(400, "Missing required parameter 'commissionRequest' when calling GuaranteeCommissionApi->PrecalculateCommission");
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
            localVarRequestOptions.Data = commissionRequest;

            localVarRequestOptions.Operation = "GuaranteeCommissionApi.PrecalculateCommission";
            localVarRequestOptions.OperationIndex = operationIndex;


            // make the HTTP request
            var localVarResponse = this.Client.Post<CommissionResponseDto>("/commissions/precalculate", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("PrecalculateCommission", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Получить предварительный расчет комиссии Получить предварительный расчет комиссии
        /// </summary>
        /// <exception cref="Multibanking.GuaranteeClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="xIBMClientID">Заголовок запроса, содержащий client_id партнера</param>
        /// <param name="commissionRequest">Информация о комиссии</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of CommissionResponseDto</returns>
        public async System.Threading.Tasks.Task<CommissionResponseDto> PrecalculateCommissionAsync(string xIBMClientID, CommissionRequest commissionRequest, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Multibanking.GuaranteeClient.Client.ApiResponse<CommissionResponseDto> localVarResponse = await PrecalculateCommissionWithHttpInfoAsync(xIBMClientID, commissionRequest, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Получить предварительный расчет комиссии Получить предварительный расчет комиссии
        /// </summary>
        /// <exception cref="Multibanking.GuaranteeClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="xIBMClientID">Заголовок запроса, содержащий client_id партнера</param>
        /// <param name="commissionRequest">Информация о комиссии</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (CommissionResponseDto)</returns>
        public async System.Threading.Tasks.Task<Multibanking.GuaranteeClient.Client.ApiResponse<CommissionResponseDto>> PrecalculateCommissionWithHttpInfoAsync(string xIBMClientID, CommissionRequest commissionRequest, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'xIBMClientID' is set
            if (xIBMClientID == null)
            {
                throw new Multibanking.GuaranteeClient.Client.ApiException(400, "Missing required parameter 'xIBMClientID' when calling GuaranteeCommissionApi->PrecalculateCommission");
            }

            // verify the required parameter 'commissionRequest' is set
            if (commissionRequest == null)
            {
                throw new Multibanking.GuaranteeClient.Client.ApiException(400, "Missing required parameter 'commissionRequest' when calling GuaranteeCommissionApi->PrecalculateCommission");
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
            localVarRequestOptions.Data = commissionRequest;

            localVarRequestOptions.Operation = "GuaranteeCommissionApi.PrecalculateCommission";
            localVarRequestOptions.OperationIndex = operationIndex;


            // make the HTTP request
            var localVarResponse = await this.AsynchronousClient.PostAsync<CommissionResponseDto>("/commissions/precalculate", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("PrecalculateCommission", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

    }
}