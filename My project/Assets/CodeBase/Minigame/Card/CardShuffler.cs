using System.Collections.Generic;
using CodeBase.Minigame.Card;
using UnityEngine;

public class CardShuffler
{
    public List<CardData> CreateShuffledDeck(List<CardData> baseSet)
    {
        var fullDeck = new List<CardData>();
        foreach (var data in baseSet)
        {
            fullDeck.Add(data);
            fullDeck.Add(data);
        }

        for (int i = 0; i < fullDeck.Count; i++)
        {
            var temp = fullDeck[i];
            int randIndex = Random.Range(i, fullDeck.Count);
            fullDeck[i] = fullDeck[randIndex];
            fullDeck[randIndex] = temp;
        }

        return fullDeck;
    }
}
