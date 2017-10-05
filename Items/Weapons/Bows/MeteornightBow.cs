using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace WNDD.Items.Weapons.Bows

{
	public class MeteornightBow : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Meteornight Bow");
			Tooltip.SetDefault("25% chance to not consume ammo");
		}

		public override void SetDefaults()
		{
			item.damage = 40;
			item.ranged = true;
			item.width = 82;
			item.height = 36;
			item.useTime = 10;
			item.useAnimation = 10;
			item.useStyle = 5;
			item.noMelee = true;
			item.knockBack = 4;
			item.value = 10000;
			item.rare = 7;
			item.UseSound = SoundID.Item5;
			item.autoReuse = true;
			item.value = Item.sellPrice(0, 10, 0, 0);
			item.shoot = 3;
			item.shootSpeed = 15f;
			item.useAmmo = AmmoID.Arrow;
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
			return Main.rand.NextFloat() >= .25f;
		}
	}
}