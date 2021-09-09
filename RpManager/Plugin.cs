using Exiled.API.Enums;
using Exiled.API.Features;
using System;
using RpManager.Broadcasts;
using Player = Exiled.Events.Handlers.Player;
using Map = Exiled.Events.Handlers.Map;
using Server = Exiled.Events.Handlers.Server;
using RpManager.Cassies;

namespace RpManager
{
    public class Plugin : Plugin<Config>
    {
        public override string Author => "quazEx & BlackStrike SK";

        public override string Name => "RpManager";

        public override string Prefix => "RpManager";

        public override Version Version => new Version(1, 0, 0);

        public override Version RequiredExiledVersion => new Version(3, 0, 0);

        public override PluginPriority Priority => PluginPriority.Default;

        internal ClassDRandomBC ClassDRandomBC { get; set; }
        internal MtfSpawnHint MtfSpawnHint { get; set; }
        internal ScientistSpawnBc ScientistSpawnBc { get; set; }
        internal ChaosBroadcast ChaosBroadcast { get; set; }
        internal GuardBroadcast GuardBroadcast { get; set; }
        internal ClassDEscapeCassie ClassDEscapeCassie { get; set; }
        internal ScientistEscapeCassie ScientistEscapeCassie { get; set; }


        public override void OnEnabled()
        {
            Singleton = this;
            ClassDRandomBC = new ClassDRandomBC();
            ScientistSpawnBc = new ScientistSpawnBc();
            MtfSpawnHint = new MtfSpawnHint();
            ChaosBroadcast = new ChaosBroadcast();
            GuardBroadcast = new GuardBroadcast();
            ClassDEscapeCassie = new ClassDEscapeCassie();
            ScientistEscapeCassie = new ScientistEscapeCassie();

            Player.Spawning += ClassDRandomBC.OnSpawningClassd;
            Player.Spawning += MtfSpawnHint.OnNtfSpawning;
            Player.Spawning += ScientistSpawnBc.OnSciSpawn;
            Player.Spawning += ChaosBroadcast.OnChaosSpawning;
            Player.Spawning += GuardBroadcast.OnSpawningGuard;
            Player.Escaping += ClassDEscapeCassie.OnClassDEscaping;
            Player.Escaping += ScientistEscapeCassie.OnSciEscaping;

            base.OnEnabled();
        }

        public override void OnDisabled()
        {

            Player.Spawning -= ClassDRandomBC.OnSpawningClassd;
            Player.Spawning -= MtfSpawnHint.OnNtfSpawning;
            Player.Spawning -= ScientistSpawnBc.OnSciSpawn;
            Player.Spawning -= ChaosBroadcast.OnChaosSpawning;
            Player.Spawning -= GuardBroadcast.OnSpawningGuard;
            Player.Escaping - ScientistEscapeCassie.OnSciEscaping;
            Player.Escaping -ClassDEscapeCassie.OnClassDEscaping;
            ClassDRandomBC = null;
            ScientistSpawnBc = null;
            MtfSpawnHint = null;
            ChaosBroadcast = null;
            GuardBroadcast = null;
            ClassDEscapeCassie = null;
            ScientistEscapeCassie = null;
            Singleton = null;
            base.OnDisabled();
        }

        public static Plugin Singleton;

    }
}
