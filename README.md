The previous team has decided to stop their development for Tremor. The mod has now been transferred to Jofairden.

Thanks to all the collaborators, Tremor will remain available and bugs will be fixed.


# Tremor
[Thread](https://forums.terraria.org/index.php?threads/tremor-remastered.28695/)

# Latest changelogs

## Changelogs for v1.3.2.2:

Fixes:
 - Fixed buff retextures not being unloaded (thanks jopojelly)
 - Fixed crab staff bad defaults, fixed Baby Slime+Crab desummon problem (thanks jopojelly)
 - Fixed issues for a ModWorld, potentially fixing load issues for certain worlds
 - Fixed the "Requesting World Information" bug
 - Fixed the Archer NPC hurting friendlies and not enemies
 - Fixed Motherboard drops, fixed Motherboard boss bag drops.
 -- All items can now drop their maximum amount (previously only maximum amount-1 was possible)
 -- The following items drop chance fixed from 50% to 100%: Soul of Plight, Greater Healing Potion, Hallowed Bar
 -- All drop fixes also apply to the boss bag. Boss bag also drops mechanical wagon piece (100%)
 -- Fixed CarbonSteel drop chance from guaranteed 50% to 100% in Tremode, 50% otherwise
 - Fixed Tiki Totem drops, fixed Tiki Totem boss bag drops
 -- Potions now drop 5-15 (previously 5-14)
 -- ToxicHilt drop chance fixed from 33% to 25%
 -- ToxicBlade drop chance fixed from 50% to 33%
 -- JungleAlloy drop chance fixed from 50% to 100%
 -- Potion drop chances fixed from 50% to 100%
 -- Boss bag drops all normal drops plus Tiki Skull
 - Fixed Tiki Totem and Motherboard treasure bag names and fixed their tooltips (now changes language)
 - Fixed Frost Liquid Flask having no crit chance
 - Fixed Toxic Flask having no crit chance
 - Fixed Shadow Flask not being an actual alchemist item, fixed it having no crit chance
 - Changed 'alchemic' damage to 'alchemical' damage

 Improvements:
 - Improved Tremor.cs code slightly
 - Improved Tremor player quest fish code
 - Improved Tremor player bad life regen code

 Notes:
 - Alchemist item crit chance is ONLY VISUAL, there's no normal way of altering crit chance in tML atm.
 - Motherboard code is still being reworked. Hopefully it can be included in the next patch.
 - Bosses will be looked at over time. They require a lot of work to be redone, have patience.
 - Thanks again to all contributors this patch, and also wiki editors for updating info.

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
