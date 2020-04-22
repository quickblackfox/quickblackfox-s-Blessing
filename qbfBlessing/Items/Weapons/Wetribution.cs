using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;
using Terraria.ID;
using Terraria;

namespace qbfBlessing.Items.Weapons
{
    public class Wetribution : ModItem
    {
        public override void SetDefaults()
        {
            item.Size = new Vector2(12, 24);
            item.rare = -12;
            item.value = Item.sellPrice(silver: 696969);
            item.useTime = 1;
            item.useAnimation = 25;
            item.useStyle = ItemUseStyleID.HoldingOut;
            item.UseSound = SoundID.Item5;
            item.noMelee = true;
            item.ranged = true;
            item.damage = 121212;
            item.useAmmo = AmmoID.Arrow;
            item.shoot = 5;
            item.shootSpeed = 1f;
            item.autoReuse = true;
            item.knockBack = 10;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(null, "SingularityBar", 10);
			recipe.AddIngredient(null, "MiniatureSingularity", 5);
			recipe.AddIngredient(ItemID.FragmentVortex, 3);
			recipe.AddIngredient(ItemID.FragmentNebula, 3);
			recipe.AddIngredient(ItemID.FragmentSolar, 3);
			recipe.AddIngredient(ItemID.FragmentStardust, 3);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}