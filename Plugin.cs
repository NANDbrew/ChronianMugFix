using BepInEx;
using BepInEx.Configuration;
using HarmonyLib;
using System;
using System.Reflection;

namespace ChronianMugFix
{
    [BepInPlugin(PLUGIN_ID, PLUGIN_NAME, PLUGIN_VERSION)]
    //[BepInDependency("com.app24.sailwindmoddinghelper", "2.0.3")]
    public class Plugin : BaseUnityPlugin
    {
        public const string PLUGIN_ID = "com.nandbrew.ChronianMugFix";
        public const string PLUGIN_NAME = "Chronian Mug Fix";
        public const string PLUGIN_VERSION = "0.0.1";

        //--settings--
        //internal ConfigEntry<bool> someSetting;


        private void Awake()
        {
            Harmony.CreateAndPatchAll(Assembly.GetExecutingAssembly(), PLUGIN_ID);

            //someSetting = Config.Bind("Settings", "Some setting", false);
        }
    }
}
