using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace PepperoniBattleRoyale.Content.Buffs
{
    public class Pregame : ModBuff
    {
        public override void SetStaticDefaults()
        {
            Main.debuff[Type] = true;
            BuffID.Sets.NurseCannotRemoveDebuff[Type] = true;
            BuffID.Sets.TimeLeftDoesNotDecrease[Type] = true;
            Main.buffNoSave[Type] = true;
            Main.persistentBuff[Type] = true;
        }
        public override void Update(Player player, ref int buffIndex)
        {
            player.statLife = player.statLifeMax2;
            player.statDefense += 999;
        }
    }
}
