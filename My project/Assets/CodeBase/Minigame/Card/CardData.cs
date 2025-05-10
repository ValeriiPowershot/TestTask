using UnityEngine;
using UnityEngine.Serialization;

namespace CodeBase.Minigame.Card
{
    [DisallowMultipleComponent] [CreateAssetMenu(menuName = "MemoryGame/Card Data")]
    public class CardData : ScriptableObject
    {
        public string Id;
        public Sprite Image;
    }
}

