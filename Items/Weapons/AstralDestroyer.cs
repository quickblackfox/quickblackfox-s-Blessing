using Terraria.ID;
using Terraria.ModLoader;

namespace qbfBlessing.Items.Weapons
{
	public class AstralDestroyer : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Astral Destroyer");
			Tooltip.SetDefault("Harness Lunar Power");
		}

		public override void SetDefaults()
		{
			item.damage =  200;
			item.melee = true;
			item.width = 1000;
			item.height = 1000;
			item.useTime = 10;
			item.useAnimation = 12;
			item.useStyle = 1;
			item.knockBack = 7;
			item.value = 10000;
			item.rare = 11;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
			item.shoot = mod.ProjectileType("AstralDestroyerProj1");
			item.shootSpeed = 30f;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.FragmentVortex, 3);
			recipe.AddIngredient(ItemID.FragmentNebula, 3);
			recipe.AddIngredient(ItemID.FragmentSolar, 3);
			recipe.AddIngredient(ItemID.FragmentStardust, 3);
			recipe.AddIngredient(ItemID.NightsEdge, 1);
			recipe.AddIngredient(ItemID.FieryGreatsword, 1);
			recipe.AddIngredient(null, "GrassSword", 1);
			recipe.AddIngredient(ItemID.LunarBar, 10);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
