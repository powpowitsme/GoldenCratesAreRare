﻿using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ValkyriesContentCrate.Projectiles
{
	public class TungstenSpear : ModProjectile
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Tungsten Spear");
		}

		public override void SetDefaults()
		{
			projectile.width = 23;
			projectile.height = 23;
			projectile.aiStyle = 19;
			projectile.friendly = true;
			projectile.penetrate = -1;
			projectile.tileCollide = false;
			projectile.scale = 1.3f;
			projectile.hide = true;
			projectile.ownerHitCheck = true;
			projectile.melee = true;
			projectile.alpha = 0;
		}

		
		public float movementFactor 
		{
			get { return projectile.ai[0]; }
			set { projectile.ai[0] = value; }
		}

		public override void AI()
		{

			Player projOwner = Main.player[projectile.owner];
			Vector2 ownerMountedCenter = projOwner.RotatedRelativePoint(projOwner.MountedCenter, true);
			projectile.direction = projOwner.direction;
			projOwner.heldProj = projectile.whoAmI;
			projOwner.itemTime = projOwner.itemAnimation;
			projectile.position.X = ownerMountedCenter.X - (float)(projectile.width / 2);
			projectile.position.Y = ownerMountedCenter.Y - (float)(projectile.height / 2);
			if (!projOwner.frozen)
			{
				if (movementFactor == 0f) 
				{
					movementFactor = 2f; 
					projectile.netUpdate = true; 
				}
				if (projOwner.itemAnimation < projOwner.itemAnimationMax / 3) 
				{
					movementFactor -= 4.4f;
				}
				else 
				{
					movementFactor += 4.1f;
				}
			}
			projectile.position += projectile.velocity * movementFactor;
			if (projOwner.itemAnimation == 0)
			{
				projectile.Kill();
			}

			projectile.rotation = (float)Math.Atan2((double)projectile.velocity.Y, (double)projectile.velocity.X) + MathHelper.ToRadians(135f);
			if (projectile.spriteDirection == -1)
			{
				projectile.rotation -= MathHelper.ToRadians(90f);
			}
		}
	}
}
