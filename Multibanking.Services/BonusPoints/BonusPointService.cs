using Multibanking.AccountClient.Model;
using Multibanking.BonusPointClient.Model;
using Multibanking.Contracts.BonusPoint;
using Multibanking.Data.OpenAPIBankClients.BonusPointClient;
using Multibanking.Services.Account;

namespace Multibanking.Services.BonusPoints;

public class BonusPointService(IBonusPointClient bonusPointClient, IAccountService accountService) : IBonusPointService
{
    private RewardBalanceDataV2 GetBonusPoints(AccountComplexType account)
    {
        var bonusPoint = bonusPointClient.GetRewardsBalance(Guid.NewGuid().ToString(), account.AccountId, Guid.NewGuid().ToString(), Guid.NewGuid().ToString());
        if (bonusPoint == null)
            throw new Exception("Со стороны банкинга не пришло ответа, попробуйте позже");
        return bonusPoint;
    }

    public void PostBonusPoints(PostBonusPointDto postBonusPointDto)
    {
        var account = accountService.GetAccountDetail(postBonusPointDto.AccountId).Data.Account.Single(account => account.AccountId == postBonusPointDto.AccountId);
        var bonusPoints = GetBonusPoints(account);
        var catalog = bonusPoints.Data.ProgramDetail.Catalogs.SingleOrDefault(catalog => catalog.CatalogId == postBonusPointDto.CatalogId);

        if (catalog == null)
            throw new Exception("Указанного каталога не существует в программе");

        bonusPointClient.ProcessRedemption(Guid.NewGuid().ToString(), Guid.NewGuid().ToString(), account.AccountId, Guid.NewGuid().ToString(),
            new RedemptionRequestDataV2(
                new RedemptionRequestV2(Guid.NewGuid().ToString(), postBonusPointDto.Amount, catalog.ConversionRate, bonusPoints.Data.ProgramDetail.ProgramId, catalog.CatalogId,
                    new RedemptionInfo(Guid.NewGuid().ToString(), postBonusPointDto.TransactionId)
                )
            ), Guid.NewGuid().ToString());
    }

    public RewardBalanceDataV2 GetBonusPoints(string accountId)
    {
        var account = accountService.GetAccountDetail(accountId).Data.Account.Single(account => account.AccountId == accountId);
        return GetBonusPoints(account);
    }
}