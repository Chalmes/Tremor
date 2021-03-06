using Terraria.ModLoader;

namespace Tremor.Items
{
	[AutoloadEquip(EquipType.Legs)]
	public class LeatherGreaves : ModItem
	{

		public override void SetDefaults()
		{

			item.width = 18;
			item.height = 20;
			item.value = 200;
			item.rare = 1;
			item.defense = 1;
		}

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Leather Greaves");
			Tooltip.SetDefault("");
		}

	}
}
