using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exiled.Events.EventArgs;
using Exiled.API.Features;

namespace RpManager.Cassies
{
    public class ClassDEscapeCassie
    {
        public void OnClassDEscaping(EscapingEventArgs ev)
        {
            if (ev.Player.Role == RoleType.ClassD)
            {
                Cassie.Message(Plugin.Singleton.Config.ClassDEscCassie);
            }
        }
    }
}
