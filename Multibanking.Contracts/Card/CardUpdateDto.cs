namespace Multibanking.Contracts.Card;

public class CardUpdateDto
{
    public required Guid Id { get; set; }

    /// <summary>
    ///     Статус карты
    /// </summary>
    public CardStatus? Status { get; set; }

    /// <summary>
    ///     Зашифрованный (RSA) публичным ключом пин-код
    /// </summary>
    public string? EncodedPinCode { get; set; }

    /// <summary>
    ///     Публичный ключ
    /// </summary>
    public string? PublicKey { get; set; }
}