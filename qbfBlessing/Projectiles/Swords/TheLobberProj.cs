using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace qbfBlessing.Projectiles.Swords
{
    public class TheLobberProj : ModProjectile
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("The Lobber");
        }

        public override void SetDefaults()
        {
            projectile.width = 40;
            projectile.height = 50;
            projectile.aiStyle = 2;
            projectile.friendly = true;
            projectile.penetrate = 3;
            projectile.melee = true;
            projectile.damage = 165;
            projectile.knockBack = 10f;
            projectile.arrow = true;
        }
    }
}