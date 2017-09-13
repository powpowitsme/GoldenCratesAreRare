using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using ValkyriesContentCrate.Items;

namespace ValkyriesContentCrate.Items.Weapons
{
    public class ArcaTitron : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Arca Titron");
            Tooltip.SetDefault("Yes, this is a Warframe Reference.");
        }
        public override void SetDefaults()
        {
            item.damage = 94;
            item.melee = true;
            item.width = 104;
            item.height = 104;
            item.useTime = 30;
            item.useAnimation = 30;
            item.hammer = 100;
            item.useStyle = 1;
            item.knockBack = 6;
            item.value = 0;
            item.crit = 60;
            item.rare = 5;
            item.UseSound = SoundID.Item38;
            item.autoReuse = true;
            item.useTurn = true;
            item.scale = 0.85f;
        }
        public override void MeleeEffects(Player player, Rectangle hitbox)
        {
            if (Main.rand.Next(1) == 0)
            {
                int dust = Dust.NewDust(new Vector2(hitbox.X, hitbox.Y), hitbox.Width, hitbox.Height, 133);
            }
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.ChlorophyteBar, 20);
            recipe.AddIngredient(ItemID.SoulofMight, 20);
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}