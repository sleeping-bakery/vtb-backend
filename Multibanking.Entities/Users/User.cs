using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using Multibanking.Contracts.Consent.Enums;

namespace Multibanking.Entities.Users;

/// <summary>
/// Пользователь системы
/// </summary>
[Table(nameof(User))]
[Index(nameof(Login), IsUnique = true)]
public class User : IEntity
{
    // ReSharper disable once EmptyConstructor
    public User()
    {
    }

    /// <summary>
    /// Идентификатор пользователя
    /// </summary>
    public Guid Id { get; set; }

    /// <summary>
    /// Согласия пользователя на операции со счетами
    /// </summary>
    [Required]
    public required List<AccountConsent> AccountConsents { get; set; }

    /// <summary>
    /// Логин пользователя
    /// </summary>
    [Required]
    [Length(5, 255)]
    public required string Login { get; set; }
}