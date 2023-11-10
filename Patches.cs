using HarmonyLib;

namespace SelfReviveMultiplayer
{
    public class MuckPatch
    {
        [HarmonyPostfix, HarmonyPatch(typeof(GraveInteract), nameof(GraveInteract.Update))]
        public static void Update(ref GraveInteract __instance, ref int ___id)
        {
            if (__instance.timeLeft <= 0f)
            {
                ClientSend.RevivePlayer(__instance.playerId, ___id, grave: true);
            }
        }

    }
}
