using ElementalHeartsRevivedMod.lib.Interfaces.ItemCategory;
using ElementalHeartsRevivedMod.lib.Interfaces.ItemTags;
using ElementalHeartsRevivedMod.lib.Interfaces.Rarity;
using System.Collections.Generic;
using Terraria.ID;

namespace ElementalHeartsRevivedMod.src.Hearts.Hardmode {
    public class Night : HeartBase, HardmodeHeart, ConsumableItem, CraftableItem, OrangeRarity {
        public Night()
          : base() {
        }

        protected override List<int> MaterialCost => [ItemID.SoulofNight];
        protected override int CraftingStation => TileID.MythrilAnvil;
    }
}
