using ElementalHeartsRevivedMod.lib.Interfaces.ItemCategory;
using ElementalHeartsRevivedMod.lib.Interfaces.ItemTags;
using ElementalHeartsRevivedMod.lib.Interfaces.Rarity;
using System.Collections.Generic;
using Terraria.ID;

namespace ElementalHeartsRevivedMod.src.Hearts.PreHardmode {
    public class Crimsand : HeartBase, PreHardmodeHeart, ConsumableItem, CraftableItem, WhiteRarity {
        public Crimsand()
          : base() {
        }

        protected override List<int> MaterialCost => new List<int>() { ItemID.CrimsandBlock };
        protected override int CraftingStation => TileID.HeavyWorkBench;
    }
}
