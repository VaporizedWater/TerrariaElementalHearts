using ElementalHeartsRevivedMod.lib.Interfaces.ItemCategory;
using ElementalHeartsRevivedMod.lib.Interfaces.ItemTags;
using ElementalHeartsRevivedMod.lib.Interfaces.Rarity;
using System.Collections.Generic;
using Terraria.ID;

namespace ElementalHeartsRevivedMod.src.Hearts.PreHardmode {
    public class Crimtane : HeartBase, PreHardmodeHeart, ConsumableItem, CraftableItem, BlueRarity {
        public Crimtane()
          : base() {
        }

        protected override List<int> MaterialCost => [ItemID.CrimtaneOre];
        protected override int CraftingStation => TileID.Furnaces;
    }
}
