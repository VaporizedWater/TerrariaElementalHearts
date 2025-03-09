using ElementalHeartsRevivedMod.lib.Interfaces.ItemCategory;
using ElementalHeartsRevivedMod.lib.Interfaces.ItemTags;
using ElementalHeartsRevivedMod.lib.Interfaces.Rarity;
using System.Collections.Generic;
using Terraria.ID;

namespace ElementalHeartsRevivedMod.src.Hearts.Hardmode {
    public class Light : HeartBase, HardmodeHeart, ConsumableItem, CraftableItem, OrangeRarity {
        public Light()
          : base() {
        }

        protected override List<int> MaterialCost => new List<int>() { ItemID.SoulofLight };
        protected override int CraftingStation => TileID.MythrilAnvil;
    }
}
