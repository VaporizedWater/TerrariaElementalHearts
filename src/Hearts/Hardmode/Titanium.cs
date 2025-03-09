using ElementalHeartsRevivedMod.lib.Interfaces.ItemCategory;
using ElementalHeartsRevivedMod.lib.Interfaces.ItemTags;
using ElementalHeartsRevivedMod.lib.Interfaces.Rarity;
using System.Collections.Generic;
using Terraria.ID;

namespace ElementalHeartsRevivedMod.src.Hearts.Hardmode {
    public class Titanium : HeartBase, HardmodeHeart, ConsumableItem, CraftableItem, OrangeRarity {
        public Titanium()
          : base() {
        }

        protected override List<int> MaterialCost => new List<int>() { ItemID.TitaniumOre };
        protected override int CraftingStation => TileID.AdamantiteForge;
    }
}
