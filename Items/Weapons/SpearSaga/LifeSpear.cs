﻿using Microsoft.Xna.Framework;
using ValkyriesContentCrate.Projectiles;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ValkyriesContentCrate.Items.Weapons.SpearSaga
{
	public class LifeSpear : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Life Spear");
			Tooltip.SetDefault("'This doesn't give life at all! Ripoff dudeeeee!'");
		}

		public override void SetDefaults()
		{
			item.damage = 91;
			item.useStyle = 5;
			item.useAnimation = 30;
			item.useTime = 30;
			item.shootSpeed = 7.7f;
			item.knockBack = 6.5f;
			item.width = 50;
			item.height = 50;
			item.scale = 1f;
			item.rare = 8;
			item.UseSound = SoundID.Item1;
			item.shoot = mod.ProjectileType<Projectiles.SpearSaga.LifeSpear>();
			item.value = Item.sellPrice(0, 50, 0, 0);
			item.noMelee = true;
			item.noUseGraphic = true;
			item.melee = true;
			item.autoReuse = true;
		}

			public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(756, 1);
			recipe.AddIngredient(550, 1);
			recipe.AddIngredient(1228, 1);
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