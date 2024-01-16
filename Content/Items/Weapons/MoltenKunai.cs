using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace PepperoniBattleRoyale.Content.Items.Weapons
{
    public class MoltenKunai : ModItem
    {
        public override void SetDefaults()
        {
            Item.width = 14;
            Item.height = 32;

            Item.consumable = true;
            Item.maxStack = 9999;
            Item.shootSpeed = 12f;
            Item.useTime = 12;
            Item.reuseDelay = 12;
            Item.useAnimation = 12;
            Item.useStyle = ItemUseStyleID.Swing;
            Item.UseSound = SoundID.Item1;
            Item.autoReuse = true;
            Item.noMelee = true;
            Item.noUseGraphic = true;
            Item.damage = 30;
            Item.knockBack = 3f;
            Item.crit = 4;

            Item.rare = ItemRarityID.Orange;

            Item.shoot = ModContent.ProjectileType<Projectiles.MoltenKunai>();
        }
        public override void OnHitNPC(Player player, NPC target, NPC.HitInfo hit, int damageDone)
        {
            if (Main.rand.NextBool(2))
                target.AddBuff(BuffID.OnFire, 600);
        }
        public override void OnHitPvp(Player player, Player target, Player.HurtInfo hurtInfo)
        {
            if (Main.rand.NextBool(2))
                target.AddBuff(BuffID.OnFire, 600);
        }
        public override void AddRecipes()
        {
            CreateRecipe(50)
                .AddIngredient(ItemID.HellstoneBar, 1)
                .AddTile(TileID.Anvils)
                .Register();
        }
    }
}
