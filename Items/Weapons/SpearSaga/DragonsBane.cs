using Microsoft.Xna.Framework;
using WNDD.Projectiles;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace WNDD.Items.Weapons.SpearSaga
{
	public class DragonsBane : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Dragon's Bane");
			Tooltip.SetDefault("Unleashes Phantom Phoenixes\nInflicts Betsy's Curse on spear crit\n'Dragon Crusher'");
		}

		public override void SetDefaults()
		{
			item.damage = 185;
			item.useStyle = 5;
			item.useAnimation = 20;
			item.useTime = 20;
			item.shootSpeed = 8.7f;
			item.knockBack = 6.5f;
			item.width = 50;
			item.height = 50;
			item.scale = 1f;
			item.rare = 8;
			item.UseSound = SoundID.Item1;
			item.shoot = mod.ProjectileType<Projectiles.SpearSaga.DragonsBane>();
			item.value = Item.sellPrice(2, 0, 0, 0);
			item.noMelee = true;
			item.noUseGraphic = true;
			item.melee = true;
			item.autoReuse = true;
		}

			public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(29, 5);
			recipe.AddIngredient(3836, 1);
			recipe.AddIngredient(3467, 10);
			recipe.AddTile(412);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
		
		public override bool CanUseItem(Player player)
		{
			return player.ownedProjectileCounts[item.shoot] < 1;
		}
	}
}