using MelonLoader;
using UnityEngine;
using ModThatIsNotMod.BoneMenu;

namespace VignetteRemover
{
    public static class BuildInfo
    {
        public const string Name = "Vignette Remover";
        public const string Author = "DarkSwitchPro";
        public const string Company = null;
        public const string Version = "1.0.0";
        public const string DownloadLink = null;
    }

    public class VignetteRemover : MelonMod 
    {
        public override void OnSceneWasInitialized(int buildindex, string sceneName)
        {
            GameObject.Find("Vignetter").SetActive(false);
        }
    }
}
