using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

using Microsoft.Xna.Framework;

using Tremor.Items;

namespace Tremor.NPCs
{
	public class BetaWolf : ModNPC
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Beta Wolf");
			Main.npcFrameCount[npc.type] = 9;
		}

		public override void SetDefaults()
		{
			npc.lifeMax = 62;
			npc.damage = 25;
			npc.defense = 6;
			npc.knockBackResist = 0.6f;
			npc.width = 68;
			npc.height = 33;
			animationType = 155;
			npc.aiStyle = 26;
			npc.npcSlots = 0.4f;
			npc.HitSound = SoundID.NPCHit6;
			npc.DeathSound = SoundID.NPCDeath5;
			npc.value = Item.buyPrice(0, 0, 4, 0);
		}

		public override void NPCLoot()
		{
			if (Main.rand.Next(2) == 0)
				npc.NewItem((short)mod.ItemType<WolfPelt>(), Main.rand.Next(1, 2));
			if (Main.rand.Next(25) == 0)
				npc.NewItem((short)mod.ItemType<FurCoat>());
		}

		public override void HitEffect(int hitDirection, double damage)
		{
			if (npc.life <= 0)
			{
				for (int k = 0; k < 20; k++)
					Dust.NewDust(npc.position, npc.width, npc.height, 151, 2.5f * hitDirection, -2.5f, 0, default(Color), 0.7f);

				for (int i = 0; i < 2; ++i)
				{
					Gore.NewGore(npc.position, npc.velocity, mod.GetGoreSlot($"Gores/WolfGore{i + 1}"), 1f);
					Gore.NewGore(npc.position, npc.velocity, mod.GetGoreSlot($"Gores/BetaWolfGore1{i + 1}"), 1f);
				}
			}
		}

		public override float SpawnChance(NPCSpawnInfo spawnInfo)
		{
			return Helper.NormalSpawn(spawnInfo) && Helper.NoZoneAllowWater(spawnInfo) && spawnInfo.player.ZoneSnow && spawnInfo.spawnTileY < Main.worldSurface ? 0.01f : 0f;
		}
	}
}