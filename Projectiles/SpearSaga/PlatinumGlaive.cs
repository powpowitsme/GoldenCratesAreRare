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
	public class PlatinumGlaive : ModProjectile
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Platinum Glaive");
		}

        public override void SetDefaults()
        {
            projectile.CloneDefaults(ProjectileID.Trident);

            aiType = ProjectileID.Trident;
        }
	}
}
