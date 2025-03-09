using ElementalHeartsRevivedMod.lib.Interfaces.ItemCategory;
using ElementalHeartsRevivedMod.lib.Interfaces.ItemTags;
using ElementalHeartsRevivedMod.lib.Interfaces.Rarity;
using System.Collections.Generic;
using Terraria.ID;

namespace ElementalHeartsRevivedMod.src.Hearts.PreHardmode {
    public class Hellstone : HeartBase, PreHardmodeHeart, ConsumableItem, CraftableItem, GreenRarity {
        public Hellstone()
          : base() {
        }
        protected override List<int> MaterialCost => [ItemID.Hellstone];
        protected override int CraftingStation => TileID.Hellforge;
    }
}
