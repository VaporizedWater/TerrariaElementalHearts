using ElementalHeartsRevivedMod.lib.Interfaces.ItemCategory;
using ElementalHeartsRevivedMod.lib.Interfaces.ItemTags;
using ElementalHeartsRevivedMod.lib.Interfaces.Rarity;
using System.Collections.Generic;
using Terraria.ID;

namespace ElementalHeartsRevivedMod.src.Hearts.Hardmode {
    public class Pearlstone : HeartBase, HardmodeHeart, ConsumableItem, CraftableItem, WhiteRarity {
        public Pearlstone()
          : base() {
        }

        protected override List<int> MaterialCost => new List<int>() { ItemID.PearlstoneBlock };
        protected override int CraftingStation => TileID.Furnaces;
    }
}
