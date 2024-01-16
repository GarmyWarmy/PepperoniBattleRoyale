using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using PepperoniBattleRoyale.Content.Projectiles;
using Microsoft.Xna.Framework;

namespace PepperoniBattleRoyale.Content.Items.Weapons
{
    public class FishBlaster : ModItem
    {
        public override void SetDefaults()
        {
            Item.width = 60;
            Item.height = 30;

            Item.autoReuse = true;
            Item.damage = 20;
            Item.DamageType = DamageClass.Ranged;
            Item.knockBack = 4f;
            Item.noMelee = true;
            Item.rare = ItemRarityID.Green;
            Item.shootSpeed = 10f;
            Item.useAnimation = 15;
            Item.useTime = 5;
            Item.reuseDelay = 30;
            Item.knockBack = 0f;
            Item.UseSound = SoundID.Item31;
            Item.useStyle = ItemUseStyleID.Shoot;
            Item.value = Item.sellPrice(gold: 5);

            Item.shoot = ModContent.ProjectileType<BabyFlyingFish>();
        }
        public override void ModifyWeaponDamage(Player player, ref StatModifier damage)
        {
            if ((player.wet && !player.lavaWet && !player.honeyWet && !player.shimmerWet) || (player.armor[0].type == ItemID.FishBowl || player.armor[0].type == ItemID.GoldGoldfishBowl))
            {
                damage *= 2;
            }
        }
        public override Vector2? HoldoutOffset()
        {
            return new Vector2(-5f, 1f);
        }
    }
}
