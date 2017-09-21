using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ValkyriesContentCrate.Items.Weapons.Swung
{
	public class Meteornightclaymore : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Meteornight Claymore");
			Tooltip.SetDefault("Left-Click for a strong and fast swing\nRight-Click to place a weaker mine that homes on nearby enemies\nBlade-hits give buffs on critical hits\nBlade-hits ignites enemies with shadowflame\n'Where are the sleepless nights I used to live for?'");	
		}

		public override void SetDefaults()
		{
			item.damage = 60;
			item.melee = true;			
			item.width = 78;			
			item.height = 98;			
			item.useTime = 15;	
			item.useAnimation = 15;
			item.useStyle = 1;			
			item.knockBack = 6;	
            item.crit = 6;			
			item.value = Item.sellPrice(0, 10, 0, 0);			
			item.rare = 7;
			item.UseSound = SoundID.Item38;
			item.autoReuse = false;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "MeteornightSpar", 12);
			recipe.AddTile(134);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	
	    public override bool AltFunctionUse(Player player)
        {
            return true;
        }
		
			public override void OnHitNPC(Player player, NPC target, int damage, float knockback, bool crit)
        {
            if (Main.rand.Next(2) == 0)
            {
                target.AddBuff(153, 180);
            }
            if (crit)
            {
                player.AddBuff(3, 380);
				player.AddBuff(5, 380);
				player.AddBuff(2, 380);
				player.AddBuff(26, 380);
            }
        }
		
        public override bool CanUseItem(Player player)
        {
            if (player.altFunctionUse == 2)
            {
                item.damage = 40;
                item.useTime = 20;
                item.useAnimation = 20;
                item.shoot = 634;
                item.knockBack = 3;
            }
			   else
            {
                item.damage = 60;
                item.useTime = 15;
                item.useAnimation = 15;
                item.knockBack = 6;
                item.shoot = 0;
            }
            return base.CanUseItem(player);
		}
	}
}
