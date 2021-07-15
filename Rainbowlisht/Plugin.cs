using PulsarPluginLoader;

namespace Rainbowlisht
{
    public class Plugin : PulsarPlugin
    {
        public override string Version => "1.0.2";

        public override string Author => "Engbot, Modified by Dragon and DeathsVendetta";

        public override string ShortDescription => "changes flashlight color to rainbow";

        public override string Name => "RainbowLight";

        public override string HarmonyIdentifier()
        {
            return "Kell.EngBot.Pulsar.rainbow";
        }
    }
}
