using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ValkyriesContentCrate.Items.Weapons
{
	public class EclipsasWand : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Eclipsa's Wand");
			Tooltip.SetDefault("'I pledge my soul, and crush my heart to burning coal. To summon forth a deathly power, to see my hated foe devoured.'");
			Item.staff[item.type] = true; 
		}

		public override void SetDefaults()
		{
			item.damage = 1000;
			item.magic = true;
			item.mana = 200;
			item.width = 40;
			item.height = 40;
			item.useTime = 25;
			item.useAnimation = 25;
			item.useStyle = 5;
			item.noMelee = true;
			item.knockBack = 5;
			item.value = Item.sellPrice(10, 0, 0, 0);
			item.expert = true;
			item.rare = 11;
			item.UseSound = SoundID.Item20;
			item.autoReuse = false;
			item.shoot = 661;
			item.shootSpeed = 40f;
		}

			public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(1131, 1);
			recipe.AddIngredient(3783, 5);
			recipe.AddIngredient(2766, 25);
			recipe.AddIngredient(3458, 25);
			recipe.AddIngredient(3457, 25);
			recipe.AddIngredient(3456, 25);
			recipe.AddIngredient(3459, 25);
			recipe.AddIngredient(3467, 25);
			recipe.AddIngredient(3476, 1);
			recipe.AddIngredient(3542, 1);
			recipe.AddTile(412);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
		
		
			 public static Vector2[] randomSpread(float speedX, float speedY, int angle, int num)
        {
            var posArray = new Vector2[num];
            float spread = (float)(angle * 0.0774532925);
            float baseSpeed = (float)System.Math.Sqrt(speedX * speedX + speedY * speedY);
            double baseAngle = System.Math.Atan2(speedX, speedY);
            double randomAngle;
            for (int i = 0; i < num; ++i)
            {
                randomAngle = baseAngle + (Main.rand.NextFloat() - 0.5f) * spread;
                posArray[i] = new Vector2(baseSpeed * (float)System.Math.Sin(randomAngle), baseSpeed * (float)System.Math.Cos(randomAngle));
            }
            return (Vector2[])posArray;
        }

        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
        {
            Vector2[] speeds = randomSpread(speedX, speedY, 8, 6);
            for (int i = 0; i < 5; ++i)
            {
                Projectile.NewProjectile(position.X, position.Y, speeds[i].X, speeds[i].Y, type, damage, knockBack, player.whoAmI);
            }
            return false;
		}
	}
}