using BepInEx;
using HarmonyLib;

namespace SelfReviveMultiplayer
{
    [BepInPlugin(GUID, NAME, VERSION)]
    public class SelfReviveMultiplayer : BaseUnityPlugin
    {
        public const string
            GUID = "SelfReviveMultiplayer",
            NAME = "SelfReviveMultiplayer",
            VERSION = "1.0.1";

        public void Awake()
        {
            Harmony.CreateAndPatchAll(typeof(MuckPatch));
            Logger.LogMessage("Loaded SelfReviveMultiplayer");
        }
    }
}
