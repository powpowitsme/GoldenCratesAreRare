using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace WNDD.Projectiles.SpearSaga
{
	public class Solardream : ModProjectile
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Solardream");
		}

		public override void SetDefaults()
        {
            projectile.CloneDefaults(ProjectileID.Trident);

            aiType = ProjectileID.Trident;
        }
			public override void PostAI()
		{
			if (Main.rand.Next(2) == 0)
			{
				int dustIndex = Dust.NewDust(projectile.position, projectile.width, projectile.height, 6, 0f, 0f, 0, default(Color), 1f);
				Main.dust[dustIndex].noGravity = true;
				Main.dust[dustIndex].scale = 1.6f;
			}
		}

				public override void OnHitNPC(NPC target, int damage, float knockback, bool crit)
        {
            if (Main.rand.Next(2) == 0)
            {
                target.AddBuff(BuffID.Daybreak, 180);
            }
        }	
	}
}