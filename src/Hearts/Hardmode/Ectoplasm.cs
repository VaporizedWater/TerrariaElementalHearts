using ElementalHeartsRevivedMod.lib.Interfaces.ItemCategory;
using ElementalHeartsRevivedMod.lib.Interfaces.ItemTags;
using ElementalHeartsRevivedMod.lib.Interfaces.Rarity;
using System.Collections.Generic;
using Terraria.ID;

namespace ElementalHeartsRevivedMod.src.Hearts.Hardmode {
    public class Ectoplasm : HeartBase, HardmodeHeart, ConsumableItem, CraftableItem, YellowRarity {
        public Ectoplasm()
          : base() {
        }

        protected override List<int> MaterialCost => new List<int>() { ItemID.Ectoplasm };
        protected override int CraftingStation => TileID.CrystalBall;
    }
}
