using Microsoft.Xna.Framework;
using WNDD.Projectiles;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace WNDD.Items.Weapons.SpearSaga
{
	public class TerraAssegai : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Terra Assegai");
			Tooltip.SetDefault("Shoots Terra Beams");
		}

		public override void SetDefaults()
		{
			item.damage = 95;
			item.useStyle = 5;
			item.useAnimation = 17;
			item.useTime = 17;
			item.shootSpeed = 9f;
			item.knockBack = 6.5f;
			item.width = 50;
			item.height = 50;
			item.scale = 1f;
			item.rare = 8;
			item.UseSound = SoundID.Item1;
			item.shoot = mod.ProjectileType<Projectiles.SpearSaga.TerraAssegai>();
			item.value = Item.sellPrice(0, 50, 0, 0);
			item.noMelee = true;
			item.noUseGraphic = true;
			item.melee = true;
			item.autoReuse = true;
		}

			public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "TrueNightsPierce", 1);
			recipe.AddIngredient(null, "TrueGungnir", 1);
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