using ElementalHeartsRevivedMod.lib.Interfaces.ItemCategory;
using ElementalHeartsRevivedMod.lib.Interfaces.ItemTags;
using ElementalHeartsRevivedMod.lib.Interfaces.Rarity;
using System.Collections.Generic;
using Terraria.ID;

namespace ElementalHeartsRevivedMod.src.Hearts.PreHardmode {
    public class PurpleIce : HeartBase, PreHardmodeHeart, ConsumableItem, CraftableItem, WhiteRarity {
        public PurpleIce()
          : base() {
        }
        protected override List<int> MaterialCost => [ItemID.PurpleIceBlock];
        protected override int CraftingStation => TileID.IceMachine;
    }
}
