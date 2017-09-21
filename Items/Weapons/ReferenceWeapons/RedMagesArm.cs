using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ValkyriesContentCrate.Items.Weapons.ReferenceWeapons
{
	public class RedMagesArm : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Red Mage's Arm");
			Tooltip.SetDefault("'Firey hell.'");	
		}

		public override void SetDefaults()
		{
			item.damage = 13;
			item.melee = true;			
			item.width = 84;			
			item.height = 84;			
			item.useTime = 6;	
			item.useAnimation = 6;
			item.useStyle = 1;			
			item.knockBack = 3;			
			item.value = Item.sellPrice(0, 3, 0, 0);			
			item.rare = 3;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(175, 25);
			recipe.AddIngredient(21, 10);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();

			ModRecipe recipe1 = new ModRecipe(mod);
			recipe1.AddIngredient(175, 25);
			recipe1.AddIngredient(705, 10);
			recipe1.AddTile(TileID.Anvils);
			recipe1.SetResult(this);
			recipe1.AddRecipe();
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
