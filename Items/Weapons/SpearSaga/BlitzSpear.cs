using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using WNDD.Items;

namespace WNDD.Items.Weapons.SpearSaga
{
public class BlitzSpear : ModItem
{
    public override void SetStaticDefaults()
    {
        DisplayName.SetDefault("Blitz Spear");
        Tooltip.SetDefault("'Quirk: Electrification'");
    }
    public override void SetDefaults()
    {
        item.damage = 80;
        item.useStyle = 5;
        item.useAnimation = 20;
        item.useTime = 25;
        item.shootSpeed = 5.0f;
        item.knockBack = 7f;
        item.width = 70;
        item.height = 70;
        item.scale = 1.25f;
        item.rare = 5;
        item.UseSound = SoundID.Item1;
        item.shoot = mod.ProjectileType<Projectiles.SpearSaga.BlitzSpearProjectile>();
        item.noMelee = true;
        item.noUseGraphic = true;
        item.melee = true;
        item.autoReuse = false;
    }
    public override void AddRecipes()
    {
        ModRecipe recipe = new ModRecipe(mod);
        recipe.AddIngredient(ItemID.SoulofSight, 20);
		recipe.AddIngredient(null, "ValkyrieSpear", 1);
		recipe.AddIngredient(null, "ThunderumSpar", 10);
        recipe.AddTile(TileID.MythrilAnvil);
        recipe.SetResult(this);
        recipe.AddRecipe();
    }
    public override bool CanUseItem(Player player)
    {
        return player.ownedProjectileCounts[item.shoot] < 1;
    }
}}