using System;
using Exiled.API.Features;
using warhead = Exiled.Events.Handlers.Warhead;
using player = Exiled.Events.Handlers.Player;

namespace ScpSurfaceRework
{
    public class Plugin : Plugin<Config>
    {
        public static Plugin Instance;
        public override Version RequiredExiledVersion => new Version(6,0,0,0);
        public override Version Version => new Version(1,0,0,0);
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
        }
        
        private void UnRegisterEvents()
        {
            warhead.Detonated -= _eventHandlers.OnDetonated;
            _eventHandlers = null;
        }
    }
}