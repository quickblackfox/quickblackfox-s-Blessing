using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace qbfBlessing.Items.Tools
{
    public class SingularityPickaxe : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Singularity Pickaxe");
            Tooltip.SetDefault("The power of the singularity will pulverise blocks");
        }

        public override void SetDefaults()
        {
            
            item.damage = 666; // Base Damage of the Weapon
            item.width = 24; // Hitbox Width
            item.height = 24; // Hitbox Height
            
            item.useTime = 1; // Speed before reuse
            item.useAnimation = 5; // Animation Speed
            item.useStyle = 1; // 1 = Broadsword 
            item.knockBack = 10f; // Weapon Knockbase: Higher means greater "launch" distance
            item.value = 696969; // 10 | 00 | 00 | 00 : Platinum | Gold | Silver | Bronze
            item.rare = 100; // Item Tier
            item.UseSound = SoundID.Item1; // Sound effect of item on use 
            item.autoReuse = true; // Do you want to torture people with clicking? Set to false

            item.pick = 66666; // Pick Power - Higher Value = Better
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(null, "SingularityBar", 69);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}