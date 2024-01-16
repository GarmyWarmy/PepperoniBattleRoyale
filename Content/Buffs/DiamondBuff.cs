using Terraria;
using Terraria.ModLoader;

namespace PepperoniBattleRoyale.Content.Buffs
{
    public class DiamondBuff : ModBuff
    {
        public override void Update(Player player, ref int buffIndex)
        {
            player.GetDamage(DamageClass.Generic) *= 1.10f;
            player.GetAttackSpeed(DamageClass.Generic) += 0.10f;
        }
    }
}
