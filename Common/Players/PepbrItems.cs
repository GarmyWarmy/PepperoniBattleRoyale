using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;
using PepperoniBattleRoyale.Content.Items.Weapons;

namespace PepperoniBattleRoyale.Common.Players
{
    public class PepbrItems : ModPlayer
    {
        public override void CatchFish(FishingAttempt attempt, ref int itemDrop, ref int npcSpawn, ref AdvancedPopupRequest sonar, ref Vector2 sonarPosition)
        {
            bool inWater = !attempt.inLava && !attempt.inHoney;
            bool inOcean = Player.ZoneBeach;
            if (inWater && inOcean)
            {
                if (attempt.veryrare && Main.rand.NextBool())
                {
                    itemDrop = ModContent.ItemType<FishBlaster>();
                    return;
                }
            }
        }
    }
}
