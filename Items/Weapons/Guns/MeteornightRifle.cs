using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace WNDD.Items.Weapons.Guns
{
	public class MeteornightRifle : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Meteornight Rifle");
			Tooltip.SetDefault("25% chance to not consume ammo\n'The ting go skrrrrra!'");
		}

		public override void SetDefaults()
		{
			item.damage = 25;
			item.ranged = true;
			item.width = 82;
			item.height = 36;
			item.useTime = 5;
			item.useAnimation = 5;
			item.useStyle = 5;
			item.noMelee = true;
			item.knockBack = 4;
			item.value = 10000;
			item.rare = 7;
			item.UseSound = SoundID.Item11;
			item.autoReuse = true;
			item.value = Item.sellPrice(0, 10, 0, 0);
			item.shoot = 10;
			item.shootSpeed = 19f;
			item.useAmmo = AmmoID.Bullet;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "MeteornightSpar", 12);
			recipe.AddTile(134);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
		
		public override Vector2? HoldoutOffset()
		{
			return new Vector2(-20, 0);
		}
		public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
		{
			Vector2 muzzleOffset = Vector2.Normalize(new Vector2(speedX, speedY)) * 25f;
			if (Collision.CanHit(position, 15, -15, position + muzzleOffset, 15, -15))
			{
				position += muzzleOffset;
			}
			return true;
		}
		
		public override bool ConsumeAmmo(Player player)
		{
			return Main.rand.NextFloat() >= .25f;
		}
	}
}