using ElementalHeartsRevivedMod.lib.Interfaces.ItemCategory;
using ElementalHeartsRevivedMod.lib.Interfaces.ItemTags;
using ElementalHeartsRevivedMod.lib.Interfaces.Rarity;
using System.Collections.Generic;
using Terraria.ID;

namespace ElementalHeartsRevivedMod.src.Hearts.PreHardmode {
    public class Coralstone : HeartBase, PreHardmodeHeart, ConsumableItem, CraftableItem, WhiteRarity {
        public Coralstone()
          : base() {
        }

        protected override List<int> MaterialCost => new List<int>() { ItemID.CoralstoneBlock };
        protected override int CraftingStation => TileID.WorkBenches;
    }
}
