using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace qbfBlessing.Projectiles.Swords
{
    public class AstralDestroyerProj2 : ModProjectile
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Astral Destroyer");
        }

        public override void SetDefaults()
        {
            projectile.width = 40;
            projectile.height = 50;
            projectile.aiStyle = 55;
            projectile.friendly = true;
            projectile.penetrate = 10;
            projectile.melee = true;
            projectile.damage = 200;
            projectile.knockBack = 20f;
            projectile.arrow = true;
        }
    }
}