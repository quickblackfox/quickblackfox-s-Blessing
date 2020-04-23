using Terraria.ModLoader;
using Terraria.ID;

namespace qbfBlessing.Items.Tiles
{
    public class SingularityBar : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Singularity Bar");
            Tooltip.SetDefault("A singularity, concentrated into a bar");
        }
        public override void SetDefaults()
        {
            item.width = 24;
            item.height = 24;
            item.useTime = 20;
            item.useAnimation = 20;
            item.useStyle = 1;
            item.value = 66666;
            item.rare = 100;
            item.UseSound = SoundID.Item1;
            item.autoReuse = true; // NEVER TURN THIS, UNDER ANY CIRCUMSTANCES, TO FALSE UNLESS YOU ARE A TERRIBLE PERSON.
            item.consumable = true;
            item.createTile = mod.TileType("SingularityBarTile");
            item.maxStack = 9999;
        }

         public override void AddRecipes()
        {
            ModRecipe r = new ModRecipe(mod);
            r.AddIngredient(null, "SingularityOre", 4);
            r.AddTile(TileID.Anvils); // Anvils = Iron, Lead, Mythril, etc
            r.SetResult(this);
            r.AddRecipe();
        }
    }
}