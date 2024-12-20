using Terraria.ID;
using Terraria.ModLoader;

namespace ElementalHeartsRevivedMod.src
{
    public class Hearts
    {
        public class Hardmode
        {
            public class Adamantite : EHRBase
            {
                public Adamantite()
                  : base(2, TileID.AdamantiteForge, 366)
                {
                }
            }

            public class Bubble : EHRBase
            {
                public Bubble()
                  : base(2, val: 1000000)
                {
                }
            }

            public class BubbleNPC : EHRNPC
            {
                public BubbleNPC()
                  : base(208, ModContent.ItemType<Bubble>())
                {
                }
            }

            public class Chlorophyte : EHRBase
            {
                public Chlorophyte()
                  : base(2, TileID.MythrilAnvil, 947)
                {
                }
            }

            public class Cobalt : EHRBase
            {
                public Cobalt()
                  : base(2, TileID.Furnaces, 364)
                {
                }
            }

            public class Cog : EHRBase
            {
                public Cog()
                  : base(2, val: 1000000)
                {
                }
            }

            public class CogNPC : EHRNPC
            {
                public CogNPC()
                  : base(178, ModContent.ItemType<Cog>())
                {
                }
            }

            public class Crystal : EHRBase
            {
                public Crystal()
                  : base(2, TileID.MythrilAnvil, 502)
                {
                }
            }

            public class CursedFlame : EHRBase
            {
                public CursedFlame()
                  : base(2, TileID.CrystalBall, 522)
                {
                }
            }

            public class Discord : EHRBase
            {
                public Discord()
                  : base(2, TileID.DemonAltar, 1326)
                {
                }
            }

            public class Ectoplasm : EHRBase
            {
                public Ectoplasm()
                  : base(2, TileID.CrystalBall, 1508)
                {
                }
            }

            public class Flesh : EHRBase
            {
                public Flesh()
                  : base(2, TileID.FleshCloningVat, 763)
                {
                }
            }

            public class Flight : EHRBase
            {
                public Flight()
                  : base(2, TileID.MythrilAnvil, 575)
                {
                }
            }

            public class Horny : EHRBase
            {
                public Horny()
                  : base(2, TileID.MythrilAnvil, 3771)
                {
                }
            }

            public class Ichor : EHRBase
            {
                public Ichor()
                  : base(2, TileID.CrystalBall, 1332)
                {
                }
            }

            public class Lesion : EHRBase
            {
                public Lesion()
                  : base(2, TileID.LesionStation, 3955)
                {
                }
            }

            public class Light : EHRBase
            {
                public Light()
                  : base(2, TileID.MythrilAnvil, 520)
                {
                }
            }

            public class Luminite : EHRBase
            {
                public Luminite()
                  : base(2, TileID.LunarCraftingStation, 3460)
                {
                }
            }

            public class Mythril : EHRBase
            {
                public Mythril()
                  : base(2, TileID.MythrilAnvil, 365)
                {
                }
            }

            public class Night : EHRBase
            {
                public Night()
                  : base(2, TileID.MythrilAnvil, 521)
                {
                }
            }

            public class Orichalcum : EHRBase
            {
                public Orichalcum()
                  : base(2, TileID.MythrilAnvil, 1105)
                {
                }
            }

            public class Palladium : EHRBase
            {
                public Palladium()
                  : base(2, TileID.Furnaces, 1104)
                {
                }
            }

            public class Pearlsand : EHRBase
            {
                public Pearlsand()
                  : base(2, TileID.HeavyWorkBench, 408)
                {
                }
            }

            public class Pearlstone : EHRBase
            {
                public Pearlstone()
                  : base(2, TileID.Furnaces, ItemID.PearlstoneBlock)
                {
                }
            }

            public class Pearlwood : EHRBase
            {
                public Pearlwood()
                  : base(2, TileID.Sawmill, ItemID.Pearlwood)
                {
                }
            }

            public class PinkIce : EHRBase
            {
                public PinkIce()
                  : base(2, TileID.IceMachine, 834)
                {
                }
            }

            public class Rainbow : EHRBase
            {
                public Rainbow()
                  : base(2, TileID.Anvils, 662, rainbowEffect: true)
                {
                }
            }

            public class SpookyWood : EHRBase
            {
                public SpookyWood()
                  : base(2, TileID.Sawmill, 1729)
                {
                }
            }

            public class Titanium : EHRBase
            {
                public Titanium()
                  : base(2, TileID.AdamantiteForge, 1106)
                {
                }
            }
        }

        public class PreHardmode
        {
            public class Amber : EHRBase
            {
                public Amber()
                  : base(4, TileID.TreeAmber, 999)
                {
                }
            }

