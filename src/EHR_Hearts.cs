using Terraria.ID;
using Terraria.ModLoader;

namespace ElementalHeartsRevivedMod.src
{
    public class Hearts
    {
        public class Hardmode
        {
            public class Adamantite : EHR_Base
            {
                public Adamantite()
                  : base(2, TileID.AdamantiteForge, 366)
                {
                }
            }

            public class Bubble : EHR_Base
            {
                public Bubble()
                  : base(2, val: 1000000)
                {
                }
            }

            public class BubbleNPC : EHR_NPC
            {
                public BubbleNPC()
                  : base(208, ModContent.ItemType<Bubble>())
                {
                }
            }

            public class Chlorophyte : EHR_Base
            {
                public Chlorophyte()
                  : base(2, TileID.MythrilAnvil, 947)
                {
                }
            }

            public class Cobalt : EHR_Base
            {
                public Cobalt()
                  : base(2, TileID.Furnaces, 364)
                {
                }
            }

            public class Cog : EHR_Base
            {
                public Cog()
                  : base(2, val: 1000000)
                {
                }
            }

            public class CogNPC : EHR_NPC
            {
                public CogNPC()
                  : base(178, ModContent.ItemType<Cog>())
                {
                }
            }

            public class Crystal : EHR_Base
            {
                public Crystal()
                  : base(2, TileID.MythrilAnvil, 502)
                {
                }
            }

            public class CursedFlame : EHR_Base
            {
                public CursedFlame()
                  : base(2, TileID.CrystalBall, 522)
                {
                }
            }

            public class Discord : EHR_Base
            {
                public Discord()
                  : base(2, TileID.DemonAltar, 1326)
                {
                }
            }

            public class Ectoplasm : EHR_Base
            {
                public Ectoplasm()
                  : base(2, TileID.CrystalBall, 1508)
                {
                }
            }

            public class Flesh : EHR_Base
            {
                public Flesh()
                  : base(2, TileID.FleshCloningVat, 763)
                {
                }
            }

            public class Flight : EHR_Base
            {
                public Flight()
                  : base(2, TileID.MythrilAnvil, 575)
                {
                }
            }

            public class Horny : EHR_Base
            {
                public Horny()
                  : base(2, TileID.MythrilAnvil, 3771)
                {
                }
            }

            public class Ichor : EHR_Base
            {
                public Ichor()
                  : base(2, TileID.CrystalBall, 1332)
                {
                }
            }

            public class Lesion : EHR_Base
            {
                public Lesion()
                  : base(2, TileID.LesionStation, 3955)
                {
                }
            }

            public class Light : EHR_Base
            {
                public Light()
                  : base(2, TileID.MythrilAnvil, 520)
                {
                }
            }

            public class Luminite : EHR_Base
            {
                public Luminite()
                  : base(2, TileID.LunarCraftingStation, 3460)
                {
                }
            }

            public class Mythril : EHR_Base
            {
                public Mythril()
                  : base(2, TileID.MythrilAnvil, 365)
                {
                }
            }

            public class Night : EHR_Base
            {
                public Night()
                  : base(2, TileID.MythrilAnvil, 521)
                {
                }
            }

            public class Orichalcum : EHR_Base
            {
                public Orichalcum()
                  : base(2, TileID.MythrilAnvil, 1105)
                {
                }
            }

            public class Palladium : EHR_Base
            {
                public Palladium()
                  : base(2, TileID.Furnaces, 1104)
                {
                }
            }

            public class Pearlsand : EHR_Base
            {
                public Pearlsand()
                  : base(2, TileID.HeavyWorkBench, 408)
                {
                }
            }

            public class Pearlstone : EHR_Base
            {
                public Pearlstone()
                  : base(2, TileID.Furnaces, ItemID.PearlstoneBlock)
                {
                }
            }

            public class Pearlwood : EHR_Base
            {
                public Pearlwood()
                  : base(2, TileID.Sawmill, ItemID.Pearlwood)
                {
                }
            }

            public class PinkIce : EHR_Base
            {
                public PinkIce()
                  : base(2, TileID.IceMachine, 834)
                {
                }
            }

            public class Rainbow : EHR_Base
            {
                public Rainbow()
                  : base(2, TileID.Anvils, 662, rainbowEffect: true)
                {
                }
            }

            public class SpookyWood : EHR_Base
            {
                public SpookyWood()
                  : base(2, TileID.Sawmill, 1729)
                {
                }
            }

            public class Titanium : EHR_Base
            {
                public Titanium()
                  : base(2, TileID.AdamantiteForge, 1106)
                {
                }
            }
        }

        public class PreHardmode
        {
            public class Amber : EHR_Base
            {
                public Amber()
                  : base(4, TileID.TreeAmber, 999)
                {
                }
            }

