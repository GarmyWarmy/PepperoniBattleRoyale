using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Localization;

namespace PepperoniBattleRoyale.Content.Items.Accessories
{
    public class FlorescentCape : ModItem
    {
        public static readonly int AdditiveMovementSpeed = 20;
        public override LocalizedText Tooltip => base.Tooltip.WithFormatArgs(AdditiveMovementSpeed);
        public override void SetDefaults()
        {
            Item.width = 26;
            Item.height = 26;
            Item.rare = ItemRarityID.Orange;
            Item.accessory = true;
        }
        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            player.frogLegJumpBoost = true;
            player.maxRunSpeed += AdditiveMovementSpeed / 100;
        }
        public override void AddRecipes()
        {
            CreateRecipe()
                .AddIngredient(ItemID.JungleSpores, 12)
                .AddIngredient(ItemID.Silk, 6)
                .AddIngredient(ItemID.Vine, 2)
                .AddTile(TileID.Loom)
                .Register();
        }
    }
}
