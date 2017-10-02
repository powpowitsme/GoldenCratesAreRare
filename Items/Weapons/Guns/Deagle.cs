using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ValkyriesContentCrate.Items.Weapons.Guns
{
	public class Deagle : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Deagle");
			Tooltip.SetDefault("Dude, this one time, I made it to round 50 with only a deagle.");
		}

		public override void SetDefaults()
		{
			item.damage = 50;
			item.ranged = true;
			item.width = 42;
			item.height = 30;
			item.useTime = 30;
			item.useAnimation = 30;
			item.useStyle = 5;
			item.noMelee = true;
			item.knockBack = 7;
			item.rare = 2;
			item.UseSound = SoundID.Item41;
			item.autoReuse = false;
			item.value = Item.sellPrice(0, 1, 0, 0);
            item.shoot = 10;
			item.shootSpeed = 22f;
			item.useAmmo = AmmoID.Bullet;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.Handgun);
            recipe.AddIngredient(ItemID.MeteoriteBar, 20);
            recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}

        public override Vector2? HoldoutOffset()
        {
            return new Vector2(-3, -1);
        }
	}
}