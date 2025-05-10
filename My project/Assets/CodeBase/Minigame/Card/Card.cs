using CodeBase.Minigame.Events;
using UnityEngine;

namespace CodeBase.Minigame.Card
{
    public class Card : MonoBehaviour
    {
        [SerializeField] private CardView view;
        private CardData data;
        private bool isRevealed;

        public CardData Data => data;
        public bool IsRevealed => isRevealed;

        public void Init(CardData cardData)
        {
            data = cardData;
            isRevealed = false;
            view.ShowBack();
        }

        public void Reveal()
        {
            if (isRevealed || CardInputBlocker.IsBlocked) return;

            isRevealed = true;
            view.ShowFront(data.Image);
            GameEvents.OnCardRevealed?.Invoke(this);
        }

        public void Hide()
        {
            isRevealed = false;
            view.ShowBack();
        }
    }
}
