using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ValkyriesContentCrate.Projectiles.SpearSaga
{
	public class Lancetongue : ModProjectile
	{
	
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
                    Projectile.NewProjectile(projectile.Center.X, projectile.Center.Y, projectile.velocity.X, projectile.velocity.Y, 524, 40, projectile.knockBack, projectile.owner, 0f, 0f);
                    timer = 20;
                }
            }
        }

        	public override bool PreAI()
        {
            int dust = Dust.NewDust(projectile.position, projectile.width, projectile.height, 133, projectile.velocity.X, projectile.velocity.Y);
            Main.dust[dust].scale = 1f;
            Main.dust[dust].noGravity = true;
            Main.dust[dust].noLight = false;

            return true;
        }

		public override void OnHitNPC(NPC target, int damage, float knockback, bool crit)
        {
         if (crit)
            {
                target.AddBuff(69, 500);
            }
        }
    }
}