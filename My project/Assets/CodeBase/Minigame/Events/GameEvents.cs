using System;

namespace CodeBase.Minigame.Events
{
    public static class GameEvents
    {
        public static Action<Card.Card> OnCardRevealed;
        public static Action OnAllPairsMatched;
    }
}
