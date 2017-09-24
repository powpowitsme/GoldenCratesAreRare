using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using ValkyriesContentCrate.Items;

namespace ValkyriesContentCrate.Items.Weapons.SpearSaga
{
public class BeePiercer : ModItem
{
    public override void SetStaticDefaults()
    {
        DisplayName.SetDefault("Bee Piercer");
        Tooltip.SetDefault("'Anything but the bees!'");
    }
    public override void SetDefaults()
    {
        item.damage = 20;
        item.useStyle = 5;
        item.useAnimation = 50;
        item.useTime = 50;
        item.shootSpeed = 3f;
        item.knockBack = 4f;
        item.width = 70;
        item.height = 70;
        item.scale = 1.25f;
        item.rare = 3;
        item.UseSound = SoundID.Item1;
        item.shoot = mod.ProjectileType<Projectiles.SpearSaga.BeePiercer>();
        item.noMelee = true;
        item.noUseGraphic = true;
        item.melee = true;
        item.autoReuse = true;
    }
    public override void AddRecipes()
    {
        ModRecipe recipe = new ModRecipe(mod);
        recipe.AddIngredient(1123, 1);
		recipe.AddIngredient(2431, 10);
        recipe.AddTile(TileID.Anvils);
        recipe.SetResult(this);
        recipe.AddRecipe();
    }
    public override bool CanUseItem(Player player)
    {
        return player.ownedProjectileCounts[item.shoot] < 1;
    }
}}