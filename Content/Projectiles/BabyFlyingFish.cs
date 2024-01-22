using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;
using Terraria.Audio;

namespace PepperoniBattleRoyale.Content.Projectiles
{
    public class BabyFlyingFish : ModProjectile
    {
        public override void SetDefaults()
        {
            Projectile.netImportant = true;
            Projectile.aiStyle = 0;
            Projectile.width = 20;
            Projectile.height = 16;
            Projectile.friendly = true;
            Projectile.DamageType = DamageClass.Ranged;
            Projectile.alpha = 255;
        }
        public override void SetStaticDefaults()
        {
            Main.projFrames[Type] = 4;
        }
        public override void AI()
        {
            if (Projectile.ai[0] <= 50f)
            {
                // Fade in
                Projectile.alpha -= 10;
                // Cap alpha before timer reaches 50 ticks
                if (Projectile.alpha < 0)
                    Projectile.alpha = 0;
            }
            if (Projectile.timeLeft <= 3570)
                Projectile.alpha = 0;

            Dust dust = Dust.NewDustDirect(Projectile.position, Projectile.height, Projectile.width, DustID.Water, 0, -1);

            if (++Projectile.frameCounter >= 5)
            {
                Projectile.frameCounter = 0;
                // Or more compactly Projectile.frame = ++Projectile.frame % Main.projFrames[Projectile.type];
                if (++Projectile.frame >= Main.projFrames[Projectile.type])
                    Projectile.frame = 0;
            }
            Projectile.direction = Projectile.spriteDirection = (Projectile.velocity.X > 0f) ? 1 : -1;
            Projectile.rotation = Projectile.velocity.ToRotation();
            if (Projectile.spriteDirection == -1)
            {
                Projectile.rotation += MathHelper.Pi;
                // For vertical sprites use MathHelper.PiOver2
            }
        }
        public override void OnKill(int timeLeft)
        {
            Collision.HitTiles(Projectile.position, Projectile.velocity, Projectile.width, Projectile.height);
            SoundEngine.PlaySound(SoundID.NPCHit25, Projectile.position);
        }
    }
}
