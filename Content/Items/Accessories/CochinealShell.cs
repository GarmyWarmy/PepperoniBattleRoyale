using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.GameInput;
using Terraria.Audio;
using Terraria.Localization;

namespace PepperoniBattleRoyale.Content.Items.Accessories
{
    public class CochinealShell : ModItem
    {
        public const int Down = 0;
        public override LocalizedText Tooltip => base.Tooltip.WithFormatArgs(Down);
        private bool isShelled = false;
        public override void SetDefaults()
        {
            Item.width = 22;
            Item.height = 26;
            Item.accessory = true;
            Item.rare = ItemRarityID.Green;
            Item.defense = 4;
        }
        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            if (player.controlDown && player.releaseDown && player.doubleTapCardinalTimer[Down] < 15 && !player.mount.Active)
            {
                isShelled = !isShelled;
                SoundEngine.PlaySound(SoundID.Item70, player.position);
            }

                if (isShelled)
                    player.AddBuff(ModContent.BuffType<Buffs.Shelled>(), 2);
        }
    }
}
