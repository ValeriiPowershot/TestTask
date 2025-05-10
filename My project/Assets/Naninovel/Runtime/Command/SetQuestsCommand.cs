using Naninovel;
using Naninovel.Runtime.UI.QuestUI;
using UnityEngine.Serialization;

[CommandAlias("setQuest")]
public class SetQuestsText : Command
{
    [ParameterAlias("title")]
    public StringParameter TitleText;

    [ParameterAlias("description")]
    public StringParameter DescriptionText;

    public override async UniTask ExecuteAsync(AsyncToken token)
    {
        var uiManager = Engine.GetService<UIManager>();
        var questUI = uiManager.GetUI<QuestUI>();

        if (questUI != null && questUI.gameObject.activeInHierarchy)
        {
            questUI.SetTitle(TitleText);
            questUI.SetDescription(DescriptionText);
        }

        await UniTask.CompletedTask;
    }
}
