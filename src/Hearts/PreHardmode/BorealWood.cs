using ElementalHeartsRevivedMod.lib.Interfaces.ItemCategory;
using ElementalHeartsRevivedMod.lib.Interfaces.ItemTags;
using ElementalHeartsRevivedMod.lib.Interfaces.Rarity;
using System.Collections.Generic;
using Terraria.ID;

namespace ElementalHeartsRevivedMod.src.Hearts.PreHardmode {
    public class BorealWood : HeartBase, PreHardmodeHeart, ConsumableItem, CraftableItem, WhiteRarity {
        public BorealWood()
          : base() {
        }

        protected override List<int> MaterialCost => new List<int>() { ItemID.BorealWood };
        protected override int CraftingStation => TileID.Sawmill;
    }
}
