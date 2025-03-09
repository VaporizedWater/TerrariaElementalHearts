using ElementalHeartsRevivedMod.lib.Interfaces.ItemCategory;
using ElementalHeartsRevivedMod.lib.Interfaces.ItemTags;
using ElementalHeartsRevivedMod.lib.Interfaces.Rarity;
using System.Collections.Generic;
using Terraria.ID;

namespace ElementalHeartsRevivedMod.src.Hearts.PreHardmode {
    public class LifeCrystal : HeartBase, PreHardmodeHeart, LightRedRarity, ConsumableItem, GreenRarity {
        public LifeCrystal()
          : base() {
        }
        protected override List<int> MaterialCost => [ItemID.LifeCrystal];
        protected override int CraftingStation => TileID.DemonAltar;
    }
}
