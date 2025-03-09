using ElementalHeartsRevivedMod.lib.Interfaces.ItemCategory;
using ElementalHeartsRevivedMod.lib.Interfaces.ItemTags;
using ElementalHeartsRevivedMod.lib.Interfaces.Rarity;
using System.Collections.Generic;
using Terraria.ID;

namespace ElementalHeartsRevivedMod.src.Hearts.PreHardmode {
    public class Fossil : HeartBase, PreHardmodeHeart, CraftableItem, ConsumableItem, WhiteRarity {
        public Fossil()
          : base() {
        }
        protected override List<int> MaterialCost => [ItemID.DesertFossil];
        protected override int CraftingStation => TileID.Extractinator;
    }
}
