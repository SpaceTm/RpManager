using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exiled.Events.EventArgs;
using Exiled.API.Features;

namespace RpManager.Features
{
    public class EscapingCassie
    {
        public void OnClassEscaping(EscapingEventArgs ev)
        {
            switch (ev.Player.Role)
            {
                case RoleType.ClassD:
                    Cassie.Message(Plugin.Singleton.Config.ClassDEscCassie);
                    break;

                case RoleType.Scientist:
                    Cassie.Message(Plugin.Singleton.Config.SciEscCassie);
                    break;
            }
        }
    }
}
