using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exiled.Events.EventArgs;

namespace RpManager.Features
{
    public class Broadcasts
    {
        System.Random random = Exiled.Loader.Loader.Random;
        public void TeamSpawning(SpawningEventArgs ev)
        {
            switch (ev.Player.Team)
            {
                case Team.CHI:
                    ev.Player.Broadcast(10, Plugin.Singleton.Config.ChaosBC);
                    break;

                case Team.RSC:
                    string[] arraySci = Plugin.Singleton.Config.BcListSci.ToArray();

                    int Sci = random.Next(0, arraySci.Length);
                    ev.Player.Broadcast(10, arraySci[Sci]);
                    break;

                case Team.CDP:
                    string[] arrayCd = Plugin.Singleton.Config.BcListClassD.ToArray();

                    int Cd = random.Next(0, arrayCd.Length);
                    ev.Player.Broadcast(10, arrayCd[Cd]);
                    break;
            }
        }

        public void SingleSpawn(SpawningEventArgs ev)
        {
            switch (ev.Player.Role)
            {
                case RoleType.NtfCaptain:
                    ev.Player.Broadcast(10, Plugin.Singleton.Config.NtfCommanderBc);
                    break;

                case RoleType.NtfSergeant:
                    ev.Player.Broadcast(10, Plugin.Singleton.Config.PrivateSergentNtfBc);
                    break;

                case RoleType.NtfPrivate:
                    ev.Player.Broadcast(10, Plugin.Singleton.Config.PrivateSergentNtfBc);
                    break;

                case RoleType.NtfSpecialist:
                    ev.Player.Broadcast(10, Plugin.Singleton.Config.SpecialistNtfBc);
                    break;

                case RoleType.FacilityGuard:
                    string[] arrayFg = Plugin.Singleton.Config.BcListGuard.ToArray();
                    int Fg = random.Next(0, arrayFg.Length);
                    ev.Player.Broadcast(10, arrayFg[Fg]);
                    break;
            }
        }
    }
}
