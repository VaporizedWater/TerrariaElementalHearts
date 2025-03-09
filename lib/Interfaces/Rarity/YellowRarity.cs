using Microsoft.Xna.Framework;
using Terraria.ID;

namespace ElementalHeartsRevivedMod.lib.Interfaces.Rarity {
    /// <summary>
    /// Rarity Level: 8
    /// </summary>
    internal interface YellowRarity : ItemRarityBase {
        new int ItemRarity => ItemRarityID.Yellow;
        new Color ItemColor() => Colors.RarityYellow;
    }
}