using ElementalHeartsRevivedMod.lib.Interfaces.ItemCategory;
using ElementalHeartsRevivedMod.lib.Interfaces.ItemTags;
using ElementalHeartsRevivedMod.lib.Interfaces.Rarity;
using System.Collections.Generic;
using Terraria.ID;

namespace ElementalHeartsRevivedMod.src.Hearts.Hardmode {
    public class Palladium : HeartBase, HardmodeHeart, ConsumableItem, CraftableItem, OrangeRarity {
        public Palladium()
          : base() {
        }

        protected override List<int> MaterialCost => new List<int>() { ItemID.PalladiumOre };
        protected override int CraftingStation => TileID.MythrilAnvil;
    }
}
