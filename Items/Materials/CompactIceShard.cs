using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace WNDD.Items.Materials
{
	public class CompactIceShard : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("'Frozen to the core'");
		}

		public override void SetDefaults()
		{
			item.width = 20;
			item.height = 20;
			item.maxStack = 999;
			item.value = Item.sellPrice(0, 0, 5, 0);
			item.rare = 1;
		}

	    public override void AddRecipes()
		{
        ModRecipe recipe = new ModRecipe(mod);
        recipe.AddIngredient(593, 25);
		recipe.AddIngredient(664, 25);
		recipe.AddIngredient(2358, 1);
        recipe.AddTile(TileID.Anvils);
        recipe.SetResult(this, 3);
        recipe.AddRecipe();
		}
	}
}