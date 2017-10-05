using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace WNDD.Items.Weapons.Swung
{
	public class Flamestriker : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Flamestriker");
			Tooltip.SetDefault("'So light em up!'");	
		}

		public override void SetDefaults()
		{
			item.damage = 10;
			item.melee = true;			
			item.width = 56;			
			item.height = 56;			
			item.useTime = 8;	
			item.useAnimation = 8;
			item.useStyle = 1;			
			item.knockBack = 0;			
			item.value = Item.sellPrice(0, 0, 30, 0);			
			item.rare = 2;				
			item.UseSound = SoundID.Item1;		
			item.autoReuse = true;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(117, 10);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}

				public override void MeleeEffects(Player player, Rectangle hitbox)
		{
			if (Main.rand.Next(3) == 0)
			{
				int dust = Dust.NewDust(new Vector2(hitbox.X, hitbox.Y), hitbox.Width, hitbox.Height, 6, 0f, 0f, 0, default(Color), 1f);
			}
		}
				
		public override void OnHitNPC(Player player, NPC target, int damage, float knockback, bool crit)
		{
			target.AddBuff(BuffID.OnFire, 60);		
		}
	}
}
