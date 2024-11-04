using System.Text.Json;
using System.Text.Json.Serialization;
using Microsoft.EntityFrameworkCore;
using Multibanking.Entities.Accounts;
using Multibanking.Entities.Cards;
using Multibanking.Entities.GuaranteeOrders;
using Multibanking.Entities.PeriodPayments;
using Multibanking.Entities.Users;
using Multibanking.GuaranteeClient.Model;
using Multibanking.PeriodPaymentClient.Model;

namespace Multibanking.Entities.Database;

public class MultibankingDbContext(DbContextOptions<MultibankingDbContext> options) : DbContext(options)
{
    public DbSet<User> Users { get; set; }

    public DbSet<UserAccountConsent> UserAccountConsents { get; set; }

    public DbSet<Card> Cards { get; set; }

    public DbSet<PeriodPaymentConsent> PeriodPaymentConsents { get; set; }
    
    public DbSet<GuaranteeOrder> GuaranteeOrders { get; set; }
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        var defaultIgnoreSerializerOptions = new JsonSerializerOptions { DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull };
        var caseInsensitiveSerializerOptions = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
        modelBuilder.Entity<PeriodPaymentConsent>()
            .Property(u => u.ConsentBanking)
            .HasConversion(
                v => JsonSerializer.Serialize(v, defaultIgnoreSerializerOptions),
                v => JsonSerializer.Deserialize<VRPConsentResponse>(v, caseInsensitiveSerializerOptions)!)
            .HasColumnType("jsonb"); 
        
        modelBuilder.Entity<GuaranteeOrder>()
            .Property(u => u.ResponseInit)
            .HasConversion(
                v => JsonSerializer.Serialize(v, defaultIgnoreSerializerOptions),
                v => JsonSerializer.Deserialize<OrderResponse>(v, caseInsensitiveSerializerOptions)!)
            .HasColumnType("jsonb"); 
    }
}