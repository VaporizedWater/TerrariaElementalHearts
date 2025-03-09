using ElementalHeartsRevivedMod.lib.Interfaces.ItemCategory;
using ElementalHeartsRevivedMod.lib.Interfaces.ItemTags;
using ElementalHeartsRevivedMod.lib.Interfaces.Rarity;
using System.Collections.Generic;
using Terraria.ID;

namespace ElementalHeartsRevivedMod.src.Hearts.Hardmode {
    public class Flight : HeartBase, HardmodeHeart, ConsumableItem, CraftableItem, OrangeRarity {
        public Flight()
          : base() {
        }

        protected override List<int> MaterialCost => new List<int>() { ItemID.SoulofFlight };
        protected override int CraftingStation => TileID.MythrilAnvil;
    }
}
