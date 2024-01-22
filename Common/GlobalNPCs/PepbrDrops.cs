using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using PepperoniBattleRoyale.Content.Items.Accessories;
using Terraria.GameContent.ItemDropRules;

namespace PepperoniBattleRoyale.Common.GlobalNPCs
{
    public class PepbrDrops : GlobalNPC
    {
        public override void ModifyNPCLoot(NPC npc, NPCLoot npcLoot)
        {
            if (npc.type == NPCID.CochinealBeetle)
            {
                npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<CochinealShell>(), 3));
            }
        }
    }
}
