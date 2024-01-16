using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace PepperoniBattleRoyale.Content.Buffs
{
    public class EmeraldBuff : ModBuff
    {
        public override void Update(Player player, ref int buffIndex)
        {
            player.moveSpeed *= 1.15f;
        }
    }
}
