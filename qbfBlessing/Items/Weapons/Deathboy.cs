using Terraria.ID;
using Terraria.ModLoader;

namespace qbfBlessing.Items.Weapons
{
	public class Deathboy : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Deathboy");
			Tooltip.SetDefault("The Legendary The The The Legendary Legendary The");
		}
		public override void SetDefaults()
		{
			item.damage = 99999999;
			item.melee = true;
			item.width = 1000;
			item.height = 1000;
			item.useTime = 20;
			item.useAnimation = 12;
			item.useStyle = 1;
			item.knockBack = 10;
			item.value = 999999;
			item.rare = 999999;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.DirtBlock, 666666);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
