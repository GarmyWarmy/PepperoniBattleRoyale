using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Localization;
using PepperoniBattleRoyale.Common;

namespace PepperoniBattleRoyale.Content
{
    public class VanillaRecipes : ModSystem
    {
        public static RecipeGroup CopperBar;
        public static RecipeGroup IronOre;
        public static RecipeGroup SilverBar;
        public static RecipeGroup GoldOre;
        public static RecipeGroup GoldBar;
        public static RecipeGroup DemoniteBar;
        public static RecipeGroup RottenChunk;
        public static RecipeGroup ForestCritter;
        public override void Unload()
        {
            CopperBar = null;
        }
        public override void AddRecipeGroups()
        {
            CopperBar = new RecipeGroup(() => $"{Language.GetTextValue("LegacyMisc.37")} {Lang.GetItemNameValue(ItemID.CopperBar)}", ItemID.CopperBar, ItemID.TinBar);
            RecipeGroup.RegisterGroup("Pepbr: Copper Bar", CopperBar);

            IronOre = new RecipeGroup(() => $"{Language.GetTextValue("LegacyMisc.37")} {Lang.GetItemNameValue(ItemID.IronOre)}", ItemID.IronOre, ItemID.LeadOre);
            RecipeGroup.RegisterGroup("Pepbr: Iron Ore", IronOre);

            SilverBar = new RecipeGroup(() => $"{Language.GetTextValue("LegacyMisc.37")} {Lang.GetItemNameValue(ItemID.SilverBar)}", ItemID.SilverBar, ItemID.TungstenBar);
            RecipeGroup.RegisterGroup("Pepbr: Silver Bar", SilverBar);

            GoldOre = new RecipeGroup(() => $"{Language.GetTextValue("LegacyMisc.37")} {Lang.GetItemNameValue(ItemID.GoldOre)}", ItemID.GoldOre, ItemID.PlatinumOre);
            RecipeGroup.RegisterGroup("Pepbr: Gold Ore", GoldOre);

            GoldBar = new RecipeGroup(() => $"{Language.GetTextValue("LegacyMisc.37")} {Lang.GetItemNameValue(ItemID.GoldBar)}", ItemID.GoldBar, ItemID.PlatinumBar);
            RecipeGroup.RegisterGroup("Pepbr: Gold Bar", GoldBar);

            DemoniteBar = new RecipeGroup(() => $"{Language.GetTextValue("LegacyMisc.37")} {Lang.GetItemNameValue(ItemID.DemoniteBar)}", ItemID.DemoniteBar, ItemID.CrimtaneBar);
            RecipeGroup.RegisterGroup("Pepbr: Demonite Bar", DemoniteBar);

            RottenChunk = new RecipeGroup(() => $"{Language.GetTextValue("LegacyMisc.37")} {Lang.GetItemNameValue(ItemID.RottenChunk)}", ItemID.RottenChunk, ItemID.Vertebrae);
            RecipeGroup.RegisterGroup("Pepbr: Rotten Chunk", RottenChunk);

            ForestCritter = new RecipeGroup(() => $"{Language.GetTextValue("LegacyMisc.37")} {Lang.GetItemNameValue(ItemID.Squirrel)}", ItemID.Squirrel, ItemID.SquirrelRed, ItemID.Bunny, ItemID.Grasshopper);
            RecipeGroup.RegisterGroup("Pepbr: Forest Critter", ForestCritter);
        }
        public override void AddRecipes()
        {
            Recipe recipe = Recipe.Create(ItemID.FruitcakeChakram, 1)
                .AddRecipeGroup(RecipeGroupID.Fruit, 4)
                .AddIngredient(ItemID.WoodenBoomerang, 1)
                .AddTile(TileID.Anvils)
                .Register();

            recipe = Recipe.Create(ItemID.WoodenBoomerang, 1)
                .AddRecipeGroup(RecipeGroupID.Wood, 20)
                .AddIngredient(ItemID.Cobweb, 15)
                .AddTile(TileID.WorkBenches)
                .Register();

            recipe = Recipe.Create(ItemID.Katana, 1)
                .AddRecipeGroup(SilverBar, 10)
                .AddIngredient(ItemID.Emerald, 6)
                .AddIngredient(ItemID.Gel, 10)
                .AddIngredient(ItemID.RedHusk, 1)
                .AddTile(TileID.Anvils)
                .Register();

            recipe = Recipe.Create(ItemID.DyeTradersScimitar, 1)
                .AddIngredient(ItemID.Katana, 1)
                .AddIngredient(ItemID.FalconBlade, 1)
                .AddTile(TileID.Anvils)
                .Register();

            recipe = Recipe.Create(ItemID.Revolver, 1)
                .AddIngredient(ItemID.FlintlockPistol, 2)
                .AddTile(TileID.WorkBenches)
                .Register();

            recipe = Recipe.Create(ItemID.Blowgun, 1)
                .AddIngredient(ItemID.Blowpipe, 1)
                .AddIngredient(ItemID.IllegalGunParts, 1)
                .AddTile(TileID.Anvils)
                .Register();

            recipe = Recipe.Create(ItemID.CloudinaBottle, 1)
                .AddIngredient(ItemID.Cloud, 30)
                .AddIngredient(ItemID.Feather, 3)
                .AddIngredient(ItemID.Bottle, 1)
                .AddTile(TileID.WorkBenches)
                .Register();

            recipe = Recipe.Create(ItemID.HermesBoots, 1)
                .AddIngredient(ItemID.Feather, 2)
                .AddIngredient(ItemID.Silk, 12)
                .AddIngredient(ItemID.Gel, 30)
                .AddTile(TileID.Loom)
                .Register();

            recipe = Recipe.Create(ItemID.FlurryBoots, 1)
                .AddIngredient(ItemID.Feather, 2)
                .AddIngredient(ItemID.Silk, 12)
                .AddIngredient(ItemID.IceBlock, 60)
                .AddTile(TileID.Loom)
                .Register();

            recipe = Recipe.Create(ItemID.SandBoots, 1)
                .AddIngredient(ItemID.AntlionMandible, 4)
                .AddIngredient(ItemID.Silk, 12)
                .AddIngredient(ItemID.FossilOre, 20)
                .AddTile(TileID.Loom)
                .Register();

            recipe = Recipe.Create(ItemID.BandofRegeneration, 1)
                .AddRecipeGroup(RecipeGroupID.IronBar, 5)
                .AddIngredient(ItemID.LifeCrystal, 1)
                .AddTile(TileID.Anvils)
                .Register();

            recipe = Recipe.Create(ItemID.BandofStarpower, 1)
                .AddRecipeGroup(RecipeGroupID.IronBar, 5)
                .AddIngredient(ItemID.ManaCrystal, 1)
                .AddTile(TileID.Anvils)
                .Register();

            recipe = Recipe.Create(ItemID.FeralClaws, 1)
                .AddIngredient(ItemID.JungleSpores, 12)
                .AddIngredient(ItemID.ClayBlock, 20)
                .AddTile(TileID.Furnaces)
                .Register();

            recipe = Recipe.Create(ItemID.LuckyHorseshoe, 1)
                .AddRecipeGroup(GoldBar, 8)
                .AddTile(TileID.Anvils)
                .Register();

            recipe = Recipe.Create(ItemID.Flipper, 1)
                .AddIngredient(ItemID.Gel, 6)
                .AddIngredient(ItemID.Coral, 3)
                .AddIngredient(ItemID.Waterleaf, 2)
                .AddTile(TileID.Anvils)
                .AddCondition(Condition.NearWater)
                .Register();

            recipe = Recipe.Create(ItemID.WaterWalkingBoots, 1)
                .AddIngredient(ItemID.SharkFin, 2)
                .AddIngredient(ItemID.Silk, 12)
                .AddIngredient(ItemID.Coral, 4)
                .AddTile(TileID.Loom)
                .Register();

            recipe = Recipe.Create(ItemID.TackleBox, 1)
                .AddIngredient(ItemID.PalmWood, 15)
                .AddIngredient(ItemID.ApprenticeBait, 2)
                .AddIngredient(ItemID.JourneymanBait, 1)
                .AddTile(TileID.Anvils)
                .Register();

            recipe = Recipe.Create(ItemID.AnglerEarring, 1)
                .AddRecipeGroup(SilverBar, 8)
                .AddIngredient(ItemID.LimeKelp, 1)
                .AddTile(TileID.Anvils)
                .Register();

            recipe = Recipe.Create(ItemID.HighTestFishingLine, 1)
                .AddIngredient(ItemID.WhiteString, 2)
                .AddIngredient(ItemID.Chain, 3)
                .AddTile(TileID.Anvils)
                .Register();

            recipe = Recipe.Create(ItemID.EskimoHood, 1)
                .AddIngredient(ItemID.SnowBlock, 40)
                .AddIngredient(ItemID.FlinxFur, 2)
                .AddTile(TileID.Anvils)
                .Register();
            recipe = Recipe.Create(ItemID.EskimoCoat, 1)
                .AddIngredient(ItemID.SnowBlock, 65)
                .AddIngredient(ItemID.FlinxFur, 3)
                .AddTile(TileID.Anvils)
                .Register();
            recipe = Recipe.Create(ItemID.EskimoPants, 1)
                .AddIngredient(ItemID.FlinxFur, 3)
                .AddTile(TileID.Anvils)
                .Register();

            recipe = Recipe.Create(ItemID.MagicHat, 1)
                .AddIngredient(ItemID.Silk, 6)
                .AddIngredient(ItemID.ManaCrystal, 1)
                .AddIngredient(ItemID.Amethyst, 3)
                .AddTile(TileID.Loom)
                .Register();

            recipe = Recipe.Create(ItemID.GypsyRobe, 1)
                .AddIngredient(ItemID.Robe, 1)
                .AddIngredient(ItemID.ManaCrystal, 1)
                .AddIngredient(ItemID.Amethyst, 3)
                .AddTile(TileID.Loom)
                .Register();

            recipe = Recipe.Create(ItemID.Gi, 1)
                .AddIngredient(ItemID.Silk, 15)
                .AddIngredient(ItemID.Gel, 10)
                .AddIngredient(ItemID.RedHusk)
                .AddTile(TileID.Loom)
                .Register();

            recipe = Recipe.Create(ItemID.MiningHelmet, 1)
                .AddRecipeGroup(GoldBar, 10)
                .AddIngredient(ItemID.ShinePotion, 1)
                .AddTile(TileID.Anvils)
                .Register();

            recipe = Recipe.Create(ItemID.NightVisionHelmet, 1)
                .AddIngredient(ItemID.Granite, 40)
                .AddIngredient(ItemID.Emerald, 1)
                .AddTile(TileID.Anvils)
                .Register();

            recipe = Recipe.Create(ItemID.FamiliarWig)
                .AddTile(TileID.Dressers)
                .Register();
            recipe = Recipe.Create(ItemID.FamiliarShirt)
                .AddTile(TileID.Dressers)
                .Register();
            recipe = Recipe.Create(ItemID.FamiliarPants)
                .AddTile(TileID.Dressers)
                .Register();

            recipe = Recipe.Create(ItemID.TinkerersWorkshop, 1)
                .AddRecipeGroup(RecipeGroupID.Wood, 30)
                .AddIngredient(ItemID.Book, 5)
                .AddIngredient(ItemID.Silk, 10)
                .AddIngredient(ItemID.TatteredCloth, 6)
                .AddTile(TileID.WorkBenches)
                .Register();

            recipe = Recipe.Create(ItemID.AmmoBox, 1)
                .AddRecipeGroup(RecipeGroupID.IronBar, 8)
                .AddIngredient(ItemID.Chain, 10)
                .AddTile(TileID.Anvils)
                .Register();

            recipe = Recipe.Create(ItemID.Extractinator, 1)
                .AddRecipeGroup(RecipeGroupID.IronBar, 10)
                .AddIngredient(ItemID.StoneBlock, 50)
                .AddTile(TileID.Anvils)
                .Register();

            recipe = Recipe.Create(ItemID.UnholyArrow, 50)
                .AddRecipeGroup(DemoniteBar, 1)
                .AddIngredient(ItemID.WoodenArrow, 50)
                .AddTile(TileID.Anvils)
                .Register();

            recipe = Recipe.Create(ItemID.MusketBall, 50)
                .AddRecipeGroup(RecipeGroupID.IronBar, 1)
                .AddTile(TileID.AmmoBox)
                .Register();

            //Miscallaneous Items
            recipe = Recipe.Create(ItemID.Binoculars, 1)
                .AddIngredient(ItemID.Goggles, 1)
                .AddRecipeGroup(DemoniteBar, 8)
                .AddTile(TileID.Tables)
                .AddTile(TileID.Chairs)
                .Register();

            recipe = Recipe.Create(ItemID.GravediggerShovel, 1)
                .AddRecipeGroup(RecipeGroupID.IronBar, 10)
                .AddRecipeGroup(RecipeGroupID.Wood, 5)
                .AddTile(TileID.Anvils)
                .Register();

            recipe = Recipe.Create(ItemID.BugNet, 1)
                .AddIngredient(ItemID.Cobweb, 30)
                .AddIngredient(ItemID.Chain, 5)
                .AddTile(TileID.Anvils)
                .Register();

            recipe = Recipe.Create(ItemID.GoldenBugNet, 1)
                .AddIngredient(ItemID.FireproofBugNet, 1)
                .AddRecipeGroup(GoldBar, 20)
                .AddTile(TileID.Anvils)
                .Register();

            recipe = Recipe.Create(ItemID.BloodMoonStarter, 1)
                .AddRecipeGroup(RottenChunk, 4)
                .AddRecipeGroup(CopperBar, 8)
                .AddTile(TileID.DemonAltar)
                .Register();

            recipe = Recipe.Create(ItemID.Glowstick, 3)
                .AddIngredient(ItemID.Gel, 1)
                .AddCondition(Condition.NearWater)
                .Register();

            recipe = Recipe.Create(ItemID.FiberglassFishingPole, 1)
                .AddIngredient(ItemID.JungleSpores, 12)
                .AddIngredient(ItemID.Vine, 3)
                .AddTile(TileID.Anvils)
                .Register();

            recipe = Recipe.Create(ItemID.ApprenticeBait, 2)
                .AddRecipeGroup(RecipeGroupID.Fruit, 1)
                .AddTile(TileID.CookingPots)
                .Register();

            recipe = Recipe.Create(ItemID.MagicMirror, 1)
                .AddIngredient(ItemID.Glass, 15)
                .AddRecipeGroup(SilverBar, 12)
                .AddIngredient(ItemID.Lens, 1)
                .AddTile(TileID.Anvils)
                .Register();

            recipe = Recipe.Create(ItemID.IceMirror, 1)
                .AddIngredient(ItemID.Glass, 15)
                .AddIngredient(ItemID.IceBlock, 20)
                .AddIngredient(ItemID.Lens, 1)
                .AddTile(TileID.IceMachine)
                .Register();

            recipe = Recipe.Create(ItemID.Bomb, 3)
                .AddRecipeGroup(RecipeGroupID.IronBar, 1)
                .AddIngredient(ItemID.Gel, 6)
                .Register();

            recipe = Recipe.Create(ItemID.PiggyBank, 1)
                .AddIngredient(ItemID.GoldCoin, 5)
                .AddIngredient(ItemID.ClayBlock, 20)
                .AddTile(TileID.Furnaces)
                .Register();

            //Post-Evil Recipes
            recipe = Recipe.Create(ItemID.Cascade)
                .AddIngredient(ItemID.HellstoneBar, 12)
                .AddIngredient(ItemID.Obsidian, 8)
                .AddIngredient(ItemID.WoodYoyo, 1)
                .AddTile(TileID.Anvils)
                .Register();

            recipe = Recipe.Create(ItemID.WormScarf, 1)
                .AddIngredient(ItemID.WormTooth, 6)
                .AddIngredient(ItemID.ShadowScale, 10)
                .AddIngredient(ItemID.Silk, 12)
                .AddTile(TileID.DemonAltar)
                .Register();

            recipe = Recipe.Create(ItemID.RocketBoots, 1)
                .AddIngredient(ItemID.Silk, 12)
                .AddIngredient(ItemID.Gel, 25)
                .AddRecipeGroup(RecipeGroupID.IronBar, 8)
                .AddTile(TileID.Anvils)
                .Register();

            recipe = Recipe.Create(ItemID.HotlineFishingHook, 1)
                .AddIngredient(ItemID.HellstoneBar, 16)
                .AddIngredient(ItemID.Obsidian, 18)
                .AddIngredient(ItemID.HellButterfly, 3)
                .AddIngredient(ItemID.MagmaSnail, 2)
                .AddTile(TileID.Anvils)
                .Register();

            recipe = Recipe.Create(ItemID.BookofSkulls, 1)
                .AddIngredient(ItemID.Book, 1)
                .AddIngredient(ItemID.Bone, 80)
                .AddTile(TileID.Bookcases)
                .Register();

            recipe = Recipe.Create(ItemID.SkeletronHand, 1)
                .AddIngredient(ItemID.Bone, 50)
                .AddTile(TileID.BoneWelder)
                .Register();

            recipe = Recipe.Create(ItemID.Spike, 2)
                .AddRecipeGroup(RecipeGroupID.IronBar, 1)
                .AddIngredient(ItemID.Bone, 1)
                .AddTile(TileID.Anvils)
                .Register();

            recipe = Recipe.Create(ItemID.AlchemyTable, 1)
                .AddIngredient(ItemID.Bone, 30)
                .AddIngredient(ItemID.BottledWater, 6)
                .AddIngredient(ItemID.HealingPotion, 8)
                .AddTile(TileID.Tables)
                .Register();

            recipe = Recipe.Create(ItemID.GoldenFishingRod, 1)
                .AddIngredient(ItemID.FisherofSouls, 1)
                .AddIngredient(ItemID.FiberglassFishingPole, 1)
                .AddIngredient(ItemID.MechanicsRod, 1)
                .AddIngredient(ItemID.HotlineFishingHook, 1)
                .AddTile(TileID.DemonAltar)
                .Register();

            //Post-QB Recipes
            recipe = Recipe.Create(ItemID.HoneyedGoggles, 1)
                .AddIngredient(ItemID.Goggles, 1)
                .AddIngredient(ItemID.BeeWax, 20)
                .AddTile(TileID.Anvils)
                .Register();

            recipe = Recipe.Create(ItemID.HiveBackpack, 1)
                .AddIngredient(ItemID.Hive, 30)
                .AddIngredient(ItemID.BeeWax, 10)
                .AddIngredient(ItemID.Stinger, 10)
                .AddIngredient(ItemID.HoneyBucket, 2)
                .AddTile(TileID.Anvils)
                .Register();

            //Potion Recipes
            recipe = Recipe.Create(ItemID.RegenerationPotion, 1)
                .AddIngredient(ItemID.WormholePotion, 1)
                .AddIngredient(ItemID.Mushroom, 1)
                .AddTile(TileID.Bottles)
                .Register();

            recipe = Recipe.Create(ItemID.SwiftnessPotion, 1)
                .AddIngredient(ItemID.WormholePotion, 1)
                .AddIngredient(ItemID.Cactus, 1)
                .AddTile(TileID.Bottles)
                .Register();

            recipe = Recipe.Create(ItemID.GillsPotion, 1)
                .AddIngredient(ItemID.WormholePotion, 1)
                .AddTile(TileID.Bottles)
                .AddCondition(Condition.NearWater)
                .Register();

            recipe = Recipe.Create(ItemID.IronskinPotion, 1)
                .AddIngredient(ItemID.WormholePotion, 1)
                .AddRecipeGroup(IronOre, 1)
                .AddTile(TileID.Bottles)
                .Register();

            recipe = Recipe.Create(ItemID.FeatherfallPotion, 1)
                .AddIngredient(ItemID.WormholePotion, 2)
                .AddIngredient(ItemID.Feather, 1)
                .AddTile(TileID.Bottles)
                .Register();

            recipe = Recipe.Create(ItemID.SpelunkerPotion, 1)
                .AddIngredient(ItemID.WormholePotion, 1)
                .AddRecipeGroup(GoldOre, 1)
                .AddTile(TileID.Bottles)
                .Register();

            recipe = Recipe.Create(ItemID.ShinePotion, 1)
                .AddIngredient(ItemID.WormholePotion, 1)
                .AddIngredient(ItemID.GlowingMushroom, 1)
                .AddTile(TileID.Bottles)
                .Register();

            recipe = Recipe.Create(ItemID.NightOwlPotion, 1)
                .AddIngredient(ItemID.WormholePotion, 1)
                .AddIngredient(ItemID.GlowingMushroom, 1)
                .AddTile(TileID.Bottles)
                .Register();

            recipe = Recipe.Create(ItemID.BattlePotion, 1)
                .AddIngredient(ItemID.WormholePotion, 1)
                .AddRecipeGroup(RottenChunk, 1)
                .AddTile(TileID.Bottles)
                .Register();

            recipe = Recipe.Create(ItemID.WaterWalkingPotion, 1)
                .AddIngredient(ItemID.WormholePotion, 1)
                .AddTile(TileID.Bottles)
                .AddCondition(Condition.NearWater)
                .Register();

            recipe = Recipe.Create(ItemID.ArcheryPotion, 1)
                .AddIngredient(ItemID.WormholePotion, 1)
                .AddIngredient(ItemID.Lens, 1)
                .AddTile(TileID.Bottles)
                .Register();

            recipe = Recipe.Create(ItemID.HunterPotion, 1)
                .AddIngredient(ItemID.WormholePotion, 1)
                .AddIngredient(ItemID.SharkFin, 1)
                .AddTile(TileID.Bottles)
                .Register();

            recipe = Recipe.Create(ItemID.MiningPotion, 1)
                .AddIngredient(ItemID.WormholePotion, 1)
                .AddIngredient(ItemID.AntlionMandible, 1)
                .AddTile(TileID.Bottles)
                .Register();

            recipe = Recipe.Create(ItemID.BuilderPotion, 1)
                .AddIngredient(ItemID.WormholePotion, 1)
                .AddIngredient(ItemID.DirtBlock, 50)
                .AddTile(TileID.Bottles)
                .Register();

            recipe = Recipe.Create(ItemID.SummoningPotion, 1)
                .AddIngredient(ItemID.WormholePotion, 1)
                .AddIngredient(ItemID.Hive, 1)
                .AddTile(TileID.Bottles)
                .Register();

            recipe = Recipe.Create(ItemID.FishingPotion, 1)
                .AddIngredient(ItemID.WormholePotion, 1)
                .AddIngredient(ItemID.ApprenticeBait, 1)
                .AddTile(TileID.Bottles)
                .Register();

            recipe = Recipe.Create(ItemID.SonarPotion, 1)
                .AddIngredient(ItemID.WormholePotion, 1)
                .AddIngredient(ItemID.Coral, 1)
                .AddTile(TileID.Bottles)
                .Register();

            recipe = Recipe.Create(ItemID.CratePotion, 2)
                .AddIngredient(ItemID.WormholePotion, 2)
                .AddIngredient(ItemID.WoodenCrate, 1)
                .AddTile(TileID.Bottles)
                .Register();

            recipe = Recipe.Create(ItemID.CratePotion, 2)
                .AddIngredient(ItemID.WormholePotion, 2)
                .AddIngredient(ItemID.WoodenCrateHard, 1)
                .AddTile(TileID.Bottles)
                .Register();

            recipe = Recipe.Create(ItemID.IceMachine)
                .AddIngredient(ItemID.Sapphire, 4)
                .AddRecipeGroup(RecipeGroupID.IronBar, 6)
                .AddIngredient(ItemID.IceBlock, 40)
                .AddTile(TileID.Anvils)
                .Register();

            recipe = Recipe.Create(ItemID.ToxicFlask)
                .AddIngredient(ItemID.BottledWater)
                .AddIngredient(ItemID.Stinger, 12)
                .AddIngredient(ItemID.JungleSpores, 8)
                .AddTile(TileID.AlchemyTable)
                .Register();

            recipe = Recipe.Create(ItemID.MushroomSpear)
                .AddIngredient(ItemID.GlowingMushroom, 50)
                .AddTile(TileID.WorkBenches)
                .Register();
        }
    }
}
