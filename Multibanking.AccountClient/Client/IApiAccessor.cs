/*
 * Получение информации о счете клиента третьей стороной
 *
 * Содержит описываются API для Открытых банковских интерфейсов по счетам и транзакциям.
 *
 * The version of the OpenAPI document: 1.2.1
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


namespace Multibanking.AccountClient.Client;

/// <summary>
///     Represents configuration aspects required to interact with the API endpoints.
/// </summary>
public interface IApiAccessor
{
    /// <summary>
    ///     Gets or sets the configuration object
    /// </summary>
    /// <value>An instance of the Configuration</value>
    IReadableConfiguration Configuration { get; set; }

    /// <summary>
    ///     Provides a factory method hook for the creation of exceptions.
    /// </summary>
    ExceptionFactory ExceptionFactory { get; set; }

    /// <summary>
    ///     Gets the base path of the API client.
    /// </summary>
    /// <value>The base path</value>
    string GetBasePath();
}