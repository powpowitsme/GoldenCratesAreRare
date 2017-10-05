using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace WNDD.Items.Armor
{
	[AutoloadEquip(EquipType.Head)]
	public class WingedGlory : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Winged Victory");
			Tooltip.SetDefault("'Wunderbar!'");
		}

		public override void SetDefaults()
		{
			item.width = 18;
			item.height = 18;
			item.value = 10000;
			item.rare = 10;
			item.expert = true;
			item.defense = 1;
		}

		public override void UpdateArmorSet(Player player)
		{
			player.setBonus = "Feel Beautiful!";
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(225, 10);
			recipe.AddTile(412);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}