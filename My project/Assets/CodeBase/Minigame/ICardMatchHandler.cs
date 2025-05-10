namespace CodeBase.Minigame
{
    public interface ICardMatchHandler
    {
        bool CanRevealCard(global::CodeBase.Minigame.Card.Card card);
        void OnCardRevealed(global::CodeBase.Minigame.Card.Card card);
    }
}
