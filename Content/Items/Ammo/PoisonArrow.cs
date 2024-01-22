using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using PepperoniBattleRoyale.Content.Projectiles;

namespace PepperoniBattleRoyale.Content.Items.Ammo
{
    public class PoisonArrow : ModItem
    {
        public override void SetDefaults()
        {
            Item.width = 14;
            Item.height = 38;
            Item.damage = 7;
            Item.DamageType = DamageClass.Ranged;
            Item.consumable = true;
            Item.shootSpeed = 3.5f;
            Item.knockBack = 2f;
            Item.rare = ItemRarityID.White;
            Item.shoot = ModContent.ProjectileType<Projectiles.PoisonArrow>();
            Item.ammo = AmmoID.Arrow;
            Item.maxStack = 9999;
        }
        public override void AddRecipes()
        {
            CreateRecipe(100)
                .AddIngredient(ItemID.Stinger, 1)
                .AddIngredient(ItemID.WoodenArrow, 100)
                .AddTile(TileID.WorkBenches)
                .Register();
        }
    }
}
