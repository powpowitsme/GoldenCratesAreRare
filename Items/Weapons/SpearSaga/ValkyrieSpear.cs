using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using ValkyriesContentCrate.Items;

namespace ValkyriesContentCrate.Items.Weapons.SpearSaga
{
public class ValkyrieSpear : ModItem
{
    public override void SetStaticDefaults()
    {
        DisplayName.SetDefault("Valkyrie Spear");
        Tooltip.SetDefault("'Magmatically Dangerous!'");
    }
    public override void SetDefaults()
    {
        item.damage = 20;
        item.useStyle = 5;
        item.useAnimation = 20;
        item.useTime = 25;
        item.shootSpeed = 6.0f;
        item.knockBack = 4f;
        item.width = 70;
        item.height = 70;
        item.scale = 1.25f;
        item.rare = 2;
        item.UseSound = SoundID.Item1;
        item.shoot = mod.ProjectileType<Projectiles.SpearSaga.ValkyrieSpearProjectile>();
        item.noMelee = true;
        item.noUseGraphic = true;
        item.melee = true;
        item.autoReuse = false;
    }
    public override void AddRecipes()
    {
        ModRecipe recipe = new ModRecipe(mod);
        recipe.AddIngredient(null, "ThunderumSpar", 10);
        recipe.AddTile(TileID.Anvils);
        recipe.SetResult(this);
        recipe.AddRecipe();
    }
    public override bool CanUseItem(Player player)
    {
        return player.ownedProjectileCounts[item.shoot] < 1;
    }
}}