            public class Amethyst : EHRBase
            {
                public Amethyst()
                  : base(4, TileID.TreeAmethyst, 181)
                {
                }
            }

            public class BorealWood : EHRBase
            {
                public BorealWood()
                  : base(4, TileID.Sawmill, 2503)
                {
                }
            }

            public class Cactus : EHRBase
            {
                public Cactus()
                  : base(4, TileID.Sawmill, 276)
                {
                }
            }

            public class CandyCane : EHRBase
            {
                public CandyCane()
                  : base(4, TileID.WorkBenches, 586)
                {
                }
            }

            public class Cloud : EHRBase
            {
                public Cloud()
                  : base(4, TileID.SkyMill, 751)
                {
                }
            }

            public class Copper : EHRBase
            {
                public Copper()
                  : base(4, TileID.Furnaces, 12)
                {
                }
            }

            public class Coralstone : EHRBase
            {
                public Coralstone()
                  : base(4, TileID.WorkBenches, 2435)
                {
                }
            }

            public class Crimsand : EHRBase
            {
                public Crimsand()
                  : base(4, TileID.HeavyWorkBench, 1246)
                {
                }
            }

            public class Crimtane : EHRBase
            {
                public Crimtane()
                  : base(4, TileID.Furnaces, 880)
                {
                }
            }

            public class Demonite : EHRBase
            {
                public Demonite()
                  : base(4, TileID.Furnaces, 56)
                {
                }
            }

            public class Diamond : EHRBase
            {
                public Diamond()
                  : base(4, TileID.TreeDiamond, 182)
                {
                }
            }

            public class Dirt : EHRBase
            {
                public Dirt()
                  : base(4, TileID.WorkBenches, 2)
                {
                }
            }

            public class Dynasty : EHRBase
            {
                public Dynasty()
                  : base(4, TileID.Sawmill, 2260)
                {
                }
            }

            public class Ebonsand : EHRBase
            {
                public Ebonsand()
                  : base(4, TileID.HeavyWorkBench, 370)
                {
                }
            }

            public class Ebonstone : EHRBase
            {
                public Ebonstone()
                  : base(4, TileID.Furnaces, 61)
                {
                }
            }

            public class Emerald : EHRBase
            {
                public Emerald()
                  : base(4, TileID.TreeEmerald, 179)
                {
                }
            }

            public class Enchanted : EHRBase
            {
                public Enchanted()
                  : base(4, TileID.DemonAltar, 989)
                {
                }
            }

            public class Fossil : EHRBase
            {
                public Fossil()
                  : base(4, TileID.Extractinator, 3347)
                {
                }
            }

            public class Glass : EHRBase
            {
                public Glass()
                  : base(4, TileID.GlassKiln, 170)
                {
                }
            }

            public class Gold : EHRBase
            {
                public Gold()
                  : base(4, TileID.Furnaces, 13)
                {
                }
            }

            public class Granite : EHRBase
            {
                public Granite()
                  : base(4, TileID.WorkBenches, 3087)
                {
                }
            }

            public class Hay : EHRBase
            {
                public Hay()
                  : base(4, TileID.WorkBenches, 1727)
                {
                }
            }

            public class Hellstone : EHRBase
            {
                public Hellstone()
                  : base(4, TileID.Hellforge, 174)
                {
                }
            }

            public class Honey : EHRBase
            {
                public Honey()
                  : base(4, TileID.HoneyDispenser, 1125)
                {
                }
            }

            public class Ice : EHRBase
            {
                public Ice()
                  : base(4, TileID.IceMachine, 664)
                {
                }
            }

            public class Iron : EHRBase
            {
                public Iron()
                  : base(4, TileID.Furnaces, 11)
                {
                }
            }

            public class Lead : EHRBase
            {
                public Lead()
                  : base(4, TileID.Furnaces, 700)
                {
                }
            }

            public class LifeCrystal : EHRBase
            {
                public LifeCrystal()
                  : base(4, TileID.DemonAltar, 29, 4)
                {
                }
            }

            public class Marble : EHRBase
            {
                public Marble()
                  : base(4, TileID.WorkBenches, 3081)
                {
                }
            }

            public class Meteorite : EHRBase
            {
                public Meteorite()
                  : base(4, TileID.Furnaces, 116)
                {
                }
            }

            public class Mushroom : EHRBase
            {
                public Mushroom()
                  : base(4, TileID.Sawmill, 183)
                {
                }
            }

            public class Obsidian : EHRBase
            {
                public Obsidian()
                  : base(4, TileID.Hellforge, 173)
                {
                }
            }