            public class Amethyst : EHR_Base
            {
                public Amethyst()
                  : base(4, TileID.TreeAmethyst, 181)
                {
                }
            }

            public class BorealWood : EHR_Base
            {
                public BorealWood()
                  : base(4, TileID.Sawmill, 2503)
                {
                }
            }

            public class Cactus : EHR_Base
            {
                public Cactus()
                  : base(4, TileID.Sawmill, 276)
                {
                }
            }

            public class CandyCane : EHR_Base
            {
                public CandyCane()
                  : base(4, TileID.WorkBenches, 586)
                {
                }
            }

            public class Cloud : EHR_Base
            {
                public Cloud()
                  : base(4, TileID.SkyMill, 751)
                {
                }
            }

            public class Copper : EHR_Base
            {
                public Copper()
                  : base(4, TileID.Furnaces, 12)
                {
                }
            }

            public class Coralstone : EHR_Base
            {
                public Coralstone()
                  : base(4, TileID.WorkBenches, 2435)
                {
                }
            }

            public class Crimsand : EHR_Base
            {
                public Crimsand()
                  : base(4, TileID.HeavyWorkBench, 1246)
                {
                }
            }

            public class Crimtane : EHR_Base
            {
                public Crimtane()
                  : base(4, TileID.Furnaces, 880)
                {
                }
            }

            public class Demonite : EHR_Base
            {
                public Demonite()
                  : base(4, TileID.Furnaces, 56)
                {
                }
            }

            public class Diamond : EHR_Base
            {
                public Diamond()
                  : base(4, TileID.TreeDiamond, 182)
                {
                }
            }

            public class Dirt : EHR_Base
            {
                public Dirt()
                  : base(4, TileID.WorkBenches, 2)
                {
                }
            }

            public class Dynasty : EHR_Base
            {
                public Dynasty()
                  : base(4, TileID.Sawmill, 2260)
                {
                }
            }

            public class Ebonsand : EHR_Base
            {
                public Ebonsand()
                  : base(4, TileID.HeavyWorkBench, 370)
                {
                }
            }

            public class Ebonstone : EHR_Base
            {
                public Ebonstone()
                  : base(4, TileID.Furnaces, 61)
                {
                }
            }

            public class Emerald : EHR_Base
            {
                public Emerald()
                  : base(4, TileID.TreeEmerald, 179)
                {
                }
            }

            public class Enchanted : EHR_Base
            {
                public Enchanted()
                  : base(4, TileID.DemonAltar, 989)
                {
                }
            }

            public class Fossil : EHR_Base
            {
                public Fossil()
                  : base(4, TileID.Extractinator, 3347)
                {
                }
            }

            public class Glass : EHR_Base
            {
                public Glass()
                  : base(4, TileID.GlassKiln, 170)
                {
                }
            }

            public class Gold : EHR_Base
            {
                public Gold()
                  : base(4, TileID.Furnaces, 13)
                {
                }
            }

            public class Granite : EHR_Base
            {
                public Granite()
                  : base(4, TileID.WorkBenches, 3087)
                {
                }
            }

            public class Hay : EHR_Base
            {
                public Hay()
                  : base(4, TileID.WorkBenches, 1727)
                {
                }
            }

            public class Hellstone : EHR_Base
            {
                public Hellstone()
                  : base(4, TileID.Hellforge, 174)
                {
                }
            }

            public class Honey : EHR_Base
            {
                public Honey()
                  : base(4, TileID.HoneyDispenser, 1125)
                {
                }
            }

            public class Ice : EHR_Base
            {
                public Ice()
                  : base(4, TileID.IceMachine, 664)
                {
                }
            }

            public class Iron : EHR_Base
            {
                public Iron()
                  : base(4, TileID.Furnaces, 11)
                {
                }
            }

            public class Lead : EHR_Base
            {
                public Lead()
                  : base(4, TileID.Furnaces, 700)
                {
                }
            }

            public class LifeCrystal : EHR_Base
            {
                public LifeCrystal()
                  : base(4, TileID.DemonAltar, 29, 4)
                {
                }
            }

            public class Marble : EHR_Base
            {
                public Marble()
                  : base(4, TileID.WorkBenches, 3081)
                {
                }
            }

            public class Meteorite : EHR_Base
            {
                public Meteorite()
                  : base(4, TileID.Furnaces, 116)
                {
                }
            }

            public class Mushroom : EHR_Base
            {
                public Mushroom()
                  : base(4, TileID.Sawmill, 183)
                {
                }
            }

            public class Obsidian : EHR_Base
            {
                public Obsidian()
                  : base(4, TileID.Hellforge, 173)
                {
                }
            }

