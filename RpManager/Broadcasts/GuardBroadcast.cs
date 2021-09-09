using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exiled.Events.EventArgs;
using UnityEngine;

namespace RpManager.Broadcasts
{
    public class GuardBroadcast
    {
        public void OnSpawningGuard(SpawningEventArgs ev)
        {
            if (ev.Player.Role == RoleType.FacilityGuard)
            {
                string[] array = Plugin.Singleton.Config.BcListClassD.ToArray();

                int num = (UnityEngine.Random.Range(0, array.Length));
                ev.Player.Broadcast(5, array[num]);
            }
        }
    }
}
