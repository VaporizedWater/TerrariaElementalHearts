using ElementalHeartsRevivedMod.lib.Interfaces.ItemCategory;
using ElementalHeartsRevivedMod.lib.Interfaces.ItemTags;
using ElementalHeartsRevivedMod.lib.Interfaces.Rarity;
using System.Collections.Generic;
using Terraria.ID;

namespace ElementalHeartsRevivedMod.src.Hearts.PreHardmode {
    public class Diamond : HeartBase, PreHardmodeHeart, ConsumableItem, CraftableItem, WhiteRarity {
        public Diamond()
          : base() {
        }

        protected override List<int> MaterialCost => [ItemID.Diamond];
        protected override int CraftingStation => TileID.TreeDiamond;
    }
}
