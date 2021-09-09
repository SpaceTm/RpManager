using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exiled.API.Features;
using Exiled.API.Interfaces;

namespace RpManager
{
    public class Config : IConfig
    {
        [Description("Is the plugin enabled?")]
        public bool IsEnabled { get; set; } = true;

        [Description("The list of things that ClassD knows when they spawn")]
        public List<string> BcListClassD { get; set; } = new List<string>()
        {
            "You are a <color=orange>ClassD</color> and you know what <color=red>SCP 173</color> is" ,
            "You are a <color=orange>ClassD</color> and you don't know nothing about the foundation",
            "You are a <color=orange>ClassD</color> and you know about the TeslaGates",
            "You are a <color=orange>ClassD</color> and you know what <color=red>SCP 106</color> is",
            "You are a <color=orange>ClassD</color> and you know what <color=red>SCP 939</color> is",
            "You are a <color=orange>ClassD</color> and you know what <color=red>SCP 079</color> is ",
            "You are a <color=orange>ClassD</color> and you know what <color=red>SCP 049</color> and <color=red>SCP 049-2</color> are"
        };

        [Description("The list of the BC displayed to every guard when they spawn")]
        public List<string> BcListGuard { get; set; } = new List<string>()
        {
            "You are a <color=#919191>Facility Guard</color> you need to help the <color=yellow>Scientist</color> escape."
        };

        [Description("The list of BC displayed to every scientist when they spawn")]
        public List<string> BcListSci { get; set; } = new List<string>()
        {
            "You are specified to <color=red>SCP-173</color>",
            "You are specified to <color=red>SCP-106</color> and have little knowledge about <color=red>SCP-173</color>",
            "You are specified to <color=red>SCP-049</color> and <color=red>SCP-079</color>",
            "You are specified to <color=red>SCP-096</color>",
            "You are specified to <color=red>SCP-106</color>",
            "You are specified to make research in Entrance Zone about <color=red>SCP-914</color>",
            "You are specified to <color=red>SCP-914</color>",
            "You are specified to <color=red>SCP-914</color>, <color=red>SCP-049</color> and <color=red>SCP-049-2</color> research."
        };

        [Description("The broadcast played to every NTF Commander when spawned when they spawn")]
        public string NtfCommanderBc { get; set; } = "You are an <color=#0033ff>NTF Commander</color>. You need to do the briefing to the other soldiers ";

        [Description("The broadcast played to every NTF Private & Sergent when they spawn")]
        public string PrivateSergentNtfBc { get; set; } = "You are an NTF <color=#43a0cc>Private</color>/<color=#348ab3>Sergent</color>, you need to listen at the <color=#0033ff>Commander</color>'s briefing";

        [Description("The broadcast displayed to every NTF Specialist when they spawn")]
        public string SpecialistNtfBc { get; set; } = "You are an <color=#348ab3>NTF Specialist</color>. Go find your squad and listen to the <color=#0033ff>Commander</color>'s orders";

        [Description("The broadcast displayed to every Chaos Insurgency when they spawn")]
        public string ChaosBC { get; set; } = "You are a <color=green>Chaos Insurgency</color>. Steal all the SCP objects";

        [Description("The cassie played when a ClassD escapes")]
        public string ClassDEscCassie { get; set; } = "ONE CLASS D ESCAPED";

        [Description("The cassie played when a Scientist escapes")]
        public string SciEscCassie { get; set; } = "ONE SCIENTIST ESCAPED";

    }
}
