using System.Collections.Generic;
using CodeBase.Minigame.Card;
using UnityEngine;

namespace CodeBase.Minigame.Game
{
    public class GameHandler : MonoBehaviour, IGameInitializer
    {
        [SerializeField] private List<CardData> cardDataSet;
        [SerializeField] private CardSpawner cardSpawner;

        private CardShuffler shuffler;

        private void Awake()
        {
            shuffler = new CardShuffler();
        }

        private void Start()
        {
            InitializeGame();
        }

        public void InitializeGame()
        {
            var shuffledDeck = shuffler.CreateShuffledDeck(cardDataSet);
            var cards = cardSpawner.Spawn(shuffledDeck);
        }
    }
}
