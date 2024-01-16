using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using PepperoniBattleRoyale.Common.GlobalNPCs;

namespace PepperoniBattleRoyale.Content.Buffs
{
    public class Rotting : ModBuff
    {
        public override void SetStaticDefaults()
        {
            Main.debuff[Type] = true;
            Main.pvpBuff[Type] = true;
        }
        public override void Update(NPC npc, ref int buffIndex)
        {
            npc.GetGlobalNPC<RottingDebuffGlobalNPC>().rottingDebuff = true;
        }
        public override void Update(Player player, ref int buffIndex)
        {
            player.statDefense -= 4;
            player.lifeRegen -= 1;
            player.moveSpeed *= 0.9f;
        }
    }
}
