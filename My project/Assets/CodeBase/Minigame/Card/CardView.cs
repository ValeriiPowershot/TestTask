using UnityEngine;
using UnityEngine.UI;

namespace CodeBase.Minigame.Card
{
    public class CardView : MonoBehaviour
    {
        [SerializeField] private Image frontImage;
        [SerializeField] private GameObject front;
        [SerializeField] private GameObject back;

        public void ShowFront(Sprite image)
        {
            frontImage.sprite = image;
            front.SetActive(true);
            back.SetActive(false);
        }

        public void ShowBack()
        {
            front.SetActive(false);
            back.SetActive(true);
        }
    }
}
