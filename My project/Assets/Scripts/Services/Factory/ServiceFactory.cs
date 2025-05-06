using UI;
using UnityEngine;

namespace Services.Factory
{
    public static class ServiceFactory
    {
        public static CurtainService CreateCurtain(bool enabled = true)
        {
            CurtainView prefab = Resources.Load<CurtainView>("CurtainPrefab");
            CurtainView instance = Object.Instantiate(prefab);
            Object.DontDestroyOnLoad(instance);

            return new CurtainService(instance, enabled);
        }
    }
}
