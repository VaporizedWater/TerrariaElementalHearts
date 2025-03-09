using ElementalHeartsRevivedMod.lib.Interfaces.ItemCategory;
using ElementalHeartsRevivedMod.lib.Interfaces.ItemTags;
using ElementalHeartsRevivedMod.lib.Interfaces.Rarity;
using System.Collections.Generic;
using Terraria.ID;

namespace ElementalHeartsRevivedMod.src.Hearts.Hardmode {
    public class Orichalcum : HeartBase, HardmodeHeart, ConsumableItem, CraftableItem, OrangeRarity {
        public Orichalcum()
          : base() {
        }

        protected override List<int> MaterialCost => new List<int>() { ItemID.OrichalcumOre };
        protected override int CraftingStation => TileID.MythrilAnvil;
    }
}
