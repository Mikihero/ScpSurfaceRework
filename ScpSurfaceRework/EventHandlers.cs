using System.Collections.Generic;
using Exiled.API.Enums;
using MEC;
using Exiled.API.Features;
using Exiled.Events.EventArgs.Player;
using Exiled.Events.EventArgs.Scp049;
using PlayerRoles;
using PlayerStatsSystem;

namespace ScpSurfaceRework
{
    public class EventHandlers
    {
        private Config _cfg = Plugin.Instance.Config;
        public void OnDetonated()
        {
            var scps = Player.Get(Side.Scp);
            foreach (Player pl in scps)
            {
                if (pl.Role.Type == RoleTypeId.Scp106)
                {
                    Timing.RunCoroutine(ChangeScpHumeShield(pl));
                    if (_cfg.Scp106SpeedBoost != 0)
                    {
                        pl.ChangeEffectIntensity(EffectType.MovementBoost, _cfg.Scp106SpeedBoost);
                    }
                }

                if (pl.Role.Type == RoleTypeId.Scp939) //TODO: Add this for every SCP
                {
                    
                }
            }
        }

        public void OnFinishingRecall(FinishingRecallEventArgs ev)
        {
            if (Warhead.IsDetonated)
            {
                ev.Player.HumeShield += 50; //TODO: Add a config for the amount
            }
        }
        
        public void OnHurt(HurtingEventArgs ev)
        {
            if (ev.DamageHandler.Type == DamageType.Scp106 && Warhead.IsDetonated)
            {
                ev.Player.Kill(DamageType.Scp106);
            }
        }
        
        private IEnumerator<float> ChangeScpHumeShield(Player pl)
        {
            while (true)
            {
                if (!pl.IsAlive)
                {
                    yield break;
                }

                switch (pl.Role.Type)
                {
                    case RoleTypeId.Scp106:
                        if (_cfg.Scp106Hs != -1)
                        {
                            if (pl.HumeShield > _cfg.Scp106Hs)
                            {
                                pl.HumeShield = _cfg.Scp106Hs;
                            }
                        }
                        break;
                    case RoleTypeId.Scp049: //TODO: Continue this whatever this is
                        /*if (_cfg.Chan)
                        {
                            if (pl.HumeShield > _cfg.Scp106Hs)
                            {
                                pl.HumeShield = _cfg.Scp106Hs;
                            }
                        }*/
                        break;
                }
                
                yield return Timing.WaitForSeconds(1f);
            }
        }
    }
}