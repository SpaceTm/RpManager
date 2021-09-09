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
                ev.Player.Broadcast(10, Plugin.Singleton.Config.ChaosBC);
            }
        }
    }
}
