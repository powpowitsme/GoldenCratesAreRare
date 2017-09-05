using Microsoft.Xna.Framework;
using ValkyriesContentCrate.Projectiles;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ValkyriesContentCrate.Items.Weapons
{
	public class LifeSpear : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Life Spear");
			Tooltip.SetDefault("'Despite the name, this actually kills things!'");
		}

		public override void SetDefaults()
		{
			item.damage = 91;
			item.useStyle = 5;
			item.useAnimation = 30;
			item.useTime = 30;
			item.shootSpeed = 3.7f;
			item.knockBack = 6.5f;
			item.width = 50;
			item.height = 50;
			item.scale = 1f;
			item.rare = 8;
			item.UseSound = SoundID.Item1;
			item.shoot = mod.ProjectileType<Projectiles.LifeSpear>();
			item.value = Item.sellPrice(0, 50, 0, 0);
			item.noMelee = true;
			item.noUseGraphic = true;
			item.melee = true;
			item.autoReuse = true;
		}

			public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(756, 1);
			recipe.AddIngredient(550, 1);
			recipe.AddIngredient(1228, 1);
			recipe.AddTile(TileID.DemonAltar);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
		
		public override bool CanUseItem(Player player)
		{
			return player.ownedProjectileCounts[item.shoot] < 1;
		}
		
		   public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
        {
            Projectile.NewProjectile(position.X, position.Y, speedX, speedY, mod.ProjectileType<Projectiles.LifeSpear>(), damage, knockBack, player.whoAmI);
			Projectile.NewProjectile(position.X, position.Y, speedX, speedY, 227, damage, knockBack, player.whoAmI);
			return false;
        }
	}
}
