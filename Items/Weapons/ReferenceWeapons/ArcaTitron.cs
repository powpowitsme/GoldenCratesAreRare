using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using WNDD.Items;

namespace WNDD.Items.Weapons.ReferenceWeapons
{
    public class ArcaTitron : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Arca Titron");
            Tooltip.SetDefault("'Yes, this is a Warframe reference.'");
        }
        public override void SetDefaults()
        {
            item.damage = 94;
            item.melee = true;
            item.width = 94;
            item.height = 94;
            item.useTime = 30;
            item.useAnimation = 30;
            item.hammer = 120;
            item.useStyle = 1;
            item.knockBack = 6;
            item.value = 0;
            item.crit = 60;
            item.rare = 7;
            item.UseSound = SoundID.Item38;
            item.autoReuse = true;
            item.useTurn = true;
        }
        public override void MeleeEffects(Player player, Rectangle hitbox)
        {
            if (Main.rand.Next(1) == 0)
            {
                int dust = Dust.NewDust(new Vector2(hitbox.X, hitbox.Y), hitbox.Width, hitbox.Height, 133);
            }
        }
		
			public override void OnHitNPC(Player player, NPC target, int damage, float knockback, bool crit)
		{
			target.AddBuff(BuffID.Oiled, 1000);		
			
		}
		
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.ChlorophyteBar, 15);
            recipe.AddIngredient(ItemID.SoulofMight, 20);
            recipe.AddTile(412);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}