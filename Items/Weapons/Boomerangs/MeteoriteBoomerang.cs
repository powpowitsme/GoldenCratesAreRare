using WNDD.Projectiles;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace WNDD.Items.Weapons.Boomerangs
{
	public class MeteoriteBoomerang : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Meteorite Boomerang");
		}

		public override void SetDefaults()
		{
			item.damage = 18;
			item.useStyle = 5;
			item.useAnimation = 40;
			item.useTime = 40;
			item.shootSpeed = 8.0f;
			item.knockBack = 3.5f;
			item.width = 32;
			item.height = 32;
			item.scale = 1f;
			item.rare = 1;
			item.UseSound = SoundID.Item1;
			item.shoot = mod.ProjectileType<Projectiles.Boomerangs.MeteoriteBoomerang>();
			item.value = Item.sellPrice(0, 0, 40, 0);
			item.noMelee = true;
			item.noUseGraphic = true;
			item.melee = true;
			item.autoReuse = false;
		}

		public override bool CanUseItem(Player player) 
        {
            for (int i = 0; i < 1000; ++i)
            {
                if (Main.projectile[i].active && Main.projectile[i].owner == Main.myPlayer && Main.projectile[i].type == item.shoot)
                {
                    return false;
                }
            }
            return true;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(117, 10);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
