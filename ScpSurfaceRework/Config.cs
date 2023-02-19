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

        [Description("Should SCP-049 get a speed boost? Default: true")]
        public bool Boost049 { get; set; } = true;
        
        [Description("The intensity of SCP-049's speed boost. Default: 30")]
        public byte Scp049SpeedBoost { get; set; } = 30;

        [Description("Should SCP-106's Hume Shield be capped at a certain value? Default: true")]
        public bool Change106Hs { get; set; } = true;
        
        [Description("The value at which SCP-106's Hume Shield will be capped. Default: 0")]
        public float Scp106Hs { get; set; } = 0;
        
        [Description("Should SCP-049 get a speed boost? Default: true")]
        public bool Boost106 { get; set; } = true;
        
        [Description("The intensity of SCP-049's speed boost. Default: 30")]
        public byte Scp106SpeedBoost { get; set; } = 30;
    }
}