using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using ValkyriesContentCrate.Items;

namespace ValkyriesContentCrate.Items.Weapons 
{
public class BlitzSpear : ModItem
{
    public override void SetStaticDefaults()
    {
        DisplayName.SetDefault("Blitz Spear");
        Tooltip.SetDefault("Quirk: Electrification");
    }
    public override void SetDefaults()
    {
        item.damage = 47;
        item.useStyle = 5;
        item.useAnimation = 20;
        item.useTime = 25;
        item.shootSpeed = 3.0f;
        item.knockBack = 4f;
        item.width = 70;
        item.height = 70;
        item.scale = 1.25f;
        item.rare = 5;
        item.UseSound = SoundID.Item1;
        item.shoot = mod.ProjectileType<Projectiles.BlitzSpearProjectile>();
        item.noMelee = true;
        item.noUseGraphic = true;
        item.melee = true;
        item.autoReuse = false;
    }
    public override void AddRecipes()
    {
        ModRecipe recipe = new ModRecipe(mod);
        recipe.AddIngredient(ItemID.SoulofSight, 20);
        recipe.AddTile(TileID.MythrilAnvil);
        recipe.SetResult(this);
        recipe.AddRecipe();
    }
    public override bool CanUseItem(Player player)
    {
        return player.ownedProjectileCounts[item.shoot] < 1;
    }
}}