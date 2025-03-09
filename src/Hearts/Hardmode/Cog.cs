using ElementalHeartsRevivedMod.lib.Interfaces.ItemCategory;
using ElementalHeartsRevivedMod.lib.Interfaces.ItemTags;
using ElementalHeartsRevivedMod.lib.Interfaces.Rarity;

namespace ElementalHeartsRevivedMod.src.Hearts.Hardmode {
    public class Cog : HeartBase, HardmodeHeart, ConsumableItem, BuyableItem, GreenRarity {
        public Cog()
          : base() {
        }
        protected override int CopperCoinCost => 1000000;
    }
}
