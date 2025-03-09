using ElementalHeartsRevivedMod.lib.Interfaces.ItemCategory;
using ElementalHeartsRevivedMod.lib.Interfaces.ItemTags;
using ElementalHeartsRevivedMod.lib.Interfaces.Rarity;
using System.Collections.Generic;
using Terraria.ID;

namespace ElementalHeartsRevivedMod.src.Hearts.Hardmode {
    public class Chlorophyte : HeartBase, HardmodeHeart, ConsumableItem, CraftableItem, LimeRarity {
        public Chlorophyte()
          : base() {
        }
        protected override List<int> MaterialCost => new List<int>() { ItemID.ChlorophyteOre };
        protected override int CraftingStation => TileID.MythrilAnvil;
    }
}
