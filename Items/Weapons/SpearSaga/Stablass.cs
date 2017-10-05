using Microsoft.Xna.Framework;
using WNDD.Projectiles;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace WNDD.Items.Weapons.SpearSaga
{
	public class Stablass : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Stablass");
		}

		public override void SetDefaults()
		{
			item.damage = 50;
			item.useStyle = 5;
			item.useAnimation = 20;
			item.useTime = 20;
			item.shootSpeed = 7.0f;
			item.knockBack = 6.5f;
			item.width = 50;
			item.height = 50;
			item.scale = 1f;
			item.rare = 5;
			item.UseSound = SoundID.Item1;
			item.shoot = mod.ProjectileType<Projectiles.SpearSaga.Stablass>();
			item.value = Item.sellPrice(0, 5, 0, 0);
			item.noMelee = true;
			item.noUseGraphic = true;
			item.melee = true;
			item.autoReuse = true;
		}

			public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(672, 1);
			recipe.AddIngredient(1225, 10);
			recipe.AddTile(134);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
		
		public override bool CanUseItem(Player player)
		{
			return player.ownedProjectileCounts[item.shoot] < 1;
		}
	}
}