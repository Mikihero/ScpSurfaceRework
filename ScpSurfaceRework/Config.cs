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

        [Description("The value at which SCP-173's Hume Shield will be capped (won't work if it goes over the default HS cap), set to -1 to disable. WARNING: Setting this value to 0 could cause SCP's to constantly hear the noise of HS breaking which could be considered as a violation of point 8.3.1 of VSR, use at your own discretion. Default: 350")]
        public float Scp173Hs { get; set; } = 350;

        [Description("The intensity of SCP-173's speed boost, set to 0 to disable, max is 255. Default: 30")]
        public byte Scp173SpeedBoost { get; set; } = 30;
        
        [Description("The value at which SCP-106's Hume Shield will be capped (won't work if it goes over the default HS cap), set to -1 to disable. WARNING: Setting this value to 0 could cause SCP's to constantly hear the noise of HS breaking which could be considered as a violation of point 8.3.1 of VSR, use at your own discretion. Default: 350")]
        public float Scp106Hs { get; set; } = 350;

        [Description("The intensity of SCP-106's speed boost, set to 0 to disable, max is 255. Default: 30")]
        public byte Scp106SpeedBoost { get; set; } = 30;

        [Description("Should SCP-106 1 shot people after warhead was detonated like he used to? Default: true")]
        public bool Scp106OneShot { get; set; } = true;

        [Description("The value at which SCP-049's Hume Shield will be capped (won't work if it goes over the default HS cap), set to -1 to disable. WARNING: Setting this value to 0 could cause SCP's to constantly hear the noise of HS breaking which could be considered as a violation of point 8.3.1 of VSR, use at your own discretion. Default: 350")]
        public float Scp049Hs { get; set; } = 350;

        [Description("The intensity of SCP-049's speed boost, set to 0 to disable, max is 255. Default: 30")]
        public byte Scp049SpeedBoost { get; set; } = 30;
        
        [Description("The amount of HS SCP-049 will get for a successful revive after warhead was detonated. Default: 50")]
        public float Scp049BonusHs { get; set; } = 50;
        
        [Description("The value at which SCP-096's Hume Shield will be capped (won't work if it goes over the default HS cap), set to -1 to disable. WARNING: Setting this value to 0 could cause SCP's to constantly hear the noise of HS breaking which could be considered as a violation of point 8.3.1 of VSR, use at your own discretion. Default: 350")]
        public float Scp096Hs { get; set; } = 350;

        [Description("The intensity of SCP-096's speed boost, set to 0 to disable, max is 255. Default: 30")]
        public byte Scp096SpeedBoost { get; set; } = 30;
        
        [Description("The value at which SCP-049-2's Hume Shield will be capped (won't work if it goes over the default HS cap), set to -1 to disable. WARNING: Setting this value to 0 could cause SCP's to constantly hear the noise of HS breaking which could be considered as a violation of point 8.3.1 of VSR, use at your own discretion. Default: 350")]
        public float Scp0492Hs { get; set; } = 350;

        [Description("The intensity of SCP-049-2's speed boost, set to 0 to disable, max is 255. Default: 30")]
        public byte Scp0492SpeedBoost { get; set; } = 30;
        
        [Description("The value at which SCP-939's Hume Shield will be capped (won't work if it goes over the default HS cap), set to -1 to disable. WARNING: Setting this value to 0 could cause SCP's to constantly hear the noise of HS breaking which could be considered as a violation of point 8.3.1 of VSR, use at your own discretion. Default: 350")]
        public float Scp939Hs { get; set; } = 350;

        [Description("The intensity of SCP-939's speed boost, set to 0 to disable, max is 255. Default: 30")]
        public byte Scp939SpeedBoost { get; set; } = 30;
    }
}