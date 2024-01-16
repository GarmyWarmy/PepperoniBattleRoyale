using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Audio;

namespace PepperoniBattleRoyale.Content.Projectiles
{
    public class WebSpitFriendly : ModProjectile
    {
        public override void SetDefaults()
        {
            Projectile.width = 2;
            Projectile.height = 2;
            Projectile.damage = 50;
            Projectile.friendly = true;
            Projectile.DamageType = DamageClass.Ranged;
            Projectile.extraUpdates = 1;

            Projectile.aiStyle = 1;
            AIType = ProjectileID.Bullet;
        }
        public override void AI()
        {
            Projectile.aiStyle = 0;

            for (int i = 0; i < 2; i++)
            {
                Dust dust = Dust.NewDustDirect(Projectile.position, Projectile.width / 2, Projectile.height / 2, DustID.Web, Projectile.velocity.X, Projectile.velocity.Y);
                dust.noGravity = true;
                dust.velocity *= 0f;
            }
        }
        public override void OnKill(int timeLeft)
        {
            // This code and the similar code above in OnTileCollide spawn dust from the tiles collided with. SoundID.Item10 is the bounce sound you hear.
            Collision.HitTiles(Projectile.position + Projectile.velocity, Projectile.velocity, Projectile.width, Projectile.height);
            SoundEngine.PlaySound(SoundID.Item10, Projectile.position);
        }
        public override void OnHitNPC(NPC target, NPC.HitInfo hit, int damageDone)
        {
                target.AddBuff(BuffID.Slow, 180);
        }
        public override void OnHitPlayer(Player target, Player.HurtInfo info)
        {
                target.AddBuff(BuffID.Slow, 180);
        }
    }
}
