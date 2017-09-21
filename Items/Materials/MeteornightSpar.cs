using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ValkyriesContentCrate.Items.Materials
{
	public class MeteornightSpar : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("'Totally intentional pun!'");
		}

		public override void SetDefaults()
		{
			item.width = 20;
			item.height = 20;
			item.maxStack = 999;
			item.value = Item.sellPrice(0, 2, 0, 0);
			item.rare = 7;
		}

	    public override void AddRecipes()
		{
        ModRecipe recipe = new ModRecipe(mod);
        recipe.AddIngredient(1006, 1);
		recipe.AddIngredient(117, 1);
		recipe.AddIngredient(521, 1);
        recipe.AddTile(134);
        recipe.SetResult(this);
        recipe.AddRecipe();
		}
	}
}