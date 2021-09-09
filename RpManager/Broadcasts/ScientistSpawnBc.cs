using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exiled.Events.EventArgs;

namespace RpManager.Broadcasts
{
    class ScientistSpawnBc
    {
        public void OnSciSpawn(SpawningEventArgs ev)
        {
            if (ev.RoleType == RoleType.Scientist)
            {
                string[] array = Plugin.Singleton.Config.BcListSci.ToArray();

                int num = (UnityEngine.Random.Range(0, array.Length));
                ev.Player.Broadcast(10, array[num]);

            }
        }
    }
}
