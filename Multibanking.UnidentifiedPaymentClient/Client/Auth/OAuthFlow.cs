/*
 * Инициирование перевода денежных средств клиента третьей стороной
 *
 * Содержит описываются API для Открытых банковских интерфейсов по переводам.
 *
 * The version of the OpenAPI document: 1.1.0
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


namespace Multibanking.UnidentifiedPaymentClient.Client.Auth
{
    /// <summary>
    /// Available flows for OAuth2 authentication
    /// </summary>
    public enum OAuthFlow
    {
        /// <summary>Authorization code flow</summary>
        ACCESS_CODE,
        /// <summary>Implicit flow</summary>
        IMPLICIT,
        /// <summary>Password flow</summary>
        PASSWORD,
        /// <summary>Client credentials flow</summary>
        APPLICATION
    }
}