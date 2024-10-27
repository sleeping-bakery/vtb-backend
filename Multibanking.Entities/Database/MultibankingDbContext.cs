using System.Text.Json;
using System.Text.Json.Serialization;
using Microsoft.EntityFrameworkCore;
using Multibanking.Entities.Accounts;
using Multibanking.Entities.Cards;
using Multibanking.Entities.PeriodPayments;
using Multibanking.Entities.Users;
using Multibanking.PeriodPaymentClient.Model;

namespace Multibanking.Entities.Database;

public class MultibankingDbContext(DbContextOptions<MultibankingDbContext> options) : DbContext(options)
{
    public DbSet<User> Users { get; set; }

    public DbSet<UserAccountConsent> UserAccountConsents { get; set; }

    public DbSet<Card> Cards { get; set; }

    public DbSet<PeriodPaymentConsent> PeriodPaymentConsents { get; set; }
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<PeriodPaymentConsent>()
            .Property(u => u.ConsentBanking)
            .HasConversion(
                v => JsonSerializer.Serialize(v, new JsonSerializerOptions { DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull }),
                v => JsonSerializer.Deserialize<VRPConsentResponse>(v, new JsonSerializerOptions { PropertyNameCaseInsensitive = true })!)
            .HasColumnType("jsonb"); 
    }
}