using Terraria.ID;
using Terraria.ModLoader;
using Terraria;

namespace qbfBlessing.Items.Weapons
{
	public class HeavenlyBlade : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Heavenly Blade");
			Tooltip.SetDefault("A blade forged by the angels\nInflicts multiple debuffs");
		}
		public override void SetDefaults()
		{
			item.damage = 444;
			item.melee = true;
			item.width = 130;
			item.height = 130;
			item.useTime = 1;
			item.useAnimation = 12;
			item.useStyle = 1;
			item.knockBack = 9;
			item.value = 50000;
			item.rare = -12;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
			item.crit = 22;
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
			recipe.AddIngredient(null, "AngelsGuard", 1);
			recipe.AddIngredient(ItemID.SoulofMight, 10);
			recipe.AddIngredient(ItemID.SoulofLight, 10);
			recipe.AddIngredient(ItemID.LunarBar, 10);
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
