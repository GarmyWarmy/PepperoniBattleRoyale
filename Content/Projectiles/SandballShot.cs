using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;
using Terraria.Audio;

namespace PepperoniBattleRoyale.Content.Projectiles
{
    public class SandballShot : ModProjectile
    {
        public override void SetDefaults()
        {
            Projectile.netImportant = true;
            Projectile.aiStyle = 1;
            Projectile.width = 18;
            Projectile.height = 18;
            Projectile.friendly = true;
            Projectile.DamageType = DamageClass.Melee;
            Projectile.usesLocalNPCImmunity = true;
            Projectile.localNPCHitCooldown = 10;
            Projectile.timeLeft = 300;
        }
        public override void AI()
        {
            Projectile.aiStyle = 0;

            Dust dust = Dust.NewDustDirect(Projectile.position, Projectile.height, Projectile.width, DustID.Water, 0, -1);
            dust = Dust.NewDustDirect(Projectile.position, Projectile.height, Projectile.width, DustID.Water, 0, -1);
            dust = Dust.NewDustDirect(Projectile.position, Projectile.height, Projectile.width, DustID.Water, 0, -1);
            dust = Dust.NewDustDirect(Projectile.position, Projectile.height, Projectile.width, DustID.Water, 0, -1);
            dust = Dust.NewDustDirect(Projectile.position, Projectile.height, Projectile.width, DustID.Water, 0, -1);
            dust = Dust.NewDustDirect(Projectile.position, Projectile.height, Projectile.width, DustID.Water, 0, -1);

        }
        public override void OnKill(int timeLeft)
        {
            Collision.TileCollision(Projectile.position, Projectile.velocity, Projectile.width, Projectile.height);
            SoundEngine.PlaySound(SoundID.Dig, Projectile.position);
            for (int i = 0; i < 10; i++)
            {
                Dust dust = Dust.NewDustDirect(Projectile.position, Projectile.width / 100, Projectile.height / 100, DustID.Water, 0, 0);
                dust.noGravity = true;
            }
        }
    }
}
