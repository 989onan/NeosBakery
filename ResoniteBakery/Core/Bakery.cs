using ResoniteModLoader;
using HarmonyLib;
using FrooxEngine;

namespace ResoniteBakery.Core
{
    class Bakery : ResoniteMod
    {
        public override string Name => "ResoniteBakery";
        public override string Author => "Toxic_Cookie 989onan";
        public override string Version => "2.0.0";
        public override string Link => "https://github.com/Toxic-Cookie/ResoniteBakery";

        public static ModConfiguration Config;


        [AutoRegisterConfigKey]
        public static ModConfigurationKey<string> blenderpath = new ModConfigurationKey<string>("blender path to use", "BlenderPath", () => "C:\\Program Files\\Blender Foundation\\Blender 3.0\\blender.exe");
        public override void OnEngineInit()
        {
            Harmony harmony = new Harmony("net.Toxic_Cookie.ResoniteBakery");
            Config = GetConfiguration();
            Config.Save(true);
            harmony.PatchAll();
            Paths.EnsureAllPathsExist();
            DevCreateNewForm.AddAction("Editor", "Light Baker Wizard", delegate (Slot s)
            {
                LightBakerWizard.GetOrCreateWizard(s);
            });
        }
    }
}
