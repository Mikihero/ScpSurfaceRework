using System;
using Exiled.API.Features;
using Exiled.Events.Handlers;
using warhead = Exiled.Events.Handlers.Warhead;
using player = Exiled.Events.Handlers.Player;
using scp049 = Exiled.Events.Handlers.Scp049;

namespace ScpSurfaceRework
{
    public class Plugin : Plugin<Config>
    {
        public static Plugin Instance;
        public override Version RequiredExiledVersion => new Version(6,0,0,0);
        public override Version Version => new Version(1,0,1);
        public override string Author => "Miki_hero";
        
        private EventHandlers _eventHandlers;
        
        public override void OnEnabled()
        {
            Instance = this;
            RegisterEvents();
            base.OnEnabled();
        }
        
        public override void OnDisabled()
        {
            UnRegisterEvents();
            Instance = null;
            base.OnDisabled();
        }
        
        private void RegisterEvents()
        {
            _eventHandlers = new EventHandlers();
            warhead.Detonated += _eventHandlers.OnDetonated;
            player.Hurting += _eventHandlers.OnHurt;
            player.ChangingRole += _eventHandlers.OnChangingRole;
            scp049.FinishingRecall += _eventHandlers.OnFinishingRecall;
        }
        
        private void UnRegisterEvents()
        {
            warhead.Detonated -= _eventHandlers.OnDetonated;
            player.Hurting -= _eventHandlers.OnHurt;
            player.ChangingRole -= _eventHandlers.OnChangingRole;
            _eventHandlers = null;
        }
    }
}