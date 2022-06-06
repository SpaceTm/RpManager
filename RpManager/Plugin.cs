<<<<<<< HEAD
﻿using Exiled.API.Enums;
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
            ClassDRandomBC = null;
            ScientistSpawnBc = null;
            MtfSpawnHint = null;
            ChaosBroadcast = null;
            GuardBroadcast = null;
            ClassDEscapeCassie = null;
            ScientistEscapeCassie = null;
            Singleton = null;

            Player.Spawning -= ClassDRandomBC.OnSpawningClassd;
            Player.Spawning -= MtfSpawnHint.OnNtfSpawning;
            Player.Spawning -= ScientistSpawnBc.OnSciSpawn;
            Player.Spawning -= ChaosBroadcast.OnChaosSpawning;
            Player.Spawning -= GuardBroadcast.OnSpawningGuard;
            base.OnDisabled();
        }

        public static Plugin Singleton;

    }
}
=======
﻿using Exiled.API.Enums;
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

            Player.Spawning += Broadcasts.SingleSpawn;
            Player.Escaping += EscapingCassie.OnClassEscaping;

            base.OnEnabled();
        }

        public override void OnDisabled()
        {
            Player.Spawning -= Broadcasts.SingleSpawn;
            Player.Escaping -= EscapingCassie.OnClassEscaping;

            EscapingCassie = null;
            Broadcasts = null;
            Singleton = null;

            base.OnDisabled();
        }

        public static Plugin Singleton;

    }
}
>>>>>>> d0f1e67d1d81873874068438682fd3923b64b011
