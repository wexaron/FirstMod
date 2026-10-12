using MelonLoader;

namespace FirstMod
{
    public static class BuildInfo
    {
        public const string Name = "";
        public const string Description = "";
        public const string Author = "";
        public const string Company = null;
        public const string Version = "1.0.0";
        public const string DownloadLink = null;
    }

    public class ModTemplate : MelonMod
    {
        public override void OnSceneWasLoaded(int buildIndex, string sceneName)
        {
            // This checks if the game scene loaded
            if (buildIndex != 1) return;

            MelonLogger.Msg("This mod seems to work");
        }

        public override void OnSceneWasUnloaded(int buildIndex, string sceneName)
        {
            // This checks if the game scene unloaded
            if (buildIndex != 1) return;
        }
    }
}