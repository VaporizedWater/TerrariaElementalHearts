using ElementalHeartsRevivedMod.lib.Interfaces.ItemCategory;
using ElementalHeartsRevivedMod.lib.Interfaces.ItemTags;
using ElementalHeartsRevivedMod.lib.Interfaces.Rarity;
using System.Collections.Generic;
using Terraria.ID;

namespace ElementalHeartsRevivedMod.src.Hearts.Hardmode {
    public class Rainbow : HeartBase, HardmodeHeart, ConsumableItem, CraftableItem, RainbowItem, BlueRarity {
        public Rainbow()
          : base() {
        }

        protected override List<int> MaterialCost => [ItemID.RainbowBrick];
        protected override int CraftingStation => TileID.Anvils;
    }
}
