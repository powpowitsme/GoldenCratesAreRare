using WNDD.Projectiles;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace WNDD.Items.Weapons.SpearSaga
{
	public class StylishSpear : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Stylish Spear");
		}

		public override void SetDefaults()
		{
			item.damage = 33;
			item.useStyle = 5;
			item.useAnimation = 40;
			item.useTime = 40;
			item.shootSpeed = 4.0f;
			item.knockBack = 3.5f;
			item.width = 32;
			item.height = 32;
			item.scale = 1f;
			item.rare = 3;
			item.UseSound = SoundID.Item1;
			item.shoot = mod.ProjectileType<Projectiles.SpearSaga.StylishSpear>();
			item.value = Item.sellPrice(0, 0, 30, 0);
			item.noMelee = true;
			item.noUseGraphic = true;
			item.melee = true;
			item.autoReuse = false;
		}

			public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(3352, 1);
			recipe.AddIngredient(175, 5);
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
