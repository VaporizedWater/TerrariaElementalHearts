using ElementalHeartsRevivedMod.lib.Interfaces.ItemCategory;
using ElementalHeartsRevivedMod.lib.Interfaces.ItemTags;
using ElementalHeartsRevivedMod.lib.Interfaces.Rarity;
using System.Collections.Generic;
using Terraria.ID;

namespace ElementalHeartsRevivedMod.src.Hearts.PreHardmode {
    public class SnowCloud : HeartBase, PreHardmodeHeart, ConsumableItem, CraftableItem, WhiteRarity {
        public SnowCloud()
          : base() {

        }
        protected override List<int> MaterialCost => [ItemID.SnowCloudBlock];
        protected override int CraftingStation => TileID.SkyMill;
    }
}
