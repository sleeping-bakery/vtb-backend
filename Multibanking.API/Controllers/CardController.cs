using Microsoft.AspNetCore.Mvc;
using Multibanking.CardInformationClient.Model;
using Multibanking.Contracts.Card;
using Multibanking.Services.Cards;

namespace Multibanking.API.Controllers;

[ApiController]
[Route("[controller]")]
public class CardController(ICardService cardService) : ControllerBase
{
    /// <summary>
    ///     Открыть (создать) карту
    /// </summary>
    /// <param name="cardCreateDto"></param>
    /// <returns></returns>
    [HttpPost]
    public ActionResult Post([FromQuery] CardCreateDto cardCreateDto)
    {
        cardService.CreateCard(cardCreateDto);
        return Ok();
    }

    /// <summary>
    ///     Получить реквизиты карты (номер, срок действия, владелец)
    /// </summary>
    /// <param name="cardId"></param>
    /// <returns></returns>
    [HttpGet("Detail")]
    public ActionResult<CredentialsResponse> GetDetail([FromQuery] Guid cardId)
    {
        return cardService.GetCardDetail(cardId);
    }

    /// <summary>
    ///     Получить CVV карты
    /// </summary>
    /// <param name="cardId"></param>
    /// <returns></returns>
    [HttpGet("CVV")]
    public ActionResult<CvvResponse> GetCvv([FromQuery] Guid cardId)
    {
        return cardService.GetCardCvv(cardId);
    }

    /// <summary>
    ///     Получить все карты пользователя
    /// </summary>
    /// <returns></returns>
    [HttpGet]
    public ActionResult<List<CardReadDto>> Get()
    {
        return cardService.GetCards();
    }

    /// <summary>
    ///     Удалить карту
    /// </summary>
    /// <param name="cardId"></param>
    /// <returns></returns>
    [HttpDelete]
    public ActionResult Delete([FromQuery] Guid cardId)
    {
        cardService.DeleteCard(cardId);
        return Ok();
    }

    /// <summary>
    ///     Обновить данные карты (статус, пин-код). Пин-код должен быть зашифрованным ключем и передан вместе с публичным ключом.
    /// </summary>
    /// <param name="cardUpdateDto"></param>
    /// <returns></returns>
    [HttpPatch]
    public ActionResult Patch(CardUpdateDto cardUpdateDto)
    {
        cardService.UpdateCard(cardUpdateDto);
        return Ok();
    }
}