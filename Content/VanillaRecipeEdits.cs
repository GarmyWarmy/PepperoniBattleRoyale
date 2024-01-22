using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace PepperoniBattleRoyale.Content
{
    public class VanillaRecipeEdits : ModSystem
    {
        public override void PostAddRecipes()
        {
            for (int i = 0; i < Recipe.numRecipes; i++)
            {
                Recipe recipe = Main.recipe[i];

                if (recipe.HasResult(ItemID.EnchantedBoomerang))
                {
                    recipe.RemoveIngredient(ItemID.FallenStar);

                    recipe.AddIngredient(ItemID.FallenStar, 3)
                        .AddIngredient(ItemID.Gel, 6)
                        .AddTile(TileID.Anvils);
                }
                if (recipe.HasResult(ItemID.BloodySpine))
                {
                    recipe.RemoveIngredient(ItemID.Vertebrae);
                    recipe.RemoveIngredient(ItemID.ViciousPowder);

                    recipe.AddIngredient(ItemID.Vertebrae, 6)
                        .AddIngredient(ItemID.ViciousMushroom, 3);
                }
                if (recipe.HasResult(ItemID.WormFood))
                {
                    recipe.RemoveIngredient(ItemID.RottenChunk);
                    recipe.RemoveIngredient(ItemID.VilePowder);

                    recipe.AddIngredient(ItemID.RottenChunk, 6)
                        .AddIngredient(ItemID.VileMushroom, 3);
                }
                if (recipe.HasResult(ItemID.Flamarang))
                {
                    recipe.AddIngredient(ItemID.Bone, 25);
                }

                if (recipe.HasResult(ItemID.NightmarePickaxe))
                    recipe.AddIngredient(ItemID.Bone, 16);

                if (recipe.HasResult(ItemID.DeathbringerPickaxe))
                    recipe.AddIngredient(ItemID.Bone, 16);
            }
        }
    }
}
