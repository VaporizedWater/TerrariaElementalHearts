using ElementalHeartsRevivedMod.lib.Interfaces.ItemCategory;
using ElementalHeartsRevivedMod.lib.Interfaces.ItemTags;
using ElementalHeartsRevivedMod.lib.Interfaces.Rarity;
using System.Collections.Generic;
using Terraria.ID;

namespace ElementalHeartsRevivedMod.src.Hearts.Hardmode {
    public class Discord : HeartBase, HardmodeHeart, ConsumableItem, CraftableItem, OneMaterialCost, NonConsumableMaterialCost, LimeRarity {
        public Discord()
          : base() {
        }

        protected override List<int> MaterialCost => new List<int>() { ItemID.RodofDiscord };

        protected override int CraftingStation => TileID.DemonAltar;
    }
}
