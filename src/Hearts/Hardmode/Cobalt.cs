using ElementalHeartsRevivedMod.lib.Interfaces.ItemCategory;
using ElementalHeartsRevivedMod.lib.Interfaces.ItemTags;
using ElementalHeartsRevivedMod.lib.Interfaces.Rarity;
using System.Collections.Generic;
using Terraria.ID;

namespace ElementalHeartsRevivedMod.src.Hearts.Hardmode {
    public class Cobalt : HeartBase, HardmodeHeart, ConsumableItem, CraftableItem, OrangeRarity {
        public Cobalt()
          : base() {
        }
        protected override List<int> MaterialCost => new List<int>() { ItemID.CobaltOre };
        protected override int CraftingStation => TileID.Furnaces;
    }
}
