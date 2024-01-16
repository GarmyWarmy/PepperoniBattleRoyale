using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace PepperoniBattleRoyale.Common.GlobalItems
{
    public class GlobalFamiliarVanity : GlobalItem
    {
        public override bool AppliesToEntity(Item item, bool lateInstantiation)
        {
            if (item.type == ItemID.FamiliarWig || item.type == ItemID.FamiliarShirt || item.type == ItemID.FamiliarPants)
                return true;
            return false;
        }
        public override void SetDefaults(Item item)
        {
            item.value = 0;
        }
    }
}
