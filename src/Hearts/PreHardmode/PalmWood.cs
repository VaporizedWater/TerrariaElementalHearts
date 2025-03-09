using ElementalHeartsRevivedMod.lib.Interfaces.ItemCategory;
using ElementalHeartsRevivedMod.lib.Interfaces.ItemTags;
using ElementalHeartsRevivedMod.lib.Interfaces.Rarity;
using System.Collections.Generic;
using Terraria.ID;

namespace ElementalHeartsRevivedMod.src.Hearts.PreHardmode {
    public class PalmWood : HeartBase, PreHardmodeHeart, ConsumableItem, CraftableItem, WhiteRarity {
        public PalmWood()
          : base() {
        }
        protected override List<int> MaterialCost => [ItemID.PalmWood];
        protected override int CraftingStation => TileID.Sawmill;
    }
}
