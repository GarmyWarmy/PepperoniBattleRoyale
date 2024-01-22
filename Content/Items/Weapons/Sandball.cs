using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using PepperoniBattleRoyale.Content.Projectiles;

namespace PepperoniBattleRoyale.Content.Items.Weapons
{
    public class Sandball : ModItem
    {
        public override void SetStaticDefaults()
        {
            ItemID.Sets.ToolTipDamageMultiplier[Type] = 2f;
        }
        public override void SetDefaults()
        {
            Item.useStyle = ItemUseStyleID.Shoot;
            Item.useAnimation = 45;
            Item.useTime = 45;
            Item.knockBack = 5.5f;
            Item.width = 32;
            Item.height = 32;
            Item.damage = 14;
            Item.knockBack = 6f;
            Item.noUseGraphic = true;
            Item.shoot = ModContent.ProjectileType<SandballProjectile>();
            Item.shootSpeed = 12f;
            Item.UseSound = SoundID.Item1;
            Item.rare = ItemRarityID.Blue;
            Item.value = Item.sellPrice(gold: 2);
            Item.DamageType = DamageClass.MeleeNoSpeed;
            Item.channel = true;
            Item.noMelee = true;
        }
        public override void AddRecipes()
        {
            CreateRecipe()
                .AddIngredient(ItemID.SandBlock, 40)
                .AddIngredient(ItemID.FossilOre, 15)
                .AddIngredient(ItemID.AntlionMandible, 6)
                .AddTile(TileID.Anvils)
                .Register();
        }
    }
}
