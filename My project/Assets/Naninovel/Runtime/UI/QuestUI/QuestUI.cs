using Naninovel.UI;
using TMPro;
using UnityEngine;
using UnityEngine.Serialization;

namespace Naninovel.Runtime.UI.QuestUI
{
    public class QuestUI : CustomUI
    {
        [SerializeField] private TextMeshProUGUI _questTitleText; 
        [SerializeField] private TextMeshProUGUI _questDescriptionText;
        
        public void SetTitle(string text)
        {
            _questTitleText.text = text;
        }

        public void SetDescription(string text)
        {
            _questDescriptionText.text = text;
        }
    }
}
