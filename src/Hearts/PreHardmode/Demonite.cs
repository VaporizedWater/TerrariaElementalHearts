using ElementalHeartsRevivedMod.lib.Interfaces.ItemCategory;
using ElementalHeartsRevivedMod.lib.Interfaces.ItemTags;
using ElementalHeartsRevivedMod.lib.Interfaces.Rarity;
using System.Collections.Generic;
using Terraria.ID;

namespace ElementalHeartsRevivedMod.src.Hearts.PreHardmode {
    public class Demonite : HeartBase, PreHardmodeHeart, ConsumableItem, CraftableItem, BlueRarity {
        public Demonite()
          : base() {
        }

        protected override List<int> MaterialCost => [ItemID.DemoniteOre];
        protected override int CraftingStation => TileID.Furnaces;
    }
}
