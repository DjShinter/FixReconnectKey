using ABI_RC.Core.Networking;
using HarmonyLib;
using MelonLoader;

namespace FixReconnectKey
{
    public static class ModBuildInfo
    {
        public const string Name = "FixReconnectKey";
        public const string Author = "Shin";
        public const string Version = "1.0";
        public const string Description = "This removes the minus hotkey since it was never supposed to be shipped.";
        public const string DownloadLink = "https://github.com/DjShinter";
    }

    public class FixReconnectKeyMod : MelonMod
    {
        public static HarmonyLib.Harmony Instance = new HarmonyLib.Harmony("FixReconnectKeyMod");
        public override void OnInitializeMelon()
        {
            Instance.PatchAll();
            MelonLogger.Msg("NetworkManager Patched");
            MelonLogger.Msg("This should only be used in 2022r170, otherwise this may cause issues!");
        }

        [HarmonyPatch(typeof(NetworkManager), "Update")]
        public class RemoveNetworkManagerKeybinding
        {
            [HarmonyPrefix]
            public static bool Prefix()
            {
                return false;
            }
        }

    }
}
