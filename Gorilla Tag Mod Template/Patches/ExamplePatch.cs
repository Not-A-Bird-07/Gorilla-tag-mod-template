using HarmonyLib;
using UnityEngine;

namespace Gorilla_Tag_Mod_Template.Patches
{
    [HarmonyPatch(typeof(GorillaLocomotion.Player), "Awake")]
    public class ExamplePatch
    {
        public static void Postfix()
        {
            Debug.Log("Example Patch");//this is so that the template includes the folder, don't actually need this
        }
    }
}
