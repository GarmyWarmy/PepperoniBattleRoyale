using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using PepperoniBattleRoyale.Content.Projectiles;
using static PepperoniBattleRoyale.Content.VanillaRecipes;
using Terraria.DataStructures;

namespace PepperoniBattleRoyale.Content.Items.Weapons
{
    public class Spiderpeater : ModItem
    {
        public override void SetDefaults()
        {
            Item.width = 60;
            Item.height = 30;

            Item.DamageType = DamageClass.Ranged;
            Item.damage = 36;
            Item.noMelee = true;
            Item.autoReuse = true;
            Item.rare = ItemRarityID.Blue;
            Item.shootSpeed = 9f;
            Item.useTime = 25;
            Item.reuseDelay = 25;
            Item.useAnimation = 25;
            Item.knockBack = 6f;
            Item.useAmmo = AmmoID.Arrow;
            Item.useStyle = ItemUseStyleID.Shoot;
            Item.UseSound = SoundID.Item5;
            Item.shoot = ProjectileID.PurificationPowder;
        }
        public override void ModifyShootStats(Player player, ref Vector2 position, ref Vector2 velocity, ref int type, ref int damage, ref float knockback)
        {
            if (type == ProjectileID.WoodenArrowFriendly)
                type = ModContent.ProjectileType<PoisonArrow>();
        }
        public override bool CanUseItem(Player player)
        {
            if (player.altFunctionUse == 2)
            {
                Item.useAmmo = 0;
                Item.reuseDelay = 40;
                Item.shoot = ModContent.ProjectileType<WebSpitFriendly>();
            }
            else
            {
                Item.useAmmo = AmmoID.Arrow;
                Item.reuseDelay = 25;
                Item.shoot = ProjectileID.PurificationPowder;
            }
            return true;
        }
        public override bool AltFunctionUse(Player player)
        {
            return true;
        }
        public override void AddRecipes()
        {
            CreateRecipe()
                .AddIngredient(ItemID.WebSlinger, 1)
                .AddRecipeGroup(GoldBar, 12)
                .AddTile(TileID.Anvils)
                .Register();
        }
    }
}
