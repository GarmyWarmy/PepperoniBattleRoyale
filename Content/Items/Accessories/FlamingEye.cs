using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace PepperoniBattleRoyale.Content.Items.Accessories
{
    public class FlamingEye : ModItem
    {
        public override void SetDefaults()
        {
            Item.width = 30;
            Item.height = 40;
            Item.accessory = true;
        }
        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            player.GetDamage(DamageClass.Generic) *= 1.15f;
            if (player.statDefense > 0)
                player.statDefense -= 15 / player.statDefense;
        }
        public override void AddRecipes()
        {
            CreateRecipe()
                .AddIngredient(ItemID.SuspiciousLookingEye, 1)
                .AddIngredient(ItemID.HellstoneBar, 8)
                .AddTile(TileID.Anvils)
                .Register();
        }
    }
}
