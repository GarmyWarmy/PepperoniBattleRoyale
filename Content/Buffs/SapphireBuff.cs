using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace PepperoniBattleRoyale.Content.Buffs
{
    public class SapphireBuff : ModBuff
    {
        public override void Update(Player player, ref int buffIndex)
        {
            player.GetDamage(DamageClass.Magic) *= 1.20f;
            player.manaRegen += player.statManaMax2 / 10;
        }
    }
}
