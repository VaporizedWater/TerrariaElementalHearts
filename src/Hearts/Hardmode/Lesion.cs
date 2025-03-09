using ElementalHeartsRevivedMod.lib.Interfaces.ItemCategory;
using ElementalHeartsRevivedMod.lib.Interfaces.ItemTags;
using ElementalHeartsRevivedMod.lib.Interfaces.Rarity;
using System.Collections.Generic;
using Terraria.ID;

namespace ElementalHeartsRevivedMod.src.Hearts.Hardmode {
    public class Lesion : HeartBase, HardmodeHeart, ConsumableItem, CraftableItem, WhiteRarity {
        public Lesion()
          : base() {
        }

        protected override List<int> MaterialCost => new List<int>() { ItemID.LesionBlock };
        protected override int CraftingStation => TileID.LesionStation;
    }
}
