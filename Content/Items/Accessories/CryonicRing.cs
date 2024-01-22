using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Localization;

namespace PepperoniBattleRoyale.Content.Items.Accessories
{
    public class CryonicRing : ModItem
    {
        public static readonly int AdditiveAttackSpeedBonus = 25;
        public override LocalizedText Tooltip => base.Tooltip.WithFormatArgs(AdditiveAttackSpeedBonus);
        public override void SetDefaults()
        {
            Item.width = 28;
            Item.height = 20;
            Item.accessory = true;
            Item.rare = ItemRarityID.Blue;
        }
        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            player.GetAttackSpeed(DamageClass.Generic) += AdditiveAttackSpeedBonus / 100f;
        }
        public override void AddRecipes()
        {
            CreateRecipe()
                .AddIngredient(ItemID.Diamond, 5)
                .AddIngredient(ItemID.IceBlock, 80)
                .AddTile(TileID.IceMachine)
                .Register();
        }
    }
}
