using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exiled.Events.EventArgs;

namespace RpManager.Broadcasts
{
    class ChaosBroadcast
    {
        public void OnChaosSpawning(SpawningEventArgs ev)
        {
            if (ev.Player.Team == Team.CHI)
            {
                if (ev.Player.Role == RoleType.ChaosConscript)
                {
                    ev.Player.Broadcast(10, Plugin.Singleton.Config.ChaosBC);
                }

                if (ev.Player.Role == RoleType.ChaosMarauder)
                {
                    ev.Player.Broadcast(10, Plugin.Singleton.Config.ChaosBC);
                }

                if (ev.Player.Role == RoleType.ChaosRepressor)
                {
                    ev.Player.Broadcast(10, Plugin.Singleton.Config.ChaosBC);
                }

                if (ev.Player.Role == RoleType.ChaosRifleman)
                {
                    ev.Player.Broadcast(10, Plugin.Singleton.Config.ChaosBC);
                }
            }
        }
    }
}
