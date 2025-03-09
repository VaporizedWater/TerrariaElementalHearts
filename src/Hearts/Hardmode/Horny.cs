using ElementalHeartsRevivedMod.lib.Interfaces.ItemCategory;
using ElementalHeartsRevivedMod.lib.Interfaces.ItemTags;
using ElementalHeartsRevivedMod.lib.Interfaces.Rarity;
using System.Collections.Generic;
using Terraria.ID;

namespace ElementalHeartsRevivedMod.src.Hearts.Hardmode {
    public class Horny : HeartBase, HardmodeHeart, ConsumableItem, CraftableItem, OneMaterialCost, NonConsumableMaterialCost, YellowRarity {
        public Horny()
          : base() {
        }

        protected override List<int> MaterialCost => [ItemID.AncientHorn];
        protected override int CraftingStation => TileID.MythrilAnvil;
    }
}
