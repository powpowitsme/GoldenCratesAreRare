using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace WNDD.Items.Weapons.Guns
{
	public class Frozone : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Frozone");
			Tooltip.SetDefault("Honey, where's my supersuit?");
		}

		public override void SetDefaults()
		{
			item.damage = 26;
			item.ranged = true;
			item.width = 50;
			item.height = 22;
			item.useTime = 46;
			item.useAnimation = 46;
			item.useStyle = 5;
			item.noMelee = true;
			item.knockBack = 7;
			item.rare = 4;
			item.UseSound = SoundID.Item36;
			item.autoReuse = false;
			item.value = Item.sellPrice(0, 5, 0, 0);
            item.shoot = 166;
			item.shootSpeed = 22f;
            item.useAmmo = AmmoID.Snowball;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.Shotgun);
            recipe.AddIngredient(ItemID.FrostCore, 1);
            recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}


        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
        {
            int numberProjectiles = 5 + Main.rand.Next(2);
            for (int i = 0; i < numberProjectiles; i++)
            {
                Vector2 perturbedSpeed = new Vector2(speedX, speedY).RotatedByRandom(MathHelper.ToRadians(10));
                float scale = 0.9f - (Main.rand.NextFloat() * .4f);
                perturbedSpeed = perturbedSpeed * scale;
                Projectile.NewProjectile(position.X, position.Y, perturbedSpeed.X, perturbedSpeed.Y, type, damage, knockBack, player.whoAmI);
            }
            return false;
        }

        public override Vector2? HoldoutOffset()
        {
            return new Vector2(-3, -1);
        }
	}
}