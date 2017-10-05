using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace WNDD.Items.Weapons.Guns
{
	public class MeteornightFlamethrower : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Meteornight Flamethrower");
			Tooltip.SetDefault("60% chance to not consume ammo");
		}

		public override void SetDefaults()
		{
			item.damage = 40;
			item.ranged = true;
			item.width = 82;
			item.height = 36;
			item.useTime = 8;
			item.useAnimation = 8;
			item.useStyle = 5;
			item.noMelee = true;
			item.knockBack = 4;
			item.value = 10000;
			item.rare = 7;
			item.UseSound = SoundID.Item34;
			item.autoReuse = true;
			item.value = Item.sellPrice(0, 10, 0, 0);
			item.shoot = mod.ProjectileType<Projectiles.Flamethrower.MeteornightFlamethrower>();
			item.shootSpeed = 19f;
			item.useAmmo = AmmoID.Gel;
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
			return new Vector2(-5, 0);
		}

		public override bool ConsumeAmmo(Player player)
		{
			return Main.rand.NextFloat() >= .60f;
		}
	}
}