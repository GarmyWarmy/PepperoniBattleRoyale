using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace PepperoniBattleRoyale.Common.Players
{
    public class GameStatePlayerBuffs : ModPlayer
    {
        public bool pregameBuff;
        public override void ResetEffects()
        {
            pregameBuff = false;
        }
    }
}
