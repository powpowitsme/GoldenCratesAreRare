﻿using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace WNDD.Projectiles
{
	public class ColdGraniteP2 : ModProjectile
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Cold Granite Shard");
		}

		public override void SetDefaults()
		{
			projectile.friendly = true;
			projectile.aiStyle = 1;
			projectile.width = 100;
			projectile.height = 100;
			projectile.penetrate = 1;
			projectile.alpha = 255;
			projectile.timeLeft = 1;
		}

		public override bool PreAI()
		{
			for (int i = 0; i < 50; ++i)
			{
				projectile.tileCollide = false;
				int dust;
				dust = Dust.NewDust(projectile.position + projectile.velocity, projectile.width, projectile.height, 67, 0f, 0f);
				Main.dust[dust].scale = 3f;
				Main.dust[dust].noGravity = true;
			}
			return false;
		}

		public override void OnHitNPC(NPC target, int damage, float knockback, bool crit)
		{
			target.AddBuff(44, 100, false);
		}
	}
}