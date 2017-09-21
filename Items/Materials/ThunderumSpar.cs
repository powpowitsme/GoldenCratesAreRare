using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ValkyriesContentCrate.Items.Materials
{
	public class ThunderumSpar : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("'Magmatically Charged!'");
		}

		public override void SetDefaults()
		{
			item.width = 20;
			item.height = 20;
			item.maxStack = 999;
			item.value = Item.sellPrice(0, 0, 20, 0);
			item.rare = 2;
		}

	    public override void AddRecipes()
		{
        ModRecipe recipe = new ModRecipe(mod);
        recipe.AddIngredient(824, 10);
		recipe.AddIngredient(75, 5);
		recipe.AddIngredient(207, 3);
        recipe.AddTile(TileID.Anvils);
        recipe.SetResult(this, 5);
        recipe.AddRecipe();
		}
	}
}