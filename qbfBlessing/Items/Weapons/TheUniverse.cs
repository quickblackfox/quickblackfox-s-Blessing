using Terraria.ID;
using Terraria.ModLoader;
using Terraria;

namespace qbfBlessing.Items.Weapons
{
	public class TheUniverse : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("The Universe");
			Tooltip.SetDefault("A sword with the power of the universe\nInflicts multiple debuffs");
		}
		public override void SetDefaults()
		{
			item.damage = 777;
			item.melee = true;
			item.width = 130;
			item.height = 130;
			item.useTime = 1;
			item.useAnimation = 12;
			item.useStyle = 1;
			item.knockBack = 11;
			item.value = 500000;
			item.rare = -12;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
			item.crit = 50;
			item.shoot = 503;
			item.shootSpeed = 8f;
		}

		public override void OnHitNPC(Player player, NPC target, int damage, float knockback, bool crit)
		{
			target.AddBuff(BuffID.Ichor, 60);
			target.AddBuff(BuffID.Venom, 60);
			player.AddBuff(BuffID.Regeneration, 180);
			player.AddBuff(BuffID.RapidHealing, 180);
		}
		

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "HeavenlyBlade", 1);
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
