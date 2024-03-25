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

        public override void OnEngineInit()
        {
            Harmony harmony = new Harmony("net.Toxic_Cookie.ResoniteBakery");
            harmony.PatchAll();
            DevCreateNewForm.AddAction("Editor", "Light Baker Wizard", delegate (Slot s)
            {
                LightBakerWizard.GetOrCreateWizard();
            });
        }
    }
}
