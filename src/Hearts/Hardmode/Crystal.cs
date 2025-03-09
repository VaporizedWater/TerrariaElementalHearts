using ElementalHeartsRevivedMod.lib.Interfaces.ItemCategory;
using ElementalHeartsRevivedMod.lib.Interfaces.ItemTags;
using ElementalHeartsRevivedMod.lib.Interfaces.Rarity;
using System.Collections.Generic;
using Terraria.ID;

namespace ElementalHeartsRevivedMod.src.Hearts.Hardmode {
    public class Crystal : HeartBase, HardmodeHeart, ConsumableItem, CraftableItem, BlueRarity {
        public Crystal()
          : base() {
        }
        protected override List<int> MaterialCost => new List<int>() { ItemID.CrystalShard };
        protected override int CraftingStation => TileID.MythrilAnvil;
    }
}
