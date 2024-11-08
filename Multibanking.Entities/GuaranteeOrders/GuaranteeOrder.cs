using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Multibanking.Entities.Users;
using Multibanking.GuaranteeClient.Model;

namespace Multibanking.Entities.GuaranteeOrders;

public class GuaranteeOrder : IEntity
{
    [Required] [ForeignKey(nameof(User))] public Guid UserId { get; set; }

    [Required]
    [Column(TypeName = "jsonb")]
    public required OrderResponse ResponseInit { get; set; }

    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public Guid Id { get; set; }
}