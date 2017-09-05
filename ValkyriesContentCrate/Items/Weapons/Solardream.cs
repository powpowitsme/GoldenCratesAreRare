using Microsoft.Xna.Framework;
using ValkyriesContentCrate.Projectiles;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ValkyriesContentCrate.Items.Weapons
{
	public class Solardream : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Solardream");
			Tooltip.SetDefault("'Forever I will burn for you!'");
		}

		public override void SetDefaults()
		{
			item.damage = 170;
			item.useStyle = 5;
			item.useAnimation = 18;
			item.useTime = 18;
			item.shootSpeed = 3.7f;
			item.knockBack = 6.5f;
			item.width = 50;
			item.height = 50;
			item.scale = 1f;
			item.rare = 10;
			item.UseSound = SoundID.Item1;
			item.shoot = mod.ProjectileType<Projectiles.Solardream>();
			item.value = Item.sellPrice(1, 0, 0, 0);
			item.noMelee = true;
			item.noUseGraphic = true;
			item.melee = true;
			item.autoReuse = true;
		}

			public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(3458, 18);
			recipe.AddTile(412);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
		
		public override bool CanUseItem(Player player)
		{
			return player.ownedProjectileCounts[item.shoot] < 1;
		}
		
				public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
		{
			int numberProjectiles = 50 + Main.rand.Next(2);
			for (int i = 0; i < numberProjectiles; i++)
			{
				Vector2 perturbedSpeed = new Vector2(speedX, speedY).RotatedByRandom(MathHelper.ToRadians(50));
				Projectile.NewProjectile(position.X, position.Y, perturbedSpeed.X, perturbedSpeed.Y, type, damage, knockBack, player.whoAmI);
			}
		return false;
		}
	}
}
