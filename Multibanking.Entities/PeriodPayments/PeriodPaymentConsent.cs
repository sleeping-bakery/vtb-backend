using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Multibanking.Entities.Cards;
using Multibanking.Entities.Users;
using Multibanking.PeriodPaymentClient.Model;

namespace Multibanking.Entities.PeriodPayments;

public class PeriodPaymentConsent : IEntity
{
    [Required] [ForeignKey(nameof(Card))] public Guid CardId { get; set; }
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
    public Card Card { get; set; }

    [Column(TypeName = "jsonb")] public VRPConsentResponse ConsentBanking { get; set; }
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.

    [Required] [ForeignKey(nameof(User))] public Guid UserId { get; set; }

    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public Guid Id { get; set; }
}