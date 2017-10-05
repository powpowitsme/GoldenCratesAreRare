using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace WNDD.Items.Weapons.Swung
{
	public class Emberblade : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Emberblade");
			Tooltip.SetDefault("Left-Click for a regular swing\nRight-Click for a swing blitz that uses mana\nIgnites enemies with shadowflame\n'Remember.'");	
		}

		public override void SetDefaults()
		{
			item.damage = 150;
			item.melee = true;			
			item.width = 76;			
			item.height = 76;			
			item.useTime = 10;	
			item.useAnimation = 10;
			item.useStyle = 1;			
			item.knockBack = 6;	
            item.crit = 4;			
			item.value = Item.sellPrice(0, 30, 0, 0);			
			item.rare = 9;
			item.UseSound = SoundID.Item34;
			item.autoReuse = true;
			
		}

		public override void ModifyTooltips(List<TooltipLine> tooltips)
        {
            TooltipLine line = new TooltipLine(mod, "ItemName", "[Special Warmage Weapon]");
            line.overrideColor = new Color(46, 239, 237);
            tooltips.Add(line);
        }

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(1811, 1);
			recipe.AddIngredient(527, 1);
			recipe.AddIngredient(177, 10);
			recipe.AddIngredient(548, 20);
			recipe.AddTile(412);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	
	    public override bool AltFunctionUse(Player player)
        {
            return true;
        }
		
			public override void OnHitNPC(Player player, NPC target, int damage, float knockback, bool crit)
        {
            if (Main.rand.Next(2) == 0)
            {
                target.AddBuff(153, 180);
            }
		}
		
        public override bool CanUseItem(Player player)
        {
            if (player.altFunctionUse == 2)
            {
                item.damage = 100;
                item.useTime = 10;
                item.useAnimation = 5;
                item.knockBack = 9;
				item.mana = 20;
				item.shoot = 709;
				item.shootSpeed = 20f;
				item.UseSound = SoundID.Item47;
				item.melee = false;
				item.magic = true;
            }
			   else
            {
                item.damage = 150;
                item.useTime = 10;
                item.useAnimation = 10;
                item.knockBack = 6;
                item.shoot = 0;
				item.mana = 0;
				item.UseSound = SoundID.Item34;
				item.melee = true;
				item.magic = false;
            }
            return base.CanUseItem(player);
		}

		public override void MeleeEffects(Player player, Rectangle hitbox)
		{
			if (Main.rand.Next(3) == 0)
			{
				int dust = Dust.NewDust(new Vector2(hitbox.X, hitbox.Y), hitbox.Width, hitbox.Height, 132, 0f, 0f, 0, default(Color), 1f);
			}
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
