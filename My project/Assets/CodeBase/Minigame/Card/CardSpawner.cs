using System.Collections.Generic;
using CodeBase.Minigame.Card;
using UnityEngine;

public class CardSpawner : MonoBehaviour
{
    [SerializeField] private GameObject cardPrefab;
    [SerializeField] private Transform boardParent;

    public List<Card> Spawn(List<CardData> deck)
    {
        var cards = new List<Card>();

        foreach (var data in deck)
        {
            var cardGO = Instantiate(cardPrefab, boardParent);
            var card = cardGO.GetComponent<Card>();
            card.Init(data);
            cards.Add(card);
        }

        return cards;
    }
}
