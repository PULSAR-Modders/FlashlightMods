using PulsarPluginLoader;

namespace Classlight
{
    public class Plugin : PulsarPlugin
    {
        public override string Version => "1.0.2";

        public override string Author => "EngBot, modified by Dragon, WeaponsPlus, and DeathsVendetta";

        public override string ShortDescription => "Modifies flashlight color";

        public override string Name => "ClassLight";

       public override string HarmonyIdentifier()
        {
            return "Kell.EngBot.Pulsar.ClassLight";
        }
    }
}
