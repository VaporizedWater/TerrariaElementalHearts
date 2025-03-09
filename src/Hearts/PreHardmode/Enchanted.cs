using ElementalHeartsRevivedMod.lib.Interfaces.ItemCategory;
using ElementalHeartsRevivedMod.lib.Interfaces.ItemTags;
using ElementalHeartsRevivedMod.lib.Interfaces.Rarity;
using System.Collections.Generic;
using Terraria.ID;

namespace ElementalHeartsRevivedMod.src.Hearts.PreHardmode {
    public class Enchanted : HeartBase, PreHardmodeHeart, ConsumableItem, CraftableItem, OneMaterialCost, NonConsumableMaterialCost, GreenRarity {
        public Enchanted()
          : base() {
        }
        protected override List<int> MaterialCost => [ItemID.EnchantedSword];
        protected override int CraftingStation => TileID.DemonAltar;
    }
}
