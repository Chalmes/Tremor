The previous team has decided to stop their development for Tremor. The mod has now been transferred to Jofairden.

Thanks to all the collaborators, Tremor will remain available and bugs will be fixed.


# Tremor
[Thread](https://forums.terraria.org/index.php?threads/tremor-remastered.28695/)

# Latest changelogs

## Changelogs for v1.3.2.4
Thanks to Eldrazi for many contributions for this patch.

 Misc
- Glacier ice wall can now only spread to other ice or snow, this should prevent the entire world from getting covered in it (as reported)

 Alchemist class
- Improved certain tooltips for alchemist class related items (please note I still probably missed many)
- Fixed certain tooltips still saying 'alchemic', changed to say 'alchemical'
- Fixed certain alchemist items not granting the right amount of increased damage or critical strike chance. Please note that this change can only affect your characters positively. Because if a tooltip showed a lesser increase than was actually given, I updated the tooltip to display the bigger increase. If a tooltip displayed a higher value than was actually given, I updated the given value to match the tooltip.
- Improved Nova alchemist flask shadow trail opacity
- Improved Shadow cloud opacity and added fadeout (many alchemist clouds need this)
- Special note: for tML v0.10.1 I added a hook to adjust crit, but unfortunately (BECAUSE IM FOOKIN STOOPID) it doesn't work properly. No worries though! With a few workarounds, special crit for the alchemist class is still functional with some workaround code. This just means that whenever tML updates, I can remove all that extra code.
- To add to the special note, this patch features a rather major buff for the alchemist class. I have abstracted alchemist specific code into it's own classes. With this work comes the change that alchemist projectiles (clouds, bursts, blasts.. you name it) will now also inherit the crit chance of your alchemist item, where this was previously not the case. This means that your alchemist related projectiles will crit more often, especially if you can get to increase your critical strike chance!
- Also fixed critical chance not showing for certain items

 Items
- Items that grant movement speed now also increase the player's maximum run speed by that amount, this ensures the movement speed bonus actually has effect when at capped speed
- Certain tooltips have been improved to match the style of wording from vanilla
- Improved and buffed Phantablast
- All treasure bag tooltips 'right click to open' will now translate properly

 NPCs
- Improved certain npc framing to update based on velocity
- You will now see certain names and chats appear more often than others for town NPCs
- Fixed many town NPCs not being able to receive their last 2 possible names
- Fixed certain town NPCs their shops
- Fixed certain town NPCs 'can spawns', some may not have been able to spawn before when they should have been able to

 Bosses
- Fixed Wall of Shadows not being able to spawn (huzzah)
- Fixed detached clampers (from the Motherboard fight) having incorrect life values
- Fixed killing (True) Andas not registering as kill

 Mod source
- Merged certain ModPlayer files, this possibly improves mod load speed
- Certain code was shortened, possibly reducing the mod size
- Removed certain drop code for items that don't exist in the mod
- Removed many npc expert scaling that did not actually scale anything. Please leave a suggestion when you find an appropiate scaling for an npc
- Many magic formatting has been done

# Report bugs
Please make an [issue](https://github.com/Jofairden/Tremor/issues) to report the bug you found. Please check first if the mod has already been reported.
When you report a bug, please provide at the very least the following information:
* tModLoader version you are using
* Tremor version you are using
* What happens?
* What should be happening?
* A FULL log of the error(s)
  * You can get a full log by clicking on 'Open Logs' when you get the error. This log provides more information. 

If applicable, provide the scenario(s) in which the bug occurs.

# Making pull requests
Help is always appreciated. Please prepend the appropiate tag in your PR so I can easily triage it:
* [Rework]
* [Bug squash]
* [Refactor]

Rework means you reworked some code entirely. Bug squash means you have fixed bugs. Refactor or revise means you've gone over some code and refactored it. Code comments are highly appreciated.
**If multiple tags could be appropiate, it's fine if you omit them and explain in the PR itself.**

_As for now, I will ignore all rebalance requests or PRs. Rebalancing is not a priority right now._
