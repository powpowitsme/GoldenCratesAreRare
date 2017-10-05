using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace WNDD.Projectiles.SpearSaga
{
	public class GalacticaIre : ModProjectile
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Galactic Ire");
		}

        int timer = 1;
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
                    Projectile.NewProjectile(projectile.Center.X, projectile.Center.Y, projectile.velocity.X, projectile.velocity.Y, 503, 180, projectile.knockBack, projectile.owner, 0f, 0f);
                    timer = 3;
                }
            }
        }
    }
}