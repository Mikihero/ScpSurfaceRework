# ScpSurfaceRework
<a href="https://github.com/Mikihero/ScpSurfaceRework/releases"><img src="https://img.shields.io/github/downloads/Mikihero/ScpSurfaceRework/total?label=Downloads" alt="Downloads"></a>

An SCP:SL EXILED plugin designed to allow server owners to balance the SCP's after warhead has been detonated.

# Default Config
```yaml
scp_surface_rework:
  # Enables or disables the plugin.
  is_enabled: true
  # Whether or not debug messages should be shown in the console.
  debug: false
  # The value at which SCP-173's Hume Shield will be capped (won't work if it goes over the default HS cap), set to -1 to disable. WARNING: Setting this value to 0 could cause SCP's to constantly hear the noise of HS breaking which could be considered as a violation of point 8.3.1 of VSR, use at your own discretion. Default: 1500
  scp173_hs: 1500
  # The intensity of SCP-173's speed boost, set to 0 to disable, max is 255. Default: 30
  scp173_speed_boost: 30
  # The value at which SCP-106's Hume Shield will be capped (won't work if it goes over the default HS cap), set to -1 to disable. WARNING: Setting this value to 0 could cause SCP's to constantly hear the noise of HS breaking which could be considered as a violation of point 8.3.1 of VSR, use at your own discretion. Default: 350
  scp106_hs: 350
  # The intensity of SCP-106's speed boost, set to 0 to disable, max is 255. Default: 30
  scp106_speed_boost: 30
  # Should SCP-106 1 shot people after warhead was detonated like he used to? Default: true
  scp106_one_shot: true
  # The value at which SCP-049's Hume Shield will be capped (won't work if it goes over the default HS cap), set to -1 to disable. WARNING: Setting this value to 0 could cause SCP's to constantly hear the noise of HS breaking which could be considered as a violation of point 8.3.1 of VSR, use at your own discretion. Default: 700
  scp049_hs: 700
  # The intensity of SCP-049's speed boost, set to 0 to disable, max is 255. Default: 30
  scp049_speed_boost: 30
  # The amount of HS SCP-049 will get for a successful revive after warhead was detonated. Default: 100
  scp049_bonus_hs: 100
  # The value at which SCP-096's Hume Shield will be capped (won't work if it goes over the default HS cap), set to -1 to disable. WARNING: Setting this value to 0 could cause SCP's to constantly hear the noise of HS breaking which could be considered as a violation of point 8.3.1 of VSR, use at your own discretion. Default: 500
  scp096_hs: 500
  # The intensity of SCP-096's speed boost, set to 0 to disable, max is 255. Default: 30
  scp096_speed_boost: 30
  # The value at which SCP-049-2's Hume Shield will be capped (won't work if it goes over the default HS cap), set to -1 to disable. WARNING: Setting this value to 0 could cause SCP's to constantly hear the noise of HS breaking which could be considered as a violation of point 8.3.1 of VSR, use at your own discretion. Default: -1
  scp0492_hs: -1
  # The intensity of SCP-049-2's speed boost, set to 0 to disable, max is 255. Default: 30
  scp0492_speed_boost: 30
  # The value at which SCP-939's Hume Shield will be capped (won't work if it goes over the default HS cap), set to -1 to disable. WARNING: Setting this value to 0 could cause SCP's to constantly hear the noise of HS breaking which could be considered as a violation of point 8.3.1 of VSR, use at your own discretion. Default: 800
  scp939_hs: 800
  # The intensity of SCP-939's speed boost, set to 0 to disable, max is 255. Default: 30
  scp939_speed_boost: 30
```