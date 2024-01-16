using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace PepperoniBattleRoyale.Common.Players
{
    public class HaemorrhagingDebuffPlayer : ModPlayer
    {
        public bool haemorrhagingDebuff;
        public override void ResetEffects()
        {
            haemorrhagingDebuff = false;
        }
        public override void UpdateBadLifeRegen()
        {
            if (haemorrhagingDebuff)
            {
                if (Player.lifeRegen > 0)
                    Player.lifeRegen = 0;

                Player.lifeRegenTime = 0;
                Player.lifeRegen -= 5;
            }
        }
    }
}