            public class PalmWood : EHR_Base
            {
                public PalmWood()
                  : base(4, TileID.Sawmill, 2504)
                {
                }
            }

            public class Platinum : EHR_Base
            {
                public Platinum()
                  : base(4, TileID.Furnaces, 702)
                {
                }
            }

            public class Pumpkin : EHR_Base
            {
                public Pumpkin()
                  : base(4, TileID.Sawmill, 1725)
                {

                }
            }

            public class PurpleIce : EHR_Base
            {
                public PurpleIce()
                  : base(4, TileID.IceMachine, 833)
                {
                }
            }

            public class RainCloud : EHR_Base
            {
                public RainCloud()
                  : base(4, TileID.SkyMill, 765)
                {
                }
            }

            public class RedIce : EHR_Base
            {
                public RedIce()
                  : base(4, TileID.IceMachine, 835)
                {
                }
            }

            public class RichMahogany : EHR_Base
            {
                public RichMahogany()
                  : base(4, TileID.Sawmill, 620)
                {
                }
            }

            public class Ruby : EHR_Base
            {
                public Ruby()
                  : base(4, TileID.TreeRuby, 178)
                {
                }
            }

            public class Sand : EHR_Base
            {
                public Sand()
                  : base(4, TileID.HeavyWorkBench, 169)
                {
                }
            }

            public class Sapphire : EHR_Base
            {
                public Sapphire()
                  : base(4, TileID.TreeSapphire, 177)
                {
                }
            }

            public class Shadewood : EHR_Base
            {
                public Shadewood()
                  : base(4, TileID.Sawmill, 911)
                {
                }
            }

            public class Silver : EHR_Base
            {
                public Silver()
                  : base(4, TileID.Furnaces, 14)
                {
                }
            }

            public class Slime : EHR_Base
            {
                public Slime()
                  : base(4, TileID.Solidifier, 23)
                {
                }
            }

            public class SnowCloud : EHR_Base
            {
                public SnowCloud()
                  : base(4, TileID.SkyMill, 3756)
                {

                }
            }

            public class Stone : EHR_Base
            {
                public Stone()
                  : base(4, TileID.Furnaces, 3)
                {

                }
            }

            public class Sunplate : EHR_Base
            {
                public Sunplate()
                  : base(4, TileID.SkyMill, 824)
                {
                }
            }

            public class Tin : EHR_Base
            {
                public Tin()
                  : base(4, TileID.Furnaces, 699)
                {
                }
            }

            public class Topaz : EHR_Base
            {
                public Topaz()
                  : base(4, TileID.TreeTopaz, 180)
                {

                }
            }

            public class Tungsten : EHR_Base
            {
                public Tungsten()
                  : base(4, TileID.Furnaces, 701)
                {
                }
            }

            public class Wood : EHR_Base
            {
                public Wood()
                  : base(4, TileID.Sawmill, 9)
                {
                }
            }
        }

        public class Boss
        {
            public class Betsy : EHR_Base
            {
                public Betsy()
                  : base(1, boss: true)
                {
                }
            }

            public class BetsyNPC : EHR_NPC
            {
                public BetsyNPC()
                  : base(551, ModContent.ItemType<Betsy>(), false)
                {
                }
            }

            public class BrainOfCthulhu : EHR_Base
            {
                public BrainOfCthulhu()
                  : base(1, boss: true)
                {
                }
            }

            public class BrainOfCthulhuNPC : EHR_NPC
            {
                public BrainOfCthulhuNPC()
                  : base(266, ModContent.ItemType<BrainOfCthulhu>(), false)
                {
                }
            }

            public class Deer : EHR_Base
            {
                public Deer()
                  : base(1, boss: true)
                {
                }
            }

            public class DeerNPC : EHR_NPC
            {
                public DeerNPC()
                  : base(668, ModContent.ItemType<Deer>(), false)
                {
                }
            }

            public class DukeFishron : EHR_Base
            {
                public DukeFishron()
                  : base(1, boss: true)
                {
                }
            }

            public class DukeFishronNPC : EHR_NPC
            {
                public DukeFishronNPC()
                  : base(370, ModContent.ItemType<DukeFishron>(), false)
                {
                }
            }

            public class EaterOfWorlds : EHR_Base
            {
                public EaterOfWorlds()
                  : base(1, boss: true)
                {
                }
            }

            public class EaterOfWorldsNPC : EHR_NPC
            {
                public EaterOfWorldsNPC()
                  : base(item: ModContent.ItemType<EaterOfWorlds>(), shopLoot: false, isEaterOfWorlds: true)
                {
                }
            }

            public class EmpressOfLight : EHR_Base
            {
                public EmpressOfLight()
                  : base(1, boss: true)
                {
                }
            }

