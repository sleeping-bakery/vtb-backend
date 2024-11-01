using Microsoft.AspNetCore.Mvc;
using Multibanking.BonusPointClient.Model;
using Multibanking.Contracts.BonusPoint;
using Multibanking.Services.BonusPoints;

namespace Multibanking.API.Controllers;

[ApiController]
[Route("[controller]")]
public class BonusPointController(IBonusPointService bonusPointService)
{
    [HttpGet]
    public RewardBalanceDataV2 Get([FromQuery] string accountId)
    {
        return bonusPointService.GetBonusPoints(accountId);
    }
    
    [HttpPost]
    public void Post(PostBonusPointDto postBonusPointDto)
    {
        bonusPointService.PostBonusPoints(postBonusPointDto);
    }
    
}