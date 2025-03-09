using ElementalHeartsRevivedMod.lib.Interfaces.ItemCategory;
using ElementalHeartsRevivedMod.lib.Interfaces.ItemTags;
using ElementalHeartsRevivedMod.lib.Interfaces.Rarity;
using System.Collections.Generic;
using Terraria.ID;

namespace ElementalHeartsRevivedMod.src.Hearts.Hardmode {
    public class SpookyWood : HeartBase, HardmodeHeart, ConsumableItem, CraftableItem, WhiteRarity {
        public SpookyWood()
          : base() {
        }

        protected override List<int> MaterialCost => new List<int>() { ItemID.SpookyWood };
        protected override int CraftingStation => TileID.Sawmill;
    }
}
