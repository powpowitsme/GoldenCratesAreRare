using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace WNDD.Items.Accessories
{
    public class ColdheartChip : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Cold Granite Chip");
            Tooltip.SetDefault("Decreases movement speed by 15%, but increases damage by 10%");

        }


        public override void SetDefaults()
        {
            item.width = 32;
            item.height = 42;
            item.value = Item.buyPrice(0, 4, 0, 0);
            item.rare = 1;
            item.defense = 3;
            item.accessory = true;
        }

        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            player.moveSpeed -= 0.15f;
            player.meleeDamage *= 1.1f;
			player.rangedDamage *= 1.1f;
		    player.minionDamage *= 1.1f;
			player.thrownDamage *= 1.1f;
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "ColdGranite", 6);
			recipe.AddIngredient(null, "CompactIceShard", 3);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
        }
    }
}