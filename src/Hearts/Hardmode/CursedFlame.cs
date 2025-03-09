using ElementalHeartsRevivedMod.lib.Interfaces.ItemCategory;
using ElementalHeartsRevivedMod.lib.Interfaces.ItemTags;
using ElementalHeartsRevivedMod.lib.Interfaces.Rarity;
using System.Collections.Generic;
using Terraria.ID;

namespace ElementalHeartsRevivedMod.src.Hearts.Hardmode {
    public class CursedFlame : HeartBase, HardmodeHeart, ConsumableItem, CraftableItem, OrangeRarity {
        public CursedFlame()
          : base() {
        }
        protected override List<int> MaterialCost => [ItemID.CursedFlame];
        protected override int CraftingStation => TileID.CrystalBall;
    }
}
