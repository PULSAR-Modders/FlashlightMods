using HarmonyLib;

namespace Classlight
{
    [HarmonyPatch(typeof(PLPlayerController))]
    [HarmonyPatch("HandleFlashlight")]
    class Lightcolor
    {
        static void Postfix(PLPlayerController __instance)
        {
            if(__instance.MyPawn.Flashlight.color != PLPlayer.GetClassColorFromID(__instance.MyPawn.MyPlayer.GetClassID()))
            __instance.MyPawn.Flashlight.color = PLPlayer.GetClassColorFromID(__instance.MyPawn.MyPlayer.GetClassID());
        }
    }
}
