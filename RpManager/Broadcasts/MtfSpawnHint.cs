using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exiled.API.Features;
using Exiled.Events.EventArgs;
using UnityEngine;
using MEC;

namespace RpManager.Broadcasts
{
    public class MtfSpawnHint
    {
        public void OnNtfSpawning(SpawningEventArgs ev)
        {
            if (ev.Player.Team == Team.MTF)
            {
                if (ev.Player.Role == RoleType.NtfCaptain)
                {
                    ev.Player.Broadcast(10, Plugin.Singleton.Config.NtfCommanderBc);
                }

                if (ev.Player.Role == RoleType.NtfPrivate)
                {
                    ev.Player.Broadcast(5, Plugin.Singleton.Config.PrivateSergentNtfBc);
                }

                if (ev.Player.Role == RoleType.NtfSergeant)
                {
                    ev.Player.Broadcast(5, Plugin.Singleton.Config.PrivateSergentNtfBc);
                }

                if (ev.Player.Role == RoleType.NtfSpecialist)
                {
                    ev.Player.Broadcast(5, Plugin.Singleton.Config.SpecialistNtfBc);
                }
            }
        }
    }
}
