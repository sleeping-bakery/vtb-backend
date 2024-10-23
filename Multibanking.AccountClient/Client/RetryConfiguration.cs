/*
 * Получение информации о счете клиента третьей стороной
 *
 * Содержит описываются API для Открытых банковских интерфейсов по счетам и транзакциям.
 *
 * The version of the OpenAPI document: 1.2.1
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using Polly;
using RestSharp;

namespace Multibanking.AccountClient.Client;

/// <summary>
///     Configuration class to set the polly retry policies to be applied to the requests.
/// </summary>
public static class RetryConfiguration
{
    /// <summary>
    ///     Retry policy
    /// </summary>
    public static Policy<RestResponse> RetryPolicy { get; set; }

    /// <summary>
    ///     Async retry policy
    /// </summary>
    public static AsyncPolicy<RestResponse> AsyncRetryPolicy { get; set; }
}