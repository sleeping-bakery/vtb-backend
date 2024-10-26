using Microsoft.AspNetCore.Mvc;
using Multibanking.CardInformationClient.Model;
using Multibanking.Contracts.Card;
using Multibanking.Services.Cards;

namespace Multibanking.API.Controllers;

[ApiController]
[Route("[controller]")]
public class CardController(ICardService cardService) : ControllerBase
{
    [HttpPost]
    public ActionResult Post([FromQuery] CardCreateDto cardCreateDto)
    {
        cardService.CreateCard(cardCreateDto);
        return Ok();
    }
    
    [HttpGet("Detail")]
    public ActionResult<CredentialsResponse> GetDetail([FromQuery] Guid cardId)
    {
        return cardService.GetCardDetail(cardId);
    }
    
    [HttpGet("CVV")]
    public ActionResult<CvvResponse> GetCvv([FromQuery] Guid cardId)
    {
        return cardService.GetCardCvv(cardId);
    }

    [HttpGet]
    public ActionResult<List<CardReadDto>> Get()
    {
        return cardService.GetCards();
    }

    [HttpDelete]
    public ActionResult Delete([FromQuery] Guid cardId)
    {
        cardService.DeleteCard(cardId);
        return Ok();
    }

    [HttpPatch]
    public ActionResult Patch(CardUpdateDto cardUpdateDto)
    {
        cardService.UpdateCard(cardUpdateDto);
        return Ok();
    }
    
}