using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace WNDD.Items.Weapons.ReferenceWeapons
{
	public class SolariasSword : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Solaria's Blade");
			Tooltip.SetDefault("Unleashes blasts of the heart\n'Monster Carver'");	
		}

		public override void SetDefaults()
		{
			item.damage = 175;
			item.melee = true;			
			item.width = 78;			
			item.height = 96;			
			item.useTime = 15;	
			item.useAnimation = 15;
			item.useStyle = 1;			
			item.knockBack = 6;			
			item.value = Item.sellPrice(10, 0, 0, 0);			
			item.rare = 10;
			item.expert = true;
			item.UseSound = SoundID.Item38;
			item.autoReuse = true;
			item.shoot = 684;
			item.shootSpeed = 20f;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(1131, 1);
			recipe.AddIngredient(3827, 1);
			recipe.AddIngredient(3065, 1);
			recipe.AddIngredient(3458, 25);
			recipe.AddIngredient(3457, 25);
			recipe.AddIngredient(3456, 25);
			recipe.AddIngredient(3459, 25);
			recipe.AddIngredient(3467, 25);
			recipe.AddTile(412);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}

		public override void OnHitNPC(Player player, NPC target, int damage, float knockback, bool crit)
		{
			target.AddBuff(BuffID.Daybreak, 120);		
			
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
		
		public override Vector2? HoldoutOffset()
		{
			return new Vector2(30, 0);
		}

		public override void MeleeEffects(Player player, Rectangle hitbox)
		{
			if (Main.rand.Next(3) == 0)
			{
				int dust = Dust.NewDust(new Vector2(hitbox.X, hitbox.Y), hitbox.Width, hitbox.Height, 219, 0f, 0f, 0, default(Color), 1f);
			}
		}
	}
}
