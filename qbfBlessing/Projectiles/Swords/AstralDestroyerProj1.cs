using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace qbfBlessing.Projectiles.Swords
{
    public class AstralDestroyerProj1 : ModProjectile
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Astral Destroyer");
        }

        public override void SetDefaults()
        {
            projectile.width = 40;
            projectile.height = 50;
            projectile.aiStyle = 88;
            projectile.friendly = true;
            projectile.penetrate = 10;
            projectile.melee = true;
            projectile.damage = 150;
            projectile.knockBack = 20f;
            projectile.arrow = true;
        }
    }
}