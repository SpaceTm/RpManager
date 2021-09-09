using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exiled.API.Features;
using Exiled.Events.EventArgs;
using UnityEngine;

namespace RpManager.Broadcasts
{
    public class ClassDRandomBC
    {
        public void OnSpawningClassd(SpawningEventArgs ev)
        {
            if (ev.Player.Role == RoleType.ClassD)
            {
                string[] array = Plugin.Singleton.Config.BcListClassD.ToArray();

                int num = (UnityEngine.Random.Range(0, array.Length));
                ev.Player.Broadcast(5, array[num]);
            }
        }
    }
}
