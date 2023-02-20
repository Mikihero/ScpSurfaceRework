using System.ComponentModel;
using Exiled.API.Interfaces;

namespace ScpSurfaceRework
{
    public class Config : IConfig
    {
        [Description("Enables or disables the plugin.")]
        public bool IsEnabled { get; set; } = true;

        [Description("Whether or not debug messages should be shown in the console.")]
        public bool Debug { get; set; } = false;

        [Description("The value at which SCP-106's Hume Shield will be capped, set to -1 to disable. WARNING: Setting this value to 0 could cause SCP's to constantly hear the noise of HS breaking which could be considered as a violation of point 8.3.1 of VSR, use at your own discretion. Default: 350")]
        public float Scp106Hs { get; set; } = 350;

        [Description("The intensity of SCP-106's speed boost, set to 0 to disable. Default: 30")]
        public byte Scp106SpeedBoost { get; set; } = 30;
    }
}