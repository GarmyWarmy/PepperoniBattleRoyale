using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace PepperoniBattleRoyale.Common.Players
{
    public class RottingDebuffPlayer : ModPlayer
    {
        public bool rottingDebuff;
        public override void ResetEffects()
        {
            rottingDebuff = false;
        }
    }
}
