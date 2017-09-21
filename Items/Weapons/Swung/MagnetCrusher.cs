using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ValkyriesContentCrate.Items.Weapons.Swung
{
	public class MagnetCrusher : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Glacial Stormbringer");
			Tooltip.SetDefault("Shoots a storm of ice javelins\n'Yes hello, ice?'");	
		}

		public override void SetDefaults()
		{
			item.damage = 180;
			item.melee = true;			
			item.width = 92;			
			item.height = 92;			
			item.useTime = 5;	
			item.useAnimation = 5;
			item.useStyle = 1;			
			item.knockBack = 6;			
			item.value = Item.sellPrice(10, 0, 0, 0);			
			item.rare = 10;
			item.expert = true;
			item.UseSound = SoundID.Item38;
			item.autoReuse = true;
			item.shoot = 343;
			item.shootSpeed = 15f;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(1131, 1);
			recipe.AddIngredient(1947, 1);
			recipe.AddIngredient(3063, 1);
			recipe.AddIngredient(3458, 25);
			recipe.AddIngredient(3457, 25);
			recipe.AddIngredient(3456, 25);
			recipe.AddIngredient(3459, 25);
			recipe.AddIngredient(3467, 25);
			recipe.AddTile(412);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	
		public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
		{
			int numberProjectiles = 50 + Main.rand.Next(2);
			for (int i = 0; i < numberProjectiles; i++)
			{
				Vector2 perturbedSpeed = new Vector2(speedX, speedY).RotatedByRandom(MathHelper.ToRadians(30));
				Projectile.NewProjectile(position.X, position.Y, perturbedSpeed.X, perturbedSpeed.Y, type, damage, knockBack, player.whoAmI);
			}
		return false;
		}

		public override void MeleeEffects(Player player, Rectangle hitbox)
		{
			if (Main.rand.Next(3) == 0)
			{
				int dust = Dust.NewDust(new Vector2(hitbox.X, hitbox.Y), hitbox.Width, hitbox.Height, 132, 0f, 0f, 0, default(Color), 1f);
			}
		}
	}
}
