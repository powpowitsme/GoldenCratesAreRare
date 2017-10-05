using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace WNDD.Items.Armor
{
	[AutoloadEquip(EquipType.Body)]
	public class TwilightdreamBreastplate : ModItem
	{
		public override void SetStaticDefaults()
		{
			base.SetStaticDefaults();
			DisplayName.SetDefault("Twilightdream Breastplate");
			Tooltip.SetDefault("A dream.");
		}

		public override void SetDefaults()
		{
			item.width = 18;
			item.height = 18;
			item.value = 10000;
			item.rare = 2;
			item.defense = 60;
		}
	}
}