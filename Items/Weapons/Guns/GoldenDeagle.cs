using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace WNDD.Items.Weapons.Guns
{
	public class GoldenDeagle : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Gold Deagle");
			Tooltip.SetDefault("Midas touch.");
		}

		public override void SetDefaults()
		{
			item.damage = 70;
			item.ranged = true;
			item.width = 42;
			item.height = 30;
			item.useTime = 20;
			item.useAnimation = 20;
			item.useStyle = 5;
			item.noMelee = true;
			item.knockBack = 9;
			item.rare = 3;
			item.UseSound = SoundID.Item41;
			item.autoReuse = false;
			item.value = Item.sellPrice(0, 2, 0, 0);
            item.shoot = 10;
			item.shootSpeed = 33f;
			item.useAmmo = AmmoID.Bullet;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(null, "Deagle");
            recipe.AddIngredient(ItemID.HellstoneBar, 20);
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