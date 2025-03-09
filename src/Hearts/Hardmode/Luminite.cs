using ElementalHeartsRevivedMod.lib.Interfaces.ItemCategory;
using ElementalHeartsRevivedMod.lib.Interfaces.ItemTags;
using ElementalHeartsRevivedMod.lib.Interfaces.Rarity;
using System.Collections.Generic;
using Terraria.ID;

namespace ElementalHeartsRevivedMod.src.Hearts.Hardmode {
    public class Luminite : HeartBase, HardmodeHeart, ConsumableItem, CraftableItem, RedRarity {
        public Luminite()
          : base() {
        }

        protected override List<int> MaterialCost => new List<int>() { ItemID.LunarOre };
        protected override int CraftingStation => TileID.LunarCraftingStation;
    }
}
