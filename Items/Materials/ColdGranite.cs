using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace WNDD.Items.Materials
{
	public class ColdGranite : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("'Chilled Granite reinforced with dark power'");
		}

		public override void SetDefaults()
		{
			item.width = 20;
			item.height = 20;
			item.maxStack = 999;
			item.value = Item.sellPrice(0, 0, 10, 0);
			item.rare = 2;
		}

	    public override void AddRecipes()
		{
        ModRecipe recipe = new ModRecipe(mod);
        recipe.AddIngredient(3086, 10);
		recipe.AddIngredient(664, 10);
		recipe.AddIngredient(57, 2);
        recipe.AddTile(TileID.Anvils);
        recipe.SetResult(this, 2);
        recipe.AddRecipe();

		ModRecipe recipe2 = new ModRecipe(mod);
        recipe2.AddIngredient(3086, 10);
		recipe2.AddIngredient(664, 10);
		recipe2.AddIngredient(1257, 2);
        recipe2.AddTile(TileID.Anvils);
        recipe2.SetResult(this, 2);
        recipe2.AddRecipe();
		}
	}
}