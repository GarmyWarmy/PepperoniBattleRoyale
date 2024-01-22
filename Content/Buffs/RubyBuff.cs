using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace PepperoniBattleRoyale.Content.Buffs
{
    public class RubyBuff : ModBuff
    {
        public override void Update(Player player, ref int buffIndex)
        {
            player.lifeRegen += 3;
        }
    }
}
