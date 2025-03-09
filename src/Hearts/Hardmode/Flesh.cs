using ElementalHeartsRevivedMod.lib.Interfaces.ItemCategory;
using ElementalHeartsRevivedMod.lib.Interfaces.ItemTags;
using ElementalHeartsRevivedMod.lib.Interfaces.Rarity;
using System.Collections.Generic;
using Terraria.ID;

namespace ElementalHeartsRevivedMod.src.Hearts.Hardmode {
    public class Flesh : HeartBase, HardmodeHeart, ConsumableItem, CraftableItem, WhiteRarity {
        public Flesh()
          : base() {
        }

        protected override List<int> MaterialCost => new List<int> { ItemID.FleshBlock };
        protected override int CraftingStation => TileID.FleshCloningVat;
    }
}
