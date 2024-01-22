using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using PepperoniBattleRoyale.Content.Buffs;

namespace PepperoniBattleRoyale.Content.Items.Misc
{
    public class Blegh : ModItem
    {
        public override void SetDefaults()
        {
            Item.width = 52;
            Item.height = 10;

            Item.consumable = true;
            Item.maxStack = 9999;
            Item.useStyle = ItemUseStyleID.HoldUp;
            Item.useTime = 2;
            Item.useAnimation = 2;
            Item.reuseDelay = 32;
            Item.rare = ItemRarityID.Expert;
        }
        public override void HoldItem(Player player)
        {
            for (int i = 0; i < Main.maxPlayers; i++)
            {
                if (!Main.player[i].dead && Main.player[i].active && !Main.player[i].HasBuff<Headstart>())
                {
                    Main.player[i].AddBuff(ModContent.BuffType<Headstart>(), 36000);
                }
            }
        }
    }
}
