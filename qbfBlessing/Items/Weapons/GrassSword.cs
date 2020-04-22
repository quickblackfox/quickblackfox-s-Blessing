using Terraria.ID;
using Terraria.ModLoader;

namespace qbfBlessing.Items.Weapons
{
	public class GrassSword : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Grass Sword");
		}
		public override void SetDefaults()
		{
			item.damage =  100;
			item.melee = true;
			item.width = 1000;
			item.height = 1000;
			item.useTime = 1;
			item.useAnimation = 12;
			item.useStyle = 1;
			item.knockBack = 3;
			item.value = 7070;
			item.rare = 7;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.BladeofGrass, 1);
			recipe.AddIngredient(ItemID.Seedler, 1);
			recipe.AddIngredient(ItemID.Stinger, 10);
			recipe.AddIngredient(ItemID.JungleSpores, 10);
			recipe.AddIngredient(ItemID.Vine, 20);
			recipe.AddIngredient(ItemID.ChlorophyteBar, 20);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
