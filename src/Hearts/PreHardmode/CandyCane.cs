using ElementalHeartsRevivedMod.lib.Interfaces.ItemCategory;
using ElementalHeartsRevivedMod.lib.Interfaces.ItemTags;
using ElementalHeartsRevivedMod.lib.Interfaces.Rarity;
using System.Collections.Generic;
using Terraria.ID;

namespace ElementalHeartsRevivedMod.src.Hearts.PreHardmode {
    public class CandyCane : HeartBase, PreHardmodeHeart, ConsumableItem, CraftableItem, WhiteRarity {
        public CandyCane()
          : base() {
        }

        protected override List<int> MaterialCost => [ItemID.CandyCaneBlock];
        protected override int CraftingStation => TileID.WorkBenches;
    }
}
