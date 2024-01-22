using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace PepperoniBattleRoyale.Content.Buffs
{
    public class Grace : ModBuff
    {
        public override void SetStaticDefaults()
        {
            Main.debuff[Type] = true;
            BuffID.Sets.NurseCannotRemoveDebuff[Type] = true;
            Main.buffNoSave[Type] = true;
            Main.persistentBuff[Type] = true;
        }
        public override void Update(Player player, ref int buffIndex)
        {
            player.lifeRegen += 1;
        }
    }
}
