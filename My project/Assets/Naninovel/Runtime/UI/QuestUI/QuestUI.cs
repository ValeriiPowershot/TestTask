using Naninovel.UI;
using TMPro;
using UnityEngine.Serialization;

namespace Naninovel.Runtime.UI.QuestUI
{
    public class QuestUI : CustomUI
    {
        public TextMeshProUGUI QuestText;

        public void SetText(string text)
        {
            QuestText.text = text;
        }
    }
}
