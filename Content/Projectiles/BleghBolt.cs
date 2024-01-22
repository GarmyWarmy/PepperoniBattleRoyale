using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Audio;
using Microsoft.Xna.Framework;
using System;

namespace PepperoniBattleRoyale.Content.Projectiles
{
    public class BleghBolt : ModProjectile
    {
        public override void SetDefaults()
        {
            Projectile.height = 16;
            Projectile.width = 16;
            Projectile.friendly = true;
            Projectile.DamageType = DamageClass.Magic;
            Projectile.penetrate = 2;
            Projectile.light = 0.5f;
            Projectile.alpha = 255;
            Projectile.timeLeft = 120;

            Projectile.aiStyle = 1;
            AIType = ProjectileID.DiamondBolt;
        }
        public override void AI()
        {
            Projectile.aiStyle = 0;

            for (int i = 0; i < 2; i++)
            {
                Dust dust = Dust.NewDustDirect(Projectile.position, Projectile.width / 2, Projectile.height / 2, DustID.Frost, Projectile.velocity.X, Projectile.velocity.Y);
                dust.noGravity = true;
                dust.velocity *= 0.3f;
            }
        }
        public override bool OnTileCollide(Vector2 oldVelocity)
        {
            Projectile.penetrate--;
            if (Projectile.penetrate <= 0)
                Projectile.Kill();
            else
            {
                Collision.HitTiles(Projectile.position, Projectile.velocity, Projectile.width, Projectile.height);
                SoundEngine.PlaySound(SoundID.Dig, Projectile.position);

                if (Math.Abs(Projectile.velocity.X - oldVelocity.X) > float.Epsilon)
                    Projectile.velocity.X = -oldVelocity.X;

                if (Math.Abs(Projectile.velocity.Y - oldVelocity.Y) > float.Epsilon)
                    Projectile.velocity.Y = -oldVelocity.Y;
            }
            return false;
        }
        public override void OnKill(int timeLeft)
        {
            Collision.HitTiles(Projectile.position + Projectile.velocity, Projectile.velocity, Projectile.width, Projectile.height);
            SoundEngine.PlaySound(SoundID.Dig, Projectile.position);
            for (int i = 0; i < 10; i++)
            {
                Dust dust = Dust.NewDustDirect(Projectile.position, Projectile.width / 100, Projectile.height / 100, DustID.Frost, 0, 0);
                dust.noGravity = true;
            }
        }
        public override void OnHitNPC(NPC target, NPC.HitInfo hit, int damageDone)
        {
            if (Main.rand.NextBool(3))
                target.AddBuff(BuffID.Chilled, 3);
        }
        public override void OnHitPlayer(Player target, Player.HurtInfo info)
        {
            if (Main.rand.NextBool(3))
                target.AddBuff(BuffID.Chilled, 3);
        }
    }
}
