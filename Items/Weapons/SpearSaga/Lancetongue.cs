using Microsoft.Xna.Framework;
using WNDD.Projectiles;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace WNDD.Items.Weapons.SpearSaga
{
	public class Lancetongue: ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Lancetongue");
			Tooltip.SetDefault("Shoots Ichor\nSpear-crits Inflict Ichor");
		}

		public override void SetDefaults()
		{
			item.damage = 63;
			item.useStyle = 5;
			item.useAnimation = 17;
			item.useTime = 17;
			item.shootSpeed = 6.7f;
			item.knockBack = 6.5f;
			item.width = 50;
			item.height = 50;
			item.scale = 1f;
			item.rare = 5;
			item.UseSound = SoundID.Item1;
			item.shoot = mod.ProjectileType<Projectiles.SpearSaga.Lancetongue>();
			item.value = Item.sellPrice(0, 5, 0, 0);
			item.noMelee = true;
			item.noUseGraphic = true;
			item.melee = true;
			item.autoReuse = false;
		}

			public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(3211, 1);
			recipe.AddIngredient(547, 20);
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