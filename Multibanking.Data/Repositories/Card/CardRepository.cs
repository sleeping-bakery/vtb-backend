using Multibanking.Entities.Database;

namespace Multibanking.Data.Repositories.Card;

public class CardRepository(MultibankingDbContext dbContext) : Repository<Entities.Cards.Card>(dbContext), ICardRepository;