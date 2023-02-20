using System.Collections.Generic;
using Exiled.API.Enums;
using MEC;
using Exiled.Events.EventArgs.Player;
using Exiled.Events.EventArgs.Scp049;
using PlayerRoles;
using Player = Exiled.API.Features.Player;
using Warhead = Exiled.API.Features.Warhead;
// ReSharper disable CompareOfFloatsByEqualityOperator

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
                if (pl.Role.Type == RoleTypeId.Scp173)
                {
                    Timing.RunCoroutine(ChangeScpHumeShield(pl));
                    if (_cfg.Scp173SpeedBoost != 0)
                    {
                        pl.ChangeEffectIntensity(EffectType.MovementBoost, _cfg.Scp173SpeedBoost);
                    }
                }
                
                if (pl.Role.Type == RoleTypeId.Scp106)
                {
                    Timing.RunCoroutine(ChangeScpHumeShield(pl));
                    if (_cfg.Scp106SpeedBoost != 0)
                    {
                        pl.ChangeEffectIntensity(EffectType.MovementBoost, _cfg.Scp106SpeedBoost);
                    }
                }

                if (pl.Role.Type == RoleTypeId.Scp049)
                {
                    Timing.RunCoroutine(ChangeScpHumeShield(pl));
                    if (_cfg.Scp049SpeedBoost != 0)
                    {
                        pl.ChangeEffectIntensity(EffectType.MovementBoost, _cfg.Scp049SpeedBoost);
                    }
                }
                
                if (pl.Role.Type == RoleTypeId.Scp096)
                {
                    Timing.RunCoroutine(ChangeScpHumeShield(pl));
                    if (_cfg.Scp096SpeedBoost != 0)
                    {
                        pl.ChangeEffectIntensity(EffectType.MovementBoost, _cfg.Scp096SpeedBoost);
                    }
                }

                if (pl.Role.Type == RoleTypeId.Scp0492)
                {
                    Timing.RunCoroutine(ChangeScpHumeShield(pl));
                    if (_cfg.Scp0492SpeedBoost != 0)
                    {
                        pl.ChangeEffectIntensity(EffectType.MovementBoost, _cfg.Scp0492SpeedBoost);
                    }
                }
                
                if (pl.Role.Type == RoleTypeId.Scp939)
                {
                    Timing.RunCoroutine(ChangeScpHumeShield(pl));
                    if (_cfg.Scp939SpeedBoost != 0)
                    {
                        pl.ChangeEffectIntensity(EffectType.MovementBoost, _cfg.Scp939SpeedBoost);
                    }
                }
            }
        }

        public void OnFinishingRecall(FinishingRecallEventArgs ev)
        {
            if (Warhead.IsDetonated)
            {
                ev.Player.HumeShield += _cfg.Scp049BonusHs;
            }
        }

        public void OnChangingRole(ChangingRoleEventArgs ev)
        {
            if (ev.NewRole == RoleTypeId.Scp0492)
            {
                if (Warhead.IsDetonated)
                {
                    Timing.CallDelayed(0.1f, () => {
                            Timing.RunCoroutine(ChangeScpHumeShield(ev.Player));
                            if (_cfg.Scp0492SpeedBoost != 0)
                            {
                                ev.Player.ChangeEffectIntensity(EffectType.MovementBoost, _cfg.Scp0492SpeedBoost);
                            }
                        }
                    );
                }
            }
        }
        
        public void OnHurt(HurtingEventArgs ev)
        {
            if (ev.DamageHandler.Type == DamageType.Scp106 && Warhead.IsDetonated && _cfg.Scp106OneShot)
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
                    case RoleTypeId.Scp173:
                        if (_cfg.Scp173Hs != -1)
                        {
                            if (pl.HumeShield > _cfg.Scp173Hs)
                            {
                                pl.HumeShield = _cfg.Scp173Hs;
                            }
                        }
                        break;
                    case RoleTypeId.Scp106:
                        if (_cfg.Scp106Hs != -1)
                        {
                            if (pl.HumeShield > _cfg.Scp106Hs)
                            {
                                pl.HumeShield = _cfg.Scp106Hs;
                            }
                        }
                        break;
                    case RoleTypeId.Scp049:
                        if (_cfg.Scp049Hs != 1)
                        {
                            if (pl.HumeShield > _cfg.Scp049Hs)
                            {
                                pl.HumeShield = _cfg.Scp049Hs;
                            }
                        }
                        break;
                    case RoleTypeId.Scp096:
                        if (_cfg.Scp096Hs != 1)
                        {
                            if (pl.HumeShield > _cfg.Scp096Hs)
                            {
                                pl.HumeShield = _cfg.Scp096Hs;
                            }
                        }
                        break;
                    case RoleTypeId.Scp0492:
                        if (_cfg.Scp0492Hs != 1)
                        {
                            if (pl.HumeShield > _cfg.Scp0492Hs)
                            {
                                pl.HumeShield = _cfg.Scp0492Hs;
                            }
                        }
                        break;
                    case RoleTypeId.Scp939:
                        if (_cfg.Scp939Hs != 1)
                        {
                            if (pl.HumeShield > _cfg.Scp939Hs)
                            {
                                pl.HumeShield = _cfg.Scp939Hs;
                            }
                        }
                        break;
                }
                
                yield return Timing.WaitForSeconds(1f);
            }
        }
    }
}