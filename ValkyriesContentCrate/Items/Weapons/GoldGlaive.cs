﻿using ValkyriesContentCrate.Projectiles;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ValkyriesContentCrate.Items.Weapons
{
	public class GoldGlaive : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Gold Glaive");
		}

		public override void SetDefaults()
		{
			item.damage = 11;
			item.useStyle = 5;
			item.useAnimation = 40;
			item.useTime = 40;
			item.shootSpeed = 1.7f;
			item.knockBack = 3.5f;
			item.width = 32;
			item.height = 32;
			item.scale = 1f;
			item.rare = 0;
			item.UseSound = SoundID.Item1;
			item.shoot = mod.ProjectileType<Projectiles.GoldGlaive>();
			item.value = Item.sellPrice(0, 0, 7, 0);
			item.noMelee = true;
			item.noUseGraphic = true;
			item.melee = true;
			item.autoReuse = false;
		}

			public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(19, 10);
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
