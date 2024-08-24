using Exiled.API.Enums;
using Exiled.API.Features;
using Exiled.Events.EventArgs.Player;
using System;

namespace Harmless_207
{
    public class Plugin : Plugin<XYlikeconfig>
    {
        public override string Name { get; } = "Harmless 207 / 无害可乐";
        public override string Author { get; } = "XingYeNotFish";
        public override Version Version { get; } = new Version(1, 0, 2);

        private static readonly Lazy<Plugin> LazyInstance = new Lazy<Plugin>(() => new Plugin());
        public static Plugin Instance;
        public override void OnEnabled()
        {
            Instance = this;
            base.OnEnabled();
            Exiled.Events.Handlers.Player.Hurting += OnPlayerHurt;
            Log.Info("Plugin has been enabled! / 插件已启用!");
        }

        public override void OnDisabled()
        {
            Instance = null;
            base.OnDisabled();
            Exiled.Events.Handlers.Player.Hurting -= OnPlayerHurt;
            Log.Info("Plugin has been disabled! / 插件已关闭!");
        }

        private static XYlikeconfig config => Instance.Config;

        public void OnPlayerHurt(HurtingEventArgs ev)
        {
            if (ev.Player != null)
            {
                if (ev.DamageHandler.Type == DamageType.Scp207)
                {
                    ev.IsAllowed = false;
                }

                if (config.Harmless_1853)
                {
                    if (ev.DamageHandler.Type == DamageType.Poison)
                    {
                        ev.IsAllowed = false;
                    }
                }
            }
        }
    }
}