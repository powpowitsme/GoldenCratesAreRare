﻿using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ValkyriesContentCrate.Projectiles.SpearSaga
{
	public class TheHorsemansSpear : ModProjectile
	{
	
        int timer = 15;
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
                    Projectile.NewProjectile(projectile.Center.X, projectile.Center.Y, projectile.velocity.X, projectile.velocity.Y, 700, 130, projectile.knockBack, projectile.owner, 0f, 0f);
                    timer = 15;
                }
            }
        }

		public override bool PreAI()
        {
            int dust = Dust.NewDust(projectile.position, projectile.width, projectile.height, 55, projectile.velocity.X, projectile.velocity.Y);
            Main.dust[dust].scale = 1f;
            Main.dust[dust].noGravity = true;
            Main.dust[dust].noLight = false;

            return true;
        }
    }
}