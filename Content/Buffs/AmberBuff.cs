using Terraria;
using Terraria.ModLoader;

namespace PepperoniBattleRoyale.Content.Buffs
{
    public class AmberBuff : ModBuff
    {
        public override void Update(Player player, ref int buffIndex)
        {
            player.statDefense += 5;
            player.endurance += 0.10f;
        }
    }
}
