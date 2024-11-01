using Multibanking.BonusPointClient.Model;
using Multibanking.Contracts.BonusPoint;

namespace Multibanking.Services.BonusPoints;

public interface IBonusPointService
{
    RewardBalanceDataV2 GetBonusPoints(string accountId);

    void PostBonusPoints(PostBonusPointDto postBonusPointDto);
}