using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace PepperoniBattleRoyale.Content.Items.Ammo
{
    public class HellfireRound : ModItem
    {
        public override void SetDefaults()
        {
            Item.width = 8;
            Item.height = 16;
            Item.damage = 11;
            Item.DamageType = DamageClass.Ranged;
            Item.consumable = true;
            Item.shootSpeed = 3f;
            Item.knockBack = 1f;
            Item.rare = ItemRarityID.Green;
            Item.ammo = AmmoID.Bullet;
            Item.maxStack = 9999;
            Item.shoot = ModContent.ProjectileType<Projectiles.HellfireRound>();
        }
        public override void AddRecipes()
        {
            CreateRecipe(100)
                .AddIngredient(ItemID.HellstoneBar, 1)
                .AddIngredient(ItemID.MusketBall, 100)
                .AddTile(TileID.Anvils)
                .Register();
        }
    }
}
