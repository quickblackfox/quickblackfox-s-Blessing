using Terraria.ID;
using Terraria.ModLoader;
using Terraria;

namespace qbfBlessing.Items.Weapons
{
	public class AngelsGuard : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Angel's Guard");
			Tooltip.SetDefault("A sword from the heavens\nSlows enemies");
		}
		public override void SetDefaults()
		{
			item.damage = 222;
			item.melee = true;
			item.width = 110;
			item.height = 110;
			item.useTime = 1;
			item.useAnimation = 12;
			item.useStyle = 1;
			item.knockBack = 7;
			item.value = 50000;
			item.rare = -12;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
			item.crit = 11;
		}

		public override void OnHitNPC(Player player, NPC target, int damage, float knockback, bool crit)
		{
			target.AddBuff(BuffID.Slow, 60);
			player.AddBuff(BuffID.Regeneration, 180);
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "Biter", 1);
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
