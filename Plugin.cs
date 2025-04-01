using BepInEx;
using BepInEx.Logging;
using System;
using BepInEx.Configuration;

namespace SAIN
{
    [BepInPlugin("com.saryn.sain", "SAIN", "3.11.2")]
    public class Plugin : BaseUnityPlugin
    {
        public static ConfigEntry<Boolean> Enable
        {
            get; set;
        }
        public static ManualLogSource LogSource;

        private void Awake()
        {
            LogSource = Logger;
            LogSource.LogInfo("APRIL FOOLS! HAHAHA!");
            {

                Enable = Config.Bind("Settings", "Enable", false, new ConfigDescription("Turns the mod on or off and opens the configuration panel.",
                    null, new ConfigurationManagerAttributes { IsAdvanced = false, Order = 1 }));


            }
        }
    }
}

