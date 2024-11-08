/*
 * Периодические  переводы денежных средств с переменными реквизитами
 *
 * Спецификация содержит описание элементов, которые являются общими для всех API на периодические  переводы денежных средств с переменными реквизитами (далее по тексту ППДС). В соответствии со стандартом ППДС Пользователь имеет право предоставить долгосрочное согласие на Услугу «Платежный сервис» СППУ с целью инициирования переводов средств от их имени, без необходимости аутентификации каждого отдельного платежа Пользователем у ППИУ. При этом ППИУ и СППУ реализуют взаимодействие для осуществления ППДС используя API.
 *
 * The version of the OpenAPI document: 1.3.0
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Multibanking.PeriodPaymentClient.Model;

/// <summary>
///     Abstract base class for oneOf, anyOf schemas in the OpenAPI specification
/// </summary>
public abstract class AbstractOpenAPISchema
{
    /// <summary>
    ///     Custom JSON serializer
    /// </summary>
    public static readonly JsonSerializerSettings SerializerSettings = new()
    {
        // OpenAPI generated types generally hide default constructors.
        ConstructorHandling = ConstructorHandling.AllowNonPublicDefaultConstructor,
        MissingMemberHandling = MissingMemberHandling.Error,
        ContractResolver = new DefaultContractResolver
        {
            NamingStrategy = new CamelCaseNamingStrategy
            {
                OverrideSpecifiedNames = false
            }
        }
    };

    /// <summary>
    ///     Custom JSON serializer for objects with additional properties
    /// </summary>
    public static readonly JsonSerializerSettings AdditionalPropertiesSerializerSettings = new()
    {
        // OpenAPI generated types generally hide default constructors.
        ConstructorHandling = ConstructorHandling.AllowNonPublicDefaultConstructor,
        MissingMemberHandling = MissingMemberHandling.Ignore,
        ContractResolver = new DefaultContractResolver
        {
            NamingStrategy = new CamelCaseNamingStrategy
            {
                OverrideSpecifiedNames = false
            }
        }
    };

    /// <summary>
    ///     Gets or Sets the actual instance
    /// </summary>
    public abstract object ActualInstance { get; set; }

    /// <summary>
    ///     Gets or Sets IsNullable to indicate whether the instance is nullable
    /// </summary>
    public bool IsNullable { get; protected set; }

    /// <summary>
    ///     Gets or Sets the schema type, which can be either `oneOf` or `anyOf`
    /// </summary>
    public string SchemaType { get; protected set; }

    /// <summary>
    ///     Converts the instance into JSON string.
    /// </summary>
    public abstract string ToJson();
}