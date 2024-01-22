using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using PepperoniBattleRoyale.Content.Buffs;

namespace PepperoniBattleRoyale.Common.GlobalItems
{
    public class GlobalVanillaItems : GlobalItem
    {
        public override bool AppliesToEntity(Item item, bool lateInstantiation)
        {
            return true;
        }
        public override void SetDefaults(Item item)
        {
            if (item.type == ItemID.StylistKilLaKillScissorsIWish)
                item.damage = 20;

            if (item.type == ItemID.AntlionClaw)
                item.damage = 19;

            if (item.type == ItemID.Gladius)
                item.damage = 22;

            if (item.type == ItemID.BoneSword)
                item.damage = 24;

            if (item.type == ItemID.BatBat)
                item.damage = 24;

            if (item.type == ItemID.Katana)
            {
                item.damage = 20;
                item.useTime = 25;
                item.useAnimation = 25;
            }

            if (item.type == ItemID.IceBlade)
                item.damage = 20;

            if (item.type == ItemID.Muramasa)
                item.damage = 28;

            if (item.type == ItemID.DyeTradersScimitar)
                item.damage = 28;

            if (item.type == ItemID.PurplePhaseblade || item.type == ItemID.YellowPhaseblade)
                item.damage = 25;

            if (item.type == ItemID.OrangePhaseblade)
                item.damage = 27;

            if (item.type == ItemID.WhitePhaseblade)
                item.damage = 27;

            if (item.type == ItemID.BloodButcherer)
                item.damage = 26;

            if (item.type == ItemID.Starfury)
                item.damage = 19;

            if (item.type == ItemID.EnchantedSword)
            {
                item.damage = 20;
                item.useTime = 18;
                item.useAnimation = 18;
            }

            if (item.type == ItemID.BeeKeeper)
            {
                item.damage = 25;
                item.Size = new(20, 20);
            }

            if (item.type == ItemID.FalconBlade)
                item.damage = 23;

            if (item.type == ItemID.FieryGreatsword)
                item.damage = 34;

            if (item.type == ItemID.NightsEdge)
                item.damage = 37;

            if (item.type == ItemID.Rally)
                item.damage = 18;

            if (item.type == ItemID.CorruptYoyo)
                item.damage = 24;

            if (item.type == ItemID.CrimsonYoyo)
                item.damage = 24;

            if (item.type == ItemID.JungleYoyo)
                item.damage = 22;

            if (item.type == ItemID.Code1)
                item.damage = 23;

            if (item.type == ItemID.Valor)
                item.damage = 29;

            if (item.type == ItemID.Cascade)
                item.damage = 31;

            if (item.type == ItemID.ThunderSpear)
                item.damage = 26;

            if (item.type == ItemID.Swordfish)
                item.damage = 26;

            if (item.type == ItemID.DarkLance)
                item.damage = 38;

            if (item.type == ItemID.EnchantedBoomerang)
                item.damage = 21;

            if (item.type == ItemID.IceBoomerang)
            {
                item.damage = 23;
                item.shootSpeed = 12f;
            }

            if (item.type == ItemID.Shroomerang)
                item.damage = 29;

            if (item.type == ItemID.CombatWrench)
                item.damage = 27;

            if (item.type == ItemID.FlamingMace)
                item.damage = 22;

            if (item.type == ItemID.Sunfury)
                item.damage = 66;

            if (item.type == ItemID.BloodRainBow)
                item.damage = 21;

            if (item.type == ItemID.QuadBarrelShotgun)
                item.damage = 17;

            if (item.type == ItemID.Handgun)
                item.damage = 17;

            if (item.type == ItemID.PhoenixBlaster)
                item.damage = 26;

            if (item.type == ItemID.FrostDaggerfish)
                item.damage = 21;

            if (item.type == ItemID.Harpoon)
                item.damage = 34;

            if (item.type == ItemID.StarCannon)
                item.damage = 56;

            if (item.type == ItemID.PoisonedKnife)
                item.damage = 17;

            if (item.type == ItemID.BoneJavelin)
                item.damage = 28;

            if (item.type == ItemID.BoneDagger)
                item.damage = 21;

            if (item.type == ItemID.ThunderStaff)
                item.damage = 24;

            if (item.type == ItemID.AmethystStaff)
            {
                item.damage = 16;
                item.useTime = 25;
                item.useAnimation = 25;
            }

            if (item.type == ItemID.TopazStaff)
            {
                item.damage = 24;
                item.useTime = 33;
                item.useAnimation = 33;
            }

            if (item.type == ItemID.SapphireStaff)
            {
                item.damage = 20;
                item.useTime = 10;
                item.useAnimation = 10;
            }

            if (item.type == ItemID.EmeraldStaff)
            {
                item.damage = 28;
                item.useTime = 10;
                item.useAnimation = 10;
            }

            if (item.type == ItemID.RubyStaff)
            {
                item.damage = 27;
                item.useTime = 25;
                item.useAnimation = 25;
            }

            if (item.type == ItemID.DiamondStaff)
            {
                item.damage = 30;
                item.useTime = 25;
                item.useAnimation = 25;
            }

            if (item.type == ItemID.AmberStaff)
            {
                item.damage = 26;
                item.useTime = 20;
                item.useAnimation = 20;
            }

            if (item.type == ItemID.Vilethorn)
                item.damage = 16;

            if (item.type == ItemID.WeatherPain)
                item.damage = 42;

            if (item.type == ItemID.MagicMissile)
            {
                item.damage = 8;
                item.mana = 35;
                item.useTime = 56;
                item.useAnimation = 56;
            }

            if (item.type == ItemID.AquaScepter)
                item.damage = 23;

            if (item.type == ItemID.FlowerofFire)
                item.damage = 50;

            if (item.type == ItemID.Flamelash)
            {
                item.damage = 14;
                item.mana = 50;
                item.useTime = 60;
                item.useAnimation = 60;
            }

            if (item.type == ItemID.SpaceGun)
                item.damage = 22;

            if (item.type == ItemID.BeeGun)
                item.damage = 12;

            if (item.type == ItemID.BookofSkulls)
            {
                item.damage = 42;
                item.mana = 40;
            }

            if (item.type == ItemID.DemonScythe)
            {
                item.damage = 39;
                item.mana = 10;
            }

            if (item.type == ItemID.ThornWhip)
                item.damage = 22;

            if (item.type == ItemID.BoneWhip)
                item.damage = 29;

            if (item.type == ItemID.FossilPickaxe)
            {
                item.useTime = 20;
                item.useAnimation = 20;
            }

            if (item.type == ItemID.WoodFishingPole)
                item.fishingPole = 10;

            if (item.type == ItemID.ReinforcedFishingPole)
                item.fishingPole = 20;

            if (item.type == ItemID.FiberglassFishingPole)
                item.fishingPole = 32;

            if (item.type == ItemID.GoldenFishingRod)
                item.fishingPole = 85;

            if (item.type == ItemID.ScarabFishingRod)
                item.fishingPole = 35;

            if (item.type == ItemID.Worm)
                item.bait = 27;

            if (item.type == ItemID.EnchantedNightcrawler)
                item.bait = 35;

            if (item.type == ItemID.ApprenticeBait)
                item.bait = 20;

            if (item.type == ItemID.BladeofGrass)
                item.damage = 28;

            if (item.type == ItemID.ToxicFlask)
            {
                item.damage = 23;
                item.mana = 20;
            }

            if (item.type == ItemID.MushroomSpear)
            {
                item.damage = 10;
            }
        }
        public override void OnHitNPC(Item item, Player player, NPC target, NPC.HitInfo hit, int damageDone)
        {
            if (item.type == ItemID.FalconBlade)
                target.AddBuff(BuffID.Weak, 540);

            if (item.type == ItemID.UnholyArrow)
                target.AddBuff(ModContent.BuffType<Rotting>(), 300);

            if (item.type == ItemID.TheMeatball)
                target.AddBuff(BuffID.BloodButcherer, 180);
        }
        public override void OnHitPvp(Item item, Player player, Player target, Player.HurtInfo hurtInfo)
        {
            if (item.type == ItemID.FalconBlade)
                target.AddBuff(BuffID.Weak, 540);

            if (item.type == ItemID.UnholyArrow)
                target.AddBuff(ModContent.BuffType<Rotting>(), 300);

            if (item.type == ItemID.TheMeatball)
                target.AddBuff(BuffID.BloodButcherer, 180);
        }
    }
}
