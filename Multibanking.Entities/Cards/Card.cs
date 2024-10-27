using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Multibanking.Contracts.Card;
using Multibanking.Entities.Users;

namespace Multibanking.Entities.Cards;

public class Card : IEntity
{
    [Required] public required string AccountId { get; set; }

    [Required] [ForeignKey(nameof(User))] public required Guid UserId { get; set; }

#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
    public User User { get; set; }
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.

    [Required] public required string Pan { get; set; }

    [Required] public required string PublicId { get; set; }

    [Required] public required CardStatus Status { get; set; }

    /// <summary>
    ///     Идентификатор карты
    /// </summary>
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public Guid Id { get; set; }
}