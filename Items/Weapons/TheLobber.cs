using Terraria.ID;
using Terraria.ModLoader;

namespace qbfBlessing.Items.Weapons
{
	public class TheLobber : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("The Lobber");
			Tooltip.SetDefault("Launches a bomb of sorts");
		}

		public override void SetDefaults()
		{
			item.damage =  165;
			item.melee = true;
			item.width = 1000;
			item.height = 1000;
			item.useTime = 10;
			item.useAnimation = 12;
			item.useStyle = 1;
			item.knockBack = 7;
			item.value = 10000;
			item.rare = 10;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
			item.shoot = mod.ProjectileType("TheLobberProj");
			item.shootSpeed = 25f;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.FragmentVortex, 3);
			recipe.AddIngredient(ItemID.FragmentNebula, 3);
			recipe.AddIngredient(ItemID.FragmentSolar, 3);
			recipe.AddIngredient(ItemID.FragmentStardust, 3);
			recipe.AddIngredient(ItemID.ChlorophyteClaymore, 1);
			recipe.AddIngredient(null, "Biter", 1);
			recipe.AddIngredient(null, "CosmicBlade", 1);
			recipe.AddIngredient(null, "StormSword", 1);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
