using System.Collections.Generic;
using Exiled.API.Enums;
using Exiled.API.Features;
using MEC;
using PlayerRoles;
using Player = Exiled.API.Features.Player;

namespace ScpSurfaceRework
{
    public class EventHandlers
    {
        public void OnDetonated()
        {
            var scps = Player.Get(Side.Scp);
            foreach (Player pl in scps)
            {
                if (Plugin.Instance.Config.Boost049 && pl.Role.Type == RoleTypeId.Scp049)
                {
                    pl.ChangeEffectIntensity(EffectType.MovementBoost, Plugin.Instance.Config.Scp049SpeedBoost);
                    Log.Debug($"Applied effect to {pl.Nickname}({pl.RawUserId}) playing as {pl.Role.Name}.");
                }
                if (pl.Role.Type == RoleTypeId.Scp106)
                {
                    if(Plugin.Instance.Config.Boost106)
                    {
                        pl.ChangeEffectIntensity(EffectType.MovementBoost, Plugin.Instance.Config.Scp106SpeedBoost);
                        Log.Debug($"Applied effect to {pl.Nickname}({pl.RawUserId}) playing as {pl.Role.Name}.");
                    }

                    if (Plugin.Instance.Config.Change106Hs)
                    {
                        Log.Info("asd");
                        pl.MaxHumeShield = /*Plugin.Instance.Config.Scp106Hs*/0;
                    }
                }
                if (/*Plugin.Instance.Config.Boost049 && */pl.Role.Type == RoleTypeId.Scp939)
                {
                    //pl.ChangeEffectIntensity(EffectType.MovementBoost, Plugin.Instance.Config.Scp049SpeedBoost);
                    Log.Debug($"Applied effect to {pl.Nickname}({pl.RawUserId}) playing as {pl.Role.Name}.");
                    pl.MaxHumeShield = 0;
                    Log.Info("asd");
                }
            }
        }

        public IEnumerator<float> Change106Health(Player pl)
        {
            while (true)
            {
                if (Plugin.Instance.Config.Change106Hs)
                {
                    if (pl.HumeShield > Plugin.Instance.Config.Scp106Hs)
                    {
                        pl.HumeShield = Plugin.Instance.Config.Scp106Hs;
                    }
                }

                yield return Timing.WaitForSeconds(1f);
            }
        }
    }
}