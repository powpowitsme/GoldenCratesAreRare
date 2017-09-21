using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
 
namespace ValkyriesContentCrate.Projectiles.Flamethrower   
{
    public class MeteornightFlamethrower : ModProjectile
    {
        public override void SetDefaults()
        {
            projectile.width = 12;  
            projectile.height = 12; 
            projectile.friendly = true;  
            projectile.ignoreWater = true; 
            projectile.ranged = true;
            projectile.penetrate = -1; 
            projectile.timeLeft = 25;  
            projectile.extraUpdates = 3;
        }
 
        public override void AI()
        {
            Lighting.AddLight(projectile.Center, ((255 - projectile.alpha) * 0.15f) / 255f, ((255 - projectile.alpha) * 0.45f) / 255f, ((255 - projectile.alpha) * 0.05f) / 255f);
            if (projectile.timeLeft > 25)
            {
                projectile.timeLeft = 25;
            }
            if (projectile.ai[0] > 1f)  
            {
                if (Main.rand.Next(1) == 0)    
                {
                    int dust = Dust.NewDust(new Vector2(projectile.position.X, projectile.position.Y), projectile.width, projectile.height, DustID.PinkFlame, projectile.velocity.X * 1.2f, projectile.velocity.Y * 1.2f, 130, default(Color), 3.75f);   
                    Main.dust[dust].noGravity = true;
                    Main.dust[dust].velocity *= 2.5f;
                    int dust2 = Dust.NewDust(new Vector2(projectile.position.X, projectile.position.Y), projectile.width, projectile.height, DustID.PinkFlame, projectile.velocity.X * 1.2f, projectile.velocity.Y * 1.2f, 130, default(Color), 1.5f); 
                }
            }
            else
            {
                projectile.ai[0] += 1f;
            }
            return;
        }
 
        public override void OnHitNPC(NPC target, int damage, float knockback, bool crit)
        {
            target.AddBuff(153, 80);   
        }
 
        public override bool OnTileCollide(Vector2 oldVelocity)
        {
            projectile.Kill();
            return false;
        }
    }
}