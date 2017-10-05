using WNDD.Projectiles;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace WNDD.Items.Weapons.SpearSaga
{
	public class EnchantedSpear : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Enchanted Spear");
		}

		public override void SetDefaults()
		{
			item.damage = 20;
			item.useStyle = 5;
			item.useAnimation = 17;
			item.useTime = 17;
			item.shootSpeed = 6.0f;
			item.knockBack = 3.5f;
			item.width = 32;
			item.height = 32;
			item.scale = 1f;
			item.rare = 1;
			item.UseSound = SoundID.Item1;
			item.shoot = mod.ProjectileType<Projectiles.SpearSaga.EnchantedSpear>();
			item.value = Item.sellPrice(0, 1, 0, 0);
			item.noMelee = true;
			item.noUseGraphic = true;
			item.melee = true;
			item.autoReuse = false;
		}

			public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(989, 1);
			recipe.AddIngredient(75, 10);
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
