using HarmonyLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChronianMugFix
{
    internal class Patches
    {
        [HarmonyPatch(typeof(Mug))]
        public static class JuniperMugFix
        {
            [HarmonyPatch("Awake")]
            [HarmonyPostfix]
            public static void Postfix(Mug __instance)
            {
                if (__instance.liquidMesh == null)
                {
                    __instance.gameObject.SetActive(false);
                }
            }

        }
    }
}