            public class PalmWood : EHRBase
            {
                public PalmWood()
                  : base(4, TileID.Sawmill, 2504)
                {
                }
            }

            public class Platinum : EHRBase
            {
                public Platinum()
                  : base(4, TileID.Furnaces, 702)
                {
                }
            }

            public class Pumpkin : EHRBase
            {
                public Pumpkin()
                  : base(4, TileID.Sawmill, 1725)
                {

                }
            }

            public class PurpleIce : EHRBase
            {
                public PurpleIce()
                  : base(4, TileID.IceMachine, 833)
                {
                }
            }

            public class RainCloud : EHRBase
            {
                public RainCloud()
                  : base(4, TileID.SkyMill, 765)
                {
                }
            }

            public class RedIce : EHRBase
            {
                public RedIce()
                  : base(4, TileID.IceMachine, 835)
                {
                }
            }

            public class RichMahogany : EHRBase
            {
                public RichMahogany()
                  : base(4, TileID.Sawmill, 620)
                {
                }
            }

            public class Ruby : EHRBase
            {
                public Ruby()
                  : base(4, TileID.TreeRuby, 178)
                {
                }
            }

            public class Sand : EHRBase
            {
                public Sand()
                  : base(4, TileID.HeavyWorkBench, 169)
                {
                }
            }

            public class Sapphire : EHRBase
            {
                public Sapphire()
                  : base(4, TileID.TreeSapphire, 177)
                {
                }
            }

            public class Shadewood : EHRBase
            {
                public Shadewood()
                  : base(4, TileID.Sawmill, 911)
                {
                }
            }

            public class Silver : EHRBase
            {
                public Silver()
                  : base(4, TileID.Furnaces, 14)
                {
                }
            }

            public class Slime : EHRBase
            {
                public Slime()
                  : base(4, TileID.Solidifier, 23)
                {
                }
            }

            public class SnowCloud : EHRBase
            {
                public SnowCloud()
                  : base(4, TileID.SkyMill, 3756)
                {

                }
            }

            public class Stone : EHRBase
            {
                public Stone()
                  : base(4, TileID.Furnaces, 3)
                {

                }
            }

            public class Sunplate : EHRBase
            {
                public Sunplate()
                  : base(4, TileID.SkyMill, 824)
                {
                }
            }

            public class Tin : EHRBase
            {
                public Tin()
                  : base(4, TileID.Furnaces, 699)
                {
                }
            }

            public class Topaz : EHRBase
            {
                public Topaz()
                  : base(4, TileID.TreeTopaz, 180)
                {

                }
            }

            public class Tungsten : EHRBase
            {
                public Tungsten()
                  : base(4, TileID.Furnaces, 701)
                {
                }
            }

            public class Wood : EHRBase
            {
                public Wood()
                  : base(4, TileID.Sawmill, 9)
                {
                }
            }
        }

        public class Boss
        {
            public class Betsy : EHRBase
            {
                public Betsy()
                  : base(1, boss: true)
                {
                }
            }

            public class BetsyNPC : EHRNPC
            {
                public BetsyNPC()
                  : base(551, ModContent.ItemType<Betsy>(), false)
                {
                }
            }

            public class BrainOfCthulhu : EHRBase
            {
                public BrainOfCthulhu()
                  : base(1, boss: true)
                {
                }
            }

            public class BrainOfCthulhuNPC : EHRNPC
            {
                public BrainOfCthulhuNPC()
                  : base(266, ModContent.ItemType<BrainOfCthulhu>(), false)
                {
                }
            }

            public class Deer : EHRBase
            {
                public Deer()
                  : base(1, boss: true)
                {
                }
            }

            public class DeerNPC : EHRNPC
            {
                public DeerNPC()
                  : base(668, ModContent.ItemType<Deer>(), false)
                {
                }
            }

            public class DukeFishron : EHRBase
            {
                public DukeFishron()
                  : base(1, boss: true)
                {
                }
            }

            public class DukeFishronNPC : EHRNPC
            {
                public DukeFishronNPC()
                  : base(370, ModContent.ItemType<DukeFishron>(), false)
                {
                }
            }

            public class EaterOfWorlds : EHRBase
            {
                public EaterOfWorlds()
                  : base(1, boss: true)
                {
                }
            }

            public class EaterOfWorldsNPC : EHRNPC
            {
                public EaterOfWorldsNPC()
                  : base(item: ModContent.ItemType<EaterOfWorlds>(), shopLoot: false, isEaterOfWorlds: true)
                {
                }
            }

            public class EmpressOfLight : EHRBase
            {
                public EmpressOfLight()
                  : base(1, boss: true)
                {
                }
            }

