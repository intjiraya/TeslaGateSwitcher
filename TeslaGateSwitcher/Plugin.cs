using CommandSystem;
using Exiled.API.Enums;
using Exiled.API.Features;
using Exiled.Events.EventArgs.Player;
using System;

namespace TeslaGateSwitcher
{
    public class Plugin : Plugin<Config>
    {
        public override string Author { get; } = "Jiraya";
        public override string Name { get; } = "TeslaGateSwitcher";
        public override string Prefix { get; } = "TeslaGateSwitcher";

        public override Version Version => new Version(1, 1, 0);
        public override Version RequiredExiledVersion => new Version(8, 9, 11);
        public override PluginPriority Priority => PluginPriority.Medium;

        public bool IsTeslaGatesActivated { get; set; }
        public static Plugin Instance { get; private set; }


        public override void OnEnabled()
        {
            Instance = this;
            IsTeslaGatesActivated = Config.EnableTeslaGatesAtRoundStart;
            Exiled.Events.Handlers.Player.TriggeringTesla += OnTriggeringTesla;
            base.OnEnabled();
        }

        public override void OnDisabled()
        {
            Exiled.Events.Handlers.Player.TriggeringTesla -= OnTriggeringTesla;
            base.OnDisabled();
        }

        private void OnTriggeringTesla(TriggeringTeslaEventArgs ev)
        {
            if (!IsTeslaGatesActivated)
            {
                ev.IsAllowed = false;
            }
        }
    }

    [CommandHandler(typeof(RemoteAdminCommandHandler))]
    public class TeslaToggle : ICommand
    {
        public string Command => "teslatoggle";
        public string[] Aliases => new[] { "tt", "tesla" };
        public string Description => "Toggle tesla gates.";


        public bool Execute(ArraySegment<string> arguments, ICommandSender sender, out string response)
        {
            Plugin.Instance.IsTeslaGatesActivated = !Plugin.Instance.IsTeslaGatesActivated;
            response = $"Tesla gates toggled to: {(Plugin.Instance.IsTeslaGatesActivated ? "Enabled" : "Disabled")} mode";
            return true;
        }
    }
}
