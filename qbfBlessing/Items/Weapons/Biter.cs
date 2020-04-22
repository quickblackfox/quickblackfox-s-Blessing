using Terraria.ID;
using Terraria.ModLoader;

namespace qbfBlessing.Items.Weapons
{
	public class Biter : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Biter");
		}
		public override void SetDefaults()
		{
			item.damage = 60;
			item.melee = true;
			item.width = 1000;
			item.height = 1000;
			item.useTime = 5;
			item.useAnimation = 12;
			item.useStyle = 1;
			item.knockBack = 5;
			item.value = 5000;
			item.rare = 4;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.NightsEdge, 1);
			recipe.AddIngredient(ItemID.AdamantiteSword, 1);
			recipe.AddIngredient(ItemID.MythrilBar, 10);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
