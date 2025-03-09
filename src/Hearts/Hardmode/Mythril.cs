using ElementalHeartsRevivedMod.lib.Interfaces.ItemCategory;
using ElementalHeartsRevivedMod.lib.Interfaces.ItemTags;
using ElementalHeartsRevivedMod.lib.Interfaces.Rarity;
using System.Collections.Generic;
using Terraria.ID;

namespace ElementalHeartsRevivedMod.src.Hearts.Hardmode {
    public class Mythril : HeartBase, HardmodeHeart, ConsumableItem, CraftableItem, OrangeRarity {
        public Mythril()
          : base() {
        }

        protected override List<int> MaterialCost => new List<int>() { ItemID.MythrilOre };
        protected override int CraftingStation => TileID.MythrilAnvil;


    }
}
