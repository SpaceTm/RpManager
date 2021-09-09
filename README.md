![img](https://img.shields.io/github/downloads/SpaceTm/RpManager/total.svg)
# RpManager
A plugin that enhanches the RP experience, by adding some settable random broadcast and cassies. This also can help new player to get used to RP

# Installation
1. You will need [The Latest Exiled beta](https://github.com/Exiled-Team/EXILED/releases/tag/3.0.0-alpha.83) (Installation guide can be found [here](https://github.com/Exiled-Team/EXILED#Installation))
2. WINDOWS: Go to AppData/Roaming/EXILED/Plugins and put the plugin in the folder 
3. LINUX: Go to your server directory, go back of one folder and then go to .config/EXILED/Plugins

# Config
```yml
# Is the plugin enabled?
  is_enabled: true
  # The list of things that ClassD knows when they spawn
  bc_list_class_d:
  - You are a <color=orange>ClassD</color> and you know what <color=red>SCP 173</color> is
  - You are a <color=orange>ClassD</color> and you don't know nothing about the foundation
  - You are a <color=orange>ClassD</color> and you know about the TeslaGates
  - You are a <color=orange>ClassD</color> and you know what <color=red>SCP 106</color> is
  - You are a <color=orange>ClassD</color> and you know what <color=red>SCP 939</color> is
  - 'You are a <color=orange>ClassD</color> and you know what <color=red>SCP 079</color> is '
  - You are a <color=orange>ClassD</color> and you know what <color=red>SCP 049</color> and <color=red>SCP 049-2</color> are
  # The list of the BC displayed to every guard when they spawn
  bc_list_guard:
  - You are a <color=#919191>Facility Guard</color> you need to help the <color=yellow>Scientist</color> escape.
  # The list of BC displayed to every scientist when they spawn
  bc_list_sci:
  - You are specified to <color=red>SCP-173</color>
  - You are specified to <color=red>SCP-106</color> and have little knowledge about <color=red>SCP-173</color>
  - You are specified to <color=red>SCP-049</color> and <color=red>SCP-079</color>
  - You are specified to <color=red>SCP-096</color>
  - You are specified to <color=red>SCP-106</color>
  - You are specified to make research in Entrance Zone about <color=red>SCP-914</color>
  - You are specified to <color=red>SCP-914</color>
  - You are specified to <color=red>SCP-914</color>, <color=red>SCP-049</color> and <color=red>SCP-049-2</color> research.
  # The broadcast played to every NTF Commander when spawned when they spawn
  ntf_commander_bc: 'You are an <color=#0033ff>NTF Commander</color>. You need to do the briefing to the other soldiers '
  # The broadcast played to every NTF Private & Sergent when they spawn
  private_sergent_ntf_bc: You are an NTF <color=#43a0cc>Private</color>/<color=#348ab3>Sergent</color>, you need to listen at the <color=#0033ff>Commander</color>'s briefing
  # The broadcast displayed to every NTF Specialist when they spawn
  specialist_ntf_bc: You are an <color=#348ab3>NTF Specialist</color>. Go find your squad and listen to the <color=#0033ff>Commander</color>'s orders
  # The broadcast displayed to every Chaos Insurgency when they spawn
  chaos_b_c: You are a <color=green>Chaos Insurgency</color>. Steal all the SCP objects
  # The cassie played when a ClassD escapes
  class_d_esc_cassie: ONE CLASS D ESCAPED
  # The cassie played when a Scientist escapes
  sci_esc_cassie: ONE SCIENTIST ESCAPED


```
