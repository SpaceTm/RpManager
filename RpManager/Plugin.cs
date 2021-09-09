using Exiled.API.Enums;
using Exiled.API.Features;
using System;
using RpManager.Features;
using Player = Exiled.Events.Handlers.Player;
using Map = Exiled.Events.Handlers.Map;
using Server = Exiled.Events.Handlers.Server;
namespace RpManager
{
    public class Plugin : Plugin<Config>
    {
        public override string Author => "quazEx & BlackStrike SK";

        public override string Name => "RpManager";

        public override string Prefix => "RpManager";

        public override Version Version => new Version(1, 5, 0);

        public override Version RequiredExiledVersion => new Version(3, 0, 0);

        internal Broadcasts Broadcasts { get; set; }
        internal EscapingCassie EscapingCassie { get; set; }


        public override void OnEnabled()
        {
            Singleton = this;
            EscapingCassie = new EscapingCassie();
            Broadcasts = new Broadcasts();


            Player.Spawning += Broadcasts.TeamSpawning;
            Player.Spawning += Broadcasts.SingleSpawn;
            Player.Escaping += EscapingCassie.OnClassEscaping;

            base.OnEnabled();
        }

        public override void OnDisabled()
        {
            Player.Spawning += Broadcasts.TeamSpawning;
            Player.Spawning += Broadcasts.SingleSpawn;
            Player.Escaping += EscapingCassie.OnClassEscaping;

            EscapingCassie = null;
            Broadcasts = null;
            Singleton = null;

            base.OnDisabled();
        }

        public static Plugin Singleton;

    }
}
