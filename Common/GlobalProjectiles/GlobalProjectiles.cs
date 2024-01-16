using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using PepperoniBattleRoyale.Content.Buffs;

namespace PepperoniBattleRoyale.Common.GlobalProjectiles
{
    public class GlobalProjectiles : GlobalProjectile
    {
        public override void ModifyHitNPC(Projectile projectile, NPC target, ref NPC.HitModifiers modifiers)
        {
            Player player = Main.player[projectile.owner];

            if (projectile.type == ProjectileID.BallOHurt)
                target.AddBuff(ModContent.BuffType<Rotting>(), 180);

            if (projectile.type == ProjectileID.TheMeatball)
                target.AddBuff(ModContent.BuffType<Haemorrhaging>(), 180);

            if (projectile.type == ProjectileID.UnholyArrow && !WorldGen.crimson)
                target.AddBuff(ModContent.BuffType<Rotting>(), 180);
            else if (projectile.type == ProjectileID.UnholyArrow && WorldGen.crimson)
                target.AddBuff(ModContent.BuffType<Haemorrhaging>(), 180);

            if (projectile.type == ProjectileID.CorruptYoyo)
                target.AddBuff(ModContent.BuffType<Rotting>(), 180);

            if (projectile.type == ProjectileID.CrimsonYoyo)
                target.AddBuff(ModContent.BuffType<Haemorrhaging>(), 180);

            if (projectile.type == ProjectileID.SapphireBolt)
                player.AddBuff(ModContent.BuffType<SapphireBuff>(), 300);

            if (projectile.type == ProjectileID.EmeraldBolt)
                player.AddBuff(ModContent.BuffType<EmeraldBuff>(), 300);

            if (projectile.type == ProjectileID.RubyBolt)
                player.AddBuff(ModContent.BuffType<RubyBuff>(), 300);

            if (projectile.type == ProjectileID.DiamondBolt)
                player.AddBuff(ModContent.BuffType<DiamondBuff>(), 300);

            if (projectile.type == ProjectileID.AmberBolt)
                player.AddBuff(ModContent.BuffType<AmberBuff>(), 300);

            if (projectile.type == ProjectileID.Dynamite || projectile.type == ProjectileID.StickyDynamite || projectile.type == ProjectileID.BouncyDynamite)
                projectile.damage = 80;

            if (projectile.type == ProjectileID.Bomb || projectile.type == ProjectileID.StickyBomb || projectile.type == ProjectileID.BouncyBomb)
                projectile.damage = 50;
        }
        public override void ModifyHitPlayer(Projectile projectile, Player target, ref Player.HurtModifiers modifiers)
        {
            Player player = Main.player[projectile.owner];

            if (projectile.type == ProjectileID.BallOHurt)
                target.AddBuff(ModContent.BuffType<Rotting>(), 180);

            if (projectile.type == ProjectileID.TheMeatball)
                target.AddBuff(ModContent.BuffType<Haemorrhaging>(), 180);

            if (projectile.type == ProjectileID.UnholyArrow && !WorldGen.crimson)
                target.AddBuff(ModContent.BuffType<Rotting>(), 180);
            else if (projectile.type == ProjectileID.UnholyArrow && WorldGen.crimson)
                target.AddBuff(ModContent.BuffType<Haemorrhaging>(), 180);

            if (projectile.type == ProjectileID.CrimsonYoyo)
                target.AddBuff(ModContent.BuffType<Haemorrhaging>(), 180);

            if (projectile.type == ProjectileID.SapphireBolt)
                player.AddBuff(ModContent.BuffType<SapphireBuff>(), 300);

            if (projectile.type == ProjectileID.EmeraldBolt)
                player.AddBuff(ModContent.BuffType<EmeraldBuff>(), 300);

            if (projectile.type == ProjectileID.RubyBolt)
                player.AddBuff(ModContent.BuffType<RubyBuff>(), 300);

            if (projectile.type == ProjectileID.DiamondBolt)
                player.AddBuff(ModContent.BuffType<DiamondBuff>(), 300);

            if (projectile.type == ProjectileID.AmberBolt)
                player.AddBuff(ModContent.BuffType<AmberBuff>(), 300);

            if (projectile.type == ProjectileID.IceBolt)
                target.AddBuff(BuffID.Frostburn, 600);

            if (projectile.type == ProjectileID.Dynamite || projectile.type == ProjectileID.StickyDynamite || projectile.type == ProjectileID.BouncyDynamite)
                projectile.damage = 80;

            if (projectile.type == ProjectileID.Bomb || projectile.type == ProjectileID.StickyBomb || projectile.type == ProjectileID.BouncyBomb)
                projectile.damage = 50;

        }
        public override void PostAI(Projectile projectile)
        {
            if (projectile.type == ProjectileID.IceBolt)
            {
                projectile.velocity *= 1.10f;
            }
        }
    }
}
