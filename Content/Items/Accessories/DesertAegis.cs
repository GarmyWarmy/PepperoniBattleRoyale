using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Localization;

namespace PepperoniBattleRoyale.Content.Items.Accessories
{
    public class DesertAegis : ModItem
    {
        public static readonly int AdditiveDamageReduction = 10;
        public override LocalizedText Tooltip => base.Tooltip.WithFormatArgs(AdditiveDamageReduction);
        public override void SetDefaults()
        {
            Item.width = 26;
            Item.height = 26;
            Item.rare = ItemRarityID.Blue;
            Item.accessory = true;

            Item.defense = 4;
        }
        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            player.endurance += AdditiveDamageReduction / 100;
        }
        public override void AddRecipes()
        {
            CreateRecipe()
                .AddIngredient(ItemID.FossilOre, 18)
                .AddIngredient(ItemID.AntlionMandible, 8)
                .AddIngredient(ItemID.Amber, 5)
                .AddTile(TileID.Anvils)
                .Register();
        }
    }
}
