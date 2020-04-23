using Terraria.ID;
using Terraria.ModLoader;

namespace qbfBlessing.Items.Weapons
{
	public class StormSword : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Storm Sword");
		}
		public override void SetDefaults()
		{
			item.damage = 70;
			item.melee = true;
			item.width = 1000;
			item.height = 1000;
			item.useTime = 4;
			item.useAnimation = 12;
			item.useStyle = 1;
			item.knockBack = 7;
			item.value = 5555;
			item.rare = 4;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.CloudinaBottle, 1);
			recipe.AddIngredient(ItemID.Feather, 10);
			recipe.AddIngredient(ItemID.SoulofFlight, 10);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
