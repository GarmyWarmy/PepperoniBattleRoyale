using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using PepperoniBattleRoyale.Common.GlobalNPCs;
using PepperoniBattleRoyale.Common.Players;

namespace PepperoniBattleRoyale.Content.Buffs
{
    public class Haemorrhaging : ModBuff
    {
        public override void SetStaticDefaults()
        {
            Main.debuff[Type] = true;
            Main.pvpBuff[Type] = true;
        }
        public override void Update(NPC npc, ref int buffIndex)
        {
            npc.GetGlobalNPC<HaemorrhagingDebuffGlobalNPC>().haemorrhagingDebuff = true;
        }
        public override void Update(Player player, ref int buffIndex)
        {
            player.GetModPlayer<HaemorrhagingDebuffPlayer>().haemorrhagingDebuff = true; ;
        }
    }
}
