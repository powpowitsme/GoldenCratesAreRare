using Microsoft.Xna.Framework;
using ValkyriesContentCrate.Projectiles;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ValkyriesContentCrate.Items.Weapons.SpearSaga
{
	public class GalacticaIre : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Galactic Ire");
			Tooltip.SetDefault("'Warning, a bit sparky!'");
		}

		public override void SetDefaults()
		{
			item.damage = 220;
			item.useStyle = 5;
			item.useAnimation = 40;
			item.useTime = 40;
			item.shootSpeed = 6f;
			item.knockBack = 6.5f;
			item.width = 50;
			item.height = 50;
			item.scale = 1f;
			item.rare = 8;
			item.UseSound = SoundID.Item1;
			item.shoot = mod.ProjectileType<Projectiles.SpearSaga.GalacticaIre>();
			item.value = Item.sellPrice(0, 50, 0, 0);
			item.noMelee = true;
			item.noUseGraphic = true;
			item.melee = true;
			item.autoReuse = true;
		}

			public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(3065, 1);
			recipe.AddIngredient(75, 50);
			recipe.AddIngredient(3467, 20);
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
