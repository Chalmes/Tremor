using Terraria.ModLoader;

namespace Tremor.Items
{
	public class OldInvarPlate : ModItem
	{
		public override void SetDefaults()
		{

			item.width = 28;
			item.height = 30;
			item.maxStack = 99;
			item.value = 25;
			item.rare = 1;
		}

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Old Invar Plate");
			Tooltip.SetDefault("");
		}

	}
}
