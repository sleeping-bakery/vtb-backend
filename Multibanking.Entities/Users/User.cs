using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using Multibanking.Contracts.Consent.Enums;
using Multibanking.Entities.Accounts;
using Multibanking.Entities.Cards;

namespace Multibanking.Entities.Users;

/// <summary>
///     Пользователь системы
/// </summary>
[Table(nameof(User))]
[Index(nameof(Login), IsUnique = true)]
public class User : IEntity
{
    /// <summary>
    ///     Согласия пользователя на операции со счетами
    /// </summary>
    [Required]
    public required List<AccountConsent> AccountConsents { get; set; }

    /// <summary>
    ///     Логин пользователя
    /// </summary>
    [Required]
    public required string Login { get; set; }

    public UserAccountConsent? UserAccountConsent { get; set; }

    // ReSharper disable once CollectionNeverUpdated.Global
    public required List<Card> Cards { get; set; }

    /// <summary>
    ///     Идентификатор пользователя
    /// </summary>
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public Guid Id { get; set; }
}