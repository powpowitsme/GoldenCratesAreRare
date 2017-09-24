using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ValkyriesContentCrate.Projectiles.SpearSaga
{
	public class BeePiercer : ModProjectile
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Bee Piercer");
		}
		
		int timer = 10;
        public override void SetDefaults()
        {
            projectile.CloneDefaults(ProjectileID.Trident);

            aiType = ProjectileID.Trident;
        }
		
        public override void AI()
        {
            {
                timer--;

                if (timer == 0)
                {
                    Projectile.NewProjectile(projectile.Center.X, projectile.Center.Y, projectile.velocity.X, projectile.velocity.Y, 469, 15, projectile.knockBack, projectile.owner, 0f, 0f);
                    timer = 30;
                }
            }
        }
    }
}