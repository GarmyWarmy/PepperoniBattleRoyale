using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using PepperoniBattleRoyale.Content.Buffs;

namespace PepperoniBattleRoyale.Common.GlobalNPCs
{
    public class GlobalVanillaNPCs : GlobalNPC
    {
        public override void SetDefaults(NPC npc)
        {
            switch (npc.type)
            {
                case NPCID.GoblinArcher:
                case NPCID.GoblinPeon:
                case NPCID.GoblinWarrior:
                case NPCID.GoblinThief:
                case NPCID.GoblinSorcerer:
                    npc.damage -= 10;
                    npc.defense -= 2;
                    break;
                case NPCID.ChaosBall:
                    npc.damage /= 2;
                    break;

                case NPCID.DevourerHead:
                case NPCID.DevourerBody:
                case NPCID.DevourerTail:
                    npc.damage -= 10;
                    npc.defense -= 2;
                    break;

                case NPCID.SkeletronHead:
                    npc.lifeMax = 8500;
                    npc.damage = 68;
                    break;
                case NPCID.SkeletronHand:
                    npc.damage = 48;
                    npc.immortal = true;
                    break;

                case NPCID.QueenBee:
                    npc.lifeMax = 6500;
                    npc.defense = 14;
                    npc.damage = 55;
                    break;

                case NPCID.WallofFlesh:
                    npc.lifeMax = 14000;
                    npc.defense = 8;
                    break;
                case NPCID.WallofFleshEye:
                    npc.defense = 16;
                    break;
                case NPCID.TheHungry:
                    npc.defense = 3;
                    break;

                case NPCID.EaterofWorldsHead:
                    npc.damage = 50;
                    npc.lifeMax = 220;
                    npc.buffImmune[BuffID.OnFire] = true;
                    npc.buffImmune[BuffID.Poisoned] = true;
                    npc.buffImmune[BuffID.Frostburn] = true;
                    npc.buffImmune[ModContent.BuffType<Rotting>()] = true;
                    break;

                case NPCID.EaterofWorldsBody:
                    npc.damage = 40;
                    npc.lifeMax = 220;
                    npc.buffImmune[BuffID.OnFire] = true;
                    npc.buffImmune[BuffID.Poisoned] = true;
                    npc.buffImmune[BuffID.Frostburn] = true;
                    npc.buffImmune[ModContent.BuffType<Rotting>()] = true;
                    break;

                case NPCID.EaterofWorldsTail:
                    npc.damage = 30;
                    npc.lifeMax = 220;
                    npc.buffImmune[BuffID.OnFire] = true;
                    npc.buffImmune[BuffID.Poisoned] = true;
                    npc.buffImmune[BuffID.Frostburn] = true;
                    npc.buffImmune[ModContent.BuffType<Rotting>()] = true;
                    break;

                case NPCID.BrainofCthulhu:
                    npc.damage = 40;
                    npc.lifeMax = 2000;
                    break;
                case NPCID.Creeper:
                    npc.damage = 37;
                    npc.lifeMax = 230;
                    npc.defense = 16;
                    npc.buffImmune[BuffID.OnFire] = true;
                    npc.buffImmune[BuffID.Poisoned] = true;
                    npc.buffImmune[BuffID.Frostburn] = true;
                    npc.buffImmune[ModContent.BuffType<Rotting>()] = true;
                    break;



            }
        }
    }
}
