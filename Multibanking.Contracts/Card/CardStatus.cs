namespace Multibanking.Contracts.Card;

public enum CardStatus
{
    /// <summary>
    /// Заблокирована
    /// </summary>
    Block = 1,

    /// <summary>
    /// Активна
    /// </summary>
    Active = 2,

    /// <summary>
    /// Перманентно заблокирована. Нельзя обновить
    /// </summary>
    PermanentBlock = 3
}