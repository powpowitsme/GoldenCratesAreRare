using Microsoft.Xna.Framework;
using ValkyriesContentCrate.Projectiles;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ValkyriesContentCrate.Items.Weapons.SpearSaga
{
	public class NightsPierce : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Night's Pierce");
		}

		public override void SetDefaults()
		{
			item.damage = 38;
			item.useStyle = 5;
			item.useAnimation = 40;
			item.useTime = 40;
			item.shootSpeed = 5.0f;
			item.knockBack = 6.5f;
			item.width = 50;
			item.height = 50;
			item.scale = 1f;
			item.rare = 3;
			item.UseSound = SoundID.Item1;
			item.shoot = mod.ProjectileType<Projectiles.SpearSaga.NightsPierce>();
			item.value = Item.sellPrice(0, 4, 0, 0);
			item.noMelee = true;
			item.noUseGraphic = true;
			item.melee = true;
			item.autoReuse = true;
		}

			public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(802, 1);
			recipe.AddIngredient(null, "SpearOfGrass", 1);
			recipe.AddIngredient(null, "Muraspeara", 1);
			recipe.AddIngredient(274, 1);
			recipe.AddTile(TileID.DemonAltar);
			recipe.SetResult(this, 1);
			recipe.AddRecipe();

			ModRecipe recipe1 = new ModRecipe(mod);
			recipe1.AddIngredient(null, "TheCorruptedTrident", 1);
			recipe1.AddIngredient(null, "SpearOfGrass", 1);
			recipe1.AddIngredient(null, "Muraspeara", 1);
			recipe1.AddIngredient(274, 1);
			recipe1.AddTile(TileID.DemonAltar);
			recipe1.SetResult(this, 1);
			recipe1.AddRecipe();
		}
		
		public override bool CanUseItem(Player player)
		{
			return player.ownedProjectileCounts[item.shoot] < 1;
		}
	}
}