using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;
using Terraria.DataStructures;

namespace PepperoniBattleRoyale.Content.Items.Weapons
{
    public class FrigidStaff : ModItem
    {
        public override void SetStaticDefaults()
        {
            Item.staff[Type] = true;
        }
        public override void SetDefaults()
        {
            Item.width = 40;
            Item.height = 40;

            Item.mana = 10;
            Item.damage = 31;
            Item.DamageType = DamageClass.Magic;
            Item.noMelee = true;
            Item.useStyle = ItemUseStyleID.Shoot;
            Item.autoReuse = true;
            Item.rare = ItemRarityID.Blue;
            Item.reuseDelay = 18;
            Item.useTime = 18;
            Item.useAnimation = 18;
            Item.shootSpeed = 9.5f;
            Item.knockBack = 5f;
            Item.UseSound = SoundID.Item28;

            Item.shoot = ModContent.ProjectileType<Projectiles.BleghBolt>();
        }
        public override bool Shoot(Player player, EntitySource_ItemUse_WithAmmo source, Vector2 position, Vector2 velocity, int type, int damage, float knockback)
        {
            float numberOfProjectiles = 3;
            float rotation = MathHelper.ToRadians(15);

            position += Vector2.Normalize(velocity) * 15f;

            for (int i = 0; i < numberOfProjectiles; i++)
            {
                Vector2 perturbedSpeed = velocity.RotatedBy(MathHelper.Lerp(-rotation, rotation, i / (numberOfProjectiles - 1)));
                Projectile.NewProjectile(source, position, perturbedSpeed, type, damage, knockback, player.whoAmI);
            }
            return false;
        }
        public override void AddRecipes()
        {
            CreateRecipe()
                .AddIngredient(ItemID.Diamond, 5)
                .AddIngredient(ItemID.FlinxFur, 4)
                .AddIngredient(ItemID.IceBlock, 80)
                .AddTile(TileID.Anvils)
                .Register();
        }
    }
}
