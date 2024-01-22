using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;
using Terraria.GameContent;

namespace PepperoniBattleRoyale.Content.Buffs
{
    public class Shelled : ModBuff
    {
        public override void Update(Player player, ref int buffIndex)
        {
            player.lifeRegen += 4;
            player.statDefense += 10;
            player.moveSpeed *= 0.25f;
            player.releaseMount = true;
            player.jump = (int)(player.jump * 0.1f);
            player.jumpSpeedBoost *= 0.5f;
            player.noItems = true;
        }
    }
}
