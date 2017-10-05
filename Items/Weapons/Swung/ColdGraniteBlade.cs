using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace WNDD.Items.Weapons.Swung
{
	public class ColdGraniteBlade : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Cold Granite Blade");
			Tooltip.SetDefault("Inflicts Frostburn\n'Cold Killer'");	
		}

		public override void SetDefaults()
		{
			item.damage = 23;
			item.melee = true;			
			item.width = 64;			
			item.height = 64;			
			item.useTime = 20;	
			item.useAnimation = 20;
			item.useStyle = 1;			
			item.knockBack = 6;			
			item.value = Item.sellPrice(0, 1, 0, 0);			
			item.rare = 1;
			item.UseSound = SoundID.Item1;
			item.autoReuse = false;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "ColdGranite", 6);
			recipe.AddIngredient(null, "CompactIceShard", 3);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}

		public override void OnHitNPC(Player player, NPC target, int damage, float knockback, bool crit)
        {
            if (Main.rand.Next(2) == 0)
            {
                target.AddBuff(44, 180);
            }
		}
	}
}
