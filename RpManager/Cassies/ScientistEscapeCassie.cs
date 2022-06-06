using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exiled.Events.EventArgs;
using Exiled.API.Features;

namespace RpManager.Cassies
{
    class ScientistEscapeCassie
    {
        public void OnSciEscaping(EscapingEventArgs ev)
        {
            if (ev.Player.Role == RoleType.Scientist)
            {
                Cassie.Message(Plugin.Singleton.Config.SciEscCassie);
            }
        }

    }
    
}