            public class EmpressOfLightNPC : EHRNPC
            {
                public EmpressOfLightNPC()
                  : base(661, ModContent.ItemType<EmpressOfLight>(), false)
                {
                }
            }

            public class EyeOfCthulhu : EHRBase
            {
                public EyeOfCthulhu()
                  : base(1, boss: true)
                {
                }
            }

            public class EyeOfCthulhuNPC : EHRNPC
            {
                public EyeOfCthulhuNPC()
                  : base(4, ModContent.ItemType<EyeOfCthulhu>(), false)
                {
                }
            }

            public class FlyingDutchman : EHRBase
            {
                public FlyingDutchman()
                  : base(1, boss: true)
                {
                }
            }

            public class FlyingDutchmanNPC : EHRNPC
            {
                public FlyingDutchmanNPC()
                  : base(491, ModContent.ItemType<FlyingDutchman>(), false)
                {
                }
            }

            public class Golem : EHRBase
            {
                public Golem()
                  : base(1, boss: true)
                {
                }
            }

            public class GolemNPC : EHRNPC
            {
                public GolemNPC()
                  : base(245, ModContent.ItemType<Golem>(), false)
                {
                }
            }

            public class KingSlime : EHRBase
            {
                public KingSlime()
                  : base(1, boss: true)
                {
                }
            }

            public class KingSlimeNPC : EHRNPC
            {
                public KingSlimeNPC()
                  : base(50, ModContent.ItemType<KingSlime>(), false)
                {
                }
            }

            public class LunaticCultist : EHRBase
            {
                public LunaticCultist()
                  : base(1, boss: true)
                {
                }
            }

            public class LunaticCultistNPC : EHRNPC
            {
                public LunaticCultistNPC()
                  : base(439, ModContent.ItemType<LunaticCultist>(), false)
                {
                }
            }

            public class MartianSaucer : EHRBase
            {
                public MartianSaucer()
                  : base(1, boss: true)
                {
                }
            }

            public class MartianSaucerNPC : EHRNPC
            {
                public MartianSaucerNPC()
                  : base(395, ModContent.ItemType<MartianSaucer>(), false)
                {
                }
            }

            public class MoonLord : EHRBase
            {
                public MoonLord()
                  : base(1, boss: true)
                {
                }
            }

            public class MoonLordNPC : EHRNPC
            {
                public MoonLordNPC()
                  : base(398, ModContent.ItemType<MoonLord>(), false)
                {
                }
            }

            public class Plantera : EHRBase
            {
                public Plantera()
                  : base(1, boss: true)
                {
                }
            }

            public class PlanteraNPC : EHRNPC
            {
                public PlanteraNPC()
                  : base(262, ModContent.ItemType<Plantera>(), false)
                {
                }
            }

            public class QueenBee : EHRBase
            {
                public QueenBee()
                  : base(1, boss: true)
                {
                }
            }

            public class QueenBeeNPC : EHRNPC
            {
                public QueenBeeNPC()
                  : base(222, ModContent.ItemType<QueenBee>(), false)
                {
                }
            }

            public class QueenSlime : EHRBase
            {
                public QueenSlime()
                  : base(1, boss: true)
                {
                }
            }

            public class QueenSlimeNPC : EHRNPC
            {
                public QueenSlimeNPC()
                  : base(657, ModContent.ItemType<QueenSlime>(), false)
                {
                }
            }

            public class Skeletron : EHRBase
            {
                public Skeletron()
                  : base(1, boss: true)
                {
                }
            }

            public class SkeletronNPC : EHRNPC
            {
                public SkeletronNPC()
                  : base(35, ModContent.ItemType<Skeletron>(), false)
                {
                }
            }

            public class SoulOfFright : EHRBase
            {
                public SoulOfFright()
                  : base(1, boss: true)
                {
                }
            }

            public class SoulOfFrightNPC : EHRNPC
            {
                public SoulOfFrightNPC()
                  : base(sbyte.MaxValue, ModContent.ItemType<SoulOfFright>(), false)
                {
                }
            }

            public class SoulOfMight : EHRBase
            {
                public SoulOfMight()
                  : base(1, boss: true)
                {
                }
            }

            public class SoulOfMightNPC : EHRNPC
            {
                public SoulOfMightNPC()
                  : base(TileID.MythrilAnvil, ModContent.ItemType<SoulOfMight>(), false)
                {
                }
            }

            public class SoulOfSight : EHRBase
            {
                public SoulOfSight()
                  : base(1, boss: true)
                {
                }
            }

            public class SoulOfSightNPC : EHRNPC
            {
                public SoulOfSightNPC()
                  : base(125, ModContent.ItemType<SoulOfSight>(), false)
                {
                }
            }
        }
    }
}
