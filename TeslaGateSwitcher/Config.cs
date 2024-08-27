using Exiled.API.Interfaces;
using System.ComponentModel;

namespace TeslaGateSwitcher
{
    public class Config : IConfig
    {
        [Description("Plugin Enabled?")]
        public bool IsEnabled { get; set; } = true;
        [Description("Enable debug?")]
        public bool Debug { get; set; } = false;
        [Description("Will the Tesla gates be enabled at the start of the round?")]
        public bool EnableTeslaGatesAtRoundStart { get; set; } = true;
    }
}
