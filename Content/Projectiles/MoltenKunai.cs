using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Audio;

namespace PepperoniBattleRoyale.Content.Projectiles
{
    public class MoltenKunai : ModProjectile
    {
        public override void SetDefaults()
        {
            Projectile.height = 2;
            Projectile.width = 2;
            Projectile.friendly = true;
            Projectile.penetrate = 2;
            Projectile.DamageType = DamageClass.Ranged;

            Projectile.aiStyle = 2;
            AIType = ProjectileID.MagicDagger;
        }
        public override void OnKill(int timeLeft)
        {
            Collision.TileCollision(Projectile.position, Projectile.velocity, Projectile.width, Projectile.height);
            SoundEngine.PlaySound(SoundID.Dig, Projectile.position);
        }
    }
}
