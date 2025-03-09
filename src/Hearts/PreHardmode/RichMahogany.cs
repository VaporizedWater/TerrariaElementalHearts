using ElementalHeartsRevivedMod.lib.Interfaces.ItemCategory;
using ElementalHeartsRevivedMod.lib.Interfaces.ItemTags;
using ElementalHeartsRevivedMod.lib.Interfaces.Rarity;
using System.Collections.Generic;
using Terraria.ID;

namespace ElementalHeartsRevivedMod.src.Hearts.PreHardmode {
    public class RichMahogany : HeartBase, PreHardmodeHeart, ConsumableItem, CraftableItem, WhiteRarity {
        public RichMahogany()
          : base() {
        }
        protected override List<int> MaterialCost => [ItemID.RichMahogany];
        protected override int CraftingStation => TileID.Sawmill;
    }
}