            public class EmpressOfLightNPC : EHR_NPC
            {
                public EmpressOfLightNPC()
                  : base(661, ModContent.ItemType<EmpressOfLight>(), false)
                {
                }
            }

            public class EyeOfCthulhu : EHR_Base
            {
                public EyeOfCthulhu()
                  : base(1, boss: true)
                {
                }
            }

            public class EyeOfCthulhuNPC : EHR_NPC
            {
                public EyeOfCthulhuNPC()
                  : base(4, ModContent.ItemType<EyeOfCthulhu>(), false)
                {
                }
            }

            public class FlyingDutchman : EHR_Base
            {
                public FlyingDutchman()
                  : base(1, boss: true)
                {
                }
            }

            public class FlyingDutchmanNPC : EHR_NPC
            {
                public FlyingDutchmanNPC()
                  : base(491, ModContent.ItemType<FlyingDutchman>(), false)
                {
                }
            }

            public class Golem : EHR_Base
            {
                public Golem()
                  : base(1, boss: true)
                {
                }
            }

            public class GolemNPC : EHR_NPC
            {
                public GolemNPC()
                  : base(245, ModContent.ItemType<Golem>(), false)
                {
                }
            }

            public class KingSlime : EHR_Base
            {
                public KingSlime()
                  : base(1, boss: true)
                {
                }
            }

            public class KingSlimeNPC : EHR_NPC
            {
                public KingSlimeNPC()
                  : base(50, ModContent.ItemType<KingSlime>(), false)
                {
                }
            }

            public class LunaticCultist : EHR_Base
            {
                public LunaticCultist()
                  : base(1, boss: true)
                {
                }
            }

            public class LunaticCultistNPC : EHR_NPC
            {
                public LunaticCultistNPC()
                  : base(439, ModContent.ItemType<LunaticCultist>(), false)
                {
                }
            }

            public class MartianSaucer : EHR_Base
            {
                public MartianSaucer()
                  : base(1, boss: true)
                {
                }
            }

            public class MartianSaucerNPC : EHR_NPC
            {
                public MartianSaucerNPC()
                  : base(395, ModContent.ItemType<MartianSaucer>(), false)
                {
                }
            }

            public class MoonLord : EHR_Base
            {
                public MoonLord()
                  : base(1, boss: true)
                {
                }
            }

            public class MoonLordNPC : EHR_NPC
            {
                public MoonLordNPC()
                  : base(398, ModContent.ItemType<MoonLord>(), false)
                {
                }
            }

            public class Plantera : EHR_Base
            {
                public Plantera()
                  : base(1, boss: true)
                {
                }
            }

            public class PlanteraNPC : EHR_NPC
            {
                public PlanteraNPC()
                  : base(262, ModContent.ItemType<Plantera>(), false)
                {
                }
            }

            public class QueenBee : EHR_Base
            {
                public QueenBee()
                  : base(1, boss: true)
                {
                }
            }

            public class QueenBeeNPC : EHR_NPC
            {
                public QueenBeeNPC()
                  : base(222, ModContent.ItemType<QueenBee>(), false)
                {
                }
            }

            public class QueenSlime : EHR_Base
            {
                public QueenSlime()
                  : base(1, boss: true)
                {
                }
            }

            public class QueenSlimeNPC : EHR_NPC
            {
                public QueenSlimeNPC()
                  : base(657, ModContent.ItemType<QueenSlime>(), false)
                {
                }
            }

            public class Skeletron : EHR_Base
            {
                public Skeletron()
                  : base(1, boss: true)
                {
                }
            }

            public class SkeletronNPC : EHR_NPC
            {
                public SkeletronNPC()
                  : base(35, ModContent.ItemType<Skeletron>(), false)
                {
                }
            }

            public class SoulOfFright : EHR_Base
            {
                public SoulOfFright()
                  : base(1, boss: true)
                {
                }
            }

            public class SoulOfFrightNPC : EHR_NPC
            {
                public SoulOfFrightNPC()
                  : base(sbyte.MaxValue, ModContent.ItemType<SoulOfFright>(), false)
                {
                }
            }

            public class SoulOfMight : EHR_Base
            {
                public SoulOfMight()
                  : base(1, boss: true)
                {
                }
            }

            public class SoulOfMightNPC : EHR_NPC
            {
                public SoulOfMightNPC()
                  : base(TileID.MythrilAnvil, ModContent.ItemType<SoulOfMight>(), false)
                {
                }
            }

            public class SoulOfSight : EHR_Base
            {
                public SoulOfSight()
                  : base(1, boss: true)
                {
                }
            }

            public class SoulOfSightNPC : EHR_NPC
            {
                public SoulOfSightNPC()
                  : base(125, ModContent.ItemType<SoulOfSight>(), false)
                {
                }
            }
        }
    }
}
