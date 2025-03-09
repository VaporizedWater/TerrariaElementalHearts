using Microsoft.Xna.Framework;
using Terraria.ID;

namespace ElementalHeartsRevivedMod.lib.Interfaces.Rarity {
    /// <summary>
    /// Rarity Level: 5
    /// </summary>
    internal interface PinkRarity : ItemRarityBase {
        new int ItemRarity => ItemRarityID.Pink;
        new Color ItemColor() => Colors.RarityPink;
    }
}