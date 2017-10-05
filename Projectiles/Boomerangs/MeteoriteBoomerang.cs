using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
 
namespace WNDD.Projectiles.Boomerangs
{
    public class MeteoriteBoomerang : ModProjectile
    {
        public override void SetDefaults()
        {
            projectile.width = 26;
            projectile.height = 36;
            projectile.aiStyle = 3;
            projectile.friendly = true;
            projectile.thrown = true;
            projectile.penetrate = -1;
            projectile.timeLeft = 600;
            projectile.extraUpdates = 1;
          
        }

       	public override void OnHitNPC(NPC target, int damage, float knockback, bool crit)
		{
			target.AddBuff(BuffID.OnFire, 60);		
		}

        public override bool PreAI()
        {
            int dust = Dust.NewDust(projectile.position, projectile.width, projectile.height, 6, projectile.velocity.X, projectile.velocity.Y);
            Main.dust[dust].scale = 1f;
            Main.dust[dust].noGravity = true;
            Main.dust[dust].noLight = false;

            return true;
        }
    }
}