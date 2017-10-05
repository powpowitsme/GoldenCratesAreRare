﻿using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace WNDD.Projectiles.SpearSaga
{
	public class TheCorruptedTrident : ModProjectile
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("The Corrupted Trident");
		}

		public override void SetDefaults()
        {
            projectile.CloneDefaults(ProjectileID.Trident);

            aiType = ProjectileID.Trident;
        }
		
		public override bool PreAI()
        {
            int dust = Dust.NewDust(projectile.position, projectile.width, projectile.height, 27, projectile.velocity.X, projectile.velocity.Y);
            Main.dust[dust].scale = 1f;
            Main.dust[dust].noGravity = true;
            Main.dust[dust].noLight = false;

            return true;
        }
	}
}