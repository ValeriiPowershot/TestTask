using Core;
using Services;
using UnityEngine;

namespace UI
{
    public class MainMenuUI : MonoBehaviour
    {
        private void Start()
        {
            CurtainService curtain = GameInstaller.Container.Resolve<CurtainService>();
            curtain.Hide();
        }
    }
}
