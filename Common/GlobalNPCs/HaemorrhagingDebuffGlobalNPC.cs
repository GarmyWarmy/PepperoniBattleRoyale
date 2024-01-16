using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace PepperoniBattleRoyale.Common.GlobalNPCs
{
    public class HaemorrhagingDebuffGlobalNPC : GlobalNPC
    {
        public override bool InstancePerEntity => true;
        public bool haemorrhagingDebuff;
        public override void ResetEffects(NPC npc)
        {
            haemorrhagingDebuff = false;
        }
        public override void UpdateLifeRegen(NPC npc, ref int damage)
        {
            if (haemorrhagingDebuff)
                npc.lifeRegen -= 10;
        }
        public override void DrawEffects(NPC npc, ref Color drawColor)
        {
            if (haemorrhagingDebuff)
                drawColor.R = 155;
        }
    }
}
