using Terraria.ID;
using Terraria.ModLoader;

namespace qbfBlessing.Items.Weapons
{
	public class Giganti : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Giganti");
			Tooltip.SetDefault("large sword of some sorts");
		}
		public override void SetDefaults()
		{
			item.damage = 123456;
			item.melee = true;
			item.width = 1000000;
			item.height = 1000000;
			item.useTime = 35;
			item.useAnimation = 12;
			item.useStyle = 1;
			item.knockBack = 25;
			item.value = 999999;
			item.rare = 999999;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
			item.shoot = mod.ProjectileType("DProjectile");
			item.shootSpeed = 666f;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.DirtBlock, 999999);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
