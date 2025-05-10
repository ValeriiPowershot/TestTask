using System.Collections;
using System.Collections.Generic;
using System.Linq;
using CodeBase.Minigame.Card;
using CodeBase.Minigame.Events;
using UnityEngine;

namespace CodeBase.Minigame.Game
{
    public class CardMatcher : MonoBehaviour
    {
        private List<Card.Card> revealedCards = new();

        private void OnEnable()
        {
            GameEvents.OnCardRevealed += HandleCardRevealed;
        }

        private void OnDisable()
        {
            GameEvents.OnCardRevealed -= HandleCardRevealed;
        }

        private void HandleCardRevealed(Card.Card card)
        {
            // Игнорируем, если уже кликнута или две карты уже открыты
            if (revealedCards.Contains(card) || CardInputBlocker.IsBlocked)
                return;

            revealedCards.Add(card);

            if (revealedCards.Count == 2)
            {
                // Начинаем проверку совпадения
                StartCoroutine(CheckMatch());
            }
        }

        private IEnumerator CheckMatch()
        {
            CardInputBlocker.IsBlocked = true;

            yield return new WaitForSeconds(1f);

            if (revealedCards[0].Data.Id == revealedCards[1].Data.Id)
            {
                Debug.Log("Карты совпали!");
            }
            else
            {
                revealedCards[0].Hide();
                revealedCards[1].Hide();
            }

            revealedCards.Clear();

            CardInputBlocker.IsBlocked = false;

            if (FindObjectsOfType<Card.Card>().All(c => c.IsRevealed))
            {
                GameEvents.OnAllPairsMatched?.Invoke();
                Debug.Log("s");
            }
        }
    }
}
