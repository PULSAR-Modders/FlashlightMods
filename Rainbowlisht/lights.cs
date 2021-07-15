using HarmonyLib;
using UnityEngine;

namespace Rainbowlisht
{
    [HarmonyPatch(typeof(PLPlayerController))]
    [HarmonyPatch("HandleMovement")]
    class Lights
    {
        static void Postfix(PLPawn ___MyPawn)
        {
            float time = Mathf.PingPong(Time.time / 2f, 1f);
            Gradient gradient = new Gradient();
            GradientColorKey[] array3 = new GradientColorKey[6];
            array3[0].color = Color.blue;
            array3[0].time = 0f;
            array3[1].color = Color.cyan;
            array3[1].time = 0.2f;
            array3[2].color = Color.green;
            array3[2].time = 0.4f;
            array3[3].color = Color.yellow;
            array3[3].time = 0.6f;
            array3[4].color = Color.magenta;
            array3[4].time = 0.8f;
            array3[5].color = Color.red;
            array3[5].time = 1f;
            GradientAlphaKey[] array4 = new GradientAlphaKey[2];
            array4[0].alpha = 1f;
            array4[0].time = 0f;
            array4[1].alpha = 1f;
            array4[1].time = 1f;
            gradient.SetKeys(array3, array4);
            ___MyPawn.Flashlight.color = gradient.Evaluate(time);
        }
    }
}
