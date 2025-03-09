using ElementalHeartsRevivedMod.lib.Interfaces.ItemCategory;
using ElementalHeartsRevivedMod.lib.Interfaces.ItemTags;
using ElementalHeartsRevivedMod.lib.Interfaces.Rarity;
using System.Collections.Generic;
using Terraria.ID;

namespace ElementalHeartsRevivedMod.src.Hearts.PreHardmode {
    public class RainCloud : HeartBase, PreHardmodeHeart, ConsumableItem, CraftableItem, WhiteRarity {
        public RainCloud()
          : base() {
        }
        protected override List<int> MaterialCost => [ItemID.RainCloud];
        protected override int CraftingStation => TileID.SkyMill;
    }
}
