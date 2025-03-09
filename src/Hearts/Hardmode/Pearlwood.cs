using ElementalHeartsRevivedMod.lib.Interfaces.ItemCategory;
using ElementalHeartsRevivedMod.lib.Interfaces.ItemTags;
using ElementalHeartsRevivedMod.lib.Interfaces.Rarity;
using System.Collections.Generic;
using Terraria.ID;

namespace ElementalHeartsRevivedMod.src.Hearts.Hardmode {
    public class Pearlwood : HeartBase, HardmodeHeart, ConsumableItem, CraftableItem, WhiteRarity {
        public Pearlwood()
          : base() {
        }

        protected override List<int> MaterialCost => new List<int>() { ItemID.Pearlwood };
        protected override int CraftingStation => TileID.Sawmill;
    }
}
