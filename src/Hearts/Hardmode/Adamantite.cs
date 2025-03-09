using ElementalHeartsRevivedMod.lib.Interfaces.ItemCategory;
using ElementalHeartsRevivedMod.lib.Interfaces.ItemTags;
using ElementalHeartsRevivedMod.lib.Interfaces.Rarity;
using System.Collections.Generic;
using Terraria.ID;

namespace ElementalHeartsRevivedMod.src.Hearts.Hardmode {
    public class Adamantite : HeartBase, HardmodeHeart, ConsumableItem, CraftableItem, OrangeRarity {
        public Adamantite() : base() { }

        protected override List<int> MaterialCost => new List<int>() { ItemID.AdamantiteOre };
        protected override int CraftingStation => TileID.AdamantiteForge;
    }
}
