using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using PepperoniBattleRoyale.Content.Buffs;
using Microsoft.Xna.Framework;

namespace PepperoniBattleRoyale.Common.GlobalNPCs
{
    public class RottingDebuffGlobalNPC : GlobalNPC
    {
        public override bool InstancePerEntity => true;
        public bool rottingDebuff;

        public override void ResetEffects(NPC npc)
        {
            rottingDebuff = false;
        }
        public override void ModifyIncomingHit(NPC npc, ref NPC.HitModifiers modifiers)
        {
            if (rottingDebuff)
            {
                modifiers.Defense -= 4;
            }
        }
        public override void DrawEffects(NPC npc, ref Color drawColor)
        {
            if (rottingDebuff)
            {
                drawColor.R = 150;
                drawColor.G = 150;
                drawColor.B = 150;
            }
        }
    }
}
