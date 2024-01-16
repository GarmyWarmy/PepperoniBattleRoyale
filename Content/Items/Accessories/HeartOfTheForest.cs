using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Localization;

namespace PepperoniBattleRoyale.Content.Items.Accessories
{
    public class HeartOfTheForest : ModItem
    {
        public static readonly int AdditiveHealthBonus = 20;
        public static readonly int AdditiveRegenerationBonus = 2;
        public override LocalizedText Tooltip => base.Tooltip.WithFormatArgs(AdditiveHealthBonus, AdditiveRegenerationBonus);
        public override void SetDefaults()
        {
            Item.width = 30;
            Item.height = 28;
            Item.accessory = true;
            Item.rare = ItemRarityID.Green;
        }
        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            player.statLifeMax2 += AdditiveHealthBonus;
            player.lifeRegen += AdditiveRegenerationBonus;
        }
        public override void AddRecipes()
        {
            CreateRecipe()
                .AddIngredient(ItemID.LifeCrystal, 1)
                .AddIngredient(ItemID.Squirrel, 1)
                .AddRecipeGroup(RecipeGroupID.Wood, 50)
                .AddTile(TileID.WorkBenches)
                .Register();
        }
    }
}
