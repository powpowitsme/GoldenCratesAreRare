using Microsoft.Xna.Framework;
using ValkyriesContentCrate.Projectiles;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ValkyriesContentCrate.Items.Weapons.SpearSaga
{
	public class JohnSpeara : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("WWE SUPERSTAR JOHN SPEARA");
			Tooltip.SetDefault("'JOHN SPEARA'S ABS CAN DESTORY GODS'");
		}

		public override void SetDefaults()
		{
			item.damage = 1000000;
			item.useStyle = 5;
			item.useAnimation = 18;
			item.useTime = 18;
			item.shootSpeed = 40.7f;
			item.knockBack = 6.5f;
			item.width = 50;
			item.height = 50;
			item.scale = 1f;
			item.rare = 8;
			item.crit = 100;
			item.UseSound = SoundID.Item1;
			item.shoot = mod.ProjectileType<Projectiles.SpearSaga.JohnSpeara>();
			item.value = Item.sellPrice(9999999, 50, 0, 0);
			item.noMelee = true;
			item.noUseGraphic = true;
			item.melee = true;
			item.autoReuse = true;
		}
		
		public override bool CanUseItem(Player player)
		{
			return player.ownedProjectileCounts[item.shoot] < 1;
		}
	}
}
