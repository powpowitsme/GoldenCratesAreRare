using Microsoft.Xna.Framework;
using WNDD.Projectiles;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace WNDD.Items.Weapons.SpearSaga
{
	public class BreakerSpear : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Breaker Spear");
		}

		public override void SetDefaults()
		{
			item.damage = 38;
			item.useStyle = 5;
			item.useAnimation = 50;
			item.useTime = 50;
			item.shootSpeed = 3.7f;
			item.knockBack = 20.5f;
			item.width = 50;
			item.height = 50;
			item.scale = 1f;
			item.rare = 4;
			item.UseSound = SoundID.Item1;
			item.shoot = mod.ProjectileType<Projectiles.SpearSaga.BreakerSpear>();
			item.value = Item.sellPrice(0, 4, 0, 0);
			item.noMelee = true;
			item.noUseGraphic = true;
			item.melee = true;
			item.autoReuse = true;
		}

			public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(426, 1);
			recipe.AddIngredient(521, 10);
			recipe.AddIngredient(520, 10);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
		
		public override bool CanUseItem(Player player)
		{
			return player.ownedProjectileCounts[item.shoot] < 1;
		}
	}
}