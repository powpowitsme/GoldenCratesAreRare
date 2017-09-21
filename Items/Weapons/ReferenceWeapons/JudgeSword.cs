using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ValkyriesContentCrate.Items.Weapons.ReferenceWeapons
{
	public class JudgeSword : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Judge Sword");
			Tooltip.SetDefault("'A good pizza cutter'");	
		}

		public override void SetDefaults()
		{
			item.damage = 200;
			item.melee = true;			
			item.width = 100;			
			item.height = 100;			
			item.useTime = 6;	
			item.useAnimation = 6;
			item.useStyle = 1;			
			item.knockBack = 6;			
			item.value = Item.sellPrice(1, 0, 0, 0);			
			item.rare = 10;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(3467, 25);
			recipe.AddTile(412);
			recipe.SetResult(this);
			recipe.AddRecipe();
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
