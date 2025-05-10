using Naninovel;
using UnityEngine;

[DisallowMultipleComponent]
public class MainMenu : MonoBehaviour
{
    public async void OnStartButton ()
    {
        //await ScriptPlayer.PreloadAndPlayAsync("Intro");
    }

    public void OnExitButton ()
    {
        Application.Quit();
    }
}
