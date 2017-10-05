using Microsoft.Xna.Framework;
using WNDD.Projectiles;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace WNDD.Items.Weapons.SpearSaga
{
	public class Solardream : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Solardream");
			Tooltip.SetDefault("'Forever I will burn for you!'");
		}

		public override void SetDefaults()
		{
			item.damage = 250;
			item.useStyle = 5;
			item.useAnimation = 20;
			item.useTime = 20;
			item.shootSpeed = 10f;
			item.knockBack = 6.5f;
			item.width = 50;
			item.height = 50;
			item.scale = 1f;
			item.rare = 10;
			item.UseSound = SoundID.Item1;
			item.shoot = mod.ProjectileType<Projectiles.SpearSaga.Solardream>();
			item.value = Item.sellPrice(1, 0, 0, 0);
			item.noMelee = true;
			item.noUseGraphic = true;
			item.melee = true;
			item.autoReuse = true;
		}

			public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(3458, 18);
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
