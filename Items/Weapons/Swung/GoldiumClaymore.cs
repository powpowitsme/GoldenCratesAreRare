using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ValkyriesContentCrate.Items.Weapons.Swung
{
	public class GoldiumClaymore : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Goldium Claymore");
			Tooltip.SetDefault("'Slow, but packs a punch!'");	
		}

		public override void SetDefaults()
		{
			item.damage = 28;
			item.melee = true;			
			item.width = 78;			
			item.height = 96;			
			item.useTime = 60;	
			item.useAnimation = 60;
			item.useStyle = 1;			
			item.knockBack = 12;			
			item.value = Item.sellPrice(10, 0, 0, 0);			
			item.rare = 1;
			item.UseSound = SoundID.Item1;
			item.autoReuse = false;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(19, 6);
			recipe.AddIngredient(706, 6);
			recipe.AddIngredient(178, 1);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
