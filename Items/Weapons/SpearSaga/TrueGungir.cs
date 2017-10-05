using Microsoft.Xna.Framework;
using WNDD.Projectiles;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace WNDD.Items.Weapons.SpearSaga
{
	public class TrueGungnir : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("True Gungnir");
			Tooltip.SetDefault("Shoots True Excalibur Blades");
		}

		public override void SetDefaults()
		{
			item.damage = 90;
			item.useStyle = 5;
			item.useAnimation = 17;
			item.useTime = 17;
			item.shootSpeed = 7.7f;
			item.knockBack = 7.5f;
			item.width = 50;
			item.height = 50;
			item.scale = 1f;
			item.rare = 8;
			item.UseSound = SoundID.Item1;
			item.shoot = mod.ProjectileType<Projectiles.SpearSaga.TrueGungnir>();
			item.value = Item.sellPrice(0, 40, 0, 0);
			item.noMelee = true;
			item.noUseGraphic = true;
			item.melee = true;
			item.autoReuse = true;
		}

			public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(550, 1);
			recipe.AddIngredient(1570, 1);
			recipe.AddTile(TileID.DemonAltar);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
		
		public override bool CanUseItem(Player player)
		{
			return player.ownedProjectileCounts[item.shoot] < 1;
		}
	}
}