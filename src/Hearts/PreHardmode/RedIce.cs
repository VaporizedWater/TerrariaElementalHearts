using ElementalHeartsRevivedMod.lib.Interfaces.ItemCategory;
using ElementalHeartsRevivedMod.lib.Interfaces.ItemTags;
using ElementalHeartsRevivedMod.lib.Interfaces.Rarity;
using System.Collections.Generic;
using Terraria.ID;

namespace ElementalHeartsRevivedMod.src.Hearts.PreHardmode {
    public class RedIce : HeartBase, PreHardmodeHeart, ConsumableItem, CraftableItem, WhiteRarity {
        public RedIce()
          : base() {
        }
        protected override List<int> MaterialCost => [ItemID.RedIceBlock];
        protected override int CraftingStation => TileID.IceMachine;
    }
}
