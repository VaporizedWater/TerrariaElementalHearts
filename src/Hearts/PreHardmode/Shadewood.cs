using ElementalHeartsRevivedMod.lib.Interfaces.ItemCategory;
using ElementalHeartsRevivedMod.lib.Interfaces.ItemTags;
using ElementalHeartsRevivedMod.lib.Interfaces.Rarity;
using System.Collections.Generic;
using Terraria.ID;

namespace ElementalHeartsRevivedMod.src.Hearts.PreHardmode {
    public class Shadewood : HeartBase, PreHardmodeHeart, ConsumableItem, CraftableItem, WhiteRarity {
        public Shadewood()
          : base() {
        }
        protected override List<int> MaterialCost => [ItemID.Shadewood];
        protected override int CraftingStation => TileID.Sawmill;
    }
}
