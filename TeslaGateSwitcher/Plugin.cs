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

        public override System.Version Version { get; } = new System.Version(1, 0, 0);
        public override System.Version RequiredExiledVersion { get; } = new System.Version(8, 9, 11);
        public override PluginPriority Priority { get; } = PluginPriority.Medium;

        public bool IsTeslaGatesActivated { get; set; }
        public static Plugin plugin { get; private set; }


        public override void OnEnabled()
        {
            plugin = this;
            IsTeslaGatesActivated = Config.EnableTeslaGatesAtRoundStart;
            Exiled.Events.Handlers.Player.TriggeringTesla += OnTriggeringTesla;
            base.OnEnabled();
        }

        public override void OnDisabled()
        {
            Exiled.Events.Handlers.Player.TriggeringTesla -= OnTriggeringTesla;
            base.OnDisabled();
        }

        public void OnTriggeringTesla(TriggeringTeslaEventArgs ev)
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
        public string Command => "TeslaToggle";

        public string[] Aliases => new string[] { "tt" };

        public string Description => "Toggle tesla gates.";

        public bool Execute(ArraySegment<string> arguments, ICommandSender sender, out string response)
        {
            Plugin.plugin.IsTeslaGatesActivated = !Plugin.plugin.IsTeslaGatesActivated;
            response = $"Tesla gates toggled to: {(Plugin.plugin.IsTeslaGatesActivated ? "Enabled" : "Disabled")} mode";
            return true;
        }
    }
}